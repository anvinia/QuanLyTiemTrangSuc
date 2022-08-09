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
    public partial class DichVu : Form
    {
        XULYDULIEU xldl = new XULYDULIEU();
        DataTable dtDV;
        DataColumn[] key = new DataColumn[1];
        bool newadd = false;
        public DichVu()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textTS1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textMTS_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textLP1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DichVu_Load(object sender, EventArgs e)
        {
            dtDV = xldl.docDuLieu("select * from DICHVU");
            key[0] = dtDV.Columns[0];
            dtDV.PrimaryKey = key;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dtDV;
            dataGridView1.Columns[0].DataPropertyName = "MADICHVU";
            dataGridView1.Columns[1].DataPropertyName = "TENDICHVU";
            dataGridView1.Columns[2].DataPropertyName = "GIADICHVU";
            dataGridView1.Columns[3].DataPropertyName = "LOIYEUCAU";
            DichvuBiingdata();
        }
        void DichvuBiingdata()
        {
            textMDV.DataBindings.Add("Text", dtDV, "MADICHVU");
            textTDV.DataBindings.Add("Text", dtDV, "TENDICHVU");
            textGDV.DataBindings.Add("Text", dtDV, "GIADICHVU");
            textDS.DataBindings.Add("Text", dtDV, "LOIYEUCAU");
        }
        public void setedit(bool isedit)
        {
            if (isedit)
            {
                textMDV.Enabled = textTDV.Enabled = textGDV.Enabled = textDS.Enabled = btL11.Enabled = true;
                dataGridView1.AllowUserToAddRows = true;
                dataGridView1.ReadOnly = false;
                foreach (DataGridViewColumn col in dataGridView1.Columns)
                    col.ReadOnly = true;
                if (newadd)
                {
                    textMDV.Clear();
                    textTDV.Clear();
                    textGDV.Clear();
                    textDS.Clear();
                    textMDV.DataBindings.Clear();
                    textTDV.DataBindings.Clear();
                    textGDV.DataBindings.Clear();
                    textDS.DataBindings.Clear();
                }
            }
            else
            {
                textMDV.Enabled = textTDV.Enabled = textGDV.Enabled = textDS.Enabled = btL11.Enabled = false;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.ReadOnly = true;
            }
        }

      

        private void btX11_Click_1(object sender, EventArgs e)
        {
            btT11.Enabled  = false;
            newadd = false;
            btL11.Enabled = true;
            dataGridView1.Columns[0].ReadOnly = true;
            setedit(true);
            textMDV.Enabled = false;
        }

        private void btS11_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btL11_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btCN11_Click_1(object sender, EventArgs e)
        {
            try
            {
                xldl.CapNhat("Select * from DICHVU", dtDV);
                MessageBox.Show("Success !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btT11_Click_2(object sender, EventArgs e)
        {
            btT11.Enabled = false;
            newadd = true;
            setedit(true);
        }
        private void btT11_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btX11_Click_2(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm", "Do you want to delete ? ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DataRow r = dtDV.Rows.Find(textMDV.Text);

                if (r != null)
                {
                    r.Delete();
                }

            }
        }

        private void btS11_Click_2(object sender, EventArgs e)
        {
            btT11.Enabled  = false;
            newadd = false;
            btL11.Enabled = true;
            dataGridView1.Columns[0].ReadOnly = true;
            setedit(true);
            textMDV.Enabled = false;
        }

        private void btL11_Click_2(object sender, EventArgs e)
        {
            if (newadd)
            {
                DataRow row = dtDV.NewRow();
                row[0] = textMDV.Text;
                row[1] = textTDV.Text;
                row[2] = textGDV.Text;
                row[3] = textDS.Text;
                dtDV.Rows.Add(row);
                btT11.Enabled = true;
                btL11.Enabled = false;
                DichvuBiingdata();
            }
            else
            {
                DataRow r = dtDV.Rows.Find(textMDV.Text);
                if (r != null)
                {
                    r[1] = textTDV.Text;
                    r[2] = textGDV.Text;
                    r[3] = textDS.Text;
                }
            }
            setedit(false);
        }

        private void btCN11_Click(object sender, EventArgs e)
        {
            try
            {
                xldl.CapNhat("Select * from DICHVU", dtDV);
                MessageBox.Show("Succes ! ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }
    }
}
