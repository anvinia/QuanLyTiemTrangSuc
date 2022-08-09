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
    public partial class TrangSuc : Form
    {
        XULYDULIEU xldl = new XULYDULIEU();
        DataTable dtTS;
        DataColumn[] key = new DataColumn[1];
        bool newadd = false;
        public TrangSuc()
        {
            InitializeComponent();
        }

        private void TrangSuc_Load(object sender, EventArgs e)
        {
            dtTS = xldl.docDuLieu("select * from TRANGSUC");
            key[0] = dtTS.Columns[0];
            dtTS.PrimaryKey = key;

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dtTS;
            dataGridView1.Columns[0].DataPropertyName = "MATRANGSUC";
            dataGridView1.Columns[1].DataPropertyName = "LOAITRANGSUC";
            dataGridView1.Columns[2].DataPropertyName = "HINHANH";
            TrangsucBidingdata();
        }
        void TrangsucBidingdata()
        {
            textMTS.DataBindings.Add("Text", dtTS, "MATRANGSUC");
            textTS1.DataBindings.Add("Text", dtTS, "LOAITRANGSUC");
            textLP1.DataBindings.Add("Text", dtTS, "HINHANH");
        }
        public void setedit(bool isedit)
        {
            if (isedit)
            {
                textMTS.Enabled = textTS1.Enabled = btL1.Enabled = textLP1.Enabled = true;
                dataGridView1.AllowUserToAddRows = true;
                dataGridView1.ReadOnly = false;
                foreach (DataGridViewColumn col in dataGridView1.Columns)
                    col.ReadOnly = true;
                if (newadd)
                {
                    textMTS.Clear();
                    textTS1.Clear();
                    textLP1.Clear();
                    textMTS.DataBindings.Clear();
                    textTS1.DataBindings.Clear();
                    textLP1.DataBindings.Clear();
                }
            }
            else
            {
                textMTS.Enabled = textTS1.Enabled = btL1.Enabled = textLP1.Enabled = false;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.ReadOnly = true;
            }
        }

        private void btT1_Click(object sender, EventArgs e)
        {
            
        }

        private void btX1_Click(object sender, EventArgs e)
        {
           
        }

        private void btL1_Click(object sender, EventArgs e)
        {
            
        }

        private void btS1_Click(object sender, EventArgs e)
        {
            
        }

        private void btCN1_Click(object sender, EventArgs e)
        {
            
        }

        private void btT1_Click_1(object sender, EventArgs e)
        {
            btT1.Enabled =  false;
            newadd = true;
            setedit(true);
        }

        private void btX1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm", "Do you want to delete ? ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DataRow r = dtTS.Rows.Find(textMTS.Text);
                if (r != null)
                {
                    r.Delete();
                }
            }
        }

        private void btS1_Click_1(object sender, EventArgs e)
        {
            btT1.Enabled =  false;
            newadd = false;
            btL1.Enabled = true;
            dataGridView1.Columns[0].ReadOnly = true;
            setedit(true);
            textMTS.Enabled = false;
        }

        private void btL1_Click_1(object sender, EventArgs e)
        {
            if (newadd)
            {
                DataRow row = dtTS.NewRow();
                row[0] = textMTS.Text;
                row[1] = textTS1.Text;
                row[2] = textLP1.Text;
                dtTS.Rows.Add(row);
                btT1.Enabled =  true;
                btL1.Enabled = false;
                TrangsucBidingdata();

            }
            else
            {
                DataRow r = dtTS.Rows.Find(textMTS.Text);
                if (r != null)
                {
                    r[1] = textTS1.Text;
                    r[2] = textLP1.Text;
                }
            }
            setedit(false);
        }

        private void btCN1_Click_1(object sender, EventArgs e)
        {
            try
            {
                xldl.CapNhat("Select * from TRANGSUC", dtTS);
                MessageBox.Show("Success !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

    }
}
