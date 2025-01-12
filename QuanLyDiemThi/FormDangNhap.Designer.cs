namespace QuanLyDiemThi
{
    partial class FormDangNhap
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
            pictureBox1 = new PictureBox();
            txtTenDangNhap = new TextBox();
            txtMatKhau = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            btnlogin = new Button();
            btnxoa = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.login_icon_13;
            pictureBox1.Location = new Point(12, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(105, 106);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(213, 26);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(159, 23);
            txtTenDangNhap.TabIndex = 1;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(213, 61);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(159, 23);
            txtMatKhau.TabIndex = 2;
            txtMatKhau.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(121, 29);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 3;
            label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(150, 64);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 4;
            label2.Text = "Mật khẩu";
            // 
            // button1
            // 
            button1.BackColor = Color.Salmon;
            button1.Location = new Point(306, 135);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Thoát";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnlogin
            // 
            btnlogin.Location = new Point(213, 90);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(103, 28);
            btnlogin.TabIndex = 6;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = true;
            btnlogin.Click += btnlogin_Click;
            // 
            // btnxoa
            // 
            btnxoa.Location = new Point(322, 90);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(50, 28);
            btnxoa.TabIndex = 7;
            btnxoa.Text = "Xóa";
            btnxoa.UseVisualStyleBackColor = true;
            btnxoa.Click += btnxoa_Click;
            // 
            // FormDangNhap
            // 
            AcceptButton = btnlogin;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(384, 161);
            Controls.Add(btnxoa);
            Controls.Add(btnlogin);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTenDangNhap);
            Controls.Add(pictureBox1);
            Name = "FormDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormDangNhap";
            Load += FormDangNhap_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtTenDangNhap;
        private TextBox txtMatKhau;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button btnlogin;
        private Button btnxoa;
    }
}