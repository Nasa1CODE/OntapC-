using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OntapWinForm
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection (@"server=MANHLV\SQLEXPRESS10;database=QLSV; uid=sa; pwd=12345678");
            SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_taikhoan WHERE tktaikhoan=@user AND tkmatkhau=@pass", conn);

            cmd.Parameters.AddWithValue("@user", txbUsername.Text);
            cmd.Parameters.AddWithValue("@pass", txbPassword.Text);

            conn.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                MessageBox.Show("Đăng nhập thành công !");
                Home frmHome = new Home();
                frmHome.Show();

            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại !");
            }
        }
    }
}
