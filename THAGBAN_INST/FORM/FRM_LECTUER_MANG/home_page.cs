using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using THAGBAN_INST.DATA;

namespace THAGBAN_INST.FORM.FRM_LECTUER_MANG
{
    public partial class home_page : DevExpress.XtraEditors.XtraUserControl
    {
        db_max_instEntities con = new db_max_instEntities();
        private int lect_id;
        private int stud_lect_id;
        private object temp_tech_lect_id;

        public home_page()
        {
            InitializeComponent();
            get_info();
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {
           
        }
   void get_info()
        {
            adl.method meth = new adl.method();
            int inst_id = THAGBAN_INST.Properties.Settings.Default.inst_id;
            label1.Text = con.TBL_INST.Find(inst_id).INST_NAME;
            meth.data = con.TBL_INST.Find(inst_id).INST_LOGO;
            if (meth.data != null)
                pictureBox1.Image = Image.FromStream(meth.convert_image());

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txt_time.Text = DateTime.Now.ToString();
        }

        private void home_page_Load(object sender, EventArgs e)
        {
            get_info();
        }
    }
}
