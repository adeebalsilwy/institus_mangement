using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using THAGBAN_INST.FORM;
using THAGBAN_INST.FORM.FRM_EMP_MANEGER;
using THAGBAN_INST.FORM.FRM_EMP_MANEGER.employees;
using THAGBAN_INST.FORM.FRM_EMP_MANEGER.job;
using THAGBAN_INST.FORM.FRM_EMP_MANEGER.part_salary;
using THAGBAN_INST.FORM.FRM_LECTUER_MANG;
using THAGBAN_INST.FORM.FRM_LECTUER_MANG.lect_mark;
using THAGBAN_INST.FORM.FRM_LECTUER_MANG.lect_salary;
using THAGBAN_INST.FORM.FRM_LECTUER_MANG.lect_send_stud;
using THAGBAN_INST.FORM.FRM_LECTUER_MANG.lect_stud;
using THAGBAN_INST.FORM.FRM_LECTUER_MANG.lect_students;
using THAGBAN_INST.FORM.FRM_LECTUER_MANG.move_stud;
using THAGBAN_INST.FORM.FRM_LECTUER_MANG.students;
using THAGBAN_INST.FORM.FRM_MANG_STUD.marks;
using THAGBAN_INST.FORM.FRM_MANG_STUD.matrila;
using THAGBAN_INST.FORM.FRM_MANG_STUD.spical;
using THAGBAN_INST.FORM.FRM_MANG_STUD.stud_foloder;
using THAGBAN_INST.FORM.FRM_MANG_STUD.terms;
using THAGBAN_INST.FORM.FRM_SYSTEM;

namespace THAGBAN_INST
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FRM_Start());
        }
    }
}
