using Aspose.Cells;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WorkbookDesigner designer = new WorkbookDesigner();
            string path = System.IO.Path.Combine(Application.StartupPath, "test.xlsx");
            //List<Test> list = new List<Test>();
            //list.Add(new Test("a",1));
            //list.Add(new Test("b", 2));
            DataTable dt = new DataTable("test");
            DataColumn dc1 = new DataColumn("name");
            DataColumn dc2 = new DataColumn("age");
            dt.Columns.Add(dc1);
            dt.Columns.Add(dc2);
            DataRow dr = dt.NewRow();
            dr["name"] = "a";
            dr["age"] = "1";
            DataRow dr2 = dt.NewRow();
            dr2["name"] = "b";
            dr2["age"] = "2";
            dt.Rows.Add(dr);
            dt.Rows.Add(dr2);
            designer.Open(path);
            //designer.SetDataSource(list);
            designer.SetDataSource(dt);
            designer.SetDataSource("test", "kkk");
            //根据数据源处理生成报表内容
            designer.Process();
            //保存Excel文件
            string fileToSave = System.IO.Path.Combine(Application.StartupPath, "result.xls");
            if (File.Exists(fileToSave))
            {
                File.Delete(fileToSave);
            }

            designer.Save(fileToSave, FileFormatType.Excel2003);
            //打开Excel文件
            Process.Start(fileToSave);
        }

        public class Test
        {
            public Test(string name,int age)
            {
                this.Name = name;
                this.Age = age;
            }
            public string Name{get;set;}
            public int Age { get; set; }
        }
    }
}
