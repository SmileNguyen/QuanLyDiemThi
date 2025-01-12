using System;
using System.Windows.Forms;

namespace QuanLyDiemThi
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            // Khởi tạo ứng dụng Windows Forms
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Hiển thị FormDangNhap đầu tiên
            FormDangNhap formDangNhap = new FormDangNhap();

            // Nếu FormDangNhap được đóng, kết thúc ứng dụng
            Application.Run(formDangNhap);
        }
    }
}
