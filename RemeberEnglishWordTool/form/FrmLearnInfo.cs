using RemeberEnglishWordTool.common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RemeberEnglishWordTool.form
{
    public partial class FrmLearnInfo : Form
    {
        Access access = new Access();
        public FrmLearnInfo()
        {
            InitializeComponent();
        }

        private void FrmLearnInfo_Load(object sender, EventArgs e)
        {
            int today = 0;
            int total = 0;
            today = access.GetRecordCount(string.Format(" and CreateTime like '%{0}%'", DateTime.Now.ToString("yyyy-MM-dd")));
            total = access.GetRecordCount("");
            lblToday.Text = "今日记录单词：" + today.ToString() + "个";
            lblTotal.Text = "总共记录单词：" + total.ToString() + "个";
        }
    }
}
