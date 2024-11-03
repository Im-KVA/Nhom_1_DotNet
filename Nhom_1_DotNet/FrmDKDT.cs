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
    public partial class FrmDKDT : Form
    {
        private string connectionString = "Data Source=NUEE\\SQLEXPRESS;Initial Catalog=Nhom1_dotnet;Integrated Security=True;TrustServerCertificate=True";
        private string studentId;
        private string role;
        public FrmDKDT(string studentId, string role)
        {
            InitializeComponent();
            this.studentId = studentId;
            this.role = role;
        }

        private void FrmDKDT_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'nhom1_dotnetDataSetOffical.GiangVien' table. You can move, or remove it, as needed.
            this.giangVienTableAdapter.Fill(this.nhom1_dotnetDataSetOffical.GiangVien);
            // TODO: This line of code loads data into the 'nhom1_dotnetDataSetOffical.DeTaiNCKH' table. You can move, or remove it, as needed.
            this.deTaiNCKHTableAdapter.Fill(this.nhom1_dotnetDataSetOffical.DeTaiNCKH);
            // TODO: This line of code loads data into the 'nhom1_dotnetDataSetOffical.Khoa' table. You can move, or remove it, as needed.
            this.khoaTableAdapter.Fill(this.nhom1_dotnetDataSetOffical.Khoa);
            // TODO: This line of code loads data into the 'nhom1_dotnetDataSetOffical.LinhVuc' table. You can move, or remove it, as needed.
            this.linhVucTableAdapter.Fill(this.nhom1_dotnetDataSetOffical.LinhVuc);
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private string GenerateMADT()
        {
            string prefix = "DT";
            int newId = GetNextID(); 
            return prefix + newId.ToString("D2"); 
        }
        private int GetNextID()
        {
            int nextId = 1; // Giá trị mặc định

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sqlQuery = "SELECT ISNULL(MAX(CAST(SUBSTRING(MADT, 3, LEN(MADT) - 2) AS INT)), 0) + 1 FROM DeTaiNCKH";

                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    // Thực thi câu lệnh truy vấn
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        nextId = Convert.ToInt32(result);
                    }
                }
            }
            return nextId;
        }
        private void btnDangki_Click(object sender, EventArgs e)
        {
            if (!checkValid())
            {
                return; 
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sqlInsert = "INSERT INTO DeTaiNCKH (MADT, TENDT, MOTA, MALINHVUC, MASV, MAKHOA, MAGIANGVIEN, NAMHOC, MATRANGTHAI, MAGIAITHUONG) VALUES (@MADT, @TenDeTai, @MoTa, @MaLinhVuc, @MASV, @MaKhoa, @MaGV, @NamHoc, @MaTrangThai, @MaGiaiThuong)";

                using (SqlCommand command = new SqlCommand(sqlInsert, connection))
                {
                    string madt = GenerateMADT();
                    string masv = studentId;
                    string namhoc = DateTime.Now.Year.ToString(); 
                    string matrangthai = "TT01";
                    // Thêm các tham số vào câu lệnh SQL
                    command.Parameters.AddWithValue("@MADT", madt);
                    command.Parameters.AddWithValue("@TenDeTai", txtTenDeTai.Text);
                    command.Parameters.AddWithValue("@MoTa", txtMoTa.Text);
                    command.Parameters.AddWithValue("@MaLinhVuc", cboLinhVuc.SelectedValue);
                    command.Parameters.AddWithValue("@MASV", masv);
                    command.Parameters.AddWithValue("@MaKhoa", cboKhoa.SelectedValue);
                    command.Parameters.AddWithValue("@MaGV", cboMaGV.SelectedValue);
                    command.Parameters.AddWithValue("@NamHoc", namhoc);
                    command.Parameters.AddWithValue("@MaTrangThai", matrangthai);
                    command.Parameters.Add("@MaGiaiThuong", SqlDbType.NVarChar).Value = DBNull.Value;


                    try
                    {
                        // Thực thi câu lệnh INSERT
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Đăng ký đề tài thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Đăng ký đề tài thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private bool checkValid()
        {
            // Kiểm tra nếu trường TenDeTai trống
            if (string.IsNullOrWhiteSpace(txtTenDeTai.Text))
            {
                MessageBox.Show("Tên đề tài không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Kiểm tra nếu trường MoTa trống
            if (string.IsNullOrWhiteSpace(txtMoTa.Text))
            {
                MessageBox.Show("Mô tả không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Kiểm tra nếu trường GiangVienHD trống
            if (string.IsNullOrWhiteSpace(cboMaGV.Text))
            {
                MessageBox.Show("Giảng viên hướng dẫn không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true; 
        }

        private void cboMaGV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void LoadGiangVienByKhoa(string maKhoa)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sqlQuery = "SELECT MAGIANGVIEN, TENGIANGVIEN FROM GiangVien WHERE MAKHOA = @MaKhoa";

                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@MaKhoa", maKhoa);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);

                        cboMaGV.DataSource = dataTable;
                        cboMaGV.DisplayMember = "TENGIANGVIEN";
                        cboMaGV.ValueMember = "MAGIANGVIEN";
                    }
                }
            }
        }

        private void cboKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadGiangVienByKhoa(cboKhoa.SelectedValue.ToString());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtTenDeTai.Text = "";
            txtMoTa.Text = "";
            cboKhoa.SelectedIndex = 0;
            cboLinhVuc.SelectedIndex = 0;
            cboMaGV.SelectedIndex = 0;
        }
    }
}
