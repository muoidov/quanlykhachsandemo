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
using quanlykhachsandemo;

namespace quanlykhachsandemo
{
    
    public partial class Main : Form
    {
        Form1 f = new Form1();
        public Main()
        {
            InitializeComponent();
            

        }
        public void anbuttonsaudangnhap()
        {
            
            btndn.Visible = false;
        }
        private void systemToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void quanLyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void xemDanhSachPhongToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bangToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            suaphong();
        }

        private void quanToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void xoaToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            using (quanlykhachsanEntities2 db = new quanlykhachsanEntities2())
            {


                string id = textBoxid.Text;
                string Ten = textBoxten.Text;
                string loai = (comboBoxloai.SelectedValue as loaiphong).id;
                decimal gia = decimal.Parse(textBoxgia.Text);
                int sogiuong = Int32.Parse(textBoxsogiuong.Text);
                string trangthai = (comboBoxstatus.SelectedValue as tinhtrang).id;
                phong phong = db.phongs.Find(id);
                phong.idtinhtrang = "1";
                db.SaveChanges();
                MessageBox.Show("Thanh toán thành công");
                loadphongthue(dataGridView1);
                loadphong(dataGridViewphong);
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewphong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button29_Click(object sender, EventArgs e)
        {
            dataGridView6.DataSource = 
XemDL("SELECT id as 'ID',ten as 'Tên khách hàng',ngaysinh as 'Ngày_sinh',email as 'email',gioitinh as 'Giới_tính',sdt as 'Phone',cmnd as 'Chứng minh',quoctich as 'Quốc tịch',ghichu as 'Ghi chú' FROM khachhang WHERE ten LIKE'%"+textBox2.Text.Trim()+"%'");
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button28_Click(object sender, EventArgs e)
        {

        }

        private void button27_Click(object sender, EventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {

        }

        private void tabPage7_Click(object sender, EventArgs e)
        {

        }

        private void nhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quanlynhansu q = new Quanlynhansu();
            q.ShowDialog();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void systemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thongkebaocao t = new Thongkebaocao();
            t.ShowDialog();
        }

        public void Main_Load(object sender, EventArgs e)
        {
            loadphong(dataGridViewphong);
            loadphongthue(dataGridView1);
            loadcb(comboBoxloai);
            loadcbstt(comboBoxstatus);
            loadkhachhang(dataGridView6);
            loadcbtkdv(comboBox5);
            loaddichvu(dataGridView7);
        }
        void loaddichvu(DataGridView dtgv)
        {
            using (quanlykhachsanEntities2 db = new quanlykhachsanEntities2())
            {
                var sr = from dv in db.dichvus
                         from ldv in db.loaidichvus
                         where dv.idloai.Equals(ldv.id)
                         select new { ID = dv.id, Tên = dv.ten, Loại = ldv.ten, Giá = dv.gia, Ngày_có = dv.bdphucvu, Kết_thúc = dv.ktphucvu };
                        dtgv.DataSource = sr.ToList();
                
            }
        }
        void loadcbtkdv(ComboBox cb)
        {
            using (quanlykhachsanEntities2 db = new quanlykhachsanEntities2())
            { 
                cb.DataSource = db.loaidichvus.ToList();
                cb.DisplayMember = "ten";
            }
        }
        void Themphong()
        {
            using (quanlykhachsanEntities2 db = new quanlykhachsanEntities2())
            {

                string id = (Int32.Parse(db.phongs.Select(n=>n.id).Max())+1).ToString();
                string Ten = textBoxten.Text;
                if (db.phongs.Select(n => n.ten).Contains(Ten))
                {
                    MessageBox.Show("Tên phòng đã tồn tại");
                    return;
                }
                string loai = (comboBoxloai.SelectedValue as loaiphong).id;
                decimal gia = decimal.Parse(textBoxgia.Text);
                int sogiuong = Int32.Parse(textBoxsogiuong.Text);
               string trangthai = (comboBoxstatus.SelectedValue as tinhtrang).id;
                phong p = new phong() { id=id,ten=Ten,idloai=loai,idtinhtrang=trangthai};
                db.phongs.Add(p);
                db.SaveChanges();
                MessageBox.Show("Thêm thành công");
                loadphong(dataGridViewphong);   
            }
        }
        void Xoaphong()
        {
            using (quanlykhachsanEntities2 db = new quanlykhachsanEntities2())
            {


                string id =textBoxid.Text;
                string Ten = textBoxten.Text;
                string loai = (comboBoxloai.SelectedValue as loaiphong).id;
                decimal gia = decimal.Parse(textBoxgia.Text);
                int sogiuong = Int32.Parse(textBoxsogiuong.Text);
                string trangthai = (comboBoxstatus.SelectedValue as tinhtrang).id;
                db.phongs.Remove(db.phongs.Find(id));
                db.SaveChanges();
                
       
                MessageBox.Show("Xóa thành công");
                loadphong(dataGridViewphong);
               
            }
        }
        void suaphong()
        {
            using (quanlykhachsanEntities2 db = new quanlykhachsanEntities2())
            {


                string id = textBoxid.Text;
                string Ten = textBoxten.Text;
                string loai = (comboBoxloai.SelectedValue as loaiphong).id;
                decimal gia = decimal.Parse(textBoxgia.Text);
                int sogiuong = Int32.Parse(textBoxsogiuong.Text);
                string trangthai = (comboBoxstatus.SelectedValue as tinhtrang).id;
                phong phong = db.phongs.Find(id);
                phong.idloai = loai;
                phong.idtinhtrang = trangthai;
                db.SaveChanges();
                MessageBox.Show("Sửa thành công");
                loadphong(dataGridViewphong);
                loadphongthue(dataGridView1);
               
            }
        }
        private void btndn_Click(object sender, EventArgs e)
        {
           
                
             
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
            

            tabControlmain.Enabled = f.kt;
            menumain.Enabled = f.kt;
            if (f.ID_USER == "1")
            {
                btntenuserdn.Visible = true;
                mnstdmk.Enabled = true;
                btntenuserdn.Text = "TK Quản lý";
            }else if(f.ID_USER=="2")
            {
                btntenuserdn.Visible = true;
                btntenuserdn.Text = "Tk Lễ tân";
            }
            else if(f.ID_USER=="3")
            {
                btntenuserdn.Visible = true;
                btntenuserdn.Text = "TK Kế toán";
            }
            else
            {
                btntenuserdn.Visible = true;
                btntenuserdn.Text = "TK Nhân sự";
            }

            if (btntenuserdn.Text == "TK Quản lý" )
            {
                tsmnqlns.Enabled = true;
                stmnbctk.Enabled = true;

            }else if(btntenuserdn.Text == "TK Nhân sự")

            {
                tsmnqlns.Enabled = true;
            }
            else if (btntenuserdn.Text == "TK Quản lý" || btntenuserdn.Text == "TK Kế toán")
            {
                stmnbctk.Enabled = true;
            }
            else
            {
                tsmnqlns.Enabled = false;
                stmnbctk.Enabled = false;
            }
            btndn.Visible = false;
            btndx.Visible = true;
        }

        private void menumain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tenuserdn_Click(object sender, EventArgs e)
        {

        }

       

        private void button35_Click(object sender, EventArgs e)
        {
            f.ID_USER = "";
            this.Hide();
            Main n = new Main();
            n.Show();
            MessageBox.Show("Đăng xuất thành công");
        }

        private void mnstdmk_Click(object sender, EventArgs e)
        {
            Doimatkhau d = new Doimatkhau();
            d.ShowDialog();
        }
        void bdphong(DataGridView dtgv) 
        {
            Binding bdid = new Binding("Text", dtgv.DataSource, "ID", true, DataSourceUpdateMode.OnPropertyChanged);
            textBoxid.DataBindings.Clear();
            textBoxid.DataBindings.Add(bdid);
            Binding bdten = new Binding("Text", dtgv.DataSource, "Tên", true, DataSourceUpdateMode.OnPropertyChanged);
            textBoxten.DataBindings.Clear();
            textBoxten.DataBindings.Add(bdten);
            Binding bdloai = new Binding("Text", dtgv.DataSource, "Loại", true, DataSourceUpdateMode.OnPropertyChanged);
            comboBoxloai.DataBindings.Clear(); 
            comboBoxloai.DataBindings.Add(bdloai); 
            Binding bdgia = new Binding("Text", dtgv.DataSource, "Giá", true, DataSourceUpdateMode.OnPropertyChanged);
            textBoxgia.DataBindings.Clear();
            textBoxgia.DataBindings.Add(bdgia);
            Binding bdstatus = new Binding("Text", dtgv.DataSource, "Status", true, DataSourceUpdateMode.OnPropertyChanged);
            comboBoxstatus.DataBindings.Clear();
            comboBoxstatus.DataBindings.Add(bdstatus);
            Binding bdsogiuong = new Binding("Text", dtgv.DataSource, "Số_giường", true, DataSourceUpdateMode.OnPropertyChanged);
            textBoxsogiuong.DataBindings.Clear();
            textBoxsogiuong.DataBindings.Add(bdsogiuong);
           
        }
        void loadkhachhang(DataGridView dtgv) 
        {
            using (quanlykhachsanEntities2 db=new quanlykhachsanEntities2())
            {
                var sr = from kh in db.khachhangs
                         select new { ID = kh.id, Tên_khách = kh.ten, Ngày_sinh = kh.ngaysinh, SĐT = kh.sdt, Email = kh.email, CMND = kh.cmnd, Quốc_tịch = kh.quoctich,
                             Note = kh.ghichu };
                dtgv.DataSource = sr.ToList();
            }
        }
        void loadcb(ComboBox cb)
        {
            using (quanlykhachsanEntities2 db = new quanlykhachsanEntities2())
            {
                cb.DataSource = db.loaiphongs.ToList();
                cb.DisplayMember = "Ten";
            }
        }
            void loadcbstt(ComboBox cb)
            {
                using (quanlykhachsanEntities2 db = new quanlykhachsanEntities2())
                {
                    cb.DataSource = db.tinhtrangs.ToList();
                    cb.DisplayMember = "Ten";
                }
            }
        void loadphong(DataGridView dtgv)
        {
            using (quanlykhachsanEntities2 db = new quanlykhachsanEntities2())
            {
                
                var sr = from p in db.phongs
                         from l in db.loaiphongs
                         from t in db.tinhtrangs
                         where p.idloai.Equals(l.id) && p.idtinhtrang.Equals(t.id) select new {ID=p.id,Tên = p.ten, Loại = l.ten, Status = t.ten, Giá = l.gia,Số_giường = l.sogiuong };
                dtgv.DataSource = sr.ToList();
            }
            bdphong(dataGridViewphong);
        }

        void loadphongthue(DataGridView dtgv)
        {
            using (quanlykhachsanEntities2 db = new quanlykhachsanEntities2())
            {

                var sr = from p in db.phongs
                         from l in db.loaiphongs
                         from t in db.tinhtrangs
                         where p.idloai.Equals(l.id) && p.idtinhtrang.Equals(t.id) && t.ten=="Đã thuê"
                         select new
                         {
                             ID = p.id,
                             Tên = p.ten,
                             Loại = l.ten,
                             Status = t.ten,
                             Giá = l.gia,
                             Số_giường = l.sogiuong
                         };
                dtgv.DataSource = sr.ToList();
            }
            bdphong(dataGridView1);
        }
        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            Themphong();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            Xoaphong();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            dataGridView7.DataSource = XemDL("SELECT * FROM dichvu  WHERE ten ='"+comboBox5.Items+"'");
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            dataGridViewphong.DataSource = XemDL("SELECT id as 'ID',ten as 'Tên phòng',idloai as 'Loại',idtinhtrang as 'Tình trạng' FROM phong  WHERE ten LIKE'%" + textBox1.Text.Trim() + "%'");
        }
         //Tạo kết nối với cơ sở dữ liệu
    public SqlConnection cn = new SqlConnection();
        public void Ketnoi()
        {
            try
            {
                if (cn.State == 0)
                {
                    cn.ConnectionString = "Data Source=DESKTOP-S1512E2\\SQLEX;Initial Catalog=quanlykhachsan;Integrated Security=True";
                    cn.Open();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Ngatketnoi()
        {
            if (cn.State != 0)
            {
                cn.Close();
            }
        }

        //Phương thức truy vấn để xem dữ liệu
        public DataTable XemDL(string sql)
        {
            Ketnoi();

            SqlDataAdapter adap = new SqlDataAdapter(sql, cn);
            DataTable dt = new DataTable();
            adap.Fill(dt);

            return dt;

            Ngatketnoi();
        }

        //Phương thức truy vấn dữ liệu: Insert, Update, Delete
        public SqlCommand ThucThiDl(string sql)
        {
            Ketnoi();

            SqlCommand cm = new SqlCommand(sql, cn);
            cm.ExecuteNonQuery();

            return cm;

            Ngatketnoi();
        }

        private void btnall_Click(object sender, EventArgs e)
        {
            loadphong(dataGridViewphong);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadkhachhang(dataGridView6);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loaddichvu(dataGridView7);
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView7_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}

