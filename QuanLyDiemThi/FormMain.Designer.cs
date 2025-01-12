namespace QuanLyDiemThi
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            GroupBox groupBox2;
            btnXoaDuLieu = new Button();
            btnThemDuLieu = new Button();
            btnSuaDuLieu = new Button();
            btnLuuDuLieu = new Button();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            accountToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            databaseHelperBindingSource5 = new BindingSource(components);
            databaseHelperBindingSource3 = new BindingSource(components);
            databaseHelperBindingSource2 = new BindingSource(components);
            databaseHelperBindingSource1 = new BindingSource(components);
            databaseHelperBindingSource = new BindingSource(components);
            databaseHelperBindingSource4 = new BindingSource(components);
            databaseHelperBindingSource6 = new BindingSource(components);
            txtTimKiem = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            btnTimKiem = new Button();
            btnThoat = new Button();
            groupBox1 = new GroupBox();
            btnNhapLai = new Button();
            groupBox3 = new GroupBox();
            btnThongKe = new Button();
            btnDangXuat = new Button();
            groupBox2 = new GroupBox();
            groupBox2.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)databaseHelperBindingSource5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)databaseHelperBindingSource3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)databaseHelperBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)databaseHelperBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)databaseHelperBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)databaseHelperBindingSource4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)databaseHelperBindingSource6).BeginInit();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnXoaDuLieu);
            groupBox2.Controls.Add(btnThemDuLieu);
            groupBox2.Controls.Add(btnSuaDuLieu);
            groupBox2.Controls.Add(btnLuuDuLieu);
            groupBox2.Location = new Point(1027, 115);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(235, 87);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tính Năng";
            // 
            // btnXoaDuLieu
            // 
            btnXoaDuLieu.Location = new Point(120, 53);
            btnXoaDuLieu.Name = "btnXoaDuLieu";
            btnXoaDuLieu.Size = new Size(109, 25);
            btnXoaDuLieu.TabIndex = 5;
            btnXoaDuLieu.Text = "Xóa Dữ Liệu";
            btnXoaDuLieu.UseVisualStyleBackColor = true;
            // 
            // btnThemDuLieu
            // 
            btnThemDuLieu.Location = new Point(6, 53);
            btnThemDuLieu.Name = "btnThemDuLieu";
            btnThemDuLieu.Size = new Size(109, 25);
            btnThemDuLieu.TabIndex = 4;
            btnThemDuLieu.Text = "Thêm Dữ Liệu";
            btnThemDuLieu.UseVisualStyleBackColor = true;
            // 
            // btnSuaDuLieu
            // 
            btnSuaDuLieu.Location = new Point(120, 22);
            btnSuaDuLieu.Name = "btnSuaDuLieu";
            btnSuaDuLieu.Size = new Size(109, 25);
            btnSuaDuLieu.TabIndex = 3;
            btnSuaDuLieu.Text = "Sửa Dữ Liệu";
            btnSuaDuLieu.UseVisualStyleBackColor = true;
            // 
            // btnLuuDuLieu
            // 
            btnLuuDuLieu.Location = new Point(6, 22);
            btnLuuDuLieu.Name = "btnLuuDuLieu";
            btnLuuDuLieu.Size = new Size(109, 25);
            btnLuuDuLieu.TabIndex = 2;
            btnLuuDuLieu.Text = "Lưu Dữ Liệu";
            btnLuuDuLieu.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, accountToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1264, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, saveToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(103, 22);
            newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(103, 22);
            openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(103, 22);
            saveToolStripMenuItem.Text = "Save";
            // 
            // accountToolStripMenuItem
            // 
            accountToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { logoutToolStripMenuItem, exitToolStripMenuItem });
            accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            accountToolStripMenuItem.Size = new Size(64, 20);
            accountToolStripMenuItem.Text = "Account";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(180, 22);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(180, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 24);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1024, 657);
            dataGridView1.TabIndex = 1;
            // 
            // databaseHelperBindingSource5
            // 
            databaseHelperBindingSource5.DataSource = typeof(DatabaseHelper);
            // 
            // databaseHelperBindingSource3
            // 
            databaseHelperBindingSource3.DataSource = typeof(DatabaseHelper);
            // 
            // databaseHelperBindingSource2
            // 
            databaseHelperBindingSource2.DataSource = typeof(DatabaseHelper);
            // 
            // databaseHelperBindingSource1
            // 
            databaseHelperBindingSource1.DataSource = typeof(DatabaseHelper);
            // 
            // databaseHelperBindingSource
            // 
            databaseHelperBindingSource.DataSource = typeof(DatabaseHelper);
            // 
            // databaseHelperBindingSource4
            // 
            databaseHelperBindingSource4.DataSource = typeof(DatabaseHelper);
            // 
            // databaseHelperBindingSource6
            // 
            databaseHelperBindingSource6.DataSource = typeof(DatabaseHelper);
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(4, 22);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(224, 23);
            txtTimKiem.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(115, 51);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(110, 23);
            btnTimKiem.TabIndex = 5;
            btnTimKiem.Text = "Tìm Kiếm Dữ Liệu";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.Salmon;
            btnThoat.Location = new Point(153, 71);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(75, 23);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnNhapLai);
            groupBox1.Controls.Add(txtTimKiem);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Location = new Point(1026, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(236, 84);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm Kiếm";
            // 
            // btnNhapLai
            // 
            btnNhapLai.Location = new Point(7, 51);
            btnNhapLai.Name = "btnNhapLai";
            btnNhapLai.Size = new Size(75, 23);
            btnNhapLai.TabIndex = 6;
            btnNhapLai.Text = "Nhập Lại";
            btnNhapLai.UseVisualStyleBackColor = true;
            btnNhapLai.Click += btnNhapLai_Click_1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnThongKe);
            groupBox3.Controls.Add(btnDangXuat);
            groupBox3.Controls.Add(btnThoat);
            groupBox3.Location = new Point(1028, 207);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(234, 100);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Hệ Thống";
            // 
            // btnThongKe
            // 
            btnThongKe.BackColor = Color.Aquamarine;
            btnThongKe.Location = new Point(5, 22);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(75, 23);
            btnThongKe.TabIndex = 8;
            btnThongKe.Text = "Thống Kê";
            btnThongKe.UseVisualStyleBackColor = false;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // btnDangXuat
            // 
            btnDangXuat.BackColor = Color.Khaki;
            btnDangXuat.Location = new Point(153, 42);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(75, 23);
            btnDangXuat.TabIndex = 7;
            btnDangXuat.Text = "Đăng xuất";
            btnDangXuat.UseVisualStyleBackColor = false;
            btnDangXuat.Click += btnDangXuat_Click_1;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1264, 681);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý điểm thi";
            Load += FormMain_Load;
            groupBox2.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)databaseHelperBindingSource5).EndInit();
            ((System.ComponentModel.ISupportInitialize)databaseHelperBindingSource3).EndInit();
            ((System.ComponentModel.ISupportInitialize)databaseHelperBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)databaseHelperBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)databaseHelperBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)databaseHelperBindingSource4).EndInit();
            ((System.ComponentModel.ISupportInitialize)databaseHelperBindingSource6).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem accountToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private DataGridView dataGridView1;
        private BindingSource databaseHelperBindingSource1;
        private BindingSource databaseHelperBindingSource;
        private BindingSource databaseHelperBindingSource2;
        private BindingSource databaseHelperBindingSource3;
        private BindingSource databaseHelperBindingSource4;
        private BindingSource databaseHelperBindingSource5;
        private BindingSource databaseHelperBindingSource6;
        private Button btnLuuDuLieu;
        private TextBox txtTimKiem;
        private ContextMenuStrip contextMenuStrip1;
        private Button btnTimKiem;
        private Button btnThoat;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private Button btnDangXuat;
        private Button btnSuaDuLieu;
        private Button btnXoaDuLieu;
        private Button btnThemDuLieu;
        private Button btnNhapLai;
        private Button btnThongKe;
    }
}