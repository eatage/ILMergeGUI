namespace ILMergeGUI
{
    partial class PanelDay
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox_thing = new System.Windows.Forms.ListBox();
            this.Label_ChineseDay = new System.Windows.Forms.Label();
            this.lbl_day = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox_thing
            // 
            this.listBox_thing.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox_thing.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBox_thing.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.listBox_thing.FormattingEnabled = true;
            this.listBox_thing.ItemHeight = 12;
            this.listBox_thing.Location = new System.Drawing.Point(1, 16);
            this.listBox_thing.Name = "listBox_thing";
            this.listBox_thing.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listBox_thing.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox_thing.Size = new System.Drawing.Size(98, 84);
            this.listBox_thing.TabIndex = 5;
            // 
            // Label_ChineseDay
            // 
            this.Label_ChineseDay.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_ChineseDay.Location = new System.Drawing.Point(17, 2);
            this.Label_ChineseDay.Name = "Label_ChineseDay";
            this.Label_ChineseDay.Size = new System.Drawing.Size(63, 12);
            this.Label_ChineseDay.TabIndex = 4;
            this.Label_ChineseDay.Text = "劳动节";
            this.Label_ChineseDay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_day
            // 
            this.lbl_day.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_day.Location = new System.Drawing.Point(79, 2);
            this.lbl_day.Name = "lbl_day";
            this.lbl_day.Size = new System.Drawing.Size(21, 12);
            this.lbl_day.TabIndex = 3;
            this.lbl_day.Text = "12";
            // 
            // PanelDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listBox_thing);
            this.Controls.Add(this.Label_ChineseDay);
            this.Controls.Add(this.lbl_day);
            this.Name = "PanelDay";
            this.Size = new System.Drawing.Size(100, 100);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_thing;
        private System.Windows.Forms.Label Label_ChineseDay;
        private System.Windows.Forms.Label lbl_day;
    }
}
