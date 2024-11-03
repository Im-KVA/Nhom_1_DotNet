namespace Nhom_1_DotNet
{
    partial class FrmGVHD
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
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.đăgnKíĐềTàiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCapNhat = new System.Windows.Forms.ToolStripMenuItem();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblMaGV = new System.Windows.Forms.Label();
            this.btnDoiMk = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnDangxuat = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.lblTitle.Location = new System.Drawing.Point(274, 43);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(324, 41);
            this.lblTitle.TabIndex = 15;
            this.lblTitle.Text = "Thông Tin Giảng Viên";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblPhone.Location = new System.Drawing.Point(100, 303);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(132, 28);
            this.lblPhone.TabIndex = 13;
            this.lblPhone.Text = "Số điện thoại:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblGender.Location = new System.Drawing.Point(100, 263);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(91, 28);
            this.lblGender.TabIndex = 12;
            this.lblGender.Text = "Giới tính:";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblBirthDate.Location = new System.Drawing.Point(100, 223);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(103, 28);
            this.lblBirthDate.TabIndex = 11;
            this.lblBirthDate.Text = "Ngày sinh:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblName.Location = new System.Drawing.Point(100, 143);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(141, 28);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "Tên giảng viên:";
            this.toolTip1.SetToolTip(this.lblName, "Enter the student\'s full name");
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăgnKíĐềTàiToolStripMenuItem,
            this.tìmKiếmToolStripMenuItem,
            this.lblCapNhat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(815, 28);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // đăgnKíĐềTàiToolStripMenuItem
            // 
            this.đăgnKíĐềTàiToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.đăgnKíĐềTàiToolStripMenuItem.Name = "đăgnKíĐềTàiToolStripMenuItem";
            this.đăgnKíĐềTàiToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.đăgnKíĐềTàiToolStripMenuItem.Text = "Đăng ký đề tài";
            this.đăgnKíĐềTàiToolStripMenuItem.Click += new System.EventHandler(this.đăgnKíĐềTàiToolStripMenuItem_Click);
            // 
            // tìmKiếmToolStripMenuItem
            // 
            this.tìmKiếmToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.tìmKiếmToolStripMenuItem.Name = "tìmKiếmToolStripMenuItem";
            this.tìmKiếmToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.tìmKiếmToolStripMenuItem.Text = "Tìm kiếm";
            this.tìmKiếmToolStripMenuItem.Click += new System.EventHandler(this.tìmKiếmToolStripMenuItem_Click);
            // 
            // lblCapNhat
            // 
            this.lblCapNhat.ForeColor = System.Drawing.Color.White;
            this.lblCapNhat.Name = "lblCapNhat";
            this.lblCapNhat.Size = new System.Drawing.Size(124, 24);
            this.lblCapNhat.Text = "Cập nhật đề tài";
            this.lblCapNhat.Click += new System.EventHandler(this.lblCapNhat_Click);
            // 
            // lblKhoa
            // 
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblKhoa.Location = new System.Drawing.Point(100, 183);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(61, 28);
            this.lblKhoa.TabIndex = 19;
            this.lblKhoa.Text = "Khoa:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblEmail.Location = new System.Drawing.Point(100, 343);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(63, 28);
            this.lblEmail.TabIndex = 18;
            this.lblEmail.Text = "Email:";
            // 
            // lblMaGV
            // 
            this.lblMaGV.AutoSize = true;
            this.lblMaGV.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblMaGV.Location = new System.Drawing.Point(100, 103);
            this.lblMaGV.Name = "lblMaGV";
            this.lblMaGV.Size = new System.Drawing.Size(140, 28);
            this.lblMaGV.TabIndex = 17;
            this.lblMaGV.Text = "Mã giảng viên:";
            this.toolTip1.SetToolTip(this.lblMaGV, "Enter the student ID");
            // 
            // btnDoiMk
            // 
            this.btnDoiMk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnDoiMk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoiMk.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDoiMk.ForeColor = System.Drawing.Color.White;
            this.btnDoiMk.Location = new System.Drawing.Point(240, 403);
            this.btnDoiMk.Name = "btnDoiMk";
            this.btnDoiMk.Size = new System.Drawing.Size(180, 45);
            this.btnDoiMk.TabIndex = 16;
            this.btnDoiMk.Text = "Đổi Mật Khẩu";
            this.toolTip1.SetToolTip(this.btnDoiMk, "Change your password");
            this.btnDoiMk.UseVisualStyleBackColor = false;
            this.btnDoiMk.Click += new System.EventHandler(this.btnDoiMk_Click);
            // 
            // btnDangxuat
            // 
            this.btnDangxuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnDangxuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangxuat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDangxuat.ForeColor = System.Drawing.Color.White;
            this.btnDangxuat.Location = new System.Drawing.Point(439, 403);
            this.btnDangxuat.Name = "btnDangxuat";
            this.btnDangxuat.Size = new System.Drawing.Size(180, 45);
            this.btnDangxuat.TabIndex = 20;
            this.btnDangxuat.Text = "Đăng xuất";
            this.toolTip1.SetToolTip(this.btnDangxuat, "Change your password");
            this.btnDangxuat.UseVisualStyleBackColor = false;
            this.btnDangxuat.Click += new System.EventHandler(this.btnDangxuat_Click);
            // 
            // FrmGVHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 473);
            this.Controls.Add(this.btnDangxuat);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblKhoa);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblMaGV);
            this.Controls.Add(this.btnDoiMk);
            this.Name = "FrmGVHD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGVHD";
            this.Load += new System.EventHandler(this.FrmGVHD_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem đăgnKíĐềTàiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lblCapNhat;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblMaGV;
        private System.Windows.Forms.Button btnDoiMk;
        private System.Windows.Forms.Button btnDangxuat;
    }
}