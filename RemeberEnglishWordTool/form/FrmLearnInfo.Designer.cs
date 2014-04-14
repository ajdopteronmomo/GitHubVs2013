namespace RemeberEnglishWordTool.form
{
    partial class FrmLearnInfo
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
            this.lblToday = new DevExpress.XtraEditors.LabelControl();
            this.lblTotal = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // lblToday
            // 
            this.lblToday.Location = new System.Drawing.Point(73, 54);
            this.lblToday.Name = "lblToday";
            this.lblToday.Size = new System.Drawing.Size(84, 14);
            this.lblToday.TabIndex = 0;
            this.lblToday.Text = "今日记录单词：";
            // 
            // lblTotal
            // 
            this.lblTotal.Location = new System.Drawing.Point(73, 96);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(84, 14);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "总共记录单词：";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(73, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(132, 14);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "亲，看一下你的战绩吧！";
            // 
            // FrmLearnInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 127);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblToday);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLearnInfo";
            this.Text = "学习情况";
            this.Load += new System.EventHandler(this.FrmLearnInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblToday;
        private DevExpress.XtraEditors.LabelControl lblTotal;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}