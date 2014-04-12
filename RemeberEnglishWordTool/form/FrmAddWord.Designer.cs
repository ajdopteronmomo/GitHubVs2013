namespace RemeberEnglishWordTool.form
{
    partial class FrmAddWord
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.cbxType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtWord = new System.Windows.Forms.TextBox();
            this.txtTranslate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.cbxType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(52, 32);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(36, 14);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "单词：";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(53, 79);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(36, 14);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "词义：";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(117, 175);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 38);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "记录";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbxType
            // 
            this.cbxType.Location = new System.Drawing.Point(118, 124);
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
            this.cbxType.TabIndex = 13;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(53, 126);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(36, 14);
            this.labelControl3.TabIndex = 12;
            this.labelControl3.Text = "词性：";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl4.Location = new System.Drawing.Point(104, 38);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(7, 14);
            this.labelControl4.TabIndex = 14;
            this.labelControl4.Text = "*";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl5.Location = new System.Drawing.Point(104, 86);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(7, 14);
            this.labelControl5.TabIndex = 15;
            this.labelControl5.Text = "*";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtWord
            // 
            this.txtWord.Location = new System.Drawing.Point(118, 32);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(159, 21);
            this.txtWord.TabIndex = 16;
            this.txtWord.Validating += new System.ComponentModel.CancelEventHandler(this.txtWord_Validating);
            // 
            // txtTranslate
            // 
            this.txtTranslate.Location = new System.Drawing.Point(117, 81);
            this.txtTranslate.Name = "txtTranslate";
            this.txtTranslate.Size = new System.Drawing.Size(160, 21);
            this.txtTranslate.TabIndex = 17;
            this.txtTranslate.Validating += new System.ComponentModel.CancelEventHandler(this.txtTranslate_Validating);
            // 
            // FrmAddWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(325, 233);
            this.Controls.Add(this.txtTranslate);
            this.Controls.Add(this.txtWord);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.cbxType);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddWord";
            this.Text = "记录单词";
            ((System.ComponentModel.ISupportInitialize)(this.cbxType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.ComboBoxEdit cbxType;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.Utils.ToolTipController toolTipController1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.TextBox txtTranslate;
    }
}