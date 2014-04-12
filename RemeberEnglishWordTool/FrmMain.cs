using RemeberEnglishWordTool.form;
using Sunisoft.IrisSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemeberEnglishWordTool
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        #region 窗体菜单事件
        private void btnAddWord_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenWindow(typeof(FrmAddWord).ToString());
        }

        private void btnFindWord_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenWindow(typeof(FrmSearchWord).ToString());
        }

        private void btnTestWord_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenWindow(typeof(FrmPractiseWord).ToString());
        }
        #endregion

        #region 通过反射，防止打开重复的mdi子窗体
        private void OpenWindow(string ChildTypeString)
        {
            Form myChild = null;
            if (!ContainMDIChild(ChildTypeString))
            {
                // Get current process assembly 
                Assembly assembly = Assembly.GetExecutingAssembly();
                // Create data type using type string 
                Type typForm = assembly.GetType(ChildTypeString);
                // Create object using type 's "InvokeMember " method 
                Object obj = typForm.InvokeMember(
                null,
                BindingFlags.DeclaredOnly |
                BindingFlags.Public | BindingFlags.NonPublic |
                BindingFlags.Instance | BindingFlags.CreateInstance,
                null,
                null,
                null);
                // Show child form 
                if (obj != null)
                {
                    myChild = obj as Form;
                    myChild.MdiParent = this;
                    myChild.Show();
                    myChild.Focus();
                }
            }
        }

        /// <summary> 
        /// Search mdi child form by specific type string 
        /// </summary> 
        /// <param name= "ChildTypeString "> </param> 
        /// <returns> </returns> 
        private bool ContainMDIChild(string ChildTypeString)
        {

            Form myMDIChild = null;
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType().ToString() == ChildTypeString)
                {
                    // found it 
                    myMDIChild = f;
                    break;
                }
            }
            // Show the exist form 
            if (myMDIChild != null)
            {
                myMDIChild.TopMost = true;
                myMDIChild.Show();
                myMDIChild.Focus();
                return true;
            }
            else
                return false;
        }
        #endregion

        private void FrmMain_Load(object sender, EventArgs e)
        {
            skinEngine1.SkinFile = Path.Combine(Application.StartupPath, "skin/One/OneCyan.ssk");
        }
    }
}
