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
                string query = "SELECT TENGIANGVIEN, NGAYSINH, GIOITINH, SODIENTHOAI, EMAIL, CCCD FROM GiangVien WHERE MAGIANGVIEN = @GVId";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@GVId", GVId);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        lblName.Text = reader["TENGIANGVIEN"].ToString();
                        lblBirthDate.Text = Convert.ToDateTime(reader["NGAYSINH"]).ToString("dd/MM/yyyy");
                        lblGender.Text = (reader["GIOITINH"].ToString() == "0") ? "Nam" : "Nữ";
                        lblPhone.Text = reader["SODIENTHOAI"].ToString();
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
    }
}
