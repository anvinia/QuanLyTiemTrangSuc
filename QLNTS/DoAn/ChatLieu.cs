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
    public partial class ChatLieu : Form
    {
        XULYDULIEU xldl = new XULYDULIEU();
        DataTable dtCL;
        DataColumn[] key = new DataColumn[1];
        bool newadd = false;
        public ChatLieu()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ChatLieu_Load(object sender, EventArgs e)
        {
           dtCL = xldl.docDuLieu("select * from CHATLIEU");
            key[0] = dtCL.Columns[0];
            dtCL.PrimaryKey = key;

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dtCL;
            dataGridView1.Columns[0].DataPropertyName = "MACHATLIEU";
            dataGridView1.Columns[1].DataPropertyName = "TENCHATLIEU";
            dataGridView1.Columns[2].DataPropertyName = "HINHANHCHATLIEU";
            ChatlieuBidingdata();
        }
        void ChatlieuBidingdata()
        {
            textMCL.DataBindings.Add("Text", dtCL, "MACHATLIEU");
            textCL1.DataBindings.Add("Text", dtCL, "TENCHATLIEU");
            textLP1.DataBindings.Add("Text", dtCL, "HINHANHCHATLIEU");
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void setedit(bool isedit)
        {
            if (isedit)
            {
                textMCL.Enabled = textCL1.Enabled = btL.Enabled = textLP1.Enabled = true;
                dataGridView1.AllowUserToAddRows = true;
                dataGridView1.ReadOnly = false;
                foreach (DataGridViewColumn col in dataGridView1.Columns)
                    col.ReadOnly = true;
                if (newadd)
                {
                    textMCL.Clear();
                    textCL1.Clear();
                    textLP1.Clear();
                    textMCL.DataBindings.Clear();
                    textCL1.DataBindings.Clear();
                    textLP1.DataBindings.Clear();
                }
            }
            else
            {
                textMCL.Enabled = textCL1.Enabled = btL.Enabled = textLP1.Enabled = false;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.ReadOnly = true;
            }
        }

        private void btT_Click1(object sender, EventArgs e)
        {

            btT1.Enabled = false;
            newadd = true;
            setedit(true);
        }

        private void btL_Click1(object sender, EventArgs e)
        {
            
        }

        private void btS_Click1(object sender, EventArgs e)
        {
            
        }

        private void btX_Click1(object sender, EventArgs e)
        {
            
        }

        private void btCN_Click1(object sender, EventArgs e)
        {
            
        }

        private void btT1_Click(object sender, EventArgs e)
        {
            btT1.Enabled =  false;
            newadd = true;
            setedit(true);
        }

        private void btX_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm", "Do you want to delete ? ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DataRow r = dtCL.Rows.Find(textMCL.Text);
                if (r != null)
                {
                    r.Delete();
                }
            }
        }

        private void btS_Click(object sender, EventArgs e)
        {
            btT1.Enabled =  false;
            newadd = false;
            btL.Enabled = true;
            dataGridView1.Columns[0].ReadOnly = true;
            setedit(true);
            textMCL.Enabled = false;
        }

        private void btL_Click(object sender, EventArgs e)
        {
            if (newadd)
            {
                DataRow row = dtCL.NewRow();
                row[0] = textMCL.Text;
                row[1] = textCL1.Text;
                row[2] = textLP1.Text;
                dtCL.Rows.Add(row);
                btT1.Enabled =  true;
                btL.Enabled = false;
                ChatlieuBidingdata();

            }
            else
            {
                DataRow r = dtCL.Rows.Find(textMCL.Text);
                if (r != null)
                {
                    r[1] = textCL1.Text;
                    r[2] = textLP1.Text;
                }
            }
            setedit(false);
        }

        private void btCN_Click(object sender, EventArgs e)
        {
            try
            {
                xldl.CapNhat("Select * from CHATLIEU", dtCL);
                MessageBox.Show("Success !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void textLP1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
