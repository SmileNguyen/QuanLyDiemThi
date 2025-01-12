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
using System.Data.SqlTypes;
using Microsoft.Data.SqlClient;

namespace QuanLyDiemThi
{
    public partial class FormDangNhap : Form
    {

        // Chuỗi kết nối đến SQL Server
        private string connectionString = "Server=Yuuko_Laptop\\SQLEXPRESS;Initial Catalog=LapTrinhNet_TaiKhoan;Integrated Security=True;Trust Server Certificate=True;";

        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            // Lấy tên đăng nhập và mật khẩu từ các ô TextBox
            string tenDangNhap = txtTenDangNhap.Text;
            string matKhau = txtMatKhau.Text;

            // Kiểm tra nếu tên đăng nhập và mật khẩu không trống
            if (string.IsNullOrEmpty(tenDangNhap) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kết nối và kiểm tra tài khoản đăng nhập
            if (CheckLogin(tenDangNhap, matKhau))
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Ẩn Form đăng nhập
                this.Hide();

                // Mở Form chính (FormMain)
                FormMain formMain = new FormMain();

                // Mở FormMain
                formMain.Show();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Phương thức kiểm tra đăng nhập
        private bool CheckLogin(string tenDangNhap, string matKhau)
        {
            // Câu lệnh SQL để kiểm tra tài khoản
            string query = "SELECT COUNT(*) FROM TaiKhoan WHERE TenDangNhap = @TenDangNhap AND MatKhau = @MatKhau";

            // Tạo kết nối đến SQL Server
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    // Mở kết nối đến cơ sở dữ liệu
                    conn.Open();

                    // Tạo đối tượng SqlCommand để thực thi câu lệnh SQL
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Thêm tham số vào câu lệnh SQL để tránh SQL Injection
                        cmd.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                        cmd.Parameters.AddWithValue("@MatKhau", matKhau);

                        // Thực thi câu lệnh và trả về kết quả
                        int result = (int)cmd.ExecuteScalar();

                        // Nếu có ít nhất 1 dòng dữ liệu trả về thì đăng nhập thành công
                        return result > 0;
                    }
                }
                catch (Exception ex)
                {
                    // Hiển thị lỗi nếu không thể kết nối
                    MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            // Xóa nội dung của cả 2 TextBox
            txtTenDangNhap.Text = string.Empty;
            txtMatKhau.Text = string.Empty;
        }





    }
}