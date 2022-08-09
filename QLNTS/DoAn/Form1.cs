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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

           pictureBox2.Image = Image.FromFile("D:/HOC KY NAY/CN.NET/DoAn/Anh/Screenshot 2021-10-26 110731.png");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }


        private void GioHang_Click(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            
            Close();
            new Login().Show();
        }

        private void Login_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void ThongKe_Click(object sender, EventArgs e)
        {
            new THONG_KE().Show();
        }

        private void SanPham_Click(object sender, EventArgs e)
        {
            new SanPham1().Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void DichVu_Click(object sender, EventArgs e)
        {
            new DichVu().Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new NhanZien().Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Login hi = new Login();
            hi.FormClosed += new FormClosedEventHandler(hi_closing);
            hi.Show();
            this.Hide();
        }
        private void hi_closing(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new HoaDon1().Show();
        }
    }
}
