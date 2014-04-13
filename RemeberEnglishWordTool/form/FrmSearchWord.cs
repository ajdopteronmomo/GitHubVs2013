using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using RemeberEnglishWordTool.common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemeberEnglishWordTool.form
{
    public partial class FrmSearchWord : Form
    {
        Access access = new Access();
        public FrmSearchWord()
        {
            InitializeComponent();
        }

        private void FrmSearchWord_Load(object sender, EventArgs e)
        {
            DataTable dt = access.SearchWord("", "", "", "0001-01-01 00:00:00", "0001-01-01 00:00:00");
            if (dt != null)
            {
                gridData.DataSource = dt;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BindData();
        }

        private void BindData()
        {
            string word = this.txtWord.Text;
            string translate = this.txtTranslate.Text;
            string type = this.cbxType.SelectedText;
            string beginTime = this.deBegin.DateTime.ToString("yyyy-MM-dd HH:mm:ss");
            string endTime = this.deEnd.DateTime.ToString("yyyy-MM-dd HH:mm:ss");
            DataTable dt = access.SearchWord(word, translate, type, beginTime, endTime);
            if (dt != null)
            {
                gridData.DataSource = dt;
            }
        }

        private void gridViewData_MouseUp(object sender, MouseEventArgs e)
        {
            GridHitInfo hi = this.gridViewData.CalcHitInfo(e.Location);
            if (hi.InRow && e.Button == MouseButtons.Right)
            {
                pMenu.ShowPopup(Control.MousePosition);
            }
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("全记住了吗？确定要删除所选单词记录？", "询问", MessageBoxButtons.YesNo) == DialogResult.OK)
            {
                foreach (int index in this.gridViewData.GetSelectedRows())
                {
                    string id = this.gridViewData.GetRowCellValue(index, "ID").ToString();
                    access.DeleteWord(id);
                }
                BindData();
            }
        }

        private void gridData_MouseDown(object sender, MouseEventArgs e)
        {
            GridHitInfo hInfo = gridViewData.CalcHitInfo(new Point(e.X, e.Y));
            if (hInfo.InRow && e.Button == MouseButtons.Left && e.Clicks == 2)
            {
                int index = this.gridViewData.GetSelectedRows()[0];
                string id = this.gridViewData.GetRowCellValue(index, "ID").ToString();
                FrmUpdateWord frm = new FrmUpdateWord(id);
                frm.ShowDialog();
                BindData();
            }
        }
    }
}
