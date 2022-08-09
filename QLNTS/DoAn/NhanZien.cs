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
using System.IO;
namespace DoAn
{
    public partial class NhanZien : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-0M7P8F7\KIEN123;Initial Catalog=DOANVANG;User ID=sa;Password=123");
        XULYDULIEU xldl = new XULYDULIEU();
        DataTable dtNV;
        DataColumn[] key = new DataColumn[1];
        bool newadd = false;
        public NhanZien()
        {
            InitializeComponent();          
        }
        void loadData()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from NHANVIEN", conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void NhanZien_Load(object sender, EventArgs e)
        {
            dtNV = xldl.docDuLieu("select * from NHANVIEN");
            key[0] = dtNV.Columns[0];
            dtNV.PrimaryKey = key;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dtNV;
            dataGridView1.Columns[0].DataPropertyName = "MANHANVIEN";
            dataGridView1.Columns[1].DataPropertyName = "TENNHANVIEN";
            dataGridView1.Columns[2].DataPropertyName = "NAMSINH";
            dataGridView1.Columns[3].DataPropertyName = "NGAYBATDAULAM";
            dataGridView1.Columns[4].DataPropertyName = "SONGAYLAM";
            dataGridView1.Columns[5].DataPropertyName = "CHUCVU";
            dataGridView1.Columns[6].DataPropertyName = "LUONGCHINHTHUC";
            dataGridView1.Columns[7].DataPropertyName = "TENTAIKHOAN";
            dataGridView1.Columns[8].DataPropertyName = "MATKHAU";
            dataGridView1.Columns[9].DataPropertyName = "ID";
            
            NHANVIENbiding();
        }
        void NHANVIENbiding()
        {
            textMNV.DataBindings.Add("text", dtNV, "MANHANVIEN");
            textTNV.DataBindings.Add("text",dtNV,"TENNHANVIEN");
            textNS.DataBindings.Add("text", dtNV, "NAMSINH");
            textNBDL.DataBindings.Add("text", dtNV, "NGAYBATDAULAM");
            textSNL.DataBindings.Add("text", dtNV, "SONGAYLAM");
            textCV.DataBindings.Add("text", dtNV, "CHUCVU");
            textL.DataBindings.Add("text", dtNV, "LUONGCHINHTHUC");
            textAC.DataBindings.Add("text", dtNV, "TENTAIKHOAN");
            textPW.DataBindings.Add("text", dtNV, "MATKHAU");
            textID.DataBindings.Add("text", dtNV, "ID");
           
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        public void setedit(bool isedit)
        {
            if (isedit)
            {
                textMNV.Enabled = textTNV.Enabled = textNS.Enabled = textNBDL.Enabled = textSNL.Enabled = textL.Enabled = btL.Enabled = textPW.Enabled = textAC.Enabled  = textID.Enabled = true ;
                dataGridView1.AllowUserToAddRows = true;
                dataGridView1.ReadOnly = false;
                foreach (DataGridViewColumn col in dataGridView1.Columns)
                    col.ReadOnly = true;
                if (newadd)
                {
                    textMNV.Clear();
                    textTNV.Clear();
                    textNS.Clear();
                    textNBDL.Clear();
                    textSNL.Clear();
                    textCV.Clear();
                    textL.Clear();
                    textAC.Clear();
                    textPW.Clear();
                    
                    textID.Clear();
                    textMNV.DataBindings.Clear();
                    textTNV.DataBindings.Clear();
                    textNS.DataBindings.Clear();
                    textNBDL.DataBindings.Clear();
                    textSNL.DataBindings.Clear();
                    textCV.DataBindings.Clear();
                    textL.DataBindings.Clear();
                    textAC.DataBindings.Clear();
                    textPW.DataBindings.Clear();
                   
                    textID.DataBindings.Clear();

                }
            }
            else
            {
                textMNV.Enabled = textTNV.Enabled = textNS.Enabled = textNBDL.Enabled = textSNL.Enabled = textL.Enabled = btL.Enabled = textPW.Enabled = textAC.Enabled  = textID.Enabled = false ;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.ReadOnly = true;
            }
        }
        private void btT_Click(object sender, EventArgs e)
        {
            btT.Enabled = false;
            textMNV.Enabled = textTNV.Enabled = textNS.Enabled = textNBDL.Enabled = textSNL.Enabled = textL.Enabled = textPW.Enabled = textAC.Enabled  = textID.Enabled = true; ;
            newadd = true;
            setedit(true);
        }

        private void btL_Click(object sender, EventArgs e)
        {
            if (newadd)
            {
                DataRow row = dtNV.NewRow();
                row[0] = textMNV.Text;
                row[1] = textTNV.Text;
                row[2] = textNS.Text;
                row[3] = textNBDL.Text;
                row[4] = textSNL.Text;
                row[5] = textCV.Text;
                row[6] = textL.Text;
                row[7] = textAC.Text;
                row[8] = textPW.Text;
                row[9] = textID.Text;
                dtNV.Rows.Add(row);
                btT.Enabled = true;
                btL.Enabled = false;
    
                NHANVIENbiding();
            }
            else
            {
                DataRow r = dtNV.Rows.Find(textMNV.Text);
                if (r != null)
                {
                    r[1] = textTNV.Text;
                    r[2] = textNS.Text;
                    r[3] = textNBDL.Text;
                    r[4] = textSNL.Text;
                    r[5] = textCV.Text;
                    r[6] = textL.Text;
                    r[7] = textAC.Text;
                    r[8] = textPW.Text;
                    r[9] = textID.Text;             
                }
            }
            
            setedit(false);

        }

        private void btX_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm", "Do you want to delete ? ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DataRow r = dtNV.Rows.Find(textMNV.Text);
                if (r != null)
                {
                    r.Delete();
                }
            }
        }

        private void btCN_Click(object sender, EventArgs e)
        {
            try
            {
                xldl.CapNhat("Select * from NHANVIEN", dtNV);
                MessageBox.Show("Success !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

       
    }
}
