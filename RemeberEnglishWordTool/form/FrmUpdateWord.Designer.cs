namespace RemeberEnglishWordTool.form
{
    partial class FrmUpdateWord
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
            this.components = new System.ComponentModel.Container();
            this.txtTranslate = new System.Windows.Forms.TextBox();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cbxType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cbxType.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTranslate
            // 
            this.txtTranslate.Location = new System.Drawing.Point(115, 75);
            this.txtTranslate.Name = "txtTranslate";
            this.txtTranslate.Size = new System.Drawing.Size(160, 21);
            this.txtTranslate.TabIndex = 26;
            // 
            // txtWord
            // 
            this.txtWord.Location = new System.Drawing.Point(116, 26);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(159, 21);
            this.txtWord.TabIndex = 25;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl5.Location = new System.Drawing.Point(102, 80);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(7, 14);
            this.labelControl5.TabIndex = 24;
            this.labelControl5.Text = "*";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl4.Location = new System.Drawing.Point(102, 32);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(7, 14);
            this.labelControl4.TabIndex = 23;
            this.labelControl4.Text = "*";
            // 
            // cbxType
            // 
            this.cbxType.Location = new System.Drawing.Point(116, 118);
            this.cbxType.Name = "cbxType";
            this.cbxType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxType.Properties.Items.AddRange(new object[] {
            "名词",
            "动词",
            "形容词",
            "副词",
            "代词",
            "数词",
            "冠词",
            "介词",
            "连词",
            "感叹词"});
            this.cbxType.Size = new System.Drawing.Size(91, 20);
            this.cbxType.TabIndex = 22;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(51, 120);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(36, 14);
            this.labelControl3.TabIndex = 21;
            this.labelControl3.Text = "词性：";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(115, 169);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(92, 38);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(51, 73);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(36, 14);
            this.labelControl2.TabIndex = 19;
            this.labelControl2.Text = "词义：";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(50, 26);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(36, 14);
            this.labelControl1.TabIndex = 18;
            this.labelControl1.Text = "单词：";
            // 
            // FrmUpdateWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 233);
            this.Controls.Add(this.txtTranslate);
            this.Controls.Add(this.txtWord);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.cbxType);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUpdateWord";
            this.Text = "修改单词";
            this.Load += new System.EventHandler(this.FrmUpdateWord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cbxType.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTranslate;
        private System.Windows.Forms.TextBox txtWord;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.ComboBoxEdit cbxType;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.Utils.ToolTipController toolTipController1;
    }
}