using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THAGBAN_INST.FORM.FRM_SYSTEM
{
    public partial class FRM_CLOCE : DevExpress.XtraEditors.XtraForm
    {
        public FRM_CLOCE()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            if(this.ParentForm!= null)
            {
                this.ParentForm.Close();
                Application.ExitThread();
            }
            else
            {
                Application.ExitThread();
            }
           
           
        }

        private void btn_no_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Close_Load(object sender, EventArgs e)
        {
            panel1.Visible = true;
            transitionManager1.StartTransition(panel1);
           
            transitionManager1.EndTransition();
           
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

          
           
          
           // this.Hide();
            //FRM_LOGIN frm = new FRM_LOGIN();
            //frm.ShowDialog();
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            if (this.ParentForm != null)
            {
                this.ParentForm.Hide();
                Application.ExitThread();
                Application.Restart();
            }
            else
            {
                Application.ExitThread();
                Application.Restart();
            }

        }
    }
}