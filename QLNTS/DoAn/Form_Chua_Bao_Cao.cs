using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public partial class Form_Chua_Bao_Cao : Form
    {
        public Form_Chua_Bao_Cao(string forname, DataTable dt)
        {
            InitializeComponent();
            if (forname == "CTHD")
            {
                CTHD hd = new CTHD();
                hd.SetDataSource(dt);
                crystalReportViewer1.ReportSource = hd;
            }
            else if (forname == "ViewCTHD")
            {
                ViewCTHD ct = new ViewCTHD();
                ct.SetDataSource(dt);
                crystalReportViewer1.ReportSource = ct;
            }
            else if (forname == "NhanVien")
            {
                
            }
        }
        
        private void Form_Chua_Bao_Cao_Load(object sender, EventArgs e)
        {
            
        }
    }
}
