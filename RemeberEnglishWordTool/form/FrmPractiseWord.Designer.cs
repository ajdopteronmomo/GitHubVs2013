namespace RemeberEnglishWordTool.form
{
    partial class FrmPractiseWord
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
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lblWrong = new DevExpress.XtraEditors.LabelControl();
            this.lblRight = new DevExpress.XtraEditors.LabelControl();
            this.lblGetScore = new DevExpress.XtraEditors.LabelControl();
            this.lblTotalScore = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.deEnd = new DevExpress.XtraEditors.DateEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.deBegin = new DevExpress.XtraEditors.DateEdit();
            this.btnStartTest = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.lblQuestion = new DevExpress.XtraEditors.LabelControl();
            this.txtAnswer = new DevExpress.XtraEditors.TextEdit();
            this.btnAnswer = new DevExpress.XtraEditors.SimpleButton();
            this.rbnAnswerEnglish = new System.Windows.Forms.RadioButton();
            this.rbnAnswerChinese = new System.Windows.Forms.RadioButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deEnd.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deBegin.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deBegin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAnswer.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.rbnAnswerEnglish);
            this.groupControl1.Controls.Add(this.rbnAnswerChinese);
            this.groupControl1.Controls.Add(this.lblWrong);
            this.groupControl1.Controls.Add(this.lblRight);
            this.groupControl1.Controls.Add(this.lblGetScore);
            this.groupControl1.Controls.Add(this.lblTotalScore);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.deEnd);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.deBegin);
            this.groupControl1.Controls.Add(this.btnStartTest);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(495, 134);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "设置与成绩";
            // 
            // lblWrong
            // 
            this.lblWrong.Location = new System.Drawing.Point(313, 105);
            this.lblWrong.Name = "lblWrong";
            this.lblWrong.Size = new System.Drawing.Size(36, 14);
            this.lblWrong.TabIndex = 41;
            this.lblWrong.Text = "答错：";
            // 
            // lblRight
            // 
            this.lblRight.Location = new System.Drawing.Point(228, 105);
            this.lblRight.Name = "lblRight";
            this.lblRight.Size = new System.Drawing.Size(36, 14);
            this.lblRight.TabIndex = 40;
            this.lblRight.Text = "答对：";
            // 
            // lblGetScore
            // 
            this.lblGetScore.Location = new System.Drawing.Point(143, 105);
            this.lblGetScore.Name = "lblGetScore";
            this.lblGetScore.Size = new System.Drawing.Size(36, 14);
            this.lblGetScore.TabIndex = 39;
            this.lblGetScore.Text = "得分：";
            // 
            // lblTotalScore
            // 
            this.lblTotalScore.Location = new System.Drawing.Point(58, 105);
            this.lblTotalScore.Name = "lblTotalScore";
            this.lblTotalScore.Size = new System.Drawing.Size(36, 14);
            this.lblTotalScore.TabIndex = 38;
            this.lblTotalScore.Text = "总分：";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(230, 41);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(12, 14);
            this.labelControl5.TabIndex = 29;
            this.labelControl5.Text = "至";
            // 
            // deEnd
            // 
            this.deEnd.EditValue = null;
            this.deEnd.Location = new System.Drawing.Point(248, 38);
            this.deEnd.Name = "deEnd";
            this.deEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deEnd.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deEnd.Size = new System.Drawing.Size(100, 20);
            this.deEnd.TabIndex = 28;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(58, 41);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(60, 14);
            this.labelControl4.TabIndex = 27;
            this.labelControl4.Text = "记录时间：";
            // 
            // deBegin
            // 
            this.deBegin.EditValue = null;
            this.deBegin.Location = new System.Drawing.Point(122, 38);
            this.deBegin.Name = "deBegin";
            this.deBegin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deBegin.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deBegin.Size = new System.Drawing.Size(100, 20);
            this.deBegin.TabIndex = 26;
            // 
            // btnStartTest
            // 
            this.btnStartTest.Location = new System.Drawing.Point(377, 37);
            this.btnStartTest.Name = "btnStartTest";
            this.btnStartTest.Size = new System.Drawing.Size(92, 38);
            this.btnStartTest.TabIndex = 25;
            this.btnStartTest.Text = "开始测试";
            this.btnStartTest.Click += new System.EventHandler(this.btnStartTest_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.lblQuestion);
            this.groupControl2.Controls.Add(this.txtAnswer);
            this.groupControl2.Controls.Add(this.btnAnswer);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 134);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(495, 101);
            this.groupControl2.TabIndex = 6;
            this.groupControl2.Text = "问答窗口";
            // 
            // lblQuestion
            // 
            this.lblQuestion.Location = new System.Drawing.Point(53, 54);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(12, 14);
            this.lblQuestion.TabIndex = 47;
            this.lblQuestion.Text = "问";
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(108, 51);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(226, 20);
            this.txtAnswer.TabIndex = 46;
            this.txtAnswer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAnswer_KeyDown);
            // 
            // btnAnswer
            // 
            this.btnAnswer.Location = new System.Drawing.Point(377, 42);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.Size = new System.Drawing.Size(92, 38);
            this.btnAnswer.TabIndex = 45;
            this.btnAnswer.Text = "答";
            this.btnAnswer.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // rbnAnswerEnglish
            // 
            this.rbnAnswerEnglish.AutoSize = true;
            this.rbnAnswerEnglish.Checked = true;
            this.rbnAnswerEnglish.Location = new System.Drawing.Point(124, 73);
            this.rbnAnswerEnglish.Name = "rbnAnswerEnglish";
            this.rbnAnswerEnglish.Size = new System.Drawing.Size(71, 16);
            this.rbnAnswerEnglish.TabIndex = 48;
            this.rbnAnswerEnglish.TabStop = true;
            this.rbnAnswerEnglish.Text = "知中答英";
            this.rbnAnswerEnglish.UseVisualStyleBackColor = true;
            this.rbnAnswerEnglish.CheckedChanged += new System.EventHandler(this.rbnAnswerEnglish_CheckedChanged);
            // 
            // rbnAnswerChinese
            // 
            this.rbnAnswerChinese.AutoSize = true;
            this.rbnAnswerChinese.Location = new System.Drawing.Point(225, 73);
            this.rbnAnswerChinese.Name = "rbnAnswerChinese";
            this.rbnAnswerChinese.Size = new System.Drawing.Size(71, 16);
            this.rbnAnswerChinese.TabIndex = 49;
            this.rbnAnswerChinese.Text = "知英答中";
            this.rbnAnswerChinese.UseVisualStyleBackColor = true;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(58, 73);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 14);
            this.labelControl1.TabIndex = 50;
            this.labelControl1.Text = "测试模式：";
            // 
            // FrmPractiseWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 235);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPractiseWord";
            this.Text = "单词测试";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deEnd.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deBegin.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deBegin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAnswer.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.ToolTipController toolTipController1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.DateEdit deEnd;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.DateEdit deBegin;
        private DevExpress.XtraEditors.SimpleButton btnStartTest;
        private DevExpress.XtraEditors.LabelControl lblWrong;
        private DevExpress.XtraEditors.LabelControl lblRight;
        private DevExpress.XtraEditors.LabelControl lblGetScore;
        private DevExpress.XtraEditors.LabelControl lblTotalScore;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl lblQuestion;
        private DevExpress.XtraEditors.TextEdit txtAnswer;
        private DevExpress.XtraEditors.SimpleButton btnAnswer;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.RadioButton rbnAnswerEnglish;
        private System.Windows.Forms.RadioButton rbnAnswerChinese;
    }
}