using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRACNGHIEMBYWINFORM
{
  
    public partial class Export_Random_Exporting : Form
    {

    

        private static DataGridView _dgv;
        public static DataGridView DGV 
        {
         get
            {
                if (_dgv == null)
                    _dgv = new DataGridView();

                    return _dgv;
            }
            

        }
        public Export_Random_Exporting()
        {
            InitializeComponent();
        }

        DataGridView newdgv = new DataGridView();




        private void ExportTextToDisk(ReportDocument reportDocument, String fileName)
        {
            ExportOptions exportOptions = new ExportOptions();
            PdfFormatOptions textFormatOptions = ExportOptions.CreatePdfFormatOptions();
            //  textFormatOptions.LinesPerPage = 60;
            exportOptions.ExportFormatOptions = textFormatOptions;
            exportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;
            DiskFileDestinationOptions diskFileDestinationOptions = new DiskFileDestinationOptions();
            diskFileDestinationOptions.DiskFileName = fileName;
            exportOptions.ExportDestinationOptions = diskFileDestinationOptions;
            exportOptions.ExportDestinationType = ExportDestinationType.DiskFile;


            reportDocument.Export(exportOptions);
        }

        public void started()
        {
          

          
            EXPORT rpt = new EXPORT();

      //      rpt.Clone();
            rpt.SetDataSource(newdgv.DataSource);
          
            crystalReportViewer1.ReportSource = rpt;



            ExportTextToDisk(rpt, @"D:/ProjectMH/DONE/thuctap/TRACNGHIEMBYWINFORM/ANOTHERFILEINPUT/DETHI/FILEDETHIOUTPUT/Output.pdf");

            MessageBox.Show("File Export Sucessful!");




        }
      
        private void Random_Exporting_Load(object sender, EventArgs e)
        {
          
            _dgv= newdgv;

            crystalReportViewer1.Dock = DockStyle.Fill;
        }
        

      


        private void btn_load_Click(object sender, EventArgs e)
        {

            started();

      //      Dispose();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
          
        }

        private void crystalReportViewer1_MouseHover(object sender, EventArgs e)
        {
            btn_load_Click(sender, e);
        }

        private void crystalReportViewer1_DoubleClick(object sender, EventArgs e)
        {
            btn_load_Click(sender, e);
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern bool SetCursorPos(int x, int y);

        private void crystalReportViewer1_MouseMove(object sender, MouseEventArgs e)
        {
    //        Text = e.Location.X + ":" + e.Location.Y;
           
        }

        private void Export_Random_Exporting_FormClosing(object sender, FormClosingEventArgs e)
        {
          
        }

        private static void LeftMouseClick(int Xposition, int Yposition)
        {
            SetCursorPos(Xposition, Yposition);
            mouse_event(MOUSEEVENTF_LEFTDOWN, Xposition, Yposition, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, Xposition, Yposition, 0, 0);
        }
    }
}
