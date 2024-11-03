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
    public partial class FrmSinhVien : Form
    {
        private string connectionString = "Data Source=NUEE\\SQLEXPRESS;Initial Catalog=Nhom1_dotnet;Integrated Security=True;TrustServerCertificate=True";
        private string username;

        public FrmSinhVien(string username)
        {
            InitializeComponent();
            this.username = username;
            LoadStudentInfo();
        }

        private void LoadStudentInfo()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
            SELECT 
                sv.TENSV, 
                sv.NGAYSINH, 
                sv.GIOITINH, 
                sv.SODIENTHOAI, 
                sv.EMAIL, 
                sv.CCCD, 
                k.MAKHOA,
                k.TENKHOA
            FROM 
                SinhVien sv
            JOIN 
                Khoa k ON sv.MAKHOA = k.MAKHOA 
            WHERE 
                sv.MASV = @username";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        lblMaSV.Text = "Mã sinh viên: " + username;
                        lblName.Text = "Tên sinh viên: " + reader["TENSV"].ToString();
                        lblKhoa.Text = "Khoa: " + reader["TENKHOA"].ToString(); 
                        lblBirthDate.Text = "Ngày sinh: " + Convert.ToDateTime(reader["NGAYSINH"]).ToString("dd/MM/yyyy");
                        lblGender.Text = (reader["GIOITINH"].ToString() == "0") ? "Giới tính: Nam" : "Giới tính: Nữ";
                        lblPhone.Text = "Số điện thoại: " + reader["SODIENTHOAI"].ToString();
                        lblEmail.Text = "Email: " + reader["EMAIL"].ToString();
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

        private void đăgnKíĐềTàiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string role = "SINHVIEN";
            FrmDKDT frmDKDT = new FrmDKDT(username, role);
            frmDKDT.ShowDialog();
        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTimKiem frmTimKiem = new FrmTimKiem();
            frmTimKiem.ShowDialog();
        }

        private void thôngTinSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmThongtin frmThongtin = new FrmThongtin(username);
            frmThongtin.ShowDialog();
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void lblName_Click_1(object sender, EventArgs e)
        {

        }

        private void FrmSinhVien_Load_1(object sender, EventArgs e)
        {

        }

        private void đăgnKíĐềTàiToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            string role = "SINHVIEN";
            FrmDKDT frmDKDT = new FrmDKDT(username, role);
            frmDKDT.ShowDialog();
        }

        private void tìmKiếmToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmTimKiem frmTimKiem = new FrmTimKiem();
            frmTimKiem.ShowDialog();
        }

        private void btnDoiMk_Click(object sender, EventArgs e)
        {
            FrmDoiMatKhau frmDoiMatKhau = new FrmDoiMatKhau(username);
            frmDoiMatKhau.ShowDialog();
        }

        private void FrmSinhVien_Load_2(object sender, EventArgs e)
        {

        }

        private void lblCapNhat_Click(object sender, EventArgs e)
        {
            string role = "SINHVIEN";
            FrmCapNhat frmCapNhat = new FrmCapNhat(username, role);
            frmCapNhat.ShowDialog();
        }

        private void btnDangxuat_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
        }
    }
}
