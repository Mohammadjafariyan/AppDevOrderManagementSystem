using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AppDevOrderManagementSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var f=new Form1();
           // initFormData(f);
            Application.Run(f);
             

        }

        //private static void initFormData(Form1 f)
        //{
        //    f.dataGridView1.Rows.Add("1", "سایت فروشگاهی", "1397/12/21", "سایت","", "خیر", "3,500,000",  "ویرایش");


        //}
    }
}
