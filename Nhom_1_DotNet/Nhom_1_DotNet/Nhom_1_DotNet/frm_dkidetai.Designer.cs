<<<<<<< HEAD
﻿using System;
using System.Windows.Forms;

namespace Nhom_1_DotNet
{
    partial class frm_dkidetai
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaDeTai = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenDeTai = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMota = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbLinhVuc = new System.Windows.Forms.ComboBox();
            this.linhVucBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhom1_dotnetDataSet = new Nhom_1_DotNet.Nhom1_dotnetDataSet();
            this.label6 = new System.Windows.Forms.Label();
            this.cbKhoa = new System.Windows.Forms.ComboBox();
            this.khoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhom1_dotnetDataSet1 = new Nhom_1_DotNet.Nhom1_dotnetDataSet1();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGVHD = new System.Windows.Forms.TextBox();
            this.btnDangki = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.linhVucTableAdapter = new Nhom_1_DotNet.Nhom1_dotnetDataSetTableAdapters.LinhVucTableAdapter();
            this.nhom1dotnetDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khoaTableAdapter = new Nhom_1_DotNet.Nhom1_dotnetDataSet1TableAdapters.KhoaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.linhVucBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhom1_dotnetDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhom1_dotnetDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhom1dotnetDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(300, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng kí đề tài NCKH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã đề tài";
            // 
            // txtMaDeTai
            // 
            this.txtMaDeTai.Location = new System.Drawing.Point(150, 80);
            this.txtMaDeTai.Name = "txtMaDeTai";
            this.txtMaDeTai.Size = new System.Drawing.Size(500, 22);
            this.txtMaDeTai.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên đề tài";
            // 
            // txtTenDeTai
            // 
            this.txtTenDeTai.Location = new System.Drawing.Point(150, 120);
            this.txtTenDeTai.Name = "txtTenDeTai";
            this.txtTenDeTai.Size = new System.Drawing.Size(500, 22);
            this.txtTenDeTai.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Mô tả";
            // 
            // txtMota
            // 
            this.txtMota.Location = new System.Drawing.Point(150, 160);
            this.txtMota.Multiline = true;
            this.txtMota.Name = "txtMota";
            this.txtMota.Size = new System.Drawing.Size(500, 100);
            this.txtMota.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Lĩnh vực";
            // 
            // cbLinhVuc
            // 
            this.cbLinhVuc.DataSource = this.linhVucBindingSource;
            this.cbLinhVuc.DisplayMember = "TENLINHVUC";
            this.cbLinhVuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLinhVuc.Location = new System.Drawing.Point(150, 280);
            this.cbLinhVuc.Name = "cbLinhVuc";
            this.cbLinhVuc.Size = new System.Drawing.Size(500, 24);
            this.cbLinhVuc.TabIndex = 8;
            this.cbLinhVuc.ValueMember = "TENLINHVUC";
            // 
            // linhVucBindingSource
            // 
            this.linhVucBindingSource.DataMember = "LinhVuc";
            this.linhVucBindingSource.DataSource = this.nhom1_dotnetDataSet;
            // 
            // nhom1_dotnetDataSet
            // 
            this.nhom1_dotnetDataSet.DataSetName = "Nhom1_dotnetDataSet";
            this.nhom1_dotnetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Khoa";
            // 
            // cbKhoa
            // 
            this.cbKhoa.DataSource = this.khoaBindingSource;
            this.cbKhoa.DisplayMember = "TENKHOA";
            this.cbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKhoa.Location = new System.Drawing.Point(150, 320);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(500, 24);
            this.cbKhoa.TabIndex = 10;
            this.cbKhoa.ValueMember = "TENKHOA";
            // 
            // khoaBindingSource
            // 
            this.khoaBindingSource.DataMember = "Khoa";
            this.khoaBindingSource.DataSource = this.nhom1_dotnetDataSet1;
            // 
            // nhom1_dotnetDataSet1
            // 
            this.nhom1_dotnetDataSet1.DataSetName = "Nhom1_dotnetDataSet1";
            this.nhom1_dotnetDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 360);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "GVHD";
            // 
            // txtGVHD
            // 
            this.txtGVHD.Location = new System.Drawing.Point(150, 360);
            this.txtGVHD.Name = "txtGVHD";
            this.txtGVHD.Size = new System.Drawing.Size(500, 22);
            this.txtGVHD.TabIndex = 12;
            // 
            // btnDangki
            // 
            this.btnDangki.Location = new System.Drawing.Point(250, 460);
            this.btnDangki.Name = "btnDangki";
            this.btnDangki.Size = new System.Drawing.Size(100, 30);
            this.btnDangki.TabIndex = 15;
            this.btnDangki.Text = "Đăng kí";
            this.btnDangki.UseVisualStyleBackColor = true;
            this.btnDangki.Click += new System.EventHandler(this.btnDangki_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(450, 460);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 30);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // linhVucTableAdapter
            // 
            this.linhVucTableAdapter.ClearBeforeFill = true;
            // 
            // nhom1dotnetDataSetBindingSource
            // 
            this.nhom1dotnetDataSetBindingSource.DataSource = this.nhom1_dotnetDataSet;
            this.nhom1dotnetDataSetBindingSource.Position = 0;
            // 
            // khoaTableAdapter
            // 
            this.khoaTableAdapter.ClearBeforeFill = true;
            // 
            // frm_dkidetai
            // 
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaDeTai);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenDeTai);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMota);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbLinhVuc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbKhoa);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtGVHD);
            this.Controls.Add(this.btnDangki);
            this.Controls.Add(this.btnXoa);
            this.Name = "frm_dkidetai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_dkidetai";
            this.Load += new System.EventHandler(this.frm_dkidetai_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.linhVucBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhom1_dotnetDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhom1_dotnetDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhom1dotnetDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnDangki;
        private System.Windows.Forms.TextBox txtGVHD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbKhoa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbLinhVuc;
        private System.Windows.Forms.TextBox txtMota;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTenDeTai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaDeTai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Nhom1_dotnetDataSet nhom1_dotnetDataSet;
        private BindingSource linhVucBindingSource;
        private Nhom1_dotnetDataSetTableAdapters.LinhVucTableAdapter linhVucTableAdapter;
        private BindingSource nhom1dotnetDataSetBindingSource;
        private Nhom1_dotnetDataSet1 nhom1_dotnetDataSet1;
        private BindingSource khoaBindingSource;
        private Nhom1_dotnetDataSet1TableAdapters.KhoaTableAdapter khoaTableAdapter;
    }
