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

namespace THAGBAN_INST.FORM.FRM_MANG_STUD.level
{
    public partial class FRM_ADD_LEVEL : DevExpress.XtraEditors.XtraForm
    {
        db_max_instEntities con = new db_max_instEntities();
        tost toast =new tost();
        dialge dialge = new dialge();
        public int level_id=0;

       public string level_name;
       public string level_desc;
       public string level_state;
        public string n_of_years;
       public bool state;


        public FRM_ADD_LEVEL()
        {
            InitializeComponent();
            
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            add_level();
            
        }
        void clear()
        {
            level_id = 0;
            txt_level_desc.Text = "";
            txt_level_name.Text = "";
            txt_number_years.Text = "";
        }
        bool is_empty()
        {
            if (txt_level_desc.Text != "" && txt_level_name.Text != "" && txt_number_years.Text!="")
            {
                return false;
            }
            else
                return true;

        }

        void add_level()
        {

            tost toast = new tost();
            dialge dialge = new dialge();
            if (is_empty() != true)
            {
                //cheak add or edit 
            try
                {
                    TBL_LEVLE cl = new TBL_LEVLE();
                    cl.LEVEL_NAME = txt_level_name.Text;
                    cl.LEVEL_DESC = txt_level_desc.Text;
                    cl.N_OF_YEARS = Convert.ToInt32(txt_number_years.Text);
                    cl.INST_ID = 1;
                    if (rdb_open.Checked)
                        cl.LEVEL_STATE = true;
                    else
                    cl.LEVEL_STATE = false;

                    if (level_id != 0)
                    {
                        //add 
                        cl.LEVEL_ID = Convert.ToInt32(level_id);
                        con.TBL_LEVLE.AddOrUpdate(cl);
                        con.SaveChanges();
                        toast.Width = this.Width;

                        adl.NotifictionUser notifiction = new adl.NotifictionUser(THAGBAN_INST.Properties.Resources.EditNotificationText, THAGBAN_INST.Properties.Resources.edit_32px);
                        notifiction.Show();
                        clear();
                        //MessageBox.Show("تم التعديل بنجاح ");
                    }
                    else
                    {
                        //update 
                        con.TBL_LEVLE.AddOrUpdate(cl);
                        con.SaveChanges();
                        adl.NotifictionUser notifiction = new adl.NotifictionUser(THAGBAN_INST.Properties.Resources.AddNotificationText, THAGBAN_INST.Properties.Resources.add_32px);
                        notifiction.Show();
                        clear();

                    }
                   
                    
                }
                catch (Exception ex)
                {
                   
                    MessageBox.Show(ex.Message+ex.InnerException.ToString());
                    //dialge.Width = this.Width;
                    //dialge.lbl_mess.Text=ex.Message;
                    //dialge.Show();
                }
              
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
            if (level_id != 0)
            {
                txt_level_desc.Text = level_desc;
                txt_level_name.Text = level_name;
                if(state==true)
                    rdb_open.Checked = true;
                else
                    rdb_close.Checked = false;

             }
        }
    }
}