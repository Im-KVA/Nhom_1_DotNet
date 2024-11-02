namespace Nhom_1_DotNet
{
    partial class FrmLogin
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
            this.btnSv = new System.Windows.Forms.Button();
            this.btnGVHD = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nhom1_dotnetDataSet = new Nhom_1_DotNet.Nhom1_dotnetDataSet();
            this.nhom1dotnetDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nhom1_dotnetDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhom1dotnetDataSetBindingSource)).BeginInit();
            this.SuspendLayout();

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(0, 122, 204); // Màu chữ
            this.label1.Location = new System.Drawing.Point(300, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng nhập";

            // 
            // btnSv
            // 
            this.btnSv.BackColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.btnSv.Font = new System.Drawing.Font("Arial", 12F);
            this.btnSv.ForeColor = System.Drawing.Color.White;
            this.btnSv.Location = new System.Drawing.Point(100, 350);
            this.btnSv.Name = "btnSv";
            this.btnSv.Size = new System.Drawing.Size(125, 40);
            this.btnSv.TabIndex = 1;
            this.btnSv.Text = "Sinh viên";
            this.btnSv.UseVisualStyleBackColor = false;
            this.btnSv.Click += new System.EventHandler(this.btnSv_Click);

            // 
            // btnGVHD
            // 
            this.btnGVHD.BackColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.btnGVHD.Font = new System.Drawing.Font("Arial", 12F);
            this.btnGVHD.ForeColor = System.Drawing.Color.White;
            this.btnGVHD.Location = new System.Drawing.Point(300, 350);
            this.btnGVHD.Name = "btnGVHD";
            this.btnGVHD.Size = new System.Drawing.Size(125, 40);
            this.btnGVHD.TabIndex = 2;
            this.btnGVHD.Text = "GVHD";
            this.btnGVHD.UseVisualStyleBackColor = false;
            this.btnGVHD.Click += new System.EventHandler(this.btnGVHD_Click);

            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.btnAdmin.Font = new System.Drawing.Font("Arial", 12F);
            this.btnAdmin.ForeColor = System.Drawing.Color.White;
            this.btnAdmin.Location = new System.Drawing.Point(500, 350);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(125, 40);
            this.btnAdmin.TabIndex = 3;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);

            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(120, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Đăng nhập với vai trò:";

            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F);
            this.label3.Location = new System.Drawing.Point(100, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên đăng nhập:";

            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(300, 130);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(250, 30);
            this.txtUsername.TabIndex = 6;

            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(300, 180);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(250, 30);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.UseSystemPasswordChar = true; // Ẩn mật khẩu

            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F);
            this.label4.Location = new System.Drawing.Point(100, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mật khẩu:";

            // 
            // nhom1_dotnetDataSet
            // 
            this.nhom1_dotnetDataSet.DataSetName = "Nhom1_dotnetDataSet";
            this.nhom1_dotnetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;

            // 
            // nhom1dotnetDataSetBindingSource
            // 
            this.nhom1dotnetDataSetBindingSource.DataSource = this.nhom1_dotnetDataSet;
            this.nhom1dotnetDataSetBindingSource.Position = 0;

            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnGVHD);
            this.Controls.Add(this.btnSv);
            this.Controls.Add(this.label1);
            this.Name = "FrmLogin";
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nhom1_dotnetDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhom1dotnetDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();


        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSv;
        private System.Windows.Forms.Button btnGVHD;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private Nhom1_dotnetDataSetOffical nhom1_dotnetDataSet;
        private System.Windows.Forms.BindingSource nhom1dotnetDataSetBindingSource;
    }

    internal class Nhom1_dotnetDataSet : Nhom1_dotnetDataSetOffical
    {
    }
}