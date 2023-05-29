using DevExpress.XtraEditors;
using DevExpress.XtraScheduler.Native;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using THAGBAN_INST.DATA;

namespace THAGBAN_INST.FORM.FRM_LECTUER_MANG.lect_students
{
    public partial class frm_add_lect_stud : DevExpress.XtraEditors.XtraForm
    {

        db_max_instEntities con = new db_max_instEntities();
        tost toast = new tost();
        dialge dialge = new dialge();
        public int stud_lect_id=0;
        public int temp_stud_id = 0;
        int tech_lect_id = 0;
        int temp_tech_lect_id = 0;
        public string matrial_name;
        public int cours_id;
        public int lect_id;
        public int stud_id;
        public int temp_cours_id;
        public int temp_lect_id;
        DateTime stud_date;


        public frm_add_lect_stud()
        {
            InitializeComponent();
        }

        
        private void btn_delete_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_add_job_Load(object sender, EventArgs e)
        {
           
            if (stud_lect_id != 0)
            {
               TBL_STUD_LECT tbl= con.TBL_STUD_LECT.Find(stud_lect_id);
                temp_stud_id = Convert.ToInt32(tbl.STUD_ID);
                temp_cours_id =Convert.ToInt32(tbl.COURS_ID);
              temp_lect_id= Convert.ToInt32(tbl.LECT_ID);
                temp_tech_lect_id = Convert.ToInt32(tbl.LECT_TECH_ID);
                txt_lect_stud_date.Value = tbl.LECT_STUD_DATE.Value;
                //   com_term_year.Text = con.TBL_TERMS.Find(tech_id).SPEC_YEAR.ToString();
                get_data();
            }
            else
            {
                get_data();
            }
           
        }
     
        public void get_data()
        {

            get_stud();
            com_com_cours.DataSource=con.TBL_LECT_COURS.ToList();
            com_com_cours.DisplayMember = "LECT_COURS_NAME";
            com_com_cours.ValueMember= "LECT_COURS_ID";
            if (stud_lect_id != 0)
                com_com_cours.SelectedValue = temp_cours_id;
            
        }
        void clear()
        {

            lect_id =0;
            stud_lect_id = 0;
            com_lect.Text = "";
            com_stud.Text = "";
            com_com_cours.Text = "";


        }
        bool is_empty()
        {
            if (com_lect.Text != "" &&com_group.Text!="" &&  com_stud.Text != "" && com_com_cours.Text != "")
            {
                return false;
            }
            else
                return true;

        }

        void add_send()
        {
           

        }
        void add_stud_lect()
        {

           
            if (is_empty() != true)
            {
                //cheak add or edit 
                try
                {
                    TBL_STUD_LECT cl = new TBL_STUD_LECT();
                   // cl.LECT_ID = com_stud.Text;

                    cl.LECT_TECH_ID =Convert.ToInt32(com_group.SelectedValue);
                    //lect_id=

                    //TBL_LECT_TECH_COURS tbl=con.TBL_LECT_TECH_COURS.Find(lect_id);
                    cl.LECT_ID = Convert.ToInt32(com_lect.SelectedValue); ;
                    cl.COURS_ID = Convert.ToInt32(com_com_cours.SelectedValue);
                    cl.STUD_ID = Convert.ToInt32(com_stud.SelectedValue);
                    string aa = string.Format("{0:dd-MM-yyyy}", txt_lect_stud_date.Value);
                    stud_date = DateTime.ParseExact(aa, "dd-MM-yyyy", null);
                    cl.LECT_STUD_DATE = stud_date;

                    if (stud_lect_id != 0)
                    {
                        //add 
                        cl.LECT_STUD_ID = Convert.ToInt32(stud_lect_id);
                        con.TBL_STUD_LECT.AddOrUpdate(cl);
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
                        con.TBL_STUD_LECT.AddOrUpdate(cl);

                        TBL_SEND_STUD_LECT sns = new TBL_SEND_STUD_LECT();

                        sns.STUD_ID = Convert.ToInt32(com_stud.SelectedValue);

                        // cl.TECH_LECT_ID = Convert.ToInt32(com_group.SelectedValue);


                        sns.STUD_LECT_ID =cl.LECT_STUD_ID;
                       
                        sns.TECH_LECT_ID = Convert.ToInt32(com_group.SelectedValue);
                        int lec_id = Convert.ToInt32(cl.LECT_ID);
                        sns.LECT_ID = Convert.ToInt32(lec_id);
                        sns.PAID_UP = 0;
                        sns.REST = con.TBL_LECTUER.Find(lec_id).LECT_PRICE;
                        sns.INST_ID = THAGBAN_INST.Properties.Settings.Default.inst_id;
                        sns.SEND_STUD_DATE = DateTime.Now;
                        con.TBL_SEND_STUD_LECT.Add(sns);
                        con.SaveChanges();
                        add_send();
                        adl.NotifictionUser notifiction = new adl.NotifictionUser(THAGBAN_INST.Properties.Resources.AddNotificationText, THAGBAN_INST.Properties.Resources.add_32px);
                        notifiction.Show();

                        clear();
                    }
                }
                catch (Exception ex)
                {

                    //dialge.Width = this.Width;
                    dialge.lbl_mess.Text ="لايمكن اضافه الطالب " +
                        "لنفس الكورس  ولنفس الدوره ";
                    dialge.Show();
                }
              
            }
            else
            {
                dialge.Width = this.Width;
                dialge.lbl_mess.Text = "الرجاء ادخال جميع البيانات ";
                dialge.Show();



            }


        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            add_stud_lect();
        }

