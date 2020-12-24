using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlykhachsandemo
{
    public partial class Quanlynhansu : Form
    {
        public Quanlynhansu()
        {
            InitializeComponent();
        }
        
        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Quanlynhansu_Load(object sender, EventArgs e)
        {
            using(quanlykhachsanEntities2 db=new quanlykhachsanEntities2())
            {
                var sr = from nv in db.nhanviens
                         select new { Tên = nv.ten, Ngaysinh = nv.ngaysinh, giới_tính = nv.gioitinh, Địa_chỉ = nv.diachi, SĐT = nv.sdt, Chức_danh = nv.idchucdanh };
                dataGridView5.DataSource = sr.ToList();
            }
        }
    }
}
