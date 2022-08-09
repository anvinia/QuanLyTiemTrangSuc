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
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            new Login().Show();
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            new SanPham2().Show();
        }

        private void User_Load(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile("D:/HOC KY NAY/CN.NET/DoAn/Anh/Screenshot 2021-10-26 110731.png");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new DichVu2().Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