        private void com_spiacl_SelectionChangeCommitted(object sender, EventArgs e)
        {

            if (com_com_cours.SelectedValue != null)
            {
                try
                {
                    cours_id = Convert.ToInt32(com_com_cours.SelectedValue.ToString());
                    get_lect();
                    get_group();
                }catch(Exception ex) { }



            }
        }
        void get_stud()
        {
            com_stud.DataSource = con.TBL_STUDENTS.ToList();
            com_stud.DisplayMember = "STUD_NAME";
            com_stud.ValueMember = "STUD_ID";
            if (stud_lect_id != 0)
            {
                com_stud.SelectedValue = temp_stud_id;
            }
        }
        void get_lect()
        {
            var tbl = con.TBL_LECT_TECH_COURS.Where(w => w.COURS_ID == cours_id && w.STATE == true)
                .Join(con.TBL_LECTUER, l => l.TBL_LECTUER.LECT_ID, tl => tl.LECT_ID,
                (l, tl) => new
                {

                    l.LECT_ID,

                    tl.LECT_NAME,

                }).Distinct();
                
               
            if (tbl != null)
            {
                com_lect.DataSource = tbl.ToList();
                com_lect.DisplayMember = "LECT_NAME";
                com_lect.ValueMember = "LECT_ID";
               

                if (stud_lect_id != 0)
                {
                    com_lect.SelectedValue = temp_lect_id;
                }
            }
            else
            {
                com_lect.DataSource = null;
                com_lect.Items.Clear();
                com_lect.Text = "";
            }
        }
        void get_group()
        {
            

           lect_id =Convert.ToInt32(com_lect.SelectedValue);
                var temp= con.TBL_LECT_TECH_COURS.Where(w=>w.LECT_ID==lect_id).ToList();
            if (temp != null)
            {
                com_group.DataSource = temp;
                com_group.DisplayMember = "GROUP_NAME";
                com_group.ValueMember = "TECH_LECT_ID";

                if (stud_lect_id != 0)
                {
                    com_group.SelectedValue =temp_tech_lect_id;
                }
            }
            else
            {
                com_group.DataSource = null;
                com_group.Items.Clear();
                com_group.Text = "";
            }
            
            
        }
        private void com_term_year_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (com_lect.SelectedValue != null)
            {
                try
                {

                    lect_id = Convert.ToInt32(com_lect.SelectedValue);
                    get_group();
                }catch(Exception ex)
                {

                }
            }
        }

        private void com_stud_SelectionChangeCommitted(object sender, EventArgs e)
        {

            try
            {
                //  List<TBL_STUD_SPEC> tbl = new List<TBL_STUD_SPEC>();
                stud_id = Convert.ToInt32(com_stud.SelectedValue.ToString());
                // tbl = con.TBL_STUD_SPEC.Where(w=>w.STUD_ID==stud_id).ToList();

            }
            catch (Exception ex)
            {

            }

            //var temp1 = con.TBL_SPECIAL.Join(con.TBL_STUD_SPEC.Where(w => w.STUD_ID == stud_id ), sp => sp.SPEC_ID, stud_spe => stud_spe.TBL_SPECIAL.SPEC_ID, (spiec, stud_spic) => new
            //{
            //    spiec.SPEC_NAME,
            //    spiec.SPEC_ID,

            //}).ToList();
            //if (temp1.Count > 0 )
            //{
            //    com_lect.DataSource = temp1;
            //    com_lect.DisplayMember = "SPEC_NAME";
            //    com_lect.ValueMember = "SPEC_ID";
            //    if (id != 0)
            //    {


            //        com_lect.SelectedValue = spaicla_id;
            //    }

            //}
            //else
            //{
            //    com_lect.Items.Clear();
            //}

            //    var temp = con.TBL_COURS.Join(con.TBL_SPE_COURS.Where(w => w.SPEC_ID == spaicla_id),
            //        c => c.COURS_ID,
            //        sp => sp.TBL_COURS.COURS_ID,
            //        (cours, cours_sp) =>
            //         new
            //         {
            //             cours.COURS_ID,
            //             cours.COURS_NAME,

            //         }).ToList();
            //    if (temp.Count > 0)
            //    {
            //        com_group.DataSource = temp.ToList();
            //        com_group.DisplayMember = "COURS_NAME";
            //        com_group.ValueMember = "COURS_ID";
            //        if (id != 0)
            //            com_group.SelectedValue = stud_lect_id;
            //    }
            //    else
            //    {
            //        dialge d = new dialge();
            //        com_group.Items.Clear();
            //        d.lbl_mess.Text = "ولايوجد مواد للتخصص المحدد";

            //        d.Show();

            //    }
            //    com_cours.SelectedValue = stud_lect_id;



        }

        private void com_lect_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (com_lect.SelectedValue != null)
            {
                try
                {

                    lect_id = Convert.ToInt32(com_lect.SelectedValue);
                    get_group();
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void com_group_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}