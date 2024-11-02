namespace Nhom_1_DotNet
{
    partial class Formdemo
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
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtGVHD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.khoaTableAdapter = new Nhom_1_DotNet.Nhom1_dotnetDataSetOfficalTableAdapters.KhoaTableAdapter();
            this.khoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhom1dotnetDataSetOfficalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhom1_dotnetDataSetOffical = new Nhom_1_DotNet.Nhom1_dotnetDataSetOffical();
            this.cboKhoa = new System.Windows.Forms.ComboBox();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.linhVucTableAdapter = new Nhom_1_DotNet.Nhom1_dotnetDataSetOfficalTableAdapters.LinhVucTableAdapter();
            this.btnDangki = new System.Windows.Forms.Button();
            this.linhVucBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboLinhVuc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.txtTenDeTai = new System.Windows.Forms.TextBox();
            this.lblTenDeTai = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhom1dotnetDataSetOfficalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhom1_dotnetDataSetOffical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linhVucBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(564, 399);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 26;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // txtGVHD
            // 
            this.txtGVHD.Location = new System.Drawing.Point(314, 345);
            this.txtGVHD.Name = "txtGVHD";
            this.txtGVHD.Size = new System.Drawing.Size(296, 22);
            this.txtGVHD.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Giảng viên hướng dẫn";
            // 
            // khoaTableAdapter
            // 
            this.khoaTableAdapter.ClearBeforeFill = true;
            // 
            // khoaBindingSource
            // 
            this.khoaBindingSource.DataMember = "Khoa";
            this.khoaBindingSource.DataSource = this.nhom1dotnetDataSetOfficalBindingSource;
            // 
            // nhom1dotnetDataSetOfficalBindingSource
            // 
            this.nhom1dotnetDataSetOfficalBindingSource.DataSource = this.nhom1_dotnetDataSetOffical;
            this.nhom1dotnetDataSetOfficalBindingSource.Position = 0;
            // 
            // nhom1_dotnetDataSetOffical
            // 
            this.nhom1_dotnetDataSetOffical.DataSetName = "Nhom1_dotnetDataSetOffical";
            this.nhom1_dotnetDataSetOffical.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cboKhoa
            // 
            this.cboKhoa.DataSource = this.khoaBindingSource;
            this.cboKhoa.DisplayMember = "TENKHOA";
            this.cboKhoa.FormattingEnabled = true;
            this.cboKhoa.Location = new System.Drawing.Point(283, 284);
            this.cboKhoa.Name = "cboKhoa";
            this.cboKhoa.Size = new System.Drawing.Size(293, 24);
            this.cboKhoa.TabIndex = 22;
            this.cboKhoa.ValueMember = "MAKHOA";
            // 
            // lblKhoa
            // 
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Location = new System.Drawing.Point(165, 292);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(38, 16);
            this.lblKhoa.TabIndex = 21;
            this.lblKhoa.Text = "Khoa";
            // 
            // linhVucTableAdapter
            // 
            this.linhVucTableAdapter.ClearBeforeFill = true;
            // 
            // btnDangki
            // 
            this.btnDangki.Location = new System.Drawing.Point(451, 399);
            this.btnDangki.Name = "btnDangki";
            this.btnDangki.Size = new System.Drawing.Size(75, 23);
            this.btnDangki.TabIndex = 25;
            this.btnDangki.Text = "Đăng kí";
            this.btnDangki.UseVisualStyleBackColor = true;
            // 
            // linhVucBindingSource
            // 
            this.linhVucBindingSource.DataMember = "LinhVuc";
            this.linhVucBindingSource.DataSource = this.nhom1dotnetDataSetOfficalBindingSource;
            // 
            // cboLinhVuc
            // 
            this.cboLinhVuc.DataSource = this.linhVucBindingSource;
            this.cboLinhVuc.DisplayMember = "TENLINHVUC";
            this.cboLinhVuc.FormattingEnabled = true;
            this.cboLinhVuc.Location = new System.Drawing.Point(283, 224);
            this.cboLinhVuc.Name = "cboLinhVuc";
            this.cboLinhVuc.Size = new System.Drawing.Size(293, 24);
            this.cboLinhVuc.TabIndex = 20;
            this.cboLinhVuc.ValueMember = "MALINHVUC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Lĩnh vực";
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(283, 124);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(296, 65);
            this.txtMoTa.TabIndex = 18;
            // 
            // lblMoTa
            // 
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Location = new System.Drawing.Point(165, 130);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(40, 16);
            this.lblMoTa.TabIndex = 17;
            this.lblMoTa.Text = "Mô tả";
            // 
            // txtTenDeTai
            // 
            this.txtTenDeTai.Location = new System.Drawing.Point(283, 77);
            this.txtTenDeTai.Name = "txtTenDeTai";
            this.txtTenDeTai.Size = new System.Drawing.Size(296, 22);
            this.txtTenDeTai.TabIndex = 16;
            // 
            // lblTenDeTai
            // 
            this.lblTenDeTai.AutoSize = true;
            this.lblTenDeTai.Location = new System.Drawing.Point(165, 83);
            this.lblTenDeTai.Name = "lblTenDeTai";
            this.lblTenDeTai.Size = new System.Drawing.Size(67, 16);
            this.lblTenDeTai.TabIndex = 15;
            this.lblTenDeTai.Text = "Tên đề tài";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(451, 29);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(128, 16);
            this.lblTitle.TabIndex = 14;
            this.lblTitle.Text = "Đăng kí đề tài NCKH";
            // 
            // Formdemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.txtGVHD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboKhoa);
            this.Controls.Add(this.lblKhoa);
            this.Controls.Add(this.btnDangki);
            this.Controls.Add(this.cboLinhVuc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.lblMoTa);
            this.Controls.Add(this.txtTenDeTai);
            this.Controls.Add(this.lblTenDeTai);
            this.Controls.Add(this.lblTitle);
            this.Name = "Formdemo";
            this.Text = "Formdemo";
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhom1dotnetDataSetOfficalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhom1_dotnetDataSetOffical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linhVucBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtGVHD;
        private System.Windows.Forms.Label label3;
        private Nhom1_dotnetDataSetOfficalTableAdapters.KhoaTableAdapter khoaTableAdapter;
        private System.Windows.Forms.BindingSource khoaBindingSource;
        private System.Windows.Forms.BindingSource nhom1dotnetDataSetOfficalBindingSource;
        private Nhom1_dotnetDataSetOffical nhom1_dotnetDataSetOffical;
        private System.Windows.Forms.ComboBox cboKhoa;
        private System.Windows.Forms.Label lblKhoa;
        private Nhom1_dotnetDataSetOfficalTableAdapters.LinhVucTableAdapter linhVucTableAdapter;
        private System.Windows.Forms.Button btnDangki;
        private System.Windows.Forms.BindingSource linhVucBindingSource;
        private System.Windows.Forms.ComboBox cboLinhVuc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.TextBox txtTenDeTai;
        private System.Windows.Forms.Label lblTenDeTai;
        private System.Windows.Forms.Label lblTitle;
    }
}