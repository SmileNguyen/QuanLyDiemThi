using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Diagnostics;

namespace QuanLyDiemThi
{
    public partial class FormMain : Form
    {
        private DatabaseHelper databaseHelper;
        private string tableName = "DiemThi"; // Tên bảng trong database
        private FormBaoCao formBaoCao; // Lưu trữ instance của FormBaoCao

        public FormMain()
        {
            InitializeComponent();
            databaseHelper = new DatabaseHelper(); // Khởi tạo đối tượng DatabaseHelper
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // Nạp dữ liệu vào DataGridView khi FormMain được tải
            LoadData();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ẩn FormMain
            FormDangNhap formDangNhap = new FormDangNhap();
            formDangNhap.FormClosed += (s, args) => Application.Exit(); //Đóng app khi formDangNhap đóng
            formDangNhap.Show(); // Hiển thị lại Form đăng nhập
        }

        private void btnDangXuat_Click_1(object sender, EventArgs e)
        {
            this.Hide(); // Ẩn FormMain
            FormDangNhap formDangNhap = new FormDangNhap();
            formDangNhap.Show(); // Hiển thị lại Form đăng nhập
            this.Close();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void LoadData()
        {
            try
            {
                string query = $"SELECT * FROM {tableName}";
                DataTable dataTable = databaseHelper.ExecuteQuery(query);
                dataGridView1.DataSource = dataTable;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                HandleException("Lỗi khi tải dữ liệu từ SQL Server", ex);
            }
        }


        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Sự kiện này xảy ra khi ô dữ liệu được chỉnh sửa
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                if (row.IsNewRow) return; // Bỏ qua nếu là dòng mới

                try
                {
                    // Lấy thông tin dòng cần update
                    object primaryKey = GetPrimaryKey(row);
                    if (primaryKey == null)
                    {
                        Debug.WriteLine("Tự động lưu: Lỗi primaryKey bằng null");
                        return;
                    }
                    // Tạo câu truy vấn update
                    string query = BuildUpdateQuery(row, primaryKey);
                    databaseHelper.ExecuteNonQuery(query);
                    Debug.WriteLine("Tự động lưu: Cập nhật thành công");
                }
                catch (Exception ex)
                {
                    HandleException("Lỗi khi cập nhật dữ liệu", ex);
                    // Refresh lại DataGridView để hiện thị dữ liệu ban đầu
                    LoadData();
                }
            }
        }

