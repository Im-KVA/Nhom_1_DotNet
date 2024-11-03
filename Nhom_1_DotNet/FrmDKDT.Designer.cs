namespace Nhom_1_DotNet
{
    partial class FrmDKDT
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
            this.lblTenDeTai = new System.Windows.Forms.Label();
            this.txtTenDeTai = new System.Windows.Forms.TextBox();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboLinhVuc = new System.Windows.Forms.ComboBox();
            this.linhVucBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nhom1_dotnetDataSetOffical = new Nhom_1_DotNet.Nhom1_dotnetDataSetOffical();
            this.linhVucBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhom1dotnetDataSetOfficalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.linhVucTableAdapter = new Nhom_1_DotNet.Nhom1_dotnetDataSetOfficalTableAdapters.LinhVucTableAdapter();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.cboKhoa = new System.Windows.Forms.ComboBox();
            this.fKGiangVienMAKHO4D94879BBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khoaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.khoaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.khoaBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.khoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khoaTableAdapter = new Nhom_1_DotNet.Nhom1_dotnetDataSetOfficalTableAdapters.KhoaTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDangki = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.cboMaGV = new System.Windows.Forms.ComboBox();
            this.linhVucBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.fKDeTaiNCKHMALIN59063A47BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deTaiNCKHTableAdapter = new Nhom_1_DotNet.Nhom1_dotnetDataSetOfficalTableAdapters.DeTaiNCKHTableAdapter();
            this.giangVienTableAdapter = new Nhom_1_DotNet.Nhom1_dotnetDataSetOfficalTableAdapters.GiangVienTableAdapter();
            this.giangVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKGiangVienMAKHO4D94879BBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.linhVucBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhom1_dotnetDataSetOffical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linhVucBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhom1dotnetDataSetOfficalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKGiangVienMAKHO4D94879BBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linhVucBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDeTaiNCKHMALIN59063A47BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giangVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKGiangVienMAKHO4D94879BBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblTitle.Location = new System.Drawing.Point(406, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(282, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Đăng kí đề tài NCKH";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // lblTenDeTai
            // 
            this.lblTenDeTai.AutoSize = true;
            this.lblTenDeTai.Font = new System.Drawing.Font("Arial", 10F);
            this.lblTenDeTai.Location = new System.Drawing.Point(208, 85);
            this.lblTenDeTai.Name = "lblTenDeTai";
            this.lblTenDeTai.Size = new System.Drawing.Size(89, 19);
            this.lblTenDeTai.TabIndex = 1;
            this.lblTenDeTai.Text = "Tên Đề Tài";
            // 
            // txtTenDeTai
            // 
            this.txtTenDeTai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenDeTai.Font = new System.Drawing.Font("Arial", 10F);
            this.txtTenDeTai.Location = new System.Drawing.Point(348, 85);
            this.txtTenDeTai.Name = "txtTenDeTai";
            this.txtTenDeTai.Size = new System.Drawing.Size(400, 27);
            this.txtTenDeTai.TabIndex = 2;
            // 
            // txtMoTa
            // 
            this.txtMoTa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMoTa.Font = new System.Drawing.Font("Arial", 10F);
            this.txtMoTa.Location = new System.Drawing.Point(348, 125);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(400, 80);
            this.txtMoTa.TabIndex = 4;
            // 
            // lblMoTa
            // 
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Font = new System.Drawing.Font("Arial", 10F);
            this.lblMoTa.Location = new System.Drawing.Point(208, 125);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(54, 19);
            this.lblMoTa.TabIndex = 3;
            this.lblMoTa.Text = "Mô Tả";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F);
            this.label1.Location = new System.Drawing.Point(208, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Lĩnh Vực";
            // 
            // cboLinhVuc
            // 
            this.cboLinhVuc.DataSource = this.linhVucBindingSource1;
            this.cboLinhVuc.DisplayMember = "TENLINHVUC";
            this.cboLinhVuc.Font = new System.Drawing.Font("Arial", 10F);
            this.cboLinhVuc.FormattingEnabled = true;
            this.cboLinhVuc.Location = new System.Drawing.Point(348, 215);
            this.cboLinhVuc.Name = "cboLinhVuc";
            this.cboLinhVuc.Size = new System.Drawing.Size(400, 27);
            this.cboLinhVuc.TabIndex = 7;
            this.cboLinhVuc.ValueMember = "MALINHVUC";
            // 
            // linhVucBindingSource1
            // 
            this.linhVucBindingSource1.DataMember = "LinhVuc";
            this.linhVucBindingSource1.DataSource = this.nhom1_dotnetDataSetOffical;
            // 
            // nhom1_dotnetDataSetOffical
            // 
            this.nhom1_dotnetDataSetOffical.DataSetName = "Nhom1_dotnetDataSetOffical";
            this.nhom1_dotnetDataSetOffical.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // linhVucTableAdapter
            // 
            this.linhVucTableAdapter.ClearBeforeFill = true;
            // 
            // lblKhoa
            // 
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Font = new System.Drawing.Font("Arial", 10F);
            this.lblKhoa.Location = new System.Drawing.Point(208, 265);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(47, 19);
            this.lblKhoa.TabIndex = 8;
            this.lblKhoa.Text = "Khoa";
            // 
            // cboKhoa
            // 
            this.cboKhoa.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.fKGiangVienMAKHO4D94879BBindingSource, "MAKHOA", true));
            this.cboKhoa.DataSource = this.khoaBindingSource1;
            this.cboKhoa.DisplayMember = "TENKHOA";
            this.cboKhoa.Font = new System.Drawing.Font("Arial", 10F);
            this.cboKhoa.FormattingEnabled = true;
            this.cboKhoa.Location = new System.Drawing.Point(348, 265);
            this.cboKhoa.Name = "cboKhoa";
            this.cboKhoa.Size = new System.Drawing.Size(400, 27);
            this.cboKhoa.TabIndex = 9;
            this.cboKhoa.ValueMember = "MAKHOA";
            this.cboKhoa.SelectedIndexChanged += new System.EventHandler(this.cboKhoa_SelectedIndexChanged);
            // 
            // fKGiangVienMAKHO4D94879BBindingSource
            // 
            this.fKGiangVienMAKHO4D94879BBindingSource.DataMember = "FK__GiangVien__MAKHO__4D94879B";
            this.fKGiangVienMAKHO4D94879BBindingSource.DataSource = this.khoaBindingSource2;
            // 
            // khoaBindingSource2
            // 
            this.khoaBindingSource2.DataMember = "Khoa";
            this.khoaBindingSource2.DataSource = this.nhom1_dotnetDataSetOffical;
            // 
            // khoaBindingSource1
            // 
            this.khoaBindingSource1.DataMember = "Khoa";
            this.khoaBindingSource1.DataSource = this.nhom1_dotnetDataSetOffical;
            // 
            // khoaBindingSource3
            // 
            this.khoaBindingSource3.DataMember = "Khoa";
            this.khoaBindingSource3.DataSource = this.nhom1_dotnetDataSetOffical;
            // 
            // khoaTableAdapter
            // 
            this.khoaTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F);
            this.label3.Location = new System.Drawing.Point(208, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tên GVHD";
            // 
            // btnDangki
            // 
            this.btnDangki.BackColor = System.Drawing.Color.LightGreen;
            this.btnDangki.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnDangki.Location = new System.Drawing.Point(420, 356);
            this.btnDangki.Name = "btnDangki";
            this.btnDangki.Size = new System.Drawing.Size(114, 47);
            this.btnDangki.TabIndex = 12;
            this.btnDangki.Text = "Đăng Ký";
            this.btnDangki.UseVisualStyleBackColor = false;
            this.btnDangki.Click += new System.EventHandler(this.btnDangki_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.IndianRed;
            this.btnXoa.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnXoa.Location = new System.Drawing.Point(550, 356);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(114, 47);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // cboMaGV
            // 
            this.cboMaGV.DataSource = this.fKGiangVienMAKHO4D94879BBindingSource;
            this.cboMaGV.DisplayMember = "TENGIANGVIEN";
            this.cboMaGV.Font = new System.Drawing.Font("Arial", 10F);
            this.cboMaGV.FormattingEnabled = true;
            this.cboMaGV.Location = new System.Drawing.Point(348, 305);
            this.cboMaGV.Name = "cboMaGV";
            this.cboMaGV.Size = new System.Drawing.Size(400, 27);
            this.cboMaGV.TabIndex = 15;
            this.cboMaGV.ValueMember = "MAGIANGVIEN";
            this.cboMaGV.SelectedIndexChanged += new System.EventHandler(this.cboMaGV_SelectedIndexChanged);
            // 
            // linhVucBindingSource2
            // 
            this.linhVucBindingSource2.DataMember = "LinhVuc";
            this.linhVucBindingSource2.DataSource = this.nhom1_dotnetDataSetOffical;
            // 
            // fKDeTaiNCKHMALIN59063A47BindingSource
            // 
            this.fKDeTaiNCKHMALIN59063A47BindingSource.DataMember = "FK__DeTaiNCKH__MALIN__59063A47";
            this.fKDeTaiNCKHMALIN59063A47BindingSource.DataSource = this.linhVucBindingSource2;
            // 
            // deTaiNCKHTableAdapter
            // 
            this.deTaiNCKHTableAdapter.ClearBeforeFill = true;
            // 
            // giangVienTableAdapter
            // 
            this.giangVienTableAdapter.ClearBeforeFill = true;
            // 
            // giangVienBindingSource
            // 
            this.giangVienBindingSource.DataMember = "GiangVien";
            this.giangVienBindingSource.DataSource = this.nhom1_dotnetDataSetOffical;
            // 
            // fKGiangVienMAKHO4D94879BBindingSource1
            // 
            this.fKGiangVienMAKHO4D94879BBindingSource1.DataMember = "FK__GiangVien__MAKHO__4D94879B";
            this.fKGiangVienMAKHO4D94879BBindingSource1.DataSource = this.khoaBindingSource3;
            // 
            // FrmDKDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 487);
            this.Controls.Add(this.cboMaGV);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnDangki);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboKhoa);
            this.Controls.Add(this.lblKhoa);
            this.Controls.Add(this.cboLinhVuc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.lblMoTa);
            this.Controls.Add(this.txtTenDeTai);
            this.Controls.Add(this.lblTenDeTai);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrmDKDT";
            this.Text = "Đăng Ký Đề Tài NCKH";
            this.Load += new System.EventHandler(this.FrmDKDT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.linhVucBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhom1_dotnetDataSetOffical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linhVucBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhom1dotnetDataSetOfficalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKGiangVienMAKHO4D94879BBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linhVucBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDeTaiNCKHMALIN59063A47BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giangVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKGiangVienMAKHO4D94879BBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTenDeTai;
        private System.Windows.Forms.TextBox txtTenDeTai;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboLinhVuc;
        private System.Windows.Forms.BindingSource nhom1dotnetDataSetOfficalBindingSource;
        private Nhom1_dotnetDataSetOffical nhom1_dotnetDataSetOffical;
        private System.Windows.Forms.BindingSource linhVucBindingSource;
        private Nhom1_dotnetDataSetOfficalTableAdapters.LinhVucTableAdapter linhVucTableAdapter;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.ComboBox cboKhoa;
        private System.Windows.Forms.BindingSource khoaBindingSource;
        private Nhom1_dotnetDataSetOfficalTableAdapters.KhoaTableAdapter khoaTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDangki;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ComboBox cboMaGV;
        private System.Windows.Forms.BindingSource linhVucBindingSource1;
        private System.Windows.Forms.BindingSource linhVucBindingSource2;
        private System.Windows.Forms.BindingSource fKDeTaiNCKHMALIN59063A47BindingSource;
        private Nhom1_dotnetDataSetOfficalTableAdapters.DeTaiNCKHTableAdapter deTaiNCKHTableAdapter;
        private System.Windows.Forms.BindingSource khoaBindingSource1;
        private System.Windows.Forms.BindingSource khoaBindingSource2;
        private System.Windows.Forms.BindingSource fKGiangVienMAKHO4D94879BBindingSource;
        private Nhom1_dotnetDataSetOfficalTableAdapters.GiangVienTableAdapter giangVienTableAdapter;
        private System.Windows.Forms.BindingSource khoaBindingSource3;
        private System.Windows.Forms.BindingSource fKGiangVienMAKHO4D94879BBindingSource1;
        private System.Windows.Forms.BindingSource giangVienBindingSource;
    }
}