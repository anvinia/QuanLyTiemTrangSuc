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
    public partial class DichVu2 : Form
    {
        XULYDULIEU xldl = new XULYDULIEU();
        DataTable dtDV;
        DataColumn[] key = new DataColumn[1];
        bool newadd = false;
        public DichVu2()
        {
            InitializeComponent();
        }

        private void DichVu2_Load(object sender, EventArgs e)
        {
            btCN11.Enabled = false;
            btL11.Enabled = false;
            btS11.Enabled = false;
            btT11.Enabled = false;
            btX11.Enabled = false;
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
            textMDV.Enabled = textTDV.Enabled = btT11.Enabled = textGDV.Enabled = textDS.Enabled = true;
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
            else
            {
                textMDV.Enabled = textTDV.Enabled = btT11.Enabled = textGDV.Enabled = textDS.Enabled = false;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.ReadOnly = true;
            }
        }

        private void btT11_Click(object sender, EventArgs e)
        {
            
        }
    }
}
