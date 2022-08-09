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
using System.Configuration;

namespace DoAn
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
            
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
           
           new TrangChu().Show();
        }
      
        private void Login_Load(object sender, EventArgs e)
        {
            Button b = new Button();
            b.Click += new EventHandler(button3_Click_1);
            Controls.Add(b);
        }
        public static string TENTAIKHOAN = "";
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            
        }

       

        private void button3_Click_1(object sender, EventArgs e)
        {
            
            if (textTK.Text == "" && textMK.Text == "")
            {
                MessageBox.Show("Tên tài khoản và mật khẩu không được để trống", "Thông Báo");
            }
            else
            {
                SqlConnection conn = new SqlConnection();
                try
                {
                    conn.ConnectionString = ConfigurationManager.ConnectionStrings["DoAn.Properties.Settings.DOANVANGConnectionString"].ConnectionString;
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "SP_AuthoLogin";
                    cmd.Parameters.AddWithValue("@UserName", textTK.Text);
                    cmd.Parameters.AddWithValue("@Password", textMK.Text);
                    cmd.Connection = conn;
                    TENTAIKHOAN = textTK.Text;
                    object kq = cmd.ExecuteScalar();
                    int code = Convert.ToInt32(kq);
                    if (code == 0)
                    {
                        MessageBox.Show("Chào mừng User đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                        new User().Show();
                    }
                    else if (code == 1)
                    {
                        MessageBox.Show("Chào mừng Admin đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                        new Form1().Show();
                        
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản hoặc mật khẩu không đúng !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textTK.Text = "";
                        textMK.Text = "";
                        textTK.Focus();
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            new Form1().Close();
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
           
        }       
    }
}
