namespace OutputConifg
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.isSVN = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.svnPath = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.resourcePath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_resourcePath = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_codeConfigPath = new System.Windows.Forms.Button();
            this.codeConfigPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_xmlConfigPath = new System.Windows.Forms.Button();
            this.xmlConfigPath = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_codeOutPath = new System.Windows.Forms.Button();
            this.codeOutPath = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_xmlOutPath = new System.Windows.Forms.Button();
            this.xmlOutPath = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.codeToolPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.xmlToolPath = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.LogTextBox = new System.Windows.Forms.RichTextBox();
            this.btn_Out = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.isSVN);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.svnPath);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 69);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "svn地址";
            // 
            // isSVN
            // 
            this.isSVN.AutoSize = true;
            this.isSVN.Checked = true;
            this.isSVN.CheckState = System.Windows.Forms.CheckState.Checked;
            this.isSVN.Location = new System.Drawing.Point(6, 42);
            this.isSVN.Name = "isSVN";
            this.isSVN.Size = new System.Drawing.Size(138, 16);
            this.isSVN.TabIndex = 2;
            this.isSVN.Text = "每次导出都会更新SVN";
            this.isSVN.UseVisualStyleBackColor = true;
            this.isSVN.CheckedChanged += new System.EventHandler(this.isSVN_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(220, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // svnPath
            // 
            this.svnPath.Location = new System.Drawing.Point(6, 15);
            this.svnPath.Name = "svnPath";
            this.svnPath.Size = new System.Drawing.Size(208, 21);
            this.svnPath.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.resourcePath);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btn_resourcePath);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btn_codeConfigPath);
            this.groupBox2.Controls.Add(this.codeConfigPath);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btn_xmlConfigPath);
            this.groupBox2.Controls.Add(this.xmlConfigPath);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(2, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(259, 142);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "配置文件地址";
            // 
            // resourcePath
            // 
            this.resourcePath.Location = new System.Drawing.Point(6, 110);
            this.resourcePath.Name = "resourcePath";
            this.resourcePath.Size = new System.Drawing.Size(208, 21);
            this.resourcePath.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 9F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(6, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "游戏资源路径";
            // 
            // btn_resourcePath
            // 
            this.btn_resourcePath.Font = new System.Drawing.Font("宋体", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_resourcePath.Location = new System.Drawing.Point(220, 109);
            this.btn_resourcePath.Name = "btn_resourcePath";
            this.btn_resourcePath.Size = new System.Drawing.Size(33, 23);
            this.btn_resourcePath.TabIndex = 7;
            this.btn_resourcePath.Text = "...";
            this.btn_resourcePath.UseVisualStyleBackColor = true;
            this.btn_resourcePath.Click += new System.EventHandler(this.button8_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 9F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(6, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "代码模式 配置文件地址";
            // 
            // btn_codeConfigPath
            // 
            this.btn_codeConfigPath.Font = new System.Drawing.Font("宋体", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_codeConfigPath.Location = new System.Drawing.Point(220, 70);
            this.btn_codeConfigPath.Name = "btn_codeConfigPath";
            this.btn_codeConfigPath.Size = new System.Drawing.Size(33, 23);
            this.btn_codeConfigPath.TabIndex = 4;
            this.btn_codeConfigPath.Text = "...";
            this.btn_codeConfigPath.UseVisualStyleBackColor = true;
            this.btn_codeConfigPath.Click += new System.EventHandler(this.button7_Click);
            // 
            // codeConfigPath
            // 
            this.codeConfigPath.Location = new System.Drawing.Point(6, 71);
            this.codeConfigPath.Name = "codeConfigPath";
            this.codeConfigPath.Size = new System.Drawing.Size(208, 21);
            this.codeConfigPath.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(6, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "数据模式 配置文件地址";
            // 
            // btn_xmlConfigPath
            // 
            this.btn_xmlConfigPath.Font = new System.Drawing.Font("宋体", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_xmlConfigPath.Location = new System.Drawing.Point(220, 31);
            this.btn_xmlConfigPath.Name = "btn_xmlConfigPath";
            this.btn_xmlConfigPath.Size = new System.Drawing.Size(33, 23);
            this.btn_xmlConfigPath.TabIndex = 1;
            this.btn_xmlConfigPath.Text = "...";
            this.btn_xmlConfigPath.UseVisualStyleBackColor = true;
            this.btn_xmlConfigPath.Click += new System.EventHandler(this.button2_Click);
            // 
            // xmlConfigPath
            // 
            this.xmlConfigPath.Location = new System.Drawing.Point(6, 32);
            this.xmlConfigPath.Name = "xmlConfigPath";
            this.xmlConfigPath.Size = new System.Drawing.Size(208, 21);
            this.xmlConfigPath.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.btn_codeOutPath);
            this.groupBox3.Controls.Add(this.codeOutPath);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btn_xmlOutPath);
            this.groupBox3.Controls.Add(this.xmlOutPath);
            this.groupBox3.Location = new System.Drawing.Point(2, 154);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(259, 96);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "导出路径";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 9F);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(4, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "代码模式导出路径";
            // 
            // btn_codeOutPath
            // 
            this.btn_codeOutPath.Font = new System.Drawing.Font("宋体", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_codeOutPath.Location = new System.Drawing.Point(218, 69);
            this.btn_codeOutPath.Name = "btn_codeOutPath";
            this.btn_codeOutPath.Size = new System.Drawing.Size(33, 23);
            this.btn_codeOutPath.TabIndex = 11;
            this.btn_codeOutPath.Text = "...";
            this.btn_codeOutPath.UseVisualStyleBackColor = true;
            this.btn_codeOutPath.Click += new System.EventHandler(this.button9_Click);
            // 
            // codeOutPath
            // 
            this.codeOutPath.Location = new System.Drawing.Point(4, 70);
            this.codeOutPath.Name = "codeOutPath";
            this.codeOutPath.Size = new System.Drawing.Size(208, 21);
            this.codeOutPath.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 9F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "数据模式导出路径";
            // 
            // btn_xmlOutPath
            // 
            this.btn_xmlOutPath.Font = new System.Drawing.Font("宋体", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_xmlOutPath.Location = new System.Drawing.Point(220, 30);
            this.btn_xmlOutPath.Name = "btn_xmlOutPath";
            this.btn_xmlOutPath.Size = new System.Drawing.Size(33, 23);
            this.btn_xmlOutPath.TabIndex = 1;
            this.btn_xmlOutPath.Text = "...";
            this.btn_xmlOutPath.UseVisualStyleBackColor = true;
            this.btn_xmlOutPath.Click += new System.EventHandler(this.button3_Click);
            // 
            // xmlOutPath
            // 
            this.xmlOutPath.Location = new System.Drawing.Point(6, 31);
            this.xmlOutPath.Name = "xmlOutPath";
            this.xmlOutPath.Size = new System.Drawing.Size(208, 21);
            this.xmlOutPath.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.button5);
            this.groupBox4.Controls.Add(this.codeToolPath);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Controls.Add(this.xmlToolPath);
            this.groupBox4.Location = new System.Drawing.Point(0, 75);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(259, 108);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "数值工具地址";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "代码模式工具地址";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("宋体", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button5.Location = new System.Drawing.Point(220, 73);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(33, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "...";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // codeToolPath
            // 
            this.codeToolPath.Location = new System.Drawing.Point(6, 75);
            this.codeToolPath.Name = "codeToolPath";
            this.codeToolPath.Size = new System.Drawing.Size(208, 21);
            this.codeToolPath.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "数据模式工具地址";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("宋体", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.Location = new System.Drawing.Point(220, 34);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(33, 23);
            this.button4.TabIndex = 1;
            this.button4.Text = "...";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // xmlToolPath
            // 
            this.xmlToolPath.Location = new System.Drawing.Point(6, 36);
            this.xmlToolPath.Name = "xmlToolPath";
            this.xmlToolPath.Size = new System.Drawing.Size(208, 21);
            this.xmlToolPath.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(284, 401);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage1.Controls.Add(this.LogTextBox);
            this.tabPage1.Controls.Add(this.btn_Out);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(276, 375);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "导出路径";
            // 
            // LogTextBox
            // 
            this.LogTextBox.Location = new System.Drawing.Point(6, 252);
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.ReadOnly = true;
            this.LogTextBox.Size = new System.Drawing.Size(255, 73);
            this.LogTextBox.TabIndex = 4;
            this.LogTextBox.Text = "";
            // 
            // btn_Out
            // 
            this.btn_Out.Location = new System.Drawing.Point(70, 331);
            this.btn_Out.Name = "btn_Out";
            this.btn_Out.Size = new System.Drawing.Size(131, 38);
            this.btn_Out.TabIndex = 3;
            this.btn_Out.Text = "导出配置";
            this.btn_Out.UseVisualStyleBackColor = true;
            this.btn_Out.Click += new System.EventHandler(this.button6_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage2.Controls.Add(this.linkLabel1);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(276, 375);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "工具配置";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Location = new System.Drawing.Point(76, 345);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(197, 21);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "        AlayaElla";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 398);
            this.Controls.Add(this.tabControl1);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.MaximumSize = new System.Drawing.Size(300, 437);
            this.MinimumSize = new System.Drawing.Size(300, 437);
            this.Name = "Form1";
            this.Text = "导出配置文件";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox svnPath;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_xmlConfigPath;
        private System.Windows.Forms.TextBox xmlConfigPath;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_xmlOutPath;
        private System.Windows.Forms.TextBox xmlOutPath;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox codeToolPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox xmlToolPath;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_Out;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.RichTextBox LogTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_resourcePath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_codeConfigPath;
        private System.Windows.Forms.TextBox codeConfigPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_codeOutPath;
        private System.Windows.Forms.TextBox codeOutPath;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox isSVN;
        private System.Windows.Forms.TextBox resourcePath;
        private System.Windows.Forms.LinkLabel linkLabel1;

    }
}

