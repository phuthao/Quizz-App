using System;
using System.Windows.Forms;

namespace TRACNGHIEMBYWINFORM
{
    static class Program
    {
        /// <summary>
        /// The Menu entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_Begin() );
        }
    }
}
