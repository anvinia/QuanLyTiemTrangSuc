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
    public partial class HoaDon1 : Form
    {
        XULYDULIEU xldl = new XULYDULIEU();
        DataTable dtHD,dtTam;
        DataColumn[] key = new DataColumn[1];
        bool addnew = false;
        public HoaDon1()
        {
            InitializeComponent();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void HoaDon1_Load(object sender, EventArgs e)
        {
            dtHD = xldl.docDuLieu("Select * from HOADON");
            key[0] = dtHD.Columns[0];
            dtHD.PrimaryKey = key;

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dtHD;
            dataGridView1.Columns[0].DataPropertyName = "MAHOADON";
            dataGridView1.Columns[1].DataPropertyName = "MAKHACHHANG";
            dataGridView1.Columns[2].DataPropertyName = "MANHANVIEN";
            dataGridView1.Columns[3].DataPropertyName = "NGAYMUA";
            dataGridView1.Columns[4].DataPropertyName = "THANHTOAN";
            HoaDonBydata();
           
            this.ShowCombobox();
            dtTam = dtHD.Copy();

        }
        public void ShowCombobox()
        {
            comboBox1.DataSource = dtHD;
            comboBox1.DisplayMember = "MAKHACHHANG";
            comboBox1.ValueMember = "MAKHACHHANG";
        }
        public void ShowData(string sql)
        {
            dataGridView1.DataSource = xldl.docDuLieu(sql);

        }
        void HoaDonBydata()
        {
            txtMaHD.DataBindings.Add("Text", dtHD, "MAHOADON");
            txtMaKH.DataBindings.Add("Text", dtHD, "MAKHACHHANG");
            txtMaNV.DataBindings.Add("Text", dtHD, "MANHANVIEN");
            txtngayMua.DataBindings.Add("Text", dtHD, "NGAYMUA");
            txtgia.DataBindings.Add("Text", dtHD, "THANHTOAN");
        }
        public void setEdit(bool isedit)
        {
            if (isedit)
            {
                txtMaHD.Enabled = txtMaKH.Enabled = txtMaNV.Enabled = txtngayMua.Enabled = txtgia.Enabled = btnLuu.Enabled = true;
                dataGridView1.AllowUserToAddRows = true;
                dataGridView1.ReadOnly = false;
                foreach (DataGridViewColumn col in dataGridView1.Columns)
                    col.ReadOnly = true;
                if (addnew)
                {
                    txtMaHD.Clear();
                    txtMaKH.Clear();
                    txtMaNV.Clear();
                    txtngayMua.Clear();
                    txtgia.Clear();
                    txtMaHD.DataBindings.Clear();
                    txtMaKH.DataBindings.Clear();
                    txtMaNV.DataBindings.Clear();
                    txtngayMua.DataBindings.Clear();
                    txtgia.DataBindings.Clear();
                }
            }
            else
            {
                txtMaHD.Enabled = txtMaKH.Enabled = txtMaNV.Enabled = txtngayMua.Enabled = txtgia.Enabled = btnLuu.Enabled = false;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.ReadOnly = true;
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = btnSua.Enabled = false;
            addnew = true;
            setEdit(true);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = btnSua.Enabled = false;
            addnew = false;
            btnLuu.Enabled = true;
            dataGridView1.Columns[0].ReadOnly = true;
            setEdit(true);
            txtMaHD.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm", "Do you want to delete ? ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DataRow r = dtHD.Rows.Find(txtMaHD.Text);
                if (r != null)
                {
                    r.Delete();
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (addnew)
            {
                DataRow row = dtHD.NewRow();
                row[0] = txtMaHD.Text;
                row[1] = txtMaKH.Text;
                row[2] = txtMaNV.Text;
                row[3] = txtngayMua.Text;
                row[4] = txtgia.Text;
                dtHD.Rows.Add(row);
                btnThem.Enabled = btnSua.Enabled = true;
                btnLuu.Enabled = false;
                HoaDonBydata();

            }
            else
            {
                btnThem.Enabled = true;
                DataRow r = dtHD.Rows.Find(txtMaHD.Text);
                if (r != null)
                {
                    r[1] = txtMaKH.Text;
                    r[2] = txtMaNV.Text;
                    r[3] = txtngayMua.Text;
                    r[4] = txtgia.Text;
                }
            }
            setEdit(false);
        }

        private void btnNEXT_Click(object sender, EventArgs e)
        {
            ChiTietHD tc = new ChiTietHD();
            tc.FormClosed += new FormClosedEventHandler(tc_formClosed);
            tc.Show();
            this.Hide();
        }

        private void tc_formClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            string name = "CTHD";
            new Form_Chua_Bao_Cao(name, dtTam).Show();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            string a = comboBox1.Text;
            string dt = "select * from HOADON where MAKHACHHANG='" + a + "'";
            this.ShowData(dt);
        }
    }
}
