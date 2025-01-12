using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanLyDiemThi
{
    public partial class FormBaoCao : Form
    {
        private DataTable dataTable;
        public FormBaoCao(DataTable data)
        {
            InitializeComponent();
            dataTable = data;

        }
        private void FormBaoCao_Load(object sender, EventArgs e)
        {
            // Hiển thị báo cáo tổng quan
            HienThiBaoCaoTongQuan();

            // Hiển thị thống kê điểm
            HienThiThongKeDiem();
            // Hiển thị biểu đồ điểm
            HienThiBieuDoDiem();
        }
        private void HienThiBaoCaoTongQuan()
        {
            if (dataTable != null)
            {
                lblTongSoHocSinh.Text = $"Tổng số học sinh: {dataTable.Rows.Count}";
                // Tính tổng số môn học (đếm số môn học khác nhau)
                var monHoc = dataTable.AsEnumerable().Select(x => x.Field<string>("TenMonHoc")).Distinct().Count();
                lblTongSoMonHoc.Text = $"Tổng số môn học: {monHoc}";

                lblTongSoBaiThi.Text = $"Tổng số bài thi: {dataTable.Rows.Count}";
            }
        }

        private void HienThiThongKeDiem()
        {
            if (dataTable != null)
            {
                var diemTrungBinh = dataTable.AsEnumerable().GroupBy(x => x.Field<string>("TenMonHoc")).Select(g => new
                {
                    MonHoc = g.Key,
                    DiemTrungBinh = g.Average(x => x.Field<decimal>("DiemThiTongKet"))
                }).ToList();
                if (diemTrungBinh.Count > 0)
                {
                    dataGridViewThongKeDiem.DataSource = ToDataTable(diemTrungBinh);
                    dataGridViewThongKeDiem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
        }
        private void HienThiBieuDoDiem()
        {
            if (dataTable != null)
            {
                // Tính điểm trung bình của từng môn học
                var diemTrungBinh = dataTable.AsEnumerable().GroupBy(x => x.Field<string>("TenMonHoc")).Select(g => new
                {
                    MonHoc = g.Key,
                    DiemTrungBinh = g.Average(x => x.Field<decimal>("DiemThiTongKet"))
                }).ToList();
                // Tạo biểu đồ cột
                chartBieuDoDiem.ChartAreas.Clear();
                chartBieuDoDiem.Series.Clear();
                ChartArea chartArea = new ChartArea("ChartArea");
                chartBieuDoDiem.ChartAreas.Add(chartArea);

                Series series = new Series("DiemTrungBinh");
                series.ChartType = SeriesChartType.Column;
                series.XValueMember = "MonHoc";
                series.YValueMembers = "DiemTrungBinh";

                chartBieuDoDiem.Series.Add(series);
                chartBieuDoDiem.DataSource = diemTrungBinh;
            }

        }


        private DataTable ToDataTable<T>(System.Collections.Generic.List<T> data)
        {
            // Tạo DataTable từ List
            System.ComponentModel.PropertyDescriptorCollection props = System.ComponentModel.TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            for (int i = 0; i < props.Count; i++)
            {
                System.ComponentModel.PropertyDescriptor prop = props[i];
                table.Columns.Add(prop.Name, prop.PropertyType);
            }
            object[] values = new object[props.Count];
            foreach (T item in data)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = props[i].GetValue(item);
                }
                table.Rows.Add(values);
            }
            return table;
        }
    }
}