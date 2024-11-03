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
    public partial class FrmGVHD : Form
    {
        private string connectionString = "Data Source=NUEE\\SQLEXPRESS;Initial Catalog=Nhom1_dotnet;Integrated Security=True;TrustServerCertificate=True";
        private string GVId;
        public FrmGVHD(string GVId)
        {
            InitializeComponent();
            this.GVId = GVId;
            LoadGVInfo();
        }

        private void LoadGVInfo()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
            SELECT 
                gv.TENGIANGVIEN, 
                gv.NGAYSINH, 
                gv.GIOITINH, 
                gv.SODIENTHOAI, 
                gv.EMAIL, 
                gv.CCCD, 
                k.MAKHOA,
                k.TENKHOA
            FROM 
                GiangVien gv
            JOIN 
                Khoa k ON gv.MAKHOA = k.MAKHOA 
            WHERE 
                gv.MAGIANGVIEN = @GVId";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@GVId", GVId);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        lblMaGV.Text = "Mã giảng viên: " + GVId;
                        lblName.Text = "Tên giảng viên: " + reader["TENGIANGVIEN"].ToString();
                        lblKhoa.Text = "Khoa: " + reader["TENKHOA"].ToString();
                        lblBirthDate.Text = "Ngày sinh: " + Convert.ToDateTime(reader["NGAYSINH"]).ToString("dd/MM/yyyy");
                        lblGender.Text = (reader["GIOITINH"].ToString() == "0") ? "Giới tính: Nam" : "Giới tính: Nữ";
                        lblPhone.Text = "Số điện thoại: " + reader["SODIENTHOAI"].ToString();
                        lblEmail.Text = "Email: " + reader["EMAIL"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy thông tin giảng viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void FrmGVHD_Load(object sender, EventArgs e)
        {

        }

        private void btnDoiMk_Click(object sender, EventArgs e)
        {
            FrmDoiMatKhau frmDoiMatKhau = new FrmDoiMatKhau(GVId);
            frmDoiMatKhau.ShowDialog();
        }

        private void đăgnKíĐềTàiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string role = "GIANGVIEN";
            FrmDKDT frmDKDT = new FrmDKDT(GVId, role);
            frmDKDT.ShowDialog();
        }

        private void lblCapNhat_Click(object sender, EventArgs e)
        {
            string role = "GIANGVIEN";
            FrmCapNhat frmCapNhat = new FrmCapNhat(GVId, role);
            frmCapNhat.ShowDialog();
        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTimKiem frmTimKiem = new FrmTimKiem();
            frmTimKiem.ShowDialog();
        }

        private void btnDangxuat_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
        }
    }
}
