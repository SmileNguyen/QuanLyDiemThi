using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace QuanLyDiemThi
{
    public class DatabaseHelper
    {
        // Chuỗi kết nối đến SQL Server
        private string connectionString = "Server=Yuuko_Laptop\\SQLEXPRESS;Initial Catalog=LapTrinhNet_TaiKhoan;Integrated Security=True;Trust Server Certificate=True;";

        // Phương thức thực thi câu lệnh SQL trả về dữ liệu (SELECT)
        public DataTable ExecuteQuery(string query)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                return dataTable;
            }
        }

        // Phương thức thực thi câu lệnh SQL không trả về dữ liệu (INSERT, UPDATE, DELETE)
        public void ExecuteNonQuery(string query)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
        }

        // Phương thức thực thi câu lệnh SQL với tham số (để tránh SQL Injection)
        public void ExecuteNonQueryWithParams(string query, SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddRange(parameters);
                cmd.ExecuteNonQuery();
            }
        }

        // Phương thức thực thi câu lệnh SQL trả về giá trị đơn (thường dùng với COUNT, SUM, v.v.)
        public object ExecuteScalar(string query)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                return cmd.ExecuteScalar();
            }
        }

        // Phương thức thực thi câu lệnh SQL trả về dữ liệu với tham số (SELECT)
        public DataTable ExecuteQueryWithParams(string query, SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                dataAdapter.SelectCommand.Parameters.AddRange(parameters);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                return dataTable;
            }
        }
    }
}