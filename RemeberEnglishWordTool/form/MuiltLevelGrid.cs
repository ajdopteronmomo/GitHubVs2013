using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RemeberEnglishWordTool.form
{
    public partial class MuiltLevelGrid : Form
    {
        DataSet ds = new DataSet();
        private static string _connectionString = string.Format(@"Data Source={0}\{1}\{2}", Application.StartupPath, "data", "word.db");


        public MuiltLevelGrid()
        {
            InitializeComponent();
        }

        private void MuiltLevelGrid_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SQLiteDataAdapter oleDBAdapter1 = new SQLiteDataAdapter("SELECT * FROM T_Word", _connectionString);
            oleDBAdapter1.Fill(ds, "Test1");
            oleDBAdapter1.Fill(ds, "Test2");
            ds.Relations.Add("关系", ds.Tables["Test1"].Columns["ID"], ds.Tables["Test2"].Columns["ID"]);
            gridControl1.DataSource = ds.Tables["Test1"];
            gridControl1.MainView.PopulateColumns();
        }
    }
}
