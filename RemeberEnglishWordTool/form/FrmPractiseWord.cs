using RemeberEnglishWordTool.common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemeberEnglishWordTool.form
{
    public partial class FrmPractiseWord : Form
    {
        Access access = new Access();
        private int _right; //答对数
        private int _wrong; //答错数
        private DataTable dt = null;    
        private DataRow dr = null;  
        public FrmPractiseWord()
        {
            InitializeComponent();
        }

        #region 窗体事件
        private void btnStartTest_Click(object sender, EventArgs e)
        {
            Reset();
            string beginTime = this.deBegin.DateTime.ToString("yyyy-MM-dd");
            string endTime = this.deEnd.DateTime.ToString("yyyy-MM-dd");
            string strWhere = access.GetSqlWhere("", "", "", beginTime, endTime);
            dt = access.SearchWord(strWhere);
            if (dt != null && dt.Rows.Count > 0)
            {
                int count = dt.Rows.Count;
                Random r = new Random();
                dr = dt.Rows[r.Next(count)];
                if (rbnAnswerEnglish.Checked)
                {
                    this.lblQuestion.Text = dr["Translate"].ToString();
                }
                else
                {
                    this.lblQuestion.Text = dr["Word"].ToString();
                }
                this.lblTotalScore.Text = "总分：" + count.ToString();
                this.txtAnswer.Focus();
            }
            else
            {
                toolTipController1.ShowHint("没有单词记录！", btnStartTest, DevExpress.Utils.ToolTipLocation.RightCenter);
            }
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            if (dt != null && dt.Rows.Count > 0)
            {
                toolTipController1.HideHint();
                if (!string.IsNullOrWhiteSpace(this.txtAnswer.Text))
                {
                    if ((rbnAnswerEnglish.Checked && dr["Word"].ToString().Equals(this.txtAnswer.Text)) || (rbnAnswerChinese.Checked && dr["Translate"].ToString().Contains(this.txtAnswer.Text)))
                    {
                        toolTipController1.ShowHint("回答正确！", btnAnswer, DevExpress.Utils.ToolTipLocation.RightCenter);
                        _right++;
                        this.lblGetScore.Text = "得分：" + _right.ToString();
                        this.lblRight.Text = "答对：" + _right.ToString();
                    }
                    else
                    {
                        toolTipController1.ShowHint("回答错误！", btnAnswer, DevExpress.Utils.ToolTipLocation.RightCenter);
                        _wrong++;
                        this.lblWrong.Text = "答错：" + _wrong.ToString();
                    }
                    //提问下一个单词
                    QuestionNextWord();
                }
                else
                {
                    toolTipController1.ShowHint("请作填答！", btnAnswer, DevExpress.Utils.ToolTipLocation.RightCenter);
                }
            }
            else
            {
                toolTipController1.ShowHint("请先点击开始测试！", btnAnswer, DevExpress.Utils.ToolTipLocation.RightCenter);
            }
        }

        private void rbnAnswerEnglish_CheckedChanged(object sender, EventArgs e)
        {
            BindQuestion();
        }

        private void txtAnswer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//如果输入的是回车键 
            {
                btnAnswer_Click(null, null);
            }
        }
        #endregion

        #region 私有方法
        /// <summary>
        /// 重置数据和界面显示
        /// </summary>
        private void Reset()
        {
            dt = null;
            lblTotalScore.Text = "总分：";
            lblGetScore.Text = "得分：";
            lblRight.Text = "答对：";
            lblWrong.Text = "答错：";
        }

        /// <summary>
        /// 判断选择的提问选项，绑定显示的问题
        /// </summary>
        private void BindQuestion()
        {
            if (rbnAnswerEnglish.Checked)
            {
                this.lblQuestion.Text = dr["Translate"].ToString();
            }
            else
            {
                this.lblQuestion.Text = dr["Word"].ToString();
            }
        }
        /// <summary>
        /// 提问下一个单词
        /// </summary>
        private void QuestionNextWord()
        {
            dt.Rows.Remove(dr);
            int count = dt.Rows.Count;
            if (count > 0)
            {
                Random r = new Random();
                dr = dt.Rows[r.Next(count)];
                BindQuestion();
                this.txtAnswer.Text = string.Empty;
                this.txtAnswer.Focus();
            }
            else
            {
                toolTipController1.ShowHint("恭喜答完，测试结束！", btnAnswer, DevExpress.Utils.ToolTipLocation.RightCenter);
            }
        }
        #endregion
    }
}
