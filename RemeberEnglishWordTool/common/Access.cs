using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemeberEnglishWordTool.common
{
    public class Access
    {
        /// <summary>
        /// 添加单词
        /// </summary>
        /// <param name="word"></param>
        /// <param name="translate"></param>
        /// <param name="type"></param>
        public void AddWord(string word, string translate, string type)
        {
            string id = Guid.NewGuid().ToString();
            string sql = string.Format("insert into T_Word (ID,Word,Translate,CreateTime,Type) values('{0}','{1}','{2}','{3}','{4}')", id, word, translate, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), type);
            SQLiteHelper.ExecuteNonQuery(sql, CommandType.Text);
        }

        public void DeleteWord(string id)
        {
            string sql = string.Format("delete from T_Word where id='{0}'", id);
            SQLiteHelper.ExecuteNonQuery(sql, CommandType.Text);
        }

        public void UpdateWord(string id, string word, string translate, string type)
        {
            string sql = string.Format("update T_Word  set Word='{0}',Translate='{1}',Type='{2}' where ID='{3}'", word, translate, type, id);
            SQLiteHelper.ExecuteNonQuery(sql, CommandType.Text);
        }

        /// <summary>
        /// 查询单词
        /// </summary>
        /// <param name="word"></param>
        /// <param name="translate"></param>
        /// <param name="type"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        public DataTable SearchWord(string word, string translate, string type, string beginTime, string endTime, string id = null)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("select * from T_Word t where 0=0");
            if (!string.IsNullOrWhiteSpace(word))
            {
                sb.Append(string.Format(" and Word like '%{0}%'", word));
            }
            if (!string.IsNullOrWhiteSpace(translate))
            {
                sb.Append(string.Format(" and Translate like '%{0}%'", translate));
            }
            if (!string.IsNullOrWhiteSpace(type))
            {
                sb.Append(string.Format(" and Type = '{0}'", type));
            }
            if (!beginTime.Equals("0001-01-01 00:00:00"))
            {
                sb.Append(string.Format(" and CreateTime >= '{0}'", beginTime));
            }
            if (!endTime.Equals("0001-01-01 00:00:00"))
            {
                sb.Append(string.Format(" and CreateTime <= '{0}'", endTime));
            }
            if (!string.IsNullOrWhiteSpace(id))
            {
                sb.Append(string.Format(" and ID ='{0}'", id));
            }
            sb.Append(string.Format(" order by t.CreateTime desc"));
            DataSet ds = SQLiteHelper.ExecuteDataSet(sb.ToString(), CommandType.Text);
            if (ds != null & ds.Tables[0].Rows.Count > 0)
            {
                return ds.Tables[0];
            }
            return null;
        }

        public int CalCount(string today = null)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format("select Count(*) from T_Word where 0=0"));
            if (!string.IsNullOrWhiteSpace(today))
            {
                sb.Append(string.Format(" and CreateTime like '%{0}%'", today));
            }
            int count = 0;
            object o = SQLiteHelper.ExecuteScalar(sb.ToString(), CommandType.Text);
            int.TryParse(o.ToString(), out count);
            return count;
        }
    }
}
