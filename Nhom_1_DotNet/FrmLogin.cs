using System;
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
    public partial class FrmLogin : Form
    {
        private string connectionString = "Data Source=NUEE\\SQLEXPRESS;Initial Catalog=Nhom1_dotnet;Integrated Security=True;TrustServerCertificate=True";
        private string selectedRole = null; // Lưu vai trò đã chọn
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnSv_Click(object sender, EventArgs e)
        {
            selectedRole = "SINHVIEN";
            PerformLogin();
        }

        private void btnGVHD_Click(object sender, EventArgs e)
        {
            selectedRole = "GIANGVIEN";
            PerformLogin();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            selectedRole = "ADMIN";
            PerformLogin();
        }

        private void PerformLogin()
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Kiểm tra xem vai trò đã được chọn chưa
            if (string.IsNullOrEmpty(selectedRole))
            {
                MessageBox.Show("Vui lòng chọn vai trò trước khi đăng nhập!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra xem các trường tên đăng nhập và mật khẩu đã được điền chưa
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng điền đầy đủ tên đăng nhập và mật khẩu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra thông tin đăng nhập
            if (ValidateUser(username, password, selectedRole, out string userId))
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide(); // Ẩn Form đăng nhập

                // Chuyển đến Form tương ứng
                switch (selectedRole)
                {
                    case "SINHVIEN":
                        new FrmSinhVien(userId).Show();
                        break;
                    case "GIANGVIEN":
                        new FrmGVHD(userId).Show(); // Tương tự cho giảng viên
                        break;
                        //case "ADMIN":
                        //    new AdminForm().Show(); // Tương tự cho admin
                        //    break;
                }
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private bool ValidateUser(string username, string password, string role, out string userId)
        {
            userId = null; // Khởi tạo userId
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Câu lệnh SQL cho sinh viên
                string queryStudent = @"SELECT SinhVien.MASV 
                                FROM TaiKhoan 
                                INNER JOIN SinhVien ON TaiKhoan.MADANGNHAP = SinhVien.MASV 
                                WHERE TaiKhoan.MADANGNHAP = @username 
                                AND TaiKhoan.MATKHAU = @password 
                                AND TaiKhoan.VAITRO = 'SINHVIEN'";

                // Câu lệnh SQL cho giảng viên
                string queryTeacher = @"SELECT GiangVien.MAGIANGVIEN 
                                FROM TaiKhoan 
                                INNER JOIN GiangVien ON TaiKhoan.MADANGNHAP = GiangVien.MAGIANGVIEN 
                                WHERE TaiKhoan.MADANGNHAP = @username 
                                AND TaiKhoan.MATKHAU = @password 
                                AND TaiKhoan.VAITRO = 'GIANGVIEN'";

                SqlCommand cmd;

                // Kiểm tra vai trò
                if (role == "SINHVIEN")
                {
                    cmd = new SqlCommand(queryStudent, conn);
                }
                else if (role == "GIANGVIEN")
                {
                    cmd = new SqlCommand(queryTeacher, conn);
                }
                else
                {
                    // Nếu vai trò không phải sinh viên hay giảng viên, không thực hiện truy vấn
                    return false;
                }

                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    userId = role == "SINHVIEN" ? reader["MASV"].ToString() : reader["MAGIANGVIEN"].ToString(); // Lưu mã tương ứng
                    return true; // Đăng nhập thành công
                }
            }
            return false; // Đăng nhập thất bại
        }

    }
}
