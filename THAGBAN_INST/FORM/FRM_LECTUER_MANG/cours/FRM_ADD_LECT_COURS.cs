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

namespace THAGBAN_INST.FORM.FRM_LECTUER_MANG.cours
{
    public partial class FRM_ADD_LECT_COURS : DevExpress.XtraEditors.XtraForm
    {
        db_max_instEntities con = new db_max_instEntities();
        tost toast =new tost();
        dialge dialge = new dialge();
        public int cours_id=0;

       public string cours_name;
       public string cours_desk;
        bool state;
        DateTime cours_date;


        public FRM_ADD_LECT_COURS()
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
            txt_cours_desc.Text = "";
            txt_cours_name.Text = "";
            txt_cors_date.Text = "";
        }
        bool is_empty()
        {
            if (txt_cours_desc.Text != "" && txt_cours_name.Text != "" && txt_cors_date.Text!="" && (rdb_open.Checked||rdb_close.Checked))
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
                    TBL_LECT_COURS cl = new TBL_LECT_COURS();
                    cl.LECT_COURS_NAME = txt_cours_name.Text;
                    cl.LECT_COURS_DESC = txt_cours_desc.Text;
                    if (rdb_open.Checked == true)
                    {
                        cl.LECT_COURS_STATE = true;
                    }
                    else
                    {
                        cl.LECT_COURS_STATE=false;
                    }
                    

                    string aa = string.Format("{0:dd-MM-yyyy}", txt_cors_date.Value);
                   cours_date = DateTime.ParseExact(aa, "dd-MM-yyyy", null);
                    cl.LECT_COURS_DATE = cours_date;
                    if (cours_id != 0)
                    {
                        //add 
                        cl.LECT_COURS_ID = Convert.ToInt32(cours_id);
                        con.TBL_LECT_COURS.AddOrUpdate(cl);
                        con.SaveChanges();
                        //toast.Width = this.Width;

                        NotifictionUser notifiction =new NotifictionUser("تم التعديل بنجاح",THAGBAN_INST.Properties.Resources.edit_32px);

                        notifiction.Show();
                        //MessageBox.Show("تم التعديل بنجاح ");
                    }
                    else
                    {
                        //update 
                        con.TBL_LECT_COURS.AddOrUpdate(cl);
                        con.SaveChanges();
                        // toast.Width = this.Width;
                        NotifictionUser notifiction = new NotifictionUser(THAGBAN_INST.Properties.Resources.AddNotificationText,THAGBAN_INST.Properties.Resources.add_32px);

                        notifiction.Show();
                       

                    }
                   
                    
                }
                catch (Exception ex)
                {
                   
                    MessageBox.Show(ex.Message+ex.InnerException.ToString());
                    //dialge.Width = this.Width;
                    //dialge.lbl_mess.Text=ex.Message;
                    //dialge.Show();
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
            if (cours_id != 0)
            {
                TBL_LECT_COURS tbl = con.TBL_LECT_COURS.Find(cours_id);
                if (tbl != null) {
                    txt_cours_desc.Text = tbl.LECT_COURS_DESC.ToString();
                    txt_cours_name.Text = tbl.LECT_COURS_NAME.ToString();
                    if (tbl.LECT_COURS_STATE == true)
                    {
                        rdb_open.Checked = true;
                    }
                    else
                    {
                        rdb_close.Checked = true;
                    }
                    txt_cors_date.Value = tbl.LECT_COURS_DATE.Value;
                   
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