using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentBuddy
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            string query = "car? dealers! bmw, audi";
            string punctuation = "?!";
            string[] a = new string[] { "?", "!", " " };
            var result = query.Split(a, StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }
            //TokenizeQuery tq = new TokenizeQuery();
            //tq.tokenize_query(query, punctuation);
            //stopwatch.Stop();
            //Console.WriteLine(stopwatch.Elapsed.TotalMilliseconds);
            //Console.ReadKey();
        }
    }
}