        private void dataGridView1_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            // Sự kiện này xảy ra khi người dùng thêm dòng mới
            DataGridViewRow row = e.Row;
            if (row.IsNewRow) return; // Bỏ qua dòng mẫu
            try
            {
                string query = BuildInsertQuery(row);
                databaseHelper.ExecuteNonQuery(query);
                Debug.WriteLine("Tự động lưu: Thêm mới thành công");
            }
            catch (Exception ex)
            {
                HandleException("Lỗi khi thêm dữ liệu", ex);
                // Refresh lại DataGridView để hiện thị dữ liệu ban đầu
                LoadData();
            }
        }

        private void dataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            // Sự kiện này xảy ra khi người dùng xóa dòng
            DataGridViewRow row = e.Row;
            if (row.IsNewRow) return;
            try
            {
                // Lấy thông tin dòng cần xóa
                object primaryKey = GetPrimaryKey(row);
                if (primaryKey == null)
                {
                    Debug.WriteLine("Tự động lưu: Lỗi primaryKey bằng null");
                    return;
                }
                string query = $"DELETE FROM {tableName} WHERE {dataGridView1.Columns[0].Name} = {primaryKey}";
                databaseHelper.ExecuteNonQuery(query);
                Debug.WriteLine("Tự động lưu: Xóa thành công");
            }
            catch (Exception ex)
            {
                HandleException("Lỗi khi xóa dữ liệu", ex);
                // Refresh lại DataGridView để hiện thị dữ liệu ban đầu
                LoadData();
            }
        }

        private void btnLuuDuLieu_Click(object sender, EventArgs e)
        {
            try
            {
                // Thực hiện load lại dữ liệu
                LoadData();
                Debug.WriteLine("Lưu thủ công: Đồng bộ thành công");
                MessageBox.Show("Đồng bộ dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                HandleException("Lỗi đồng bộ dữ liệu", ex);
                LoadData();
            }
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                LoadData();
                return;
            }

            try
            {
                string query = $"SELECT * FROM {tableName} WHERE ";
                string whereClause = "";
                // Xây dựng điều kiện WHERE, ở đây mình sẽ tìm kiếm ở tất cả các cột. Bạn có thể sửa lại theo yêu cầu
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    string columnName = dataGridView1.Columns[i].Name;
                    if (dataGridView1.Columns[i].ValueType == typeof(string))
                    {
                        whereClause += $"{columnName} LIKE '%{keyword}%' OR ";
                    }
                    else if (dataGridView1.Columns[i].ValueType == typeof(int))
                    {
                        int number;
                        if (int.TryParse(keyword, out number))
                        {
                            whereClause += $"{columnName} = {number} OR ";
                        }
                    }
                    else if (dataGridView1.Columns[i].ValueType == typeof(decimal) || dataGridView1.Columns[i].ValueType == typeof(double))
                    {
                        decimal number;
                        if (decimal.TryParse(keyword, out number))
                        {
                            whereClause += $"{columnName} = {number} OR ";
                        }
                    }
                }
                whereClause = whereClause.TrimEnd("OR ".ToCharArray());
                query += whereClause;
                DataTable dataTable = databaseHelper.ExecuteQuery(query);
                dataGridView1.DataSource = dataTable;
                // In đậm và chọn dòng đầu tiên
                HighlightSearchResults(keyword);
            }
            catch (Exception ex)
            {
                HandleException("Lỗi khi tìm kiếm dữ liệu", ex);
            }
        }
        private void HighlightSearchResults(string keyword)
        {
            if (dataGridView1.Rows.Count == 0) return;
            // Đặt lại style cho tất cả các ô
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Style.Font = new Font(dataGridView1.Font, FontStyle.Regular);
                }
            }

            DataGridViewRow firstMatchRow = null;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().Contains(keyword, StringComparison.OrdinalIgnoreCase))
                    {
                        cell.Style.Font = new Font(dataGridView1.Font, FontStyle.Bold);
                        if (firstMatchRow == null)
                        {
                            firstMatchRow = row;
                        }
                    }
                }
            }
            // Chọn dòng đầu tiên
            if (firstMatchRow != null)
            {
                if (firstMatchRow.Cells.Count > 0)
                {
                    dataGridView1.CurrentCell = firstMatchRow.Cells[0]; // Chọn ô đầu tiên
                    if (dataGridView1.CurrentCell != null)
                        dataGridView1.FirstDisplayedScrollingRowIndex = firstMatchRow.Index; // Kéo thanh cuộn nếu cần
                }
            }
        }
        private void menuBaoCaoTongQuan_Click(object sender, EventArgs e)
        {

        }

        private void menuThongKeDiem_Click(object sender, EventArgs e)
        {

        }
        private void menuBieuDoDiem_Click(object sender, EventArgs e)
        {

        }
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            // Lấy DataTable
            DataTable dataTable = (DataTable)dataGridView1.DataSource;
            // In dữ liệu ra console để kiểm tra
            if (dataTable != null)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    foreach (DataColumn column in dataTable.Columns)
                    {
                        Console.WriteLine($"{column.ColumnName}: {row[column]}");
                    }
                    Console.WriteLine("-----");
                }
            }
            // Kiểm tra xem form đã được tạo chưa
            if (formBaoCao == null || formBaoCao.IsDisposed)
            {
                // Tạo mới form nếu chưa có hoặc đã đóng
                formBaoCao = new FormBaoCao(dataTable);
                formBaoCao.Show(); // Hiển thị form
            }
            else
            {
                // Hiển thị form đã có
                formBaoCao.Activate();
            }
        }
        private string BuildUpdateQuery(DataGridViewRow row, object primaryKey)
        {
            // Ví dụ, đây là cách xây dựng câu update, bạn cần chỉnh sửa lại theo cấu trúc bảng của bạn
            string query = $"UPDATE {tableName} SET ";
            string setClause = "";
            foreach (DataGridViewCell cell in row.Cells)
            {
                if (cell.OwningColumn.Name != dataGridView1.Columns[0].Name)
                { // bỏ qua cột khóa chính
                    setClause += $"{cell.OwningColumn.Name} = '{cell.Value}', ";
                }
            }
            setClause = setClause.TrimEnd(',', ' ');
            query += setClause + $" WHERE {dataGridView1.Columns[0].Name} = {primaryKey}";
            return query;
        }
        private string BuildInsertQuery(DataGridViewRow row)
        {
            // Ví dụ, đây là cách xây dựng câu insert, bạn cần chỉnh sửa lại theo cấu trúc bảng của bạn
            string query = $"INSERT INTO {tableName} (";
            string columns = "";
            string values = "";
            foreach (DataGridViewCell cell in row.Cells)
            {
                if (cell.OwningColumn.Name != dataGridView1.Columns[0].Name)
                { // bỏ qua cột khóa chính
                    columns += $"{cell.OwningColumn.Name}, ";
                    values += $"'{cell.Value}', ";
                }
            }
            columns = columns.TrimEnd(',', ' ');
            values = values.TrimEnd(',', ' ');
            query += columns + ") VALUES (" + values + ")";
            return query;
        }
        private object GetPrimaryKey(DataGridViewRow row)
        {
            // Lấy giá trị của cột khóa chính để update hoặc xóa
            if (row == null)
                return null;

            if (row.Cells[dataGridView1.Columns[0].Name] == null)
                return null;

            return row.Cells[dataGridView1.Columns[0].Name].Value; //Thay 'PrimaryKeyColumn' bằng tên cột khóa chính
        }
        private void HandleException(string message, Exception ex)
        {
            string errorMessage = message + ": " + ex.Message;
            if (ex.InnerException != null)
            {
                errorMessage += "\nInner Exception: " + ex.InnerException.Message;
            }
            MessageBox.Show(errorMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            // Log error message vào file log nếu cần
            Console.WriteLine(errorMessage);
            Debug.WriteLine(errorMessage);
        }

        private void btnNhapLai_Click_1(object sender, EventArgs e)
        {
            txtTimKiem.Text = string.Empty;
        }


        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ẩn FormMain
            FormDangNhap formDangNhap = new FormDangNhap();
            formDangNhap.FormClosed += (s, args) => Application.Exit(); //Đóng app khi formDangNhap đóng
            formDangNhap.Show(); // Hiển thị lại Form đăng nhập
        }


    }
}