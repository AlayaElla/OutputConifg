using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace OutputConifg
{
    public partial class Form1 : Form
    {
        string address;
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            this.Load += new System.EventHandler(this.Form1_Load);
            address = Environment.CurrentDirectory;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //逐行读取
            ArrayList textline = TextHelper.ReadFile(address + "\\OutputConfig.ini", TextHelper.ReadType.ReadLine);
            if (textline != null && textline.Count >= 9)
            {
                xmlConfigPath.Text = (string)textline[0];     //数据配置文件路径
                codeConfigPath.Text = (string)textline[1];     //代码配置文件路径
                resourcePath.Text = (string)textline[2];     //游戏资源配置文件路径
                xmlOutPath.Text = (string)textline[3];     //数据模式导出路径
                codeOutPath.Text = (string)textline[4];     //代码模式导出路径
                svnPath.Text = (string)textline[5];     //svn路径
                isSVN.Checked = ((string)textline[6]) == "True" ? true : false;     //是否更新svn
                xmlToolPath.Text = (string)textline[7];     //数据模式路径
                codeToolPath.Text = (string)textline[8];     //代码模式路径
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Threading.Thread G_th;//定义线程
            G_th = new System.Threading.Thread(//新建一条线程
                delegate()//使用匿名方法
                {
                    LogTextBox.Clear();

                    //检查文件是否存在
                    bool iswrong = false;
                    if (!File.Exists(svnPath.Text + "/TortoiseProc.exe"))
                    {
                        LogTextBox.AppendText("SVN地址错误，请检查后重试...\n");
                        iswrong = true;
                    }
                    if (!File.Exists(xmlToolPath.Text + "/ConfigGenerator_x64.exe"))
                    {
                        LogTextBox.AppendText("数据模式工具地址错误，请检查后重试...\n");
                        iswrong = true;
                    }
                    if (!File.Exists(codeToolPath.Text + "/ConfigGenerator_x64.exe"))
                    {
                        LogTextBox.AppendText("代码模式工具地址错误，请检查后重试...\n");
                        iswrong = true;
                    }
                    if (xmlConfigPath.Text == "" || codeConfigPath.Text == "" || resourcePath.Text == "" || xmlOutPath.Text == "" || codeOutPath.Text=="")
                    {
                        LogTextBox.AppendText("有配置文件路径为空，请检查后重试...\n");
                        iswrong = true;
                    }

                    if (iswrong)
                        return;

                    btn_Out.Text = "导出中...";
                    btn_Out.Enabled = false;

                    string cmd = svnPath.Text + "/TortoiseProc.exe" + " /command:update /path:" + xmlConfigPath.Text + " /closeonend:1";
                    string output = "";
                    if (isSVN.Checked)
                    {
                        LogTextBox.AppendText("更新SVN...");
                        CmdHelper.RunCmd(cmd, out output);
                        LogTextBox.AppendText("更新完毕！\n");
                    }
                    else
                        LogTextBox.AppendText("跳过SVN更新\n");


                    //生成配置
                    LogTextBox.AppendText("生成数据模式配置...");
                    cmd = @xmlToolPath.Text + "/ConfigGenerator_x64.exe" + " " + xmlConfigPath.Text + " " + xmlOutPath.Text + " " + resourcePath.Text;
                    CmdHelper.RunCmd(cmd, out output);
                    LogTextBox.AppendText("生成完毕！\n");
                    LogTextBox.AppendText("生成代码模式配置...");
                    cmd = @codeToolPath.Text + "/ConfigGenerator_x64.exe" + " " + codeConfigPath.Text + " " + codeOutPath.Text;
                    CmdHelper.RunCmd(cmd, out output);
                    LogTextBox.AppendText("生成完毕！\n");

                    LogTextBox.AppendText("导出配置完成~");

                    cmd = @"start " + xmlOutPath.Text + " && " + "start " + codeOutPath.Text;
                    CmdHelper.RunCmd(cmd, out output);


                    btn_Out.Text = "导出配置";
                    btn_Out.Enabled = true;
                });
            G_th.IsBackground = true;//设置线程为后台线程
            G_th.Start();//开始执行线程
        }

        //设置数据配置文件路径
        private void button2_Click(object sender, EventArgs e)
        {
            if (xmlConfigPath.Text != "")
                folderBrowserDialog1.SelectedPath = xmlConfigPath.Text;
            folderBrowserDialog1.Description = "请选择数据模式配置文件的地址...";
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                xmlConfigPath.Text = folderBrowserDialog1.SelectedPath;

                SaveConfig();
            }
        }
        //游戏资源路径
        private void button8_Click(object sender, EventArgs e)
        {
            if (resourcePath.Text != "")
                folderBrowserDialog1.SelectedPath = resourcePath.Text;
            folderBrowserDialog1.Description = "请选择游戏资源游戏地址...";
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                resourcePath.Text = folderBrowserDialog1.SelectedPath;

                SaveConfig();
            }
        }
        //代码模式配置路径
        private void button7_Click(object sender, EventArgs e)
        {
            if (codeConfigPath.Text != "")
                folderBrowserDialog1.SelectedPath = codeConfigPath.Text;
            folderBrowserDialog1.Description = "请选择代码模式配置文件的地址...";
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                codeConfigPath.Text = folderBrowserDialog1.SelectedPath;

                SaveConfig();
            }
        }


        //设置数据模式导出地址
        private void button3_Click(object sender, EventArgs e)
        {
            if (xmlOutPath.Text != "")
                folderBrowserDialog1.SelectedPath = xmlOutPath.Text;
            folderBrowserDialog1.Description = "请选择数据模式配置的导出地址...";
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                xmlOutPath.Text = folderBrowserDialog1.SelectedPath;

                SaveConfig();
            }
        }
        //代码模式导出路径
        private void button9_Click(object sender, EventArgs e)
        {
            if (codeOutPath.Text != "")
                folderBrowserDialog1.SelectedPath = codeOutPath.Text;
            folderBrowserDialog1.Description = "请选择代码模式配置的导出地址...";
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                codeOutPath.Text = folderBrowserDialog1.SelectedPath;

                SaveConfig();
            }
        }


        //设置svn地址
        private void button1_Click(object sender, EventArgs e)
        {
            if (svnPath.Text != "")
                folderBrowserDialog1.SelectedPath = svnPath.Text;
            folderBrowserDialog1.Description = "请选择SVN地址...";
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                svnPath.Text = folderBrowserDialog1.SelectedPath;

                SaveConfig();
            }
        }
        //设置数据模式地址
        private void button4_Click(object sender, EventArgs e)
        {
            if (xmlToolPath.Text != "")
                folderBrowserDialog1.SelectedPath = xmlToolPath.Text;
            folderBrowserDialog1.Description = "请选择数值工具数据模式的地址...";
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                xmlToolPath.Text = folderBrowserDialog1.SelectedPath;

                SaveConfig();
            }
        }
        //设置代码模式地址
        private void button5_Click(object sender, EventArgs e)
        {
            if (codeToolPath.Text != "")
                folderBrowserDialog1.SelectedPath = codeToolPath.Text;
            folderBrowserDialog1.Description = "请选择数值工具代码模式的地址...";
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                codeToolPath.Text = folderBrowserDialog1.SelectedPath;

                SaveConfig();
            }
        }

        void SaveConfig()
        {
            string conifg = "";

            conifg += xmlConfigPath.Text + "\n";
            conifg += codeConfigPath.Text + "\n";
            conifg += resourcePath.Text + "\n";
            conifg += xmlOutPath.Text + "\n";
            conifg += codeOutPath.Text + "\n";
            conifg += svnPath.Text + "\n";
            conifg += isSVN.Checked + "\n";
            conifg += xmlToolPath.Text + "\n";
            conifg += codeToolPath.Text + "\n";
            TextHelper.CreateFille(address + "\\OutputConfig.ini", conifg);
        }

        private void isSVN_CheckedChanged(object sender, EventArgs e)
        {
            SaveConfig();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.rainymirrors.com/"); 
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.rainymirrors.com/"); 
        }
    }
}
