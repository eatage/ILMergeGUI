using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Win32;

namespace ILMergeGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            ccb_type.SelectedIndex = 0;
            ccb_netver.SelectedIndex = 0;
            txt_ILMergePath.Text = AppDomain.CurrentDomain.BaseDirectory;
        }

        private void btn_ILMergePath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择ILMerge安装路径";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string foldPath = dialog.SelectedPath;
                txt_ILMergePath.Text = foldPath;
            }
        }

        private void btn_exePath_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = true;
            fileDialog.Title = "请选择文件";
            fileDialog.Filter = "可执行文件*.exe|*.exe|应用程序扩展*.dll|*.dll";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string file = fileDialog.FileName;
                txt_exePath.Text = file;
            }
        }

        private void btn_dlladd_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = true;
            fileDialog.Title = "请选择文件";
            fileDialog.Filter = "应用程序扩展*.dll|*.dll";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (String str in fileDialog.FileNames)
                {
                    listBox_Dlls.Items.Add(str);
                }
            }
        }

        private void btn_dlldel_Click(object sender, EventArgs e)
        {
            listBox_Dlls.Items.Clear();
        }
        private void btn_OutPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择导出路径";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string foldPath = dialog.SelectedPath;
                txt_Outpath.Text = foldPath;
            }
        }

        private void btn_Srart_Click(object sender, EventArgs e)
        {
            string ls_ILMergePath = txt_ILMergePath.Text;
            string ls_ExePath = txt_exePath.Text;
            System.Collections.ArrayList ListDll = new System.Collections.ArrayList() { };
            #region 校验
            if (string.IsNullOrEmpty(ls_ILMergePath))
            {
                MessageBox.Show("请选择ILMerge安装路径", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!System.IO.File.Exists(ls_ILMergePath + "\\ILMerge.exe"))
            {
                MessageBox.Show("未找到ILMerge程序,请先安装此程序");
                return;
            }
            if (string.IsNullOrEmpty(ls_ExePath))
            {
                MessageBox.Show("请选择主文件", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!System.IO.File.Exists(ls_ExePath))
            {
                MessageBox.Show("主文件不存在", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (listBox_Dlls.Items.Count == 0)
            {
                MessageBox.Show("请选择DLL", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            foreach (string str in listBox_Dlls.Items)
            {
                if (!System.IO.File.Exists(str))
                {
                    MessageBox.Show("未找到" + str, "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                ListDll.Add(str);
            }
            if (txt_Outpath.Text == "")
            {
                MessageBox.Show("请选择导出路径", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txt_ExeName.Text == "")
            {
                MessageBox.Show("请选择导出文件名", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            #endregion
            try
            {
                string ls_Arguments = "/target:winexe /out:{0} /log {1}{2}";
                if (ccb_type.SelectedIndex == 1)
                    ls_Arguments = "/target:dll /out:{0} /log {1}{2}";
                string ls_outPath = txt_Outpath.Text + "\\" + txt_ExeName.Text;
                string ls_logPath = ls_ExePath + " ";
                foreach (string str in ListDll)
                {
                    ls_logPath += str + " ";
                }
                string netPath = "/targetplatform:v4,C:\\Windows\\Microsoft.NET\\Framework\\v4.0.30319";
                if (ccb_netver.SelectedIndex == 1)

                    netPath = "/targetplatform:v2,C:\\Windows\\Microsoft.NET\\Framework\\v2.0.50727";
                ls_Arguments = string.Format(ls_Arguments, ls_outPath, ls_logPath, netPath);
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                process.StartInfo = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = ls_ILMergePath + "\\ILMerge.exe",
                    Arguments = ls_Arguments,
                    UseShellExecute = true
                    //WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden
                };
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardInput = true;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.CreateNoWindow = true;
                process.OutputDataReceived += new System.Diagnostics.DataReceivedEventHandler(OutputHandler);
                process.Start();
                process.StandardInput.WriteLine("");
                process.BeginOutputReadLine();
            }
            catch
            {
                Console.WriteLine("ILMerge.exe未找到，已停止执行\r\n");
                Console.ReadKey();
                MessageBox.Show("ILMerge.exe执行出错", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }
        private void OutputHandler(object sendingProcess, System.Diagnostics.DataReceivedEventArgs outLine)
        {
            if (!String.IsNullOrEmpty(outLine.Data))
            {
                AppendText(outLine.Data);
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //从注册表中读取默认浏览器可执行文件路径  
            RegistryKey key = Registry.ClassesRoot.OpenSubKey(@"http\shell\open\command\");
            string s = key.GetValue("").ToString();
            //s就是你的默认浏览器，不过后面带了参数，把它截去，不过需要注意的是：不同的浏览器后面的参数不一样！  
            //"D:\Program Files (x86)\Google\Chrome\Application\chrome.exe" -- "%1"  
            System.Diagnostics.Process.Start(s.Substring(0, s.Length - 8), "https://www.microsoft.com/en-us/download/details.aspx?id=17630");
        }
        private void AppendText(string text)
        {
            AppendText(richTextBox1, text, Color.Green);
        }

        private void AppendText(RichTextBox box, string text, Color color)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;
            box.SelectionColor = color;
            box.AppendText(text + "\n");
            box.SelectionColor = box.ForeColor;
            box.Focus();
            box.Select(box.TextLength, 0);
            box.ScrollToCaret();
        }
    }
}
