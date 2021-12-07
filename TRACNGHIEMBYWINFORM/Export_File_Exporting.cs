using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CrystalDecisions.Windows.Forms;
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
    public partial class Export_File_Exporting : Form
    {
        public Export_File_Exporting()
        {
            InitializeComponent();

        }

        DataSet ds2 = new DataSet();

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

        private void Export_File_Crystal_Load(object sender, EventArgs e)
        {
           
            try
            {
                EXPORT rpt = new EXPORT();
                SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog =quiz; Integrated Security = True");

          
                conn.Open();
            
                string   query = "Select * from new where chude = N'" + Form_Document.get_txttiemkiem + "' and madt = '" + Form_Document.get_made + "'";
                      
              
           
                SqlDataAdapter dap = new SqlDataAdapter(query, conn);
                    
                      dap.Fill(ds2);
                   
                   
             
           
                rpt.SetDataSource(ds2.Tables[0]);
                crystalReportViewer1.ReportSource = rpt;
           


             
                ExportTextToDisk(rpt, @"D:/ProjectMH/DONE/thuctap/TRACNGHIEMBYWINFORM/ANOTHERFILEINPUT/DETHI/FILEDETHIOUTPUT/Output.pdf");

                MessageBox.Show("File Export Successful!");
                conn.Close();
            }
             
            catch
            {
                MessageBox.Show("Please Try Again!");
            }

       

        }

    }
}
