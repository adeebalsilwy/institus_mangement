using DevExpress.Utils.Extensions;
using DevExpress.Utils.MVVM;
using DevExpress.XtraCharts.Native;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Design;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using THAGBAN_INST.DATA;
using THAGBAN_INST.FORM.FRM_EMP_MANEGER.job;
using THAGBAN_INST.FORM.FRM_EMP_MANEGER.lsits;

namespace THAGBAN_INST.FORM.FRM_LECTUER_MANG.students
{
    public partial class frm_add_students : DevExpress.XtraEditors.XtraForm
    {

        db_max_instEntities con = new db_max_instEntities();
        tost toast = new tost();
        dialge dialge = new dialge();
      
        public int stud_id = 0;
        public int spical_id = 0;


        public string stud_name;
        public string stud_lname;
        public string stud_phone;
        public string stud_address;
        public string stud_gender;
        public DateTime stud_date;
        public DateTime stud_spec_date;

        public frm_add_students()
        {
            InitializeComponent();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        

       


        void clear()
        {
            stud_id = 0;
            txt_stud_lname.Text = "";
            txt_stud_address.Text = "";
            txt_stud_date.Value = DateTime.Now;
            txt_stud_name.Text = "";
            txt_stud_phone.Text = "";
            txt_stud_lname.Text = "";




        }
        bool is_empty()
        {
            if (txt_stud_name.Text != "" && txt_stud_phone.Text != "" && txt_stud_lname.Text!=""  && txt_stud_address.Text != "" )
            {
                return false;
            }
            else
                return true;

        }

        void add_stud()
        {

            tost toast = new tost();
            dialge dialge = new dialge();
            if (is_empty() != true)
            {
                //cheak add or edit 
                try
                {
                    TBL_STUDENTS cl = new TBL_STUDENTS();
                    cl.STUD_STATE = true;
                    cl.STUD_ADDRESS = txt_stud_address.Text;
                    cl.STUD_NAME =txt_stud_name.Text ;
                    cl.STUD_PHONE = txt_stud_phone.Text;
                    cl.STUD_LNAME =txt_stud_lname.Text;
                    if (rdb_m.Checked == true)
                        cl.STUD_GENDER = rdb_m.Text;
                    else
                        cl.STUD_GENDER = rdb_fm.Text;
                     string aa = string.Format("{0:dd-MM-yyyy}", txt_stud_date.Value);
                    stud_date = DateTime.ParseExact(aa, "dd-MM-yyyy", null);
                    cl.STUD_DATE = stud_date.Date;
                 
                   
                    if (stud_id != 0)
                    {
                        //add 
                        cl.STUD_ID = Convert.ToInt32(stud_id);
                       // add_spec(stud_id);
                        con.TBL_STUDENTS.AddOrUpdate(cl);
                        con.SaveChanges();

                        adl.NotifictionUser notifiction = new adl.NotifictionUser(THAGBAN_INST.Properties.Resources.EditNotificationText, THAGBAN_INST.Properties.Resources.edit_32px);
                        notifiction.Show();
                        clear();
                        //MessageBox.Show("تم التعديل بنجاح ");
                    }
                    else
                    {
                        //update 
                        stud_id = cl.STUD_ID;
                        //add_spec(stud_id);
                        con.TBL_STUDENTS.AddOrUpdate(cl);
                        con.SaveChanges();
                        adl.NotifictionUser notifiction = new adl.NotifictionUser(THAGBAN_INST.Properties.Resources.AddNotificationText, THAGBAN_INST.Properties.Resources.add_32px);
                        notifiction.Show();
                        clear();

                    }
                }
                catch (Exception ex)
                {


                    dialge.Width = this.Width;
                    dialge.lbl_mess.Text ="تاكد من ادخال البيانات بالشكل الصحيح ";
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

      void add_spec(int id)
        {
            TBL_STUD_SPEC ch = con.TBL_STUD_SPEC.Where(w => w.STUD_ID == id && w.SPEC_ID == spical_id).FirstOrDefault();

            TBL_STUD_SPEC tbl = new TBL_STUD_SPEC();

           // MessageBox.Show(id + "   " + spical_id);
            tbl.SPEC_ID = spical_id;
            tbl.STUD_ID = id;
            string aa = string.Format("{0:dd-MM-yyyy}", txt_stud_spec_date.Value);
            stud_spec_date = DateTime.ParseExact(aa, "dd-MM-yyyy", null);
            tbl.STUD_SPEC_YEAR = stud_spec_date.Date;


            if (ch != null)
            {
                tbl.STUD_SPEC_ID = ch.STUD_SPEC_ID;
            }
            con.TBL_STUD_SPEC.AddOrUpdate(tbl);
            con.SaveChanges();

        }
        public void get_data()
        {

            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            db_max_instEntities dbContext = new db_max_instEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.TBL_SPECIAL.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                com_spiacl.DataSource = dbContext.TBL_SPECIAL.Local.ToBindingList();
                com_spiacl.DisplayMember = "SPEC_NAME";
                com_spiacl.ValueMember = "SPEC_ID";
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }
        private void frm_add_emp_Load(object sender, EventArgs e)
        {
            get_add();



            if (stud_id != 0)
            {
                TBL_STUDENTS tbl=con.TBL_STUDENTS.Find(stud_id);
                if (tbl != null) {
                    txt_stud_address.Text = tbl.STUD_ADDRESS;
                    txt_stud_date.Value = tbl.STUD_DATE;
                    txt_stud_name.Text = tbl.STUD_NAME;
                    txt_stud_phone.Text = tbl.STUD_PHONE;
                    txt_stud_lname.Text = tbl.STUD_LNAME;
                if (tbl.STUD_GENDER == "ذكر")
                        rdb_m.Checked = true;
                    else
                        rdb_fm.Checked = true;
                    com_spiacl.DataSource = con.TBL_SPECIAL.ToList();
                    com_spiacl.DisplayMember = "SPEC_NAME";
                    com_spiacl.ValueMember = "SPEC_ID";
                    com_spiacl.SelectedValue = spical_id;
                }

            }
            else
            {
                get_data();
            }

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            clear();
          

        }

       

       

      
       
    private void btn_save_Click(object sender, EventArgs e)
        {
           
           add_stud();
        }
        void get_add()
        {
            TBL_STUDENTS tbl = new TBL_STUDENTS();
            AutoCompleteStringCollection ac = new AutoCompleteStringCollection();
            con.TBL_STUDENTS.ForEach(s=>ac.Add(s.STUD_ADDRESS));
           


            txt_stud_address.AutoCompleteCustomSource = ac;

        }

        private void txt_stud_address_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_stud_address_TextChanged_1(object sender, EventArgs e)
        {

        }

       

        private void com_spiacl_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (com_spiacl.SelectedValue != null)
            {
                spical_id=Convert.ToInt32(com_spiacl.SelectedValue.ToString());
            }
        }

        private void txt_stud_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
           
        }

        private void btn_save_KeyDown(object sender, KeyEventArgs e)
        {
            add_stud();
        }
    }
}