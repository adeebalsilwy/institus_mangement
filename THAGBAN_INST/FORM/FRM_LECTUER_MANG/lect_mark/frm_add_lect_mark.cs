using DevExpress.PivotGrid.OLAP.AdoWrappers;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using THAGBAN_INST.adl;
using THAGBAN_INST.DATA;

namespace THAGBAN_INST.FORM.FRM_LECTUER_MANG.lect_mark
{
    public partial class frm_add_lect_mark : DevExpress.XtraEditors.XtraForm
    {

        db_max_instEntities con = new db_max_instEntities();
        tost toast = new tost();
        dialge dialge = new dialge();
        adl.method methods  = new adl.method();
        public int id=0;
        public int stud_id = 0;
        public int stud_lect_id = 0;
        public int lect_id = 0;
        public int temp_stud_lect_id = 0;
        public int temp_lect_id = 0;
        public int temp_tech_lect_id = 0;
        int matrial_id;
        int temp_matrail_id;
        int temp_stud_id;
        int tech_lect_id;




        public frm_add_lect_mark()
        {
            InitializeComponent();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_add_job_Load(object sender, EventArgs e)
        {
           
            if (id != 0)
            {
               TBL_LECT_MARK tbl= con.TBL_LECT_MARK.Find(id);
                // txt_cours_name.Text = tbl.COURS_NAME.ToString();

                temp_stud_id = Convert.ToInt32(tbl.STUD_ID);
                //spaicla_id= Convert.ToInt32(tbl.STUD_ID);
               // txt_mark_date.Text=tbl.MARK_YEAR.ToString();
                txt_mark_value.Text=tbl.MARK_VALUE.ToString();
                temp_stud_lect_id = Convert.ToInt32(tbl.LECT_STUD_ID);
                temp_tech_lect_id = Convert.ToInt32(tbl.LECT_TECH_ID);
                temp_matrail_id= Convert.ToInt32(tbl.MATRIAL_ID);
                get_data();

            }
            else
            {
                get_data();
            }
           
        }
        public void get_data()
        {

            
                com_stud.DataSource =con.TBL_STUDENTS.ToList();
                com_stud.DisplayMember = "STUD_NAME";
                com_stud.ValueMember = "STUD_ID";
  
           if(id!= 0)
            {
                com_stud.SelectedValue = temp_stud_id;
            }
        }
        void clear()
        {
            id = 0;
            com_group.Text = "";
            com_lect.Text = "";
           // com_term.Text="";
            com_matrial.Text = "";
            stud_lect_id = 0;
            stud_id = 0;
            txt_mark_value.Text = "";



        }
        bool is_empty()
        {
            if ( com_group.Text != "" &&com_matrial.Text!=""&&com_stud.Text!="" && com_lect.Text != "" && txt_mark_value.Text!="")
            {
                try
                {
                    int mark =Convert.ToInt32(txt_mark_value.Text);
                    if(mark <0 || mark>100) {
                        return true;
                    }
                    
                   
                }
                catch(Exception)
                { 
                    return true; 
                }
                return false;

            }
            else
                return true;

        }
      
        
        void add_marks()
        {

            tost toast = new tost();
            dialge dialge = new dialge();
            if (is_empty() != true)
            {
                //cheak add or edit 
                try
                {
                    TBL_LECT_MARK cl = new TBL_LECT_MARK();
                    cl.COURS_ID = stud_lect_id ;
                   // cl.SPEC_ID = spaicla_id;
                    cl.STUD_ID = Convert.ToInt32(com_stud.SelectedValue) ;
                    cl.MARK_VALUE=Convert.ToInt32(txt_mark_value.Text);
                    cl.MATRIAL_ID = Convert.ToInt32(com_matrial.SelectedValue);
                    cl.LECT_STUD_ID = Convert.ToInt32(com_lect.SelectedValue);
                    cl.LECT_ID = con.TBL_STUD_LECT.Find(cl.LECT_STUD_ID).LECT_ID;
                    cl.COURS_ID = con.TBL_LECTUER.Find(cl.LECT_ID).LECT_COURS_ID;
                    cl.LECT_TECH_ID = Convert.ToInt32(com_group.SelectedValue);


                    if (id != 0)
                    {
                        //add 
                        cl.MARK_ID = Convert.ToInt32(id);
                        con.TBL_LECT_MARK.AddOrUpdate(cl);
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
                        con.TBL_LECT_MARK.AddOrUpdate(cl);
                        con.SaveChanges();
                        // toast.Width = this.Width;
                        adl.NotifictionUser notifiction = new adl.NotifictionUser(THAGBAN_INST.Properties.Resources.AddNotificationText, THAGBAN_INST.Properties.Resources.add_32px);
                        notifiction.Show();

                        clear();

                    }
                }
                catch (Exception ex)
                {

                  //  dialge.Width = this.Width;
                    dialge.lbl_mess.Text ="قد تم اضافه الدرجه للطالب ولنفس الماده";
                    dialge.Show();
                }
                clear();
            }
            else
            {
              //  dialge.Width = this.Width;
                dialge.lbl_mess.Text = "الرجاء ادخال جميع البيانات ";
                dialge.Show();



            }


        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            add_marks();
        }

        private void com_spiacl_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if(com_lect.SelectedValue!= null)
            {
                try
                {

                    stud_lect_id = Convert.ToInt32(com_lect.SelectedValue.ToString());
                    get_group();
                   // get_matrial();
                }
                catch(Exception ex)
                {
                    com_matrial.DataSource=null;
                    com_group.DataSource=null;
                    com_group.Text = "";
                    com_matrial.Text = "";
                }

            }
           
        }

