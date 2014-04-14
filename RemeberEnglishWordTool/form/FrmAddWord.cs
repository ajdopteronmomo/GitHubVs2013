using RemeberEnglishWordTool.common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemeberEnglishWordTool.form
{
    public partial class FrmAddWord : Form
    {
        Access access = new Access();
        public FrmAddWord()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                string word = this.txtWord.Text.ToString();
                string translate = this.txtTranslate.Text.ToString();
                string type = this.cbxType.SelectedText;
                access.AddWord(word, translate, type);
                toolTipController1.HideHint();
                toolTipController1.ShowHint("添加成功！", btnAdd, DevExpress.Utils.ToolTipLocation.RightCenter);
                Clear();
            }
        }

        /// <summary>
        /// 添加完数据空清空输入框，方便继续添加
        /// </summary>
        private void Clear()
        {
            this.txtTranslate.Text = string.Empty;
            this.txtWord.Text = string.Empty;
            this.cbxType.SelectedText = string.Empty;
        }

        #region 验证
        private void txtWord_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtWord.Text))
            {
                this.errorProvider1.SetError(this.txtWord, "不能为空，必填");
                e.Cancel = true;
            }
            else
            {
                this.errorProvider1.SetError(this.txtWord, string.Empty);
            }
        }

        private void txtTranslate_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtTranslate.Text))
            {
                this.errorProvider1.SetError(this.txtTranslate, "不能为空，必填");
                e.Cancel = true;
            }
            else
            {
                this.errorProvider1.SetError(this.txtTranslate, string.Empty);
            }
        }
        #endregion
    }
}
