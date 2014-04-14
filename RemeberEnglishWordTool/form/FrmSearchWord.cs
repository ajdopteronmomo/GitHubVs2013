using DevExpress.XtraEditors;
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

        //页行数  
        private int pagesize = 10;
        //当前页  
        private int pageIndex = 1;
        //总页数  
        private int pageCount;

        //查询条件  
        private static string strWhere = string.Empty;
        public FrmSearchWord()
        {
            InitializeComponent();
        }

        private void FrmSearchWord_Load(object sender, EventArgs e)
        {
            BindPageGridList();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //获取查询条件  
            strWhere = access.GetSqlWhere(this.txtWord.Text, this.txtTranslate.Text, this.cbxType.SelectedText, this.deBegin.DateTime.ToString("yyyy-MM-dd"), this.deEnd.DateTime.ToString("yyyy-MM-dd").Equals("0001-01-01") ? "0001-01-01" : this.deEnd.DateTime.AddDays(1).ToString("yyyy-MM-dd"));
            BindPageGridList(strWhere);
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
            if (MessageBox.Show("全记住了吗？确定要删除所选单词记录？", "询问", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (int index in this.gridViewData.GetSelectedRows())
                {
                    string id = this.gridViewData.GetRowCellValue(index, "ID").ToString();
                    access.DeleteWord(id);
                }
                strWhere = access.GetSqlWhere(this.txtWord.Text, this.txtTranslate.Text, this.cbxType.SelectedText, this.deBegin.Text, this.deEnd.Text);
                BindPageGridList(strWhere);
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
                strWhere = access.GetSqlWhere(this.txtWord.Text, this.txtTranslate.Text, this.cbxType.SelectedText, this.deBegin.Text, this.deEnd.Text);
                BindPageGridList(strWhere);
            }
        }

        /// <summary>  
        /// 绑定分页控件和GridControl数据  
        /// </summary>  
        /// <author>PengZhen</author>  
        /// <time>2013-11-5 14:22:22</time>  
        /// <param name="strWhere">查询条件</param>  
        public void BindPageGridList(string strWhere = null)
        {
            nvgtDataPager.Buttons.CustomButtons[0].Enabled = true;
            nvgtDataPager.Buttons.CustomButtons[1].Enabled = true;
            nvgtDataPager.Buttons.CustomButtons[2].Enabled = true;
            nvgtDataPager.Buttons.CustomButtons[3].Enabled = true;
            //记录获取开始数  
            int startIndex = (pageIndex - 1) * pagesize + 1;
            //结束数  
            int endIndex = pageIndex * pagesize;
            //总行数  
            int row = access.GetRecordCount(strWhere);
            //获取总页数    
            if (row % pagesize > 0)
            {
                pageCount = row / pagesize + 1;
            }
            else
            {
                pageCount = row / pagesize;
            }
            if (pageIndex == 1)
            {
                nvgtDataPager.Buttons.CustomButtons[0].Enabled = false;
                nvgtDataPager.Buttons.CustomButtons[1].Enabled = false; ;
            }
            //最后页时获取真实记录数  
            if (pageCount == pageIndex)
            {
                endIndex = row;
                nvgtDataPager.Buttons.CustomButtons[2].Enabled = false;
                nvgtDataPager.Buttons.CustomButtons[3].Enabled = false;
            }
            //分页获取数据列表  
            DataTable dt = access.GetListByPage(strWhere, "CreateTime", startIndex, endIndex).Tables[0];
            gridData.DataSource = dt;
            nvgtDataPager.DataSource = dt;
            nvgtDataPager.TextStringFormat = string.Format("第 {0}页, 共 {1}页", pageIndex, pageCount);
        }

        private void nvgtDataPager_ButtonClick(object sender, DevExpress.XtraEditors.NavigatorButtonClickEventArgs e)
        {
            ShowEvent("ButtonClick", e.Button);
        }

        /// <summary>  
        /// 分页事件处理  
        /// </summary>  
        /// <param name="eventString">事件名称</param>  
        /// <param name="button">按钮控件</param>  
        /// <author>PengZhen</author>  
        /// <time>2013-11-5 14:25:59</time>  
        void ShowEvent(string eventString, NavigatorButtonBase button)
        {
            NavigatorCustomButton btn = (NavigatorCustomButton)button;
            string type = btn.Tag.ToString();
            if (type == "首页")
            {
                pageIndex = 1;
            }

            if (type == "下一页")
            {
                pageIndex++;
            }

            if (type == "末页")
            {
                pageIndex = pageCount;
            }

            if (type == "上一页")
            {
                pageIndex--;
            }
            //绑定分页控件和GridControl数据  
            BindPageGridList(strWhere);
        }
    }
}
