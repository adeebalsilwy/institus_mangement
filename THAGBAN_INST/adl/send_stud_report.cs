using DevExpress.PivotGrid.OLAP.AdoWrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using THAGBAN_INST.DATA;

namespace THAGBAN_INST.adl
{
     class send_stud_report_calss
    {
        db_max_instEntities con = new db_max_instEntities();

        public int SEND_STUD_ID { get; set; }
        public string STUD_NAME { get; set; }
        public Nullable<int> PAID_UP { get; set; }
        public Nullable<int> LECT_ID { get; set; }
        public Nullable<int> REST { get; set; }
        public Nullable<System.DateTime> SEND_STUD_DATE { get; set; }
        public string INST_NAME { get; set; }
        public string INST_DESC { get; set; }
        public string INST_LOCATION { get; set; }
        public byte[] INST_LOGO { get; set; }
        public Nullable<int> LECT_PRICE { get; set; }

        public string LECT_NAME { get; set; }
        public string GROUP_NAME { get; set; }
        public string STUD_LNAME { get; set; }
        public string  EMP_NAME { get; set; }
       public send_stud_report_calss get_send_stud(int send_id)
        {
            send_stud_report_calss t = new send_stud_report_calss();
            send_stud_report_calss tem =(from sts in con.TBL_SEND_STUD_LECT.Where(w=>w.SEND_STUD_ID==send_id)
                    join lec in con.TBL_LECTUER on sts.LECT_ID equals lec.LECT_ID
                    join stl in con.TBL_STUD_LECT on 
                    sts.STUD_LECT_ID equals stl.LECT_STUD_ID join
                    tcl in con.TBL_LECT_TECH_COURS on stl.LECT_TECH_ID equals
                    tcl.TECH_LECT_ID join emp in con.TBL_EMPLOYEES 
                    on tcl.TECHER_ID equals emp.EMP_ID join
                    stud in con.TBL_STUDENTS on 
                    sts.STUD_ID equals stud.STUD_ID 
                    join inst in con.TBL_INST on sts.INST_ID equals 
                    inst.INST_ID 
                    select new
                        send_stud_report_calss
                    {
LECT_NAME=lec.LECT_NAME,
EMP_NAME=emp.EMP_NAME,
 GROUP_NAME=tcl.GROUP_NAME,
 INST_DESC=inst.INST_DESC,
 INST_LOCATION=inst.INST_LOCATION,
 INST_LOGO=inst.INST_LOGO,
 INST_NAME=inst.INST_NAME,
 LECT_PRICE=lec.LECT_PRICE,
 PAID_UP=sts.PAID_UP,
 REST=sts.REST,
 SEND_STUD_DATE=sts.SEND_STUD_DATE,
 SEND_STUD_ID=sts.SEND_STUD_ID,
 STUD_NAME=stud.STUD_NAME,
 STUD_LNAME=stud.STUD_LNAME,
                    }).FirstOrDefault();

            return t;
        }
    }
    
}
