namespace ILMergeGUI
{
    partial class Calendar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GridViewCalendar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewCalendar)).BeginInit();
            this.SuspendLayout();
            // 
            // GridViewCalendar
            // 
            this.GridViewCalendar.AllowUserToAddRows = false;
            this.GridViewCalendar.AllowUserToDeleteRows = false;
            this.GridViewCalendar.AllowUserToResizeColumns = false;
            this.GridViewCalendar.AllowUserToResizeRows = false;
            this.GridViewCalendar.BackgroundColor = System.Drawing.SystemColors.Control;
            this.GridViewCalendar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridViewCalendar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewCalendar.Location = new System.Drawing.Point(4, 24);
            this.GridViewCalendar.MultiSelect = false;
            this.GridViewCalendar.Name = "GridViewCalendar";
            this.GridViewCalendar.ReadOnly = true;
            this.GridViewCalendar.RowHeadersWidth = 40;
            this.GridViewCalendar.RowTemplate.Height = 23;
            this.GridViewCalendar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.GridViewCalendar.Size = new System.Drawing.Size(702, 364);
            this.GridViewCalendar.TabIndex = 0;
            this.GridViewCalendar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewCalendar_CellClick);
            // 
            // Calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 393);
            this.Controls.Add(this.GridViewCalendar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Calendar";
            this.Text = "Calendar";
            this.Load += new System.EventHandler(this.Calendar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewCalendar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridViewCalendar;
    }
}