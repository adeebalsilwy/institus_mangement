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
using System.Configuration;
using System.IO;
using THAGBAN_INST.DATA;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.Utils.About;
using static DevExpress.XtraEditors.Mask.MaskSettings;

namespace THAGBAN_INST.FORM
{
    public partial class frm_setting : DevExpress.XtraEditors.XtraForm
    {
        string connect_str = "";
        string server_name = @".\sqlexpress";
        adl.method methods = new adl.method();
        public int inst_id = 0;
        public string inst_name;
        public string inst_location;
        public string inst_desc;
        db_max_instEntities con = new db_max_instEntities();
        TBL_INST inst = new TBL_INST();
        TBL_USERS users;
       public int emp_id = 0;
        int user_id = 0;
        public frm_setting()
        {
            InitializeComponent();
            get_server_info();
        }

        public void get_emp()
        {




            com_emp.DataSource = con.TBL_EMPLOYEES.Where(w => w.STATE == true).ToList();
            com_emp.DisplayMember = "EMP_NAME";
            com_emp.ValueMember = "EMP_ID";
            if (emp_id != 0)
            {
                com_emp.SelectedValue = emp_id;
            }
        }

        private void accordionControl1_Click(object sender, EventArgs e)
        {

        }
        void sav_server()
        {
            string temp_connt = "";
            var server_name = txt_server.Text;
            var database=txt_database_name.Text;
            var porst = txt_port.Text;
            var user_server=txt_server_user_name.Text;
            var pass_user_server=txt_user_server_pass.Text;
            const string qu = "\"";
            if (rdb_local.Checked)
            {
                var conf = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                temp_connt = conf.ConnectionStrings.ConnectionStrings["db_max_instEntities"].ConnectionString.ToString();
                var connect_strring = @"metadata=res://*/DATA.Model1.csdl|res://*/DATA.Model1.ssdl|res://*/DATA.Model1.msl;provider=System.Data.SqlClient;provider connection string=" + qu + ";data source=" + server_name + ";initial catalog=db_max_inst;integrated security=True;multipleactiveresultsets=True;application name=EntityFramework" + qu + ";";
                conf.ConnectionStrings.ConnectionStrings["db_max_instEntities"].ConnectionString = connect_strring;
                conf.Save();
                ConfigurationManager.RefreshSection("connectionString");
                var str = conf.ConnectionStrings.ConnectionStrings["db_max_instEntities"].ConnectionString;
                MessageBox.Show(str);
                THAGBAN_INST.Properties.Settings.Default.server_name = server_name;
                THAGBAN_INST.Properties.Settings.Default.port = porst;
                THAGBAN_INST.Properties.Settings.Default.database_name = database;
                THAGBAN_INST.Properties.Settings.Default.user_server_id = user_server;
                THAGBAN_INST.Properties.Settings.Default.user_server_pass = pass_user_server;
                THAGBAN_INST.Properties.Settings.Default.Save();


            }
            else
            {
                var conf = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                temp_connt = conf.ConnectionStrings.ConnectionStrings["db_max_instEntities"].ConnectionString.ToString();
                var connect_strring = @"metadata=res://*/DATA.Model1.csdl|res://*/DATA.Model1.ssdl|res://*/DATA.Model1.msl;provider=System.Data.SqlClient;provider connection string=';data source="+server_name+","+porst+";initial catalog="+database+ ";User ID="+ user_server + ";Password="+pass_user_server+"; connect Timeout=60;multipleactiveresultsets=True;application name=EntityFramework';";
                conf.ConnectionStrings.ConnectionStrings["db_max_instEntities"].ConnectionString = connect_strring;
                conf.Save();
                ConfigurationManager.RefreshSection("connectionString");
                var str = conf.ConnectionStrings.ConnectionStrings["db_max_instEntities"].ConnectionString;
                MessageBox.Show(str);
                THAGBAN_INST.Properties.Settings.Default.server_name = server_name;
                THAGBAN_INST.Properties.Settings.Default.port = porst;
                THAGBAN_INST.Properties.Settings.Default.database_name = database;
                THAGBAN_INST.Properties.Settings.Default.user_server_id = user_server;
                THAGBAN_INST.Properties.Settings.Default.user_server_pass = pass_user_server;
                THAGBAN_INST.Properties.Settings.Default.Save();
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)

        {

            sav_server(); 
            
        }


        private void btn_save_inst_Click(object sender, EventArgs e)
        {

            if (txt_inst_name.Text != "" && txt_inst_location.Text != "" && txt_inst_desc.Text != "")
            {
                try
                {
                    adl.method methods = new adl.method();
                    TBL_INST inst= new TBL_INST();
                    pic_logo.Image.Save(methods.ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    inst.INST_LOCATION = txt_inst_location.Text;
                    inst.INST_LOGO = methods.convert_byte();
                    inst.INST_DESC = txt_inst_desc.Text;
                    inst.INST_NAME = txt_inst_name.Text;
                    inst.INST_TOTAL = txt_totoal_inst.Text;
                    inst.INST_ADMIN = txt_inst_admin.Text;
                    if (inst_id == 0)
                    {

                        con.TBL_INST.Add(inst);
                        con.SaveChanges();
                        adl.NotifictionUser notifiction = new adl.NotifictionUser(THAGBAN_INST.Properties.Resources.AddNotificationText, THAGBAN_INST.Properties.Resources.add_32px);
                        notifiction.Show();
                        get_data();

                    }
                    else
                    {
                        inst.INST_ID = inst_id;
                        con.TBL_INST.AddOrUpdate(inst);
                        con.SaveChanges();
                        adl.NotifictionUser notifiction = new adl.NotifictionUser(THAGBAN_INST.Properties.Resources.EditNotificationText, THAGBAN_INST.Properties.Resources.edit_32px);
                        notifiction.Show();
                        get_data();

                    }
                }
                catch (Exception ex)
                {

                }
            }
        }
        public List<TBL_INST> list;
        private string porst;
        private string database;
        private string user_server;
        private string pass_user_server;

        void get_data()

        {
            TBL_INST obj_inst = new TBL_INST();

            db_max_instEntities con = new db_max_instEntities();
            //con.TBL_INST.LoadAsync().ContinueWith(loadTask =>
            //{
            //    list = con.TBL_INST.ToList();
            //}, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
            try
            {
                list = con.TBL_INST.ToList();
                if (list != null && list.Count > 0)
                {
                    txt_inst_desc.Text = list.FirstOrDefault().INST_DESC.ToString();
                    txt_inst_location.Text = list.FirstOrDefault().INST_LOCATION.ToString();
                    txt_inst_name.Text = list.FirstOrDefault().INST_NAME.ToString();
                    inst_id = list.FirstOrDefault().INST_ID;
                    methods.data = list.FirstOrDefault().INST_LOGO;
                    txt_totoal_inst.Text= list.FirstOrDefault().INST_TOTAL;
                    txt_inst_admin.Text= list.FirstOrDefault().INST_ADMIN;
                    if (methods.data != null)
                        pic_logo.Image = Image.FromStream(methods.convert_image());

                }
                else
                {
                    txt_totoal_inst.Text =0+"";
                }
            }catch(Exception ex)
            {

            }
        }
        private void frm_setting_Load(object sender, EventArgs e)
        {

            try
            {
                get_data();
                get_emp();
                comb_primarycur.Text = THAGBAN_INST.Properties.Settings.Default.courncy;
            }catch(Exception ex)
            {

            }

        }
        void get_server_info()
        {
            string server_name;
            server_name= THAGBAN_INST.Properties.Settings.Default.server_name ;
            porst= THAGBAN_INST.Properties.Settings.Default.port ;
            database= THAGBAN_INST.Properties.Settings.Default.database_name ;
            user_server= THAGBAN_INST.Properties.Settings.Default.user_server_id ;
            pass_user_server= THAGBAN_INST.Properties.Settings.Default.user_server_pass ;
            if (server_name != "")
            {
                txt_server.Text = server_name;
            }
            if (porst != "")
            {
                txt_port.Text=porst;
            }
            if (user_server != "")
            {
                txt_server_user_name.Text = user_server;
            }
            if (database != "")
            {
                txt_database_name.Text = database;
            }
            if (pass_user_server != "")
            {
                txt_user_server_pass.Text = pass_user_server;
            }
        }

        private void btn_groups_Click(object sender, EventArgs e)
        {
            navigationFrame1.SelectedPage = nav_page_server;
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            navigationFrame1.SelectedPage = nav_page_home;
        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {
            navigationFrame1.SelectedPage = navigationPage4;
        }

        private void btn_categories_Click(object sender, EventArgs e)
        {
            navigationFrame1.SelectedPage = nav_page_rouls;
        }

        private void btn_backup_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog folder = new FolderBrowserDialog();
                var rs = folder.ShowDialog();
                if (rs == DialogResult.OK)
                {
                    db_max_instEntities db = new db_max_instEntities();
                    string dbname = db.Database.Connection.Database;
                    string dbBackUp = "db_max_inst" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm");
                    var fullpath = folder.SelectedPath.ToString() + dbBackUp + ".bak";
                    string sqlCommand = @"BACKUP DATABASE [{0}] TO  DISK = '" + fullpath + "' WITH NOFORMAT, NOINIT,  NAME = N'"+ dbname + "', SKIP, NOREWIND, NOUNLOAD,  STATS = 10";
                    int path = db.Database.ExecuteSqlCommand(System.Data.Entity.TransactionalBehavior.DoNotEnsureTransaction, string.Format(sqlCommand, dbname, dbBackUp));
                    MessageBox.Show("تم النسخ الاحتياطي بنجاح");
                }
            }
            catch
            {
                MessageBox.Show("خطأ , لا يمكن النسخ الاحتياطي الى المسار المحدد, الرجاء تحديد مسار مختلف, تذكر لا تحدد القرص C");
            }

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {




            try
            {
                OpenFileDialog folder = new OpenFileDialog();
                var rs = folder.ShowDialog();
                if (rs == DialogResult.OK)
                {
                    db_max_instEntities db = new db_max_instEntities();

                    string dbname = db.Database.Connection.Database;
                    string dbBackUp = "db_max_inst" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm");
                   // MessageBox.Show(folder.FileName);
                    string sqlCommand = @"Use master;Restore DATABASE [{0}] From  DISK = '" + folder.FileName + "'";
                    int path = db.Database.ExecuteSqlCommand(System.Data.Entity.TransactionalBehavior.DoNotEnsureTransaction, string.Format(sqlCommand, dbname));
                    MessageBox.Show("تم استعادة النسخة الاحتياطية بنجاح");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("لا يمكن استعادة النسخة الاحتياطية, يرجى التأكد من الملف المختار" + ex.Message.ToString());
            }
        }

        private void pic_logo_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void navigationPage1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rdb_inter_CheckedChanged(object sender, EventArgs e)
        {

            if (rdb_inter.Checked)
            {
                group_server.Enabled = true;
                txt_server_user_name.Enabled = true;
                txt_user_server_pass.Enabled = true;
                txt_port.Enabled = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            THAGBAN_INST.Properties.Settings.Default.courncy = comb_primarycur.SelectedItem.ToString();
            THAGBAN_INST.Properties.Settings.Default.Save();
        }

        private void navigationPage3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ch_cat_CheckedChanged(object sender, EventArgs e)
        {

        }

        void cheack_rouls(int user)
        {
            var rouls = con.TBL_ROULLS_LECTUER.Where(w => w.USER_ID == user).FirstOrDefault();
            if (rouls != null)
            {
                if (rouls.ch_tech_lec == true)
                    ch_tech_lec.Checked = true;
                else
                    ch_tech_lec.Checked = false;
                if (rouls.ch_send_tech == true)
                    ch_send_tech.Checked = true;
                else
                    ch_send_tech.Checked = false;
                if (rouls.ch_send_stud == true)
                    ch_send_stud.Checked = true;
                else
                    ch_send_stud.Checked = false;
                if (rouls.ch_stud == true)
                    ch_stud.Checked = true;
                else
                    ch_stud.Checked = false;
                if (rouls.ch_lect_stud == true)
                    ch_lect_stud.Checked = true;
                else
                    ch_lect_stud.Checked = false;
                if (rouls.ch_activ == true)
                    ch_activ.Checked = true;
                else
                    ch_activ.Checked = false;
                if (rouls.ch_admin == true)
                    ch_admin.Checked = true;
                else
                    ch_admin.Checked = false;
                if (rouls.ch_apu == true)
                    ch_apu.Checked = true;
                else
                    ch_apu.Checked = false;
                if (rouls.ch_attend == true)
                    ch_attend.Checked = true;
                else
                    ch_attend.Checked = false;
                if (rouls.ch_cours_lect == true)
                    ch_cours_lect.Checked = true;
                else
                    ch_cours_lect.Checked = false;
                if (rouls.ch_dept == true)
                    ch_dept.Checked = true;
                else
                    ch_dept.Checked = false;
                if (rouls.ch_emp == true)
                    ch_emp.Checked = true;
                else
                    ch_emp.Checked = false;
                if (rouls.ch_job == true)
                    ch_job.Checked = true;
                else
                    ch_job.Checked = false;
                if (rouls.ch_lect == true)
                    ch_lect.Checked = true;
                else
                    ch_lect.Checked = false;
                if (rouls.ch_lect_stud == true)
                    ch_lect_stud.Checked = true;
                else
                    ch_lect_stud.Checked = false;
                if (rouls.ch_main == true)
                    ch_main.Checked = true;
                else
                    ch_main.Checked = false;
                if (rouls.ch_mark == true)
                    ch_mark.Checked = true;
                else
                    ch_mark.Checked = false;
                if (rouls.ch_matrila == true)
                    ch_matrila.Checked = true;
                else
                    ch_matrila.Checked = false;
                if (rouls.ch_report == true)
                    ch_report.Checked = true;
                else
                    ch_report.Checked = false;
                if (rouls.ch_sala == true)
                    ch_sala.Checked = true;
                else
                    ch_sala.Checked = false;
                if (rouls.ch_sett == true)
                    ch_sett.Checked = true;
                else
                    ch_sett.Checked = false;


            }
        }
        
        void defult_rouls()
        {
            ch_tech_lec.Checked = true;
            ch_send_tech.Checked = true;
            ch_send_stud.Checked = true;
            ch_stud.Checked = true;
            ch_lect_stud.Checked = true;
            ch_activ.Checked = false;
            ch_admin.Checked = false;
            ch_apu.Checked = true;
            ch_attend.Checked = true;
            ch_cours_lect.Checked = true;
           
                ch_dept.Checked = true;
            
            ch_emp.Checked = false;
            ch_job.Checked = false;
            ch_lect.Checked = true;
            ch_lect_stud.Checked = true;
            ch_main.Checked = true;
           
              
           
                ch_mark.Checked = true;
            
               
            ch_matrila.Checked = true;
          
               
           
                ch_report.Checked = true;
          
                
           
                ch_sala.Checked = true;
          
           
                ch_sett.Checked = false;

        }
        void add_rouls()
        {
                if(txt_user_pass.Text!="" && txt_user_name.Text!="" && user_id!=0)
                {
                try
                {
                    TBL_ROULLS_LECTUER tbl = new TBL_ROULLS_LECTUER();
                    tbl.USER_ID = user_id;
                    if (ch_activ.Checked)
                        tbl.ch_activ = true;
                    else
                        tbl.ch_activ = false;
                    if (ch_admin.Checked)
                        tbl.ch_admin = true;
                    else
                        tbl.ch_admin = false;
                    if (ch_apu.Checked)
                        tbl.ch_apu = true;
                    else
                        tbl.ch_apu = false;
                    if (ch_attend.Checked)
                        tbl.ch_attend = true;
                    else
                        tbl.ch_attend = false;
                    if (ch_cours_lect.Checked)
                        tbl.ch_cours_lect = true;
                    else
                        tbl.ch_cours_lect = false;
                    if (ch_dept.Checked)
                        tbl.ch_dept = true;
                    else
                        tbl.ch_dept = false;
                    if (ch_emp.Checked)
                        tbl.ch_emp = true;
                    else
                        tbl.ch_emp = false;
                    if (ch_job.Checked)
                        tbl.ch_job = true;
                    else
                        tbl.ch_job = false;
                    if (ch_lect.Checked)
                        tbl.ch_lect = true;
                    else
                        tbl.ch_lect = false;
                    if (ch_lect_stud.Checked)
                        tbl.ch_lect_stud = true;
                    else
                        tbl.ch_lect_stud = false;
                    if (ch_main.Checked)
                        tbl.ch_main = true;
                    else
                        tbl.ch_main = false;
                    if (ch_mark.Checked)
                        tbl.ch_mark = true;
                    else
                        tbl.ch_mark = false;
                    if (ch_matrila.Checked)
                        tbl.ch_matrila = true;
                    else
                        tbl.ch_matrila = false;
                    if (ch_report.Checked)
                        tbl.ch_report = true;
                    else
                        tbl.ch_report = false;
                    if (ch_sala.Checked)
                        tbl.ch_sala = true;
                    else
                        tbl.ch_sala = false;
                    if (ch_send_stud.Checked)
                        tbl.ch_send_stud = true;
                    else
                        tbl.ch_send_stud = true;
                    if (ch_send_tech.Checked)
                        tbl.ch_send_tech = true;
                    else
                        tbl.ch_send_tech = false;
                    if (ch_sett.Checked)
                        tbl.ch_sett = true;
                    else
                        tbl.ch_sett = false;
                    if (ch_stud.Checked)
                        tbl.ch_stud = true;
                    else
                        tbl.ch_stud = false;
                    if (ch_tech_lec.Checked)
                        tbl.ch_tech_lec = true;
                    else
                        tbl.ch_tech_lec = false;

                    con.TBL_ROULLS_LECTUER.AddOrUpdate(tbl);
                    con.SaveChanges();
                    adl.NotifictionUser notifiction = new adl.NotifictionUser("تم عمل الصلاحيات بنجاح ", THAGBAN_INST.Properties.Resources.add_32px);
                    notifiction.Show();
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                }
        }
        private void com_emp_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (com_emp.SelectedValue != null)
            {
                try
                {
                    emp_id = Convert.ToInt32(com_emp.SelectedValue);
                    var temp=con.TBL_USERS.Where(w=>w.EMP_ID==emp_id).FirstOrDefault();
                    if(temp!=null)
                    {
                        user_id = temp.USER_ID;
                        txt_user_name.Text = temp.USER_NAME;
                        txt_user_pass.Text=temp.USER_PASS;
                        cheack_rouls(user_id);
                    }
                    else
                    {
                        user_id = 0;
                        txt_user_name.Text ="";
                        txt_user_pass.Text ="";
                        defult_rouls();
                    }


                }
                catch (Exception ex)
                {

                }
            }
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_rouls_Click(object sender, EventArgs e)
        {
            add_rouls();
        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void rdb_local_CheckedChanged(object sender, EventArgs e)
        {
            if(rdb_local.Checked)
            {
                group_server.Enabled = true;
                txt_server_user_name.Enabled = false;
                txt_user_server_pass.Enabled=false;
                txt_port.Enabled = false;
            }
           

        }

        private void btn_user_Click(object sender, EventArgs e)
        {
            if (user_id == 0)
            {
                TBL_USERS user = new TBL_USERS();

                if (txt_user_pass.Text != "" && txt_user_name.Text != "")
                {
                    user.USER_NAME = txt_user_name.Text;
                    user.USER_PASS = txt_user_pass.Text;
                    user.EMP_ID = emp_id;
                    con.TBL_USERS.AddOrUpdate(user);
                    user_id = user.USER_ID;
                    add_rouls();
                    con.SaveChanges();
                    adl.NotifictionUser notifiction = new adl.NotifictionUser("تم عمل اسم مستخدم وكلمه مرور بنجاح", THAGBAN_INST.Properties.Resources.add_32px);
                    notifiction.Show();

                }

            }
            else
            {

                TBL_USERS user = new TBL_USERS();

                if (txt_user_pass.Text != "" && txt_user_name.Text != "")
                {
                    user.USER_NAME = txt_user_name.Text;
                    user.USER_PASS = txt_user_pass.Text;
                    user.EMP_ID = emp_id;
                    user.USER_ID = user_id;

                    con.TBL_USERS.AddOrUpdate(user);
                    con.SaveChanges();
                    adl.NotifictionUser notifiction = new adl.NotifictionUser("تم عمل اسم مستخدم وكلمه مرور بنجاح", THAGBAN_INST.Properties.Resources.add_32px);
                    notifiction.Show();

                }
            }
        }
    }
}