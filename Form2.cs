using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace ILMergeGUI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = true;
            fileDialog.Title = "请选择文件";
            fileDialog.Filter = "所有文件*|*.*";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                DateTime d1 = DateTime.Now;
                string file = fileDialog.FileName;
                string ls_md5 = getMD5(file);
                DateTime d2 = DateTime.Now;
                TimeSpan ts = d2 - d1;
                MessageBox.Show("MD5:" + ls_md5 + " 用时：" + ts.Seconds + "秒" + ts.Milliseconds + "毫秒");
            }
        }
        public static string getMD5(string file)
        {
            if (!File.Exists(file))
                return null;
            System.IO.FileInfo fi = new FileInfo(file);
            if (fi.Length > 10 * 1024 * 1024)//大于10MB
                return __getMD5Max(file);
            else return __getMD5Min(file);
        }
        private static string __getMD5Min(string path)
        {
            if (!File.Exists(path))
                throw new ArgumentException(string.Format("<{0}>, 不存在", path));
            int bufferSize = 1024 * 16;//自定义缓冲区大小16K  
            byte[] buffer = new byte[bufferSize];
            Stream inputStream = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.Read);
            HashAlgorithm hashAlgorithm = new MD5CryptoServiceProvider();
            int readLength = 0;//每次读取长度  
            var output = new byte[bufferSize];
            while ((readLength = inputStream.Read(buffer, 0, buffer.Length)) > 0)
            {
                //计算MD5  
                hashAlgorithm.TransformBlock(buffer, 0, readLength, output, 0);
            }
            //完成最后计算，必须调用(由于上一部循环已经完成所有运算，所以调用此方法时后面的两个参数都为0)  
            hashAlgorithm.TransformFinalBlock(buffer, 0, 0);
            string md5 = BitConverter.ToString(hashAlgorithm.Hash);
            hashAlgorithm.Clear();
            inputStream.Close();
            md5 = md5.Replace("-", "");
            return md5;
        }
        private static string __getMD5Max(string path)
        {
            if (!File.Exists(path))
                return null;
            int bufferSize = 1024 * 16;//自定义缓冲区大小16K  
            byte[] buffer = new byte[bufferSize];
            Stream inputStream = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.Read);
            HashAlgorithm hashAlgorithm = new MD5CryptoServiceProvider();
            int readLength = 0;//每次读取长度  
            var output = new byte[bufferSize];
            while ((readLength = inputStream.Read(buffer, 0, buffer.Length)) > 0)
            {
                //计算MD5  
                hashAlgorithm.TransformBlock(buffer, 0, readLength, output, 0);
                inputStream.Seek(10 * 1024 * 1024, SeekOrigin.Current);//每次将流的位置往前移10MB
            }
            //加上文件长度哈希
            byte[] filelength = System.Text.Encoding.ASCII.GetBytes(new FileInfo(path).Length.ToString());
            hashAlgorithm.TransformBlock(filelength, 0, filelength.Length, output, 0);
            //完成最后计算，必须调用(由于上一部循环已经完成所有运算，所以调用此方法时后面的两个参数都为0)  
            hashAlgorithm.TransformFinalBlock(buffer, 0, 0);
            string md5 = BitConverter.ToString(hashAlgorithm.Hash);
            hashAlgorithm.Clear();
            inputStream.Close();
            md5 = md5.Replace("-", "");


            //防止鉴别失败
            //MD5 md5length = new MD5CryptoServiceProvider();
            //byte[] result = md5length.ComputeHash(System.Text.Encoding.ASCII.GetBytes((new FileInfo(path).Length.ToString() + md5)));
            //string md5lengthstr= System.Text.Encoding.ASCII.GetString(result);

            return md5;
        }
    }
}
