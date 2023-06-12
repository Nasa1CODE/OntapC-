using SinhVienConnectDB.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinhVienConnectDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //DatabaseDataContext db = new DatabaseDataContext();

            //var qr = db.tbl_SinhViens; //select * from tbl_SinhVien

            //if (qr.Any())
            //{
            //    dataGridView1.DataSource = qr.ToList();
            //}
            //else
            //{
            //    MessageBox.Show("Bảng Sinh viên đang rỗng");
            //}

            LoadData2Dtg();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                tbl_SinhVien sv = new tbl_SinhVien();
                sv.ID = txt_MSSV.Text;
                sv.MSSV = txt_MSSV.Text;
                sv.HoTen = txt_HoTen.Text;
                sv.NgaySinh = dtp_NgaySinh.Value;
                sv.GioiTinh = cbx_GioiTinh.Text;
                sv.DiaChi = txt_DiaChi.Text;

                //DatabaseDataContext db = new DatabaseDataContext();
                db.tbl_SinhViens.InsertOnSubmit(sv);
                //db.tbl_SinhViens.InsertAllOnSubmit();
                db.SubmitChanges();

                //sau khi subchange mà không có lỗi => tức là thành công
                MessageBox.Show("Thêm mới sinh viên thành công");

                //load lại dữ liệu từ csdl và hiển thị lại vào datagridview1
                LoadData2Dtg();
                //var qr = db.tbl_SinhViens; //select * from tbl_SinhVien

                //if (qr.Any())
                //{
                //    dataGridView1.DataSource = null;
                //    dataGridView1.DataSource = qr.ToList();
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra trong quá trình thêm mới sinh viên. Chi tiết lỗi: " + ex.Message);
            }
        }

        DatabaseDataContext db = new DatabaseDataContext();

        private void LoadData2Dtg()
        {
            //load lại dữ liệu trên datagridview1
            var qr = db.tbl_SinhViens;
            //select * from tbl_SinhVien

            if (qr.Any())
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = qr.ToList();
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                //lấy về đối tượng cần sửa
                //DatabaseDataContext db = new DatabaseDataContext();
                var qr = db.tbl_SinhViens.Where(o => o.ID == txt_id.Text)
                    ;
                if (qr.Any())
                {
                    //có đối tượng thỏa mãn điều kiện sửa
                    tbl_SinhVien obj = qr.SingleOrDefault();
                    obj.MSSV = txt_MSSV.Text;
                    obj.HoTen = txt_HoTen.Text;
                    obj.NgaySinh = dtp_NgaySinh.Value;
                    obj.GioiTinh = cbx_GioiTinh.Text;
                    obj.DiaChi = txt_DiaChi.Text;

                    db.SubmitChanges();

                    //thành công
                    MessageBox.Show("Cập nhật thông tin sinh viên thành công");

                    //load lại dữ liệu trên datagridview1
                    LoadData2Dtg();
                    //var qr1 = db.tbl_SinhViens; //select * from tbl_SinhVien

                    //if (qr1.Any())
                    //{
                    //    dataGridView1.DataSource = null;
                    //    dataGridView1.DataSource = qr1.ToList();
                    //}
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra trong quá trình chỉnh sửa thông tin sinh viên. Chi tiết lỗi: " + ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //lấy về row được click
                if (dataGridView1.SelectedCells.Count == 1)
                {
                    //nếu chỉ chọn 1 cell => lấy dữ liệu trên row tương ứng và đổ lên các input
                    var r = dataGridView1.Rows[e.RowIndex];

                    //đổ dữ liệu lên input
                    txt_id.Text = r.Cells[0].Value.ToString();
                    txt_MSSV.Text = r.Cells[1].Value.ToString();
                    txt_HoTen.Text = r.Cells[2].Value.ToString();
                    dtp_NgaySinh.Value = DateTime.Parse(r.Cells[3].Value.ToString());
                    cbx_GioiTinh.Text = r.Cells[4].Value.ToString();
                    txt_DiaChi.Text = r.Cells[5].Value.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra trong quá trình chọn đối tượng trên Datagridview. Chi tiết lỗi: " + ex.Message);
            }


        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                //lấy về đối tượng cần sửa
                //DatabaseDataContext db = new DatabaseDataContext();
                var qr = db.tbl_SinhViens.Where(o => o.ID == txt_id.Text);
                if (qr.Any())
                {
                    //có đối tượng thỏa mãn điều kiện sửa
                    tbl_SinhVien obj = qr.SingleOrDefault();

                    db.tbl_SinhViens.DeleteOnSubmit(obj);
                    db.SubmitChanges();

                    //thành công
                    MessageBox.Show("Xóa sinh viên thành công");

                    //load lại dữ liệu trên datagridview1
                    LoadData2Dtg();
                    //var qr1 = db.tbl_SinhViens; //select * from tbl_SinhVien

                    //if (qr1.Any())
                    //{
                    //    dataGridView1.DataSource = null;
                    //    dataGridView1.DataSource = qr1.ToList();
                    //}
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra trong quá trình xóa sinh viên. Chi tiết lỗi: " + ex.Message);
            }
        }
    }
}
