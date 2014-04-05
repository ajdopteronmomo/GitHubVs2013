using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentBuddy
{
    public class TokenizeQuery
    {
        public void tokenize_query(string query, string punctuation)
        {
            List<int> iList = new List<int>();
            string result = string.Empty;
            foreach (char c in punctuation)
            {
                iList.AddRange(GetAllContainIndex(query, c));
            }
            iList.OrderBy(c => c.ToString());
            for (int i = 0; i < iList.Count; i++)
            {
                if (i == 0)
                {
                    result = query.Substring(0, iList[i]).Trim();
                    SplitSpace(result);
                }
                else if (i != iList.Count - 1)
                {
                    result = query.Substring(iList[i] + 1, iList[i + 1] - iList[i] - 1).Trim();
                    SplitSpace(result);
                }
                else
                {
                    result = query.Substring(iList[i] + 1).Trim();
                    SplitSpace(result);
                }
            }

        }

        List<int> indexs = new List<int>();
        private List<int> GetAllContainIndex(string query, char c)
        {
            if (query.Contains(c))
            {
                int index = query.IndexOf(c);
                indexs.Add(index);
                query = query.Substring(index + 1, query.Length - 1 - index);
                GetAllContainIndex(query, c);
            }
            return indexs;
        }

        private void SplitSpace(string result)
        {
            if (result.Contains(" "))
            {
                var arr = result.Split(' ');
                foreach (var item in arr)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            else
            {
                Console.WriteLine(result);
            }
        }
    }
}
