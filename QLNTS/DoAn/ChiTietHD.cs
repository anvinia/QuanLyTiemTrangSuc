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
    public partial class ChiTietHD : Form
    {
        public ChiTietHD()
        {
            InitializeComponent();
        }
        XULYDULIEU xldl = new XULYDULIEU();
        DataTable dtCTHD,dtTam;
        DataColumn[] key = new DataColumn[2];
        bool addnew = false;
        void HoaDonBydata()
        {
            txtMaHD.DataBindings.Add("Text", dtCTHD, "MAHOADON");
            txtMaSP.DataBindings.Add("Text", dtCTHD, "MASANPHAM");
            txtMaHDDV.DataBindings.Add("Text", dtCTHD, "MAHOADONDV");
            txtSoLuong.DataBindings.Add("Text", dtCTHD, "SOLUONGMUA");
            txtGiaBan.DataBindings.Add("Text", dtCTHD, "GIASANPHAM");
            txtTong.DataBindings.Add("Text", dtCTHD, "TONGTIEN");
        }
        private void CTHOADON_Load(object sender, EventArgs e)
        {
           
        }
        public void setEdit(bool isedit)
        {
            if (isedit)
            {
                txtMaHD.Enabled = txtMaSP.Enabled = txtMaHDDV.Enabled = txtSoLuong.Enabled = txtGiaBan.Enabled = txtTong.Enabled = btnluu.Enabled = true;
                dataGridView2.AllowUserToAddRows = true;
                dataGridView2.ReadOnly = false;
                foreach (DataGridViewColumn col in dataGridView2.Columns)
                    col.ReadOnly = true;
                if (addnew)
                {
                    //cc gì z
                    //lag 
                    //à
                    txtMaHD.Clear();
                    txtMaSP.Clear();
                    txtMaHDDV.Clear();
                    txtSoLuong.Clear();
                    txtGiaBan.Clear();
                    txtTong.Clear();
                    txtMaHD.DataBindings.Clear();
                    txtMaSP.DataBindings.Clear();
                    txtMaHDDV.DataBindings.Clear();
                    txtSoLuong.DataBindings.Clear();
                    txtGiaBan.DataBindings.Clear();
                    txtTong.DataBindings.Clear();
                }
            }
            else
            {
                txtMaHD.Enabled = txtMaSP.Enabled = txtMaHDDV.Enabled = txtSoLuong.Enabled = txtGiaBan.Enabled = txtTong.Enabled = btnluu.Enabled = false;
                dataGridView2.AllowUserToAddRows = false;
                dataGridView2.ReadOnly = true;
            }
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
           
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
           
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            
        }
        private void btnNEXT_Click(object sender, EventArgs e)
        {
            HoaDon1 tc = new HoaDon1();
            tc.FormClosed += new FormClosedEventHandler(tc_formClosed);
            tc.Show();
            this.Hide();
        }

        private void tc_formClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void ChiTietHD_Load(object sender, EventArgs e)
        {
            dtCTHD = xldl.docDuLieu("SELECT * FROM CHITIETHOADON");
            key[0] = dtCTHD.Columns[0];
            key[1] = dtCTHD.Columns[1];
            dtCTHD.PrimaryKey = key;
            txtTong.Enabled = false;

            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.DataSource = dtCTHD;
            dataGridView2.Columns[0].DataPropertyName = "MAHOADON";
            dataGridView2.Columns[1].DataPropertyName = "MASANPHAM";
            dataGridView2.Columns[2].DataPropertyName = "MAHOADONDV";
            dataGridView2.Columns[3].DataPropertyName = "SOLUONGMUA";
            dataGridView2.Columns[4].DataPropertyName = "GIASANPHAM";
            dataGridView2.Columns[5].DataPropertyName = "TONGTIEN";
            HoaDonBydata();
            dtTam = dtCTHD.Copy();
        }

        

        private void btnsua_Click_1(object sender, EventArgs e)
        {
            button1.Enabled = btnsua.Enabled = false;
            addnew = false;
            btnluu.Enabled = true;
            dataGridView2.Columns[0].ReadOnly = true;
            setEdit(true);
            txtMaHD.Enabled = false;
        }

       

        private void btnluu_Click_1(object sender, EventArgs e)
        {
            if (addnew)
            {
                DataRow row = dtCTHD.NewRow();
                row[0] = txtMaHD.Text;
                row[1] = txtMaSP.Text;
                row[2] = txtMaHDDV.Text;
                row[3] = txtSoLuong.Text;
                row[4] = txtGiaBan.Text;
                row[5] = txtTong.Text;
                dtCTHD.Rows.Add(row);
                button1.Enabled = btnsua.Enabled = true;
                btnluu.Enabled = false;
                HoaDonBydata();
            }
            else
            {
                btnthem.Enabled = true;
                DataRow r = dtCTHD.Rows.Find(txtMaHD.Text);
                DataRow r1 = dtCTHD.Rows.Find(txtMaSP.Text);
                if (r != null)
                {
                    r[0] = txtMaHD.Text;
                    r[1] = txtMaSP.Text;
                    r[2] = txtMaHDDV.Text;
                    r[3] = txtSoLuong.Text;
                    r[4] = txtGiaBan.Text;
                    r[5] = txtTong.Text;

                    r1[0] = txtMaHD.Text;
                    r1[1] = txtMaSP.Text;
                    r1[2] = txtMaHDDV.Text;
                    r1[3] = txtSoLuong.Text;
                    r1[4] = txtGiaBan.Text;
                    r1[5] = txtTong.Text;
                }
            }
            setEdit(false);
        }

        private void btnInn_Click(object sender, EventArgs e)
        {
            string name = "ViewCTHD";
            new Form_Chua_Bao_Cao(name, dtTam).Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm", "Do you want to delete ? ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DataRow r = dtCTHD.Rows.Find(txtMaHD.Text);
                if (r != null)
                {
                    r.Delete();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = btnsua.Enabled = false;
            addnew = true;
            setEdit(true);
        }

      
    }
}
