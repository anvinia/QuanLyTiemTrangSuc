using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DoAn
{
    public partial class SanPham2 : Form
    {
        DataTable dtSP;
        SqlConnection con;
        DataSet ds;
        SqlDataAdapter da;
        public SanPham2()
        {
            InitializeComponent();            
        }

        private void dtBling(DataTable dtsp)
        {
            textCL.DataBindings.Clear();
            textTS.DataBindings.Clear();
            textMSP.DataBindings.Clear();
            textSP.DataBindings.Clear();
            textGSP.DataBindings.Clear();
            textSL.DataBindings.Clear();
            textCL.DataBindings.Add("Text", dtsp, "MACHATLIEU");
            textTS.DataBindings.Add("Text", dtsp, "MATRANGSUC");
            textMSP.DataBindings.Add("Text", dtsp, "MASANPHAM");
            textSP.DataBindings.Add("Text", dtsp, "TENSANPHAM");
            textGSP.DataBindings.Add("Text", dtsp, "GIASANPHAM");
            textSL.DataBindings.Add("Text", dtsp, "SOLUONGCOSAN");
            textLP.DataBindings.Add("Text", dtsp, "HINHANHSANPHAM");
        }

        private void SanPham2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dOANVANGDataSet2.SANPHAM' table. You can move, or remove it, as needed.
            this.sANPHAMTableAdapter1.Fill(this.dOANVANGDataSet2.SANPHAM);
            // TODO: This line of code loads data into the 'dOANVANGDataSet1.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Fill(this.dOANVANGDataSet1.NHANVIEN);
            this.sANPHAMTableAdapter.Fill(this.dOANVANGDataSet.SANPHAM);
        }
        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                //this.sANPHAMTableAdapter.FillBy(this.dOANVANGDataSet.SANPHAM);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, System.EventArgs e)
        {

        }

        private void label3_Click(object sender, System.EventArgs e)
        {

        }

        private void label4_Click(object sender, System.EventArgs e)
        {

        }

        private void label5_Click(object sender, System.EventArgs e)
        {

        }

        private void label6_Click(object sender, System.EventArgs e)
        {

        }

        private void label9_Click(object sender, System.EventArgs e)
        {

        }

        private void label7_Click(object sender, System.EventArgs e)
        {

        }

        private void textCL_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void textTS_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void textMSP_TextChanged(object sender, System.EventArgs e)
        {

        }
    }
}
