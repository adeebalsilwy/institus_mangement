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

namespace THAGBAN_INST.FORM.FRM_MANG_STUD
{
    public partial class FRM_ADD_COURS : DevExpress.XtraEditors.XtraForm
    {
        db_max_instEntities con = new db_max_instEntities();
        tost toast =new tost();
        dialge dialge = new dialge();
        public int cours_id=0;

       public string cours_name;
       public string cours_desk;
        public int number_of_hours;


        public FRM_ADD_COURS()
        {
            InitializeComponent();
            
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            add_cours();
            
        }
        void clear()
        {
            cours_id = 0;
            txt_level_desc.Text = "";
            txt_cours_name.Text = "";
            txt_number_hours.Text = "";
        }
        bool is_empty()
        {
            if (txt_level_desc.Text != "" && txt_cours_name.Text != "" && txt_number_hours.Text!="")
            {
                return false;
            }
            else
                return true;

        }

        void add_cours()
        {

            tost toast = new tost();
            dialge dialge = new dialge();
            if (is_empty() != true)
            {
                //cheak add or edit 
            try
                {
                    TBL_COURS cl = new TBL_COURS();
                    cl.COURS_NAME = txt_cours_name.Text;
                    cl.COURS_DESC = txt_level_desc.Text;
                    cl.NUMBER_HOURS = Convert.ToInt32(txt_number_hours.Text);
                   

                    if (cours_id != 0)
                    {
                        //add 
                        cl.COURS_ID = Convert.ToInt32(cours_id);
                        con.TBL_COURS.AddOrUpdate(cl);
                        con.SaveChanges();
                        //toast.Width = this.Width;

                        adl.NotifictionUser notifiction = new adl.NotifictionUser(THAGBAN_INST.Properties.Resources.EditNotificationText, THAGBAN_INST.Properties.Resources.edit_32px);
                        notifiction.Show();
                        clear();
                        //MessageBox.Show("تم التعديل بنجاح ");
                    }
                    else
                    {
                        //update 
                        con.TBL_COURS.AddOrUpdate(cl);
                        con.SaveChanges();
                        // toast.Width = this.Width;
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
            if (cours_id != 0)
            {
                TBL_COURS tbl = con.TBL_COURS.Find(cours_id);
                if (tbl != null) {
                    txt_level_desc.Text = tbl.COURS_DESC.ToString();
                    txt_cours_name.Text = tbl.COURS_NAME.ToString();
                    txt_number_hours.Text = tbl.NUMBER_HOURS.ToString();
                        }

             }
        }

        private void txt_cours_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }
    }
}