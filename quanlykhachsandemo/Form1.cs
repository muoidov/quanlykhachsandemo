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

namespace quanlykhachsandemo
{
    public partial class Form1 : Form
    {
        public bool kt = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
        public string ID_USER = "";
        private string getID(string username, string pass)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-S1512E2\SQLEX;Initial Catalog=quanlykhachsan;Integrated Security=True");
            string id = "";
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM users WHERE idnhanvien ='" + username + "' and pass='" + pass + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        id = dr["idnhanvien"].ToString();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi xảy ra khi truy vấn dữ liệu hoặc kết nối với server thất bại !");
            }
            finally
            {
                con.Close();
            }
            return id;
        }
        private void btndangnhap_Click(object sender, EventArgs e)
        {
            ID_USER = getID(txbuserid.Text, txbpassword.Text);
            if (ID_USER != "")  
           //if(txbpassword.Text=="1" && txbuserid.Text=="1")
                {
                    kt = true;
                    this.Hide();
                 
                }
                
                else if (txbuserid.Text == "" || txbpassword.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin đăng nhập ");
                
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu");
                   
                
            }

            } 

        private void btnthoat_Click(object sender, EventArgs e)
        {
            
        }
    }
}
