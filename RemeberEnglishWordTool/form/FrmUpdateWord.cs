using RemeberEnglishWordTool.common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace RemeberEnglishWordTool.form
{
    public partial class FrmUpdateWord : Form
    {
        Access access = new Access();
        private string _id;
        public FrmUpdateWord()
        {
            InitializeComponent();
        }
        public FrmUpdateWord(string id)
        {
            _id = id;
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            access.UpdateWord(_id, this.txtWord.Text, this.txtTranslate.Text, string.IsNullOrWhiteSpace(this.cbxType.SelectedText) ? this.cbxType.Text : this.cbxType.SelectedText);
            toolTipController1.HideHint();
            toolTipController1.ShowHint("修改成功！", btnUpdate, DevExpress.Utils.ToolTipLocation.RightCenter);
        }

        private void FrmUpdateWord_Load(object sender, EventArgs e)
        {
            string sqlWhere = access.GetSqlWhere("", "", "", "", "", _id);
            DataTable dt = access.SearchWord(sqlWhere);
            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow dr=dt.Rows[0];
                this.txtWord.Text = dr["Word"].ToString();
                this.txtTranslate.Text = dr["Translate"].ToString();
                this.cbxType.SelectedText = dr["Type"].ToString();
            }
        }
    }
}
