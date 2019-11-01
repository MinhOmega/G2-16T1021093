using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppG2.View;
namespace AppG2
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
<<<<<<< HEAD
            //Application.Run(new frmThongTinSinhVien("16T1021006"));
            Application.Run(new frmContacts());
=======
            Application.Run(new frmThongTinSinhVien("1021093"));
>>>>>>> fa6656062ad07236aecf31725e24efd42b4eb4ac
        }
    }
}
