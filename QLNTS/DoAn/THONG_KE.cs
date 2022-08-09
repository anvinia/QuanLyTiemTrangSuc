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
    public partial class THONG_KE : Form
    {
        XULYDULIEU DB = new XULYDULIEU();
        DataTable dtMaHD, dtDV, dtlop_Tam, dtlop_Tam1, dtNV, dtlop_Tam2;
        
        public THONG_KE()
        {
            InitializeComponent();
        }

        private void THONG_KE_Load(object sender, EventArgs e)
        {
            dtMaHD = DB.docDuLieu("select * from CHITIETHOADON");
            cbmCTDH.DataSource = dtMaHD;
            cbmCTDH.DisplayMember = "MAHOADON";
            cbmCTDH.ValueMember = "MAHOADONDV";

            dtMaHD = DB.docDuLieu("select * from View_Hoa_Don");
            dataGridView1.DataSource = dtMaHD;
            dtlop_Tam = dtMaHD.Copy();

            dtDV = DB.docDuLieu("select * from CHITIETDV");
            cbmHDDV.DataSource = dtDV;
            cbmHDDV.DisplayMember = "MAHOADONDV";

            dtDV = DB.docDuLieu("select * from CHITIETDV");
            dataGridView2.DataSource = dtDV;
            dtlop_Tam1 = dtDV.Copy();

            dtNV = DB.docDuLieu("select * from NHANVIEN");
            dtlop_Tam2 = dtNV.Copy();

            string[] dl = { "Hóa Đơn", "Dịch Vụ","Nhân Viên" };
            foreach (string x in dl)
            {
                cbmIN.Items.Add(x);
            }
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            if(cbmIN.Text=="Dịch Vụ")
                new Form_Chua_Bao_Cao("ChiTietDV", dtlop_Tam1).Show();
            else if (cbmIN.Text == "Hóa Đơn")
                new Form_Chua_Bao_Cao("CTHD", dtlop_Tam).Show();
            else if (cbmIN.Text == "Nhân Viên")
                new Form_Chua_Bao_Cao("NhanVien", dtlop_Tam2).Show();
        }

        private void btnLocDV_Click(object sender, EventArgs e)
        {
            dtlop_Tam1.Rows.Clear();
            foreach (DataRow r in dtDV.Rows)
            {
                if (r[2].ToString().Equals(cbmHDDV.Text))
                {
                    {
                        DataRow newrow = dtlop_Tam1.NewRow();
                        newrow[0] = r[0];
                        newrow[1] = r[1];
                        newrow[2] = r[2];
                        dtlop_Tam1.Rows.Add(newrow);
                    }

                }
                dataGridView2.DataSource = dtlop_Tam1;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnLocHD_Click(object sender, EventArgs e)
        {
            dtlop_Tam.Rows.Clear();
            foreach (DataRow r in dtMaHD.Rows)
            {
                if (r[2].ToString().Equals(cbmCTDH.Text))
                {
                    {
                        DataRow newrow = dtlop_Tam.NewRow();
                        newrow[0] = r[0];
                        newrow[1] = r[1];
                        newrow[2] = r[2];
                        dtlop_Tam.Rows.Add(newrow);
                    }

                }
                dataGridView1.DataSource = dtlop_Tam;
            }
        }

        private void btnprintHD_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
       
    }
}