        private void com_year_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (com_matrial.SelectedValue != null)
            {
                try { 
                //{
                //     lect_id = Convert.ToInt32(com_matrail.SelectedValue.ToString());
                //    var data= con.TBL_TERMS.Where(w => w.YEAR_ID == lect_id && w.SPEC_ID == spaicla_id).ToList();
                //    if (data.Count > 0)
                //    {
                //        com_term.DataSource = data.ToList();
                //        com_term.DisplayMember = "TERM_NAME";
                //        com_term.ValueMember = "TERM_ID";
                //        if (groupBox1.Enabled == true)
                //        {
                //            get_cours();
                //        }

                //    }
                //    else
                //    {
                //        dialge d = new dialge();
                //        com_term.Items.Clear();
                //        com_group.DataSource = null;
                //        com_group.Items.Clear();
                //        d.lbl_mess.Text = "ولايوجد مواد للسنه المحدده" +
                //            "لم يتم اضافه اترام لهذا التخصص";
                //        d.Show();
                //    }
                }catch(Exception ex) { }

            }
         
        }

        private void ch_year_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        
        private void com_stud_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (com_stud.SelectedValue != null)
            {
                get_lect();
               // get_group();
               // get_matrial();
            }
            
        }
       void get_lect()
        {
            try
            {

                if (com_stud.SelectedValue != null)
                {
                   stud_id = Convert.ToInt32(com_stud.SelectedValue.ToString());
                    lbl_l_name.Text = con.TBL_STUDENTS.Find(stud_id).STUD_LNAME.ToString();


                    //var temp1 = con.TBL_STUD_LECT.
                    //      Where(w => w.STUD_ID == stud_id).Join(con.TBL_LECTUER,
                    //      s => s.TBL_LECTUER.LECT_ID,
                    //      a => a.LECT_ID, (stud, cours) => new
                    //      {
                    //          stud.LECT_STUD_ID,
                    //          stud.TBL_LECTUER.LECT_NAME,

                    //      }).Distinct().ToList();

                    //var temp1 = con.TBL_STUD_LECT.
                    //      Where(w => w.STUD_ID == stud_id).Join(con.TBL_LECT_TECH_COURS.Where(w => w.STATE == true),
                    //      s => s.TBL_LECT_TECH_COURS.LECT_ID,
                    //      a => a.LECT_ID, (stud, cours) => new
                    //      {
                    //          stud.LECT_STUD_ID,
                    //          stud.TBL_LECTUER.LECT_NAME,

                    //      }).Distinct().ToList();
                    //  var temp = con.TBL_STUD_LECT.Find(stud_id);

                    var temp1 = (from sl in con.TBL_STUD_LECT.Where(w => w.STUD_ID == stud_id)
                                 join
                                tl in con.TBL_LECT_TECH_COURS.Where(w => w.STATE == true) on
                                sl.LECT_TECH_ID equals tl.TECH_LECT_ID
                                 join l in con.TBL_LECTUER on
                                 tl.LECT_ID equals l.LECT_ID
                                 select new
                                 {
                                     sl.LECT_STUD_ID,
                                     l.LECT_NAME
                                 }).Distinct().ToList();
                    if (temp1.Count > 0)
                    {
                        com_lect.DataSource = temp1.ToList();
                        com_lect.DisplayMember = "LECT_NAME";
                        com_lect.ValueMember = "LECT_STUD_ID";
                        if (id != 0)
                        {
                           com_lect.SelectedValue = temp_stud_lect_id;
                        }
                    }
                    else
                    {
                        com_lect.Items.Clear();
                        com_lect.Text = "";
                        com_lect.DataSource = null;
                        com_lect.SelectedValue = null;
                    }
                }


            }
            catch (Exception ex) {
               
                com_lect.Text = "";
                com_lect.DataSource = null;
                com_lect.SelectedValue = null;
            }
        }
        void get_group()
        {
            try
            {

                var temp = con.TBL_STUD_LECT.Where(w => w.LECT_STUD_ID == stud_lect_id).Join(
                          con.TBL_LECT_TECH_COURS, tl => tl.TBL_LECT_TECH_COURS.TECH_LECT_ID,
                          sl => sl.TECH_LECT_ID, (tl, sl) => new
                          {
                              sl.GROUP_NAME,
                              sl.TECH_LECT_ID,
                          }
                          )
                          .ToList();
                if (temp.Count>0)
                {
                    com_group.DataSource = temp;
                    com_group.DisplayMember = "GROUP_NAME";
                    com_group.ValueMember = "TECH_LECT_ID";

                    if (id == 0)
                    {
                        com_group.SelectedValue = temp_tech_lect_id;
                    }
                }
                else
                {
                    com_group.DataSource = null;
                    com_group.Text = "";
                    com_group.Items.Clear();
                }
            }catch(Exception ex)
            {
                com_group.DataSource = null;
                com_group.Text = "";
            }
        }
        private void com_term_SelectionChangeCommitted(object sender, EventArgs e)
        {

          

        }

        void get_cours()
        {
            //var data = con.TBL_COURS
            //           .Join(con.TBL_SPE_COURS.Where(w => w.SPEC_ID == spaicla_id && w.TERM_ID == term_id
            //           && w.YEAR_ID == lect_id),
            //           c => c.COURS_ID,
            //           spc => spc.TBL_COURS.COURS_ID, (cours, sp_cours) => new
            //           {
            //               cours.COURS_ID,
            //               cours.COURS_NAME,
            //           }).ToList();

            //if (data.Count > 0)
            //{
            //    com_group.DataSource = data.ToList();
            //    com_group.DisplayMember = "COURS_NAME";
            //    com_group.ValueMember = "COURS_ID";
                
            //    com_group.SelectedValue = stud_lect_id;
            //}
            //else
            //{
            //    com_group.DataSource = null;
            //    com_group.Items.Clear();
            //    dialge d = new dialge();

            //    d.lbl_mess.Text = "ولايوجد مواد للترم المحدد";

            //    d.Show();

            //}
        }
        private void com_term_SelectedValueChanged(object sender, EventArgs e)
        {
            //if (com_term.SelectedValue != null)
            //{
            //    try {
            //        term_id = Convert.ToInt32(com_term.SelectedValue.ToString());
            //        if (groupBox1.Enabled == true)
            //        {
            //            get_cours();
            //        }

            //    }
            //    catch(Exception ex) { }
            //    }
        }

        private void com_term_DataSourceChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    if(groupBox1.Enabled==true)
            //    {
            //        get_cours();
            //    }
              

            //}catch(Exception ex) { }
        }

        private void com_cours_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (com_group.SelectedValue != null)
            {
                try
                {
                     tech_lect_id = Convert.ToInt32(com_group.SelectedValue.ToString());
                    get_matrial();
                }
                catch (Exception ex) { }
            }

        }

        void get_matrial()
        {
            try
            {

                stud_lect_id = Convert.ToInt32(com_lect.SelectedValue.ToString());
                tech_lect_id = Convert.ToInt32(com_group.SelectedValue.ToString());
                var temp = (from sl in con.TBL_STUD_LECT.Where(w => w.LECT_STUD_ID == stud_lect_id)
                            join tl in con.TBL_LECT_TECH_COURS.Where(w => w.TECH_LECT_ID == tech_lect_id)
                            on sl.LECT_TECH_ID equals tl.TECH_LECT_ID
                            join l in con.TBL_LECTUER on sl.LECT_ID equals l.LECT_ID
                            join mat in con.TBL_LECT_MATRIAL on l.LECT_ID
                            equals mat.LECT_ID
                            select new
                            {
                                mat.MATRIAL_LECT_NAME,
                                mat.MATRIAL_LECT_ID,
                            }).ToList();
                if (temp.Count > 0)
                {
                    com_matrial.DataSource = temp;
                    com_matrial.DisplayMember = "MATRIAL_LECT_NAME";
                    com_matrial.ValueMember = "MATRIAL_LECT_ID";
                    if (id != 0)
                    {
                        com_matrial.SelectedValue = temp_matrail_id;
                    }
                }
                else
                {
                    com_matrial.DataSource = null;
                    com_matrial.Items.Clear();
                    com_matrial.Text = "";
                }
            }catch(Exception ex)
            {
                com_matrial.DataSource = null;
               // com_matrial.Items.Clear();
                com_matrial.Text = "";
            }
                
        }
        private void txt_mark_value_TextChanged(object sender, EventArgs e)
        {

        }

        private void com_matrial_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void com_stud_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}