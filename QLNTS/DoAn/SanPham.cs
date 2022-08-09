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
    public partial class SanPham1 : Form 
    {
        XULYDULIEU xldl = new XULYDULIEU();
        DataTable dtSP;
        DataColumn[] key = new DataColumn[1];
        bool addnew = false;
        public SanPham1()
        {
            InitializeComponent();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SanPham_Load(object sender, EventArgs e)
        {
            dtSP = xldl.docDuLieu("select * from SANPHAM");
            key[0] = dtSP.Columns[2];
            dtSP.PrimaryKey = key;

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dtSP;
            dataGridView1.Columns[0].DataPropertyName = "MACHATLIEU";
            dataGridView1.Columns[1].DataPropertyName = "MATRANGSUC";
            dataGridView1.Columns[2].DataPropertyName = "MASANPHAM";
            dataGridView1.Columns[3].DataPropertyName = "TENSANPHAM";
            dataGridView1.Columns[4].DataPropertyName = "GIASANPHAM";
            dataGridView1.Columns[5].DataPropertyName = "SOLUONGCOSAN";
            dataGridView1.Columns[6].DataPropertyName = "HINHANHSANPHAM";
            SanphamBidata();
        }

        void SanphamBidata()
        {
            textCL.DataBindings.Add("Text", dtSP, "MACHATLIEU");
            textTS.DataBindings.Add("Text", dtSP, "MATRANGSUC");
            textMSP.DataBindings.Add("Text", dtSP, "MASANPHAM");
            textSP.DataBindings.Add("Text", dtSP, "TENSANPHAM");
            textGSP.DataBindings.Add("Text", dtSP, "GIASANPHAM");
            textSL.DataBindings.Add("Text", dtSP, "SOLUONGCOSAN");
            textLP.DataBindings.Add("Text", dtSP, "HINHANHSANPHAM");
        }
        public void setedit(bool isedit)
        {
            if (isedit)
            {
                textMSP.Enabled = textCL.Enabled = textTS.Enabled = textSP.Enabled = btL.Enabled = textLP.Enabled = textGSP.Enabled = textSL.Enabled= true;
                dataGridView1.AllowUserToAddRows = true;
                dataGridView1.ReadOnly = false;
                foreach (DataGridViewColumn col in dataGridView1.Columns)
                    col.ReadOnly = true;
                if (addnew)
                {
                    textCL.Clear();
                    textTS.Clear();
                    textMSP.Clear();
                    textSP.Clear();
                    textGSP.Clear();
                    textSL.Clear();
                    textLP.Clear();
                    textCL.DataBindings.Clear();
                    textTS.DataBindings.Clear();
                    textMSP.DataBindings.Clear();
                    textSP.DataBindings.Clear();
                    textGSP.DataBindings.Clear();
                    textSL.DataBindings.Clear();
                    textLP.DataBindings.Clear();
                }
            }
            else
            {
                textMSP.Enabled = textCL.Enabled = textTS.Enabled = textSP.Enabled = btL.Enabled = textLP.Enabled = textGSP.Enabled = textSL.Enabled = false;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.ReadOnly = true;
            }
        }

       

        private void btRT_Click(object sender, EventArgs e)
        {
            new Form1().Show();
        }

        private void btT_Click_1(object sender, EventArgs e)
        {
            btT.Enabled = btS.Enabled = false;
            addnew = true;
            setedit(true);
        }

       

        private void btS_Click_1(object sender, EventArgs e)
        {
            btT.Enabled = btS.Enabled = false;
            addnew = false;
            btL.Enabled = true;
            dataGridView1.Columns[0].ReadOnly = true;
            setedit(true);
            textMSP.Enabled = textCL.Enabled = textTS.Enabled = false;
        }

        private void btL_Click_1(object sender, EventArgs e)
        {
            if (addnew)
            {
                DataRow row = dtSP.NewRow();
                row[0] = textCL.Text;
                row[1] = textTS.Text;
                row[2] = textMSP.Text;
                row[3] = textSP.Text;
                row[4] = textGSP.Text;
                row[5] = textSL.Text;
                row[6] = textLP.Text;               
                dtSP.Rows.Add(row);
                btT.Enabled = btS.Enabled = true;
                btL.Enabled = false;
                SanphamBidata();
            }
            else
            {
                DataRow row1 = dtSP.Rows.Find(textMSP.Text);
                if (row1 != null)
                {
                    row1[0] = textCL.Text;
                    row1[1] = textTS.Text;
                    row1[3] = textSP.Text;
                    row1[4] = textGSP.Text;
                    row1[5] = textSL.Text;
                    row1[6] = textLP.Text;
                }
            }
            setedit(false);
        }

        private void btCN_Click_1(object sender, EventArgs e)
        {
            try
            {
                xldl.CapNhat("Select * from SANPHAM", dtSP);
                MessageBox.Show("Success !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void btCL_Click(object sender, EventArgs e)
        {
            new ChatLieu().Show();
        }

        private void btTS_Click(object sender, EventArgs e)
        {
            new TrangSuc().Show();
        }

        private void textTS_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btD_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm", "Do you want to delete ?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes);
            {
                DataRow r = dtSP.Rows.Find(textMSP.Text);
                if (r != null)
                {
                    r.Delete();
                }
            }
        }

    }
}
