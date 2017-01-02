using System;
using System.Collections;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

public class TextHelper
{
    static public void CreateFille(string filename, string str)
    {
        //不存在文件
        if (!File.Exists(filename))
        {
            FileStream fs1 = new FileStream(filename, FileMode.Create, FileAccess.Write);//创建写入文件 
            StreamWriter sw = new StreamWriter(fs1);

            //开始写入值
            //sw.WriteLine("<!--  filename:" + filename + "  -->");
            sw.Write(str);
            sw.Close();
            fs1.Close();
        }
        //存在文件
        else
        {
            FileStream fs = new FileStream(filename, FileMode.Truncate, FileAccess.Write);
            StreamWriter sr = new StreamWriter(fs);

            //开始写入值
            //sr.WriteLine("<!--  filename:" + filename + "  -->");
            sr.Write(str);
            sr.Close();
            fs.Close();
        }
    }

    public enum ReadType
    {
        ReadLine,
        ReadToEnd
    }
    static public ArrayList ReadFile(string filepath, ReadType type)
    {
        ArrayList textline = new ArrayList();
        StreamReader sr = null;
        try
        {
            sr = File.OpenText(filepath);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            CreateFille(filepath, "");
            return null;
        }

        string text;
        if (type == ReadType.ReadLine)
        {
            //逐行读取
            while ((text = sr.ReadLine()) != null)
            {
                textline.Add(text);
            }
        }
        else
        {
            //直接读取
            text = sr.ReadToEnd();
            textline.Add(text);
        }
        sr.Close();
        sr.Dispose();

        return textline;
    }
}
