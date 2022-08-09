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
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }
        
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            //Close();
            
            
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click_1(object sender, EventArgs e)
        {
            Login fmb = new Login();
            fmb.FormClosed +=  new FormClosedEventHandler(fmb_FormClosing);
            fmb.Show();
            this.Hide();
        }

       private void fmb_FormClosing(object sender,FormClosedEventArgs e)
       {
           this.Show();
       }
    }
}
