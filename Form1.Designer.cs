namespace ILMergeGUI
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
            this.ccb_netver = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ccb_type = new System.Windows.Forms.ComboBox();
            this.btn_OutPath = new System.Windows.Forms.Button();
            this.txt_ExeName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Outpath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Srart = new System.Windows.Forms.Button();
            this.btn_dlldel = new System.Windows.Forms.Button();
            this.btn_dlladd = new System.Windows.Forms.Button();
            this.listBox_Dlls = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_exePath = new System.Windows.Forms.Button();
            this.txt_exePath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ILMergePath = new System.Windows.Forms.TextBox();
            this.btn_ILMergePath = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ccb_netver);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.ccb_type);
            this.groupBox1.Controls.Add(this.btn_OutPath);
            this.groupBox1.Controls.Add(this.txt_ExeName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_Outpath);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btn_Srart);
            this.groupBox1.Controls.Add(this.btn_dlldel);
            this.groupBox1.Controls.Add(this.btn_dlladd);
            this.groupBox1.Controls.Add(this.listBox_Dlls);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_exePath);
            this.groupBox1.Controls.Add(this.txt_exePath);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(6, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(634, 255);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Import";
            // 
            // ccb_netver
            // 
            this.ccb_netver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ccb_netver.FormattingEnabled = true;
            this.ccb_netver.Items.AddRange(new object[] {
            "v4.0.30319",
            "v2.0.50727"});
            this.ccb_netver.Location = new System.Drawing.Point(290, 20);
            this.ccb_netver.Name = "ccb_netver";
            this.ccb_netver.Size = new System.Drawing.Size(121, 20);
            this.ccb_netver.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(231, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 16;
            this.label7.Text = ".NetVer:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "ImpartType：";
            // 
            // ccb_type
            // 
            this.ccb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ccb_type.FormattingEnabled = true;
            this.ccb_type.Items.AddRange(new object[] {
            "EXE",
            "DLL"});
            this.ccb_type.Location = new System.Drawing.Point(89, 20);
            this.ccb_type.Name = "ccb_type";
            this.ccb_type.Size = new System.Drawing.Size(121, 20);
            this.ccb_type.TabIndex = 0;
            // 
            // btn_OutPath
            // 
            this.btn_OutPath.Location = new System.Drawing.Point(552, 193);
            this.btn_OutPath.Name = "btn_OutPath";
            this.btn_OutPath.Size = new System.Drawing.Size(75, 23);
            this.btn_OutPath.TabIndex = 8;
            this.btn_OutPath.Text = "···";
            this.btn_OutPath.UseVisualStyleBackColor = true;
            this.btn_OutPath.Click += new System.EventHandler(this.btn_OutPath_Click);
            // 
            // txt_ExeName
            // 
            this.txt_ExeName.Location = new System.Drawing.Point(68, 222);
            this.txt_ExeName.Name = "txt_ExeName";
            this.txt_ExeName.Size = new System.Drawing.Size(460, 21);
            this.txt_ExeName.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "ExeName：";
            // 
            // txt_Outpath
            // 
            this.txt_Outpath.Location = new System.Drawing.Point(68, 195);
            this.txt_Outpath.Name = "txt_Outpath";
            this.txt_Outpath.Size = new System.Drawing.Size(460, 21);
            this.txt_Outpath.TabIndex = 7;
            this.txt_Outpath.Text = "D:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "OutPath：";
            // 
            // btn_Srart
            // 
            this.btn_Srart.Location = new System.Drawing.Point(552, 220);
            this.btn_Srart.Name = "btn_Srart";
            this.btn_Srart.Size = new System.Drawing.Size(75, 23);
            this.btn_Srart.TabIndex = 10;
            this.btn_Srart.Text = "Start";
            this.btn_Srart.UseVisualStyleBackColor = true;
            this.btn_Srart.Click += new System.EventHandler(this.btn_Srart_Click);
            // 
            // btn_dlldel
            // 
            this.btn_dlldel.Location = new System.Drawing.Point(552, 126);
            this.btn_dlldel.Name = "btn_dlldel";
            this.btn_dlldel.Size = new System.Drawing.Size(75, 23);
            this.btn_dlldel.TabIndex = 6;
            this.btn_dlldel.Text = "Remove";
            this.btn_dlldel.UseVisualStyleBackColor = true;
            this.btn_dlldel.Click += new System.EventHandler(this.btn_dlldel_Click);
            // 
            // btn_dlladd
            // 
            this.btn_dlladd.Location = new System.Drawing.Point(552, 97);
            this.btn_dlladd.Name = "btn_dlladd";
            this.btn_dlladd.Size = new System.Drawing.Size(75, 23);
            this.btn_dlladd.TabIndex = 5;
            this.btn_dlladd.Text = "AddDll";
            this.btn_dlladd.UseVisualStyleBackColor = true;
            this.btn_dlladd.Click += new System.EventHandler(this.btn_dlladd_Click);
            // 
            // listBox_Dlls
            // 
            this.listBox_Dlls.FormattingEnabled = true;
            this.listBox_Dlls.ItemHeight = 12;
            this.listBox_Dlls.Location = new System.Drawing.Point(14, 97);
            this.listBox_Dlls.Name = "listBox_Dlls";
            this.listBox_Dlls.Size = new System.Drawing.Size(514, 88);
            this.listBox_Dlls.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "DllsPath：";
            // 
            // btn_exePath
            // 
            this.btn_exePath.Location = new System.Drawing.Point(552, 46);
            this.btn_exePath.Name = "btn_exePath";
            this.btn_exePath.Size = new System.Drawing.Size(75, 23);
            this.btn_exePath.TabIndex = 3;
            this.btn_exePath.Text = "···";
            this.btn_exePath.UseVisualStyleBackColor = true;
            this.btn_exePath.Click += new System.EventHandler(this.btn_exePath_Click);
            // 
            // txt_exePath
            // 
            this.txt_exePath.Location = new System.Drawing.Point(68, 48);
            this.txt_exePath.Name = "txt_exePath";
            this.txt_exePath.Size = new System.Drawing.Size(460, 21);
            this.txt_exePath.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "EXEPath：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "ILMergePath：";
            // 
            // txt_ILMergePath
            // 
            this.txt_ILMergePath.Location = new System.Drawing.Point(115, 6);
            this.txt_ILMergePath.Name = "txt_ILMergePath";
            this.txt_ILMergePath.Size = new System.Drawing.Size(328, 21);
            this.txt_ILMergePath.TabIndex = 1;
            this.txt_ILMergePath.Text = "C:\\Program Files (x86)\\Microsoft\\ILMerge";
            // 
            // btn_ILMergePath
            // 
            this.btn_ILMergePath.Location = new System.Drawing.Point(449, 4);
            this.btn_ILMergePath.Name = "btn_ILMergePath";
            this.btn_ILMergePath.Size = new System.Drawing.Size(75, 23);
            this.btn_ILMergePath.TabIndex = 0;
            this.btn_ILMergePath.Text = "···";
            this.btn_ILMergePath.UseVisualStyleBackColor = true;
            this.btn_ILMergePath.Click += new System.EventHandler(this.btn_ILMergePath_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabel1.Location = new System.Drawing.Point(538, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(95, 12);
            this.linkLabel1.TabIndex = 17;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "DownLoadILMerge";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(6, 294);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(634, 169);
            this.richTextBox1.TabIndex = 18;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 466);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btn_ILMergePath);
            this.Controls.Add(this.txt_ILMergePath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "ILMergeGUI";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ILMergePath;
        private System.Windows.Forms.Button btn_ILMergePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_exePath;
        private System.Windows.Forms.Button btn_exePath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox_Dlls;
        private System.Windows.Forms.Button btn_dlladd;
        private System.Windows.Forms.Button btn_dlldel;
        private System.Windows.Forms.Button btn_Srart;
        private System.Windows.Forms.TextBox txt_ExeName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Outpath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_OutPath;
        private System.Windows.Forms.ComboBox ccb_type;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ccb_netver;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

