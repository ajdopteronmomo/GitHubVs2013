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
        public DataTable SearchWord(string strWhere)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("select * from T_Word t");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                sb.Append(" WHERE 0=0" + strWhere);
            }
            sb.Append(string.Format(" order by t.CreateTime desc"));
            DataSet ds = SQLiteHelper.ExecuteDataSet(sb.ToString(), CommandType.Text);
            if (ds != null & ds.Tables[0].Rows.Count > 0)
            {
                return ds.Tables[0];
            }
            return null;
        }

        /// <summary>  
        /// 获取记录总数  
        /// </summary>  
        public int GetRecordCount(string strWhere)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("select count(1) FROM T_Word ");
            if (!string.IsNullOrWhiteSpace(strWhere))
            {
                sb.Append(" where 0=0" + strWhere);
            }
            object obj = SQLiteHelper.ExecuteScalar(sb.ToString(), CommandType.Text);
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>  
        /// 分页获取数据列表  
        /// </summary>  
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT * FROM ( ");
            sb.Append(string.Format(" SELECT (SELECT COUNT(*) FROM T_Word AS t2 WHERE t2.CreateTime >= T.CreateTime {0})",strWhere));
            sb.Append(" AS Rows, T.*  from T_Word T ");
            if (!string.IsNullOrWhiteSpace(strWhere))
            {
                sb.Append(" WHERE 0=0" + strWhere);
            }
            if (!string.IsNullOrWhiteSpace(orderby))
            {
                sb.Append(" order by T." + orderby + " desc");
            }
            else
            {
                sb.Append(" order by T.ID desc");
            }
            sb.Append(" ) TT");
            sb.AppendFormat(" WHERE TT.Rows between {0} and {1}", startIndex, endIndex);
            return SQLiteHelper.ExecuteDataSet(sb.ToString(), CommandType.Text);
        }

        /// <summary>  
        /// 获取查询条件  
        /// </summary>  
        /// <author>PengZhen</author>  
        /// <time>2013-11-5 15:25:00</time>  
        /// <returns>返回查询条件</returns>  
        public string GetSqlWhere(string word,string translate,string type,string beginTime,string endTime,string id=null)
        {
            //查询条件  
            StringBuilder sb = new StringBuilder();

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
            if (!beginTime.Equals("0001-01-01"))
            {
                sb.Append(string.Format(" and CreateTime >= '{0}'", beginTime));
            }
            if (!endTime.Equals("0001-01-01"))
            {
                sb.Append(string.Format(" and CreateTime <= '{0}'", endTime));
            }
            if (!string.IsNullOrWhiteSpace(id))
            {
                sb.Append(string.Format(" and ID='{0}'", id));
            }
            return sb.ToString();
        }  
    }
}
