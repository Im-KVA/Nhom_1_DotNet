<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom_1_DotNet
{
    public partial class FrmSinhVien : Form
    {
        private string connectionString = "Data Source=NUEE\\SQLEXPRESS;Initial Catalog=Nhom1_dotnet;Integrated Security=True;TrustServerCertificate=True";
        private string studentId;

        public FrmSinhVien(string studentId)
        {
            InitializeComponent();
            this.studentId = studentId;
            LoadStudentInfo();
        }

        private void LoadStudentInfo()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT TENSV, NGAYSINH, GIOITINH, SODIENTHOAI, EMAIL, CCCD FROM SinhVien WHERE MASV = @studentId";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@studentId", studentId);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        lblName.Text = reader["TENSV"].ToString();
                        lblBirthDate.Text = Convert.ToDateTime(reader["NGAYSINH"]).ToString("dd/MM/yyyy");
                        lblGender.Text = (reader["GIOITINH"].ToString() == "0") ? "Nam" : "Nữ";
                        lblPhone.Text = reader["SODIENTHOAI"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy thông tin sinh viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void FrmSinhVien_Load(object sender, EventArgs e)
        {
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom_1_DotNet
{
    public partial class FrmSinhVien : Form
    {
        private string connectionString = "Data Source=NUEE\\SQLEXPRESS;Initial Catalog=Nhom1_dotnet;Integrated Security=True;TrustServerCertificate=True";
        private string studentId;

        public FrmSinhVien(string studentId)
        {
            InitializeComponent();
            this.studentId = studentId;
            LoadStudentInfo();
        }

        private void LoadStudentInfo()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT TENSV, NGAYSINH, GIOITINH, SODIENTHOAI, EMAIL, CCCD FROM SinhVien WHERE MASV = @studentId";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@studentId", studentId);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        lblName.Text = reader["TENSV"].ToString();
                        lblBirthDate.Text = Convert.ToDateTime(reader["NGAYSINH"]).ToString("dd/MM/yyyy");
                        lblGender.Text = (reader["GIOITINH"].ToString() == "0") ? "Nam" : "Nữ";
                        lblPhone.Text = reader["SODIENTHOAI"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy thông tin sinh viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void FrmSinhVien_Load(object sender, EventArgs e)
        {
        }
    }
}
>>>>>>> create login sv + gvhd