=======
﻿using System;
using System.Windows.Forms;

namespace Nhom_1_DotNet
{
    partial class frm_dkidetai
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaDeTai = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenDeTai = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMota = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbLinhVuc = new System.Windows.Forms.ComboBox();
            this.linhVucBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhom1_dotnetDataSet = new Nhom_1_DotNet.Nhom1_dotnetDataSet();
            this.label6 = new System.Windows.Forms.Label();
            this.cbKhoa = new System.Windows.Forms.ComboBox();
            this.khoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhom1_dotnetDataSet1 = new Nhom_1_DotNet.Nhom1_dotnetDataSet1();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGVHD = new System.Windows.Forms.TextBox();
            this.btnDangki = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.linhVucTableAdapter = new Nhom_1_DotNet.Nhom1_dotnetDataSetTableAdapters.LinhVucTableAdapter();
            this.nhom1dotnetDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khoaTableAdapter = new Nhom_1_DotNet.Nhom1_dotnetDataSet1TableAdapters.KhoaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.linhVucBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhom1_dotnetDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhom1_dotnetDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhom1dotnetDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(300, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng kí đề tài NCKH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã đề tài";
            // 
            // txtMaDeTai
            // 
            this.txtMaDeTai.Location = new System.Drawing.Point(150, 80);
            this.txtMaDeTai.Name = "txtMaDeTai";
            this.txtMaDeTai.Size = new System.Drawing.Size(500, 22);
            this.txtMaDeTai.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên đề tài";
            // 
            // txtTenDeTai
            // 
            this.txtTenDeTai.Location = new System.Drawing.Point(150, 120);
            this.txtTenDeTai.Name = "txtTenDeTai";
            this.txtTenDeTai.Size = new System.Drawing.Size(500, 22);
            this.txtTenDeTai.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Mô tả";
            // 
            // txtMota
            // 
            this.txtMota.Location = new System.Drawing.Point(150, 160);
            this.txtMota.Multiline = true;
            this.txtMota.Name = "txtMota";
            this.txtMota.Size = new System.Drawing.Size(500, 100);
            this.txtMota.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Lĩnh vực";
            // 
            // cbLinhVuc
            // 
            this.cbLinhVuc.DataSource = this.linhVucBindingSource;
            this.cbLinhVuc.DisplayMember = "TENLINHVUC";
            this.cbLinhVuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLinhVuc.Location = new System.Drawing.Point(150, 280);
            this.cbLinhVuc.Name = "cbLinhVuc";
            this.cbLinhVuc.Size = new System.Drawing.Size(500, 24);
            this.cbLinhVuc.TabIndex = 8;
            this.cbLinhVuc.ValueMember = "TENLINHVUC";
            // 
            // linhVucBindingSource
            // 
            this.linhVucBindingSource.DataMember = "LinhVuc";
            this.linhVucBindingSource.DataSource = this.nhom1_dotnetDataSet;
            // 
            // nhom1_dotnetDataSet
            // 
            this.nhom1_dotnetDataSet.DataSetName = "Nhom1_dotnetDataSet";
            this.nhom1_dotnetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Khoa";
            // 
            // cbKhoa
            // 
            this.cbKhoa.DataSource = this.khoaBindingSource;
            this.cbKhoa.DisplayMember = "TENKHOA";
            this.cbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKhoa.Location = new System.Drawing.Point(150, 320);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(500, 24);
            this.cbKhoa.TabIndex = 10;
            this.cbKhoa.ValueMember = "TENKHOA";
            // 
            // khoaBindingSource
            // 
            this.khoaBindingSource.DataMember = "Khoa";
            this.khoaBindingSource.DataSource = this.nhom1_dotnetDataSet1;
            // 
            // nhom1_dotnetDataSet1
            // 
            this.nhom1_dotnetDataSet1.DataSetName = "Nhom1_dotnetDataSet1";
            this.nhom1_dotnetDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 360);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "GVHD";
            // 
            // txtGVHD
            // 
            this.txtGVHD.Location = new System.Drawing.Point(150, 360);
            this.txtGVHD.Name = "txtGVHD";
            this.txtGVHD.Size = new System.Drawing.Size(500, 22);
            this.txtGVHD.TabIndex = 12;
            // 
            // btnDangki
            // 
            this.btnDangki.Location = new System.Drawing.Point(250, 460);
            this.btnDangki.Name = "btnDangki";
            this.btnDangki.Size = new System.Drawing.Size(100, 30);
            this.btnDangki.TabIndex = 15;
            this.btnDangki.Text = "Đăng kí";
            this.btnDangki.UseVisualStyleBackColor = true;
            this.btnDangki.Click += new System.EventHandler(this.btnDangki_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(450, 460);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 30);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // linhVucTableAdapter
            // 
            this.linhVucTableAdapter.ClearBeforeFill = true;
            // 
            // nhom1dotnetDataSetBindingSource
            // 
            this.nhom1dotnetDataSetBindingSource.DataSource = this.nhom1_dotnetDataSet;
            this.nhom1dotnetDataSetBindingSource.Position = 0;
            // 
            // khoaTableAdapter
            // 
            this.khoaTableAdapter.ClearBeforeFill = true;
            // 
            // frm_dkidetai
            // 
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaDeTai);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenDeTai);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMota);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbLinhVuc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbKhoa);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtGVHD);
            this.Controls.Add(this.btnDangki);
            this.Controls.Add(this.btnXoa);
            this.Name = "frm_dkidetai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_dkidetai";
            this.Load += new System.EventHandler(this.frm_dkidetai_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.linhVucBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhom1_dotnetDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhom1_dotnetDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhom1dotnetDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnDangki;
        private System.Windows.Forms.TextBox txtGVHD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbKhoa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbLinhVuc;
        private System.Windows.Forms.TextBox txtMota;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTenDeTai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaDeTai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Nhom1_dotnetDataSet nhom1_dotnetDataSet;
        private BindingSource linhVucBindingSource;
        private Nhom1_dotnetDataSetTableAdapters.LinhVucTableAdapter linhVucTableAdapter;
        private BindingSource nhom1dotnetDataSetBindingSource;
        private Nhom1_dotnetDataSet1 nhom1_dotnetDataSet1;
        private BindingSource khoaBindingSource;
        private Nhom1_dotnetDataSet1TableAdapters.KhoaTableAdapter khoaTableAdapter;
    }
>>>>>>> create login sv + gvhd
}