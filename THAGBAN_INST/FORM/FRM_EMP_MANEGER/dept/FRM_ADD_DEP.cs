using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using THAGBAN_INST.FORM.FRM_EMP_MANEGER;
using THAGBAN_INST.FORM;
using System.Data.Entity.Migrations;
using THAGBAN_INST.DATA;
using THAGBAN_INST.adl;

namespace THAGBAN_INST.FORM.FRM_EMP_MANEGER
{
    public partial class FRM_ADD_DEP : DevExpress.XtraEditors.XtraForm
    {
        db_max_instEntities con = new db_max_instEntities();
        tost toast =new tost();
        dialge dialge = new dialge();
        public int dept_id;

       public string dept_name;
       public string dept_desc;
       public string dept_state;


        public FRM_ADD_DEP()
        {
            InitializeComponent();
            
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            add_dept();
            
        }
        void clear()
        {
            dept_id = 0;
            txt_dept_desc.Text = "";
            txt_dept_name.Text = "";
        }
        bool is_empty()
        {
            if (txt_dept_desc.Text != "" && txt_dept_name.Text != "" && com_state.Text!="")
            {
                return false;
            }
            else
                return true;

        }

        void add_dept()
        {

            tost toast = new tost();
            dialge dialge = new dialge();
            if (is_empty() != true)
            {
                //cheak add or edit 
            try
                {
                    TBL_DEPT cl = new TBL_DEPT();
                    cl.DEPT_NAME = txt_dept_name.Text;
                    cl.DEPT_DESC = txt_dept_desc.Text;
                    
                        cl.DEPT_STATE =com_state.Text;

                    if (dept_id != 0)
                    {
                        //add 
                        cl.DEPT_ID = Convert.ToInt32(dept_id);
                        con.TBL_DEPT.AddOrUpdate(cl);
                        con.SaveChanges();
                        toast.Width = this.Width;
                        adl.NotifictionUser notifiction = new adl.NotifictionUser(THAGBAN_INST.Properties.Resources.EditNotificationText, THAGBAN_INST.Properties.Resources.edit_32px);
                        notifiction.Show();
                        //MessageBox.Show("تم التعديل بنجاح ");
                    }
                    else
                    {
                        //update 
                        con.TBL_DEPT.AddOrUpdate(cl);
                        con.SaveChanges();
                        NotifictionUser notifiction = new NotifictionUser(THAGBAN_INST.Properties.Resources.AddNotificationText, THAGBAN_INST.Properties.Resources.add_32px);

                        notifiction.Show();

                    }
                }
                catch (Exception ex)
                {
                   
                    dialge.Width = this.Width;
                    dialge.lbl_mess.Text=ex.Message;
                    dialge.Show();
                }
                clear();
            }
            else
            {
                dialge.Width = this.Width;
                dialge.lbl_mess.Text ="الرجاء ادخال جميع البيانات ";
                dialge.Show();



            }


        }

        private void ch_open_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
        }

        private void ch_close_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {

        }
       

        private void bunifuPanel2_Click(object sender, EventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void FRM_ADD_DEP_Load(object sender, EventArgs e)
        {
            if (dept_id != 0)
            {
                txt_dept_desc.Text = dept_desc;
                txt_dept_name.Text = dept_name;
                com_state.Text = dept_state;
            }
        }
    }
}