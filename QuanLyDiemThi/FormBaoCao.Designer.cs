namespace QuanLyDiemThi
{
    partial class FormBaoCao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            tabControlBaoCao = new TabControl();
            tabPageTongQuan = new TabPage();
            lblTongSoBaiThi = new Label();
            lblTongSoMonHoc = new Label();
            lblTongSoHocSinh = new Label();
            tabPageThongKeDiem = new TabPage();
            dataGridViewThongKeDiem = new DataGridView();
            tabPageBieuDoDiem = new TabPage();
            chartBieuDoDiem = new System.Windows.Forms.DataVisualization.Charting.Chart();
            tabControlBaoCao.SuspendLayout();
            tabPageTongQuan.SuspendLayout();
            tabPageThongKeDiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewThongKeDiem).BeginInit();
            tabPageBieuDoDiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartBieuDoDiem).BeginInit();
            SuspendLayout();
            // 
            // tabControlBaoCao
            // 
            tabControlBaoCao.Controls.Add(tabPageTongQuan);
            tabControlBaoCao.Controls.Add(tabPageThongKeDiem);
            tabControlBaoCao.Controls.Add(tabPageBieuDoDiem);
            tabControlBaoCao.Location = new Point(12, 12);
            tabControlBaoCao.Name = "tabControlBaoCao";
            tabControlBaoCao.SelectedIndex = 0;
            tabControlBaoCao.Size = new Size(650, 350);
            tabControlBaoCao.TabIndex = 0;
            // 
            // tabPageTongQuan
            // 
            tabPageTongQuan.Controls.Add(lblTongSoBaiThi);
            tabPageTongQuan.Controls.Add(lblTongSoMonHoc);
            tabPageTongQuan.Controls.Add(lblTongSoHocSinh);
            tabPageTongQuan.Location = new Point(4, 24);
            tabPageTongQuan.Name = "tabPageTongQuan";
            tabPageTongQuan.Padding = new Padding(3);
            tabPageTongQuan.Size = new Size(642, 322);
            tabPageTongQuan.TabIndex = 0;
            tabPageTongQuan.Text = "Tổng Quan";
            tabPageTongQuan.UseVisualStyleBackColor = true;
            // 
            // lblTongSoBaiThi
            // 
            lblTongSoBaiThi.AutoSize = true;
            lblTongSoBaiThi.Font = new Font("Segoe UI", 26.25F);
            lblTongSoBaiThi.Location = new Point(6, 194);
            lblTongSoBaiThi.Name = "lblTongSoBaiThi";
            lblTongSoBaiThi.Size = new Size(261, 47);
            lblTongSoBaiThi.TabIndex = 3;
            lblTongSoBaiThi.Text = "Tổng số bài thi:";
            // 
            // lblTongSoMonHoc
            // 
            lblTongSoMonHoc.AutoSize = true;
            lblTongSoMonHoc.Font = new Font("Segoe UI", 26.25F);
            lblTongSoMonHoc.Location = new Point(6, 127);
            lblTongSoMonHoc.Name = "lblTongSoMonHoc";
            lblTongSoMonHoc.Size = new Size(302, 47);
            lblTongSoMonHoc.TabIndex = 2;
            lblTongSoMonHoc.Text = "Tổng số môn học:";
            // 
            // lblTongSoHocSinh
            // 
            lblTongSoHocSinh.AutoSize = true;
            lblTongSoHocSinh.Font = new Font("Segoe UI", 26.25F);
            lblTongSoHocSinh.Location = new Point(6, 60);
            lblTongSoHocSinh.Name = "lblTongSoHocSinh";
            lblTongSoHocSinh.Size = new Size(294, 47);
            lblTongSoHocSinh.TabIndex = 1;
            lblTongSoHocSinh.Text = "Tổng số học sinh:";
            // 
            // tabPageThongKeDiem
            // 
            tabPageThongKeDiem.Controls.Add(dataGridViewThongKeDiem);
            tabPageThongKeDiem.Location = new Point(4, 24);
            tabPageThongKeDiem.Name = "tabPageThongKeDiem";
            tabPageThongKeDiem.Padding = new Padding(3);
            tabPageThongKeDiem.Size = new Size(642, 322);
            tabPageThongKeDiem.TabIndex = 1;
            tabPageThongKeDiem.Text = "Thống Kê Điểm";
            tabPageThongKeDiem.UseVisualStyleBackColor = true;
            // 
            // dataGridViewThongKeDiem
            // 
            dataGridViewThongKeDiem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewThongKeDiem.Location = new Point(6, 6);
            dataGridViewThongKeDiem.Name = "dataGridViewThongKeDiem";
            dataGridViewThongKeDiem.Size = new Size(630, 310);
            dataGridViewThongKeDiem.TabIndex = 0;
            // 
            // tabPageBieuDoDiem
            // 
            tabPageBieuDoDiem.Controls.Add(chartBieuDoDiem);
            tabPageBieuDoDiem.Location = new Point(4, 24);
            tabPageBieuDoDiem.Name = "tabPageBieuDoDiem";
            tabPageBieuDoDiem.Padding = new Padding(3);
            tabPageBieuDoDiem.Size = new Size(642, 322);
            tabPageBieuDoDiem.TabIndex = 2;
            tabPageBieuDoDiem.Text = "Biểu Đồ Điểm";
            tabPageBieuDoDiem.UseVisualStyleBackColor = true;
            // 
            // chartBieuDoDiem
            // 
            chartArea1.Name = "ChartArea1";
            chartBieuDoDiem.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartBieuDoDiem.Legends.Add(legend1);
            chartBieuDoDiem.Location = new Point(6, 6);
            chartBieuDoDiem.Name = "chartBieuDoDiem";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartBieuDoDiem.Series.Add(series1);
            chartBieuDoDiem.Size = new Size(630, 310);
            chartBieuDoDiem.TabIndex = 0;
            chartBieuDoDiem.Text = "chart1";
            // 
            // FormBaoCao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 381);
            Controls.Add(tabControlBaoCao);
            Name = "FormBaoCao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormBaoCao";
            Load += FormBaoCao_Load;
            tabControlBaoCao.ResumeLayout(false);
            tabPageTongQuan.ResumeLayout(false);
            tabPageTongQuan.PerformLayout();
            tabPageThongKeDiem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewThongKeDiem).EndInit();
            tabPageBieuDoDiem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartBieuDoDiem).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlBaoCao;
        private TabPage tabPageTongQuan;
        private TabPage tabPageThongKeDiem;
        private TabPage tabPageBieuDoDiem;
        private Label lblTongSoHocSinh;
        private Label lblTongSoBaiThi;
        private Label lblTongSoMonHoc;
        private DataGridView dataGridViewThongKeDiem;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBieuDoDiem;
    }
}