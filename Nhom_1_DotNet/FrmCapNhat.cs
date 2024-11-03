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
    public partial class FrmCapNhat : Form
    {
        private string connectionString = "Data Source=NUEE\\SQLEXPRESS;Initial Catalog=Nhom1_dotnet;Integrated Security=True;TrustServerCertificate=True";
        private string username;
        private string role;
        public FrmCapNhat(string username, string role)
        {
            InitializeComponent();
            this.role = role;
            this.username = username;
        }

        private void FrmCapNhat_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;

            if (cbTrangthai.Text.Trim() == "TT03")
            {
                cbTrangthai.Text = "Đã hoàn thành";
                cbTrangthai.Enabled = false;
            }

            string query;
            if (role == "GIANGVIEN")
            {
                query = @"SELECT MADT, TENDT, MOTA, MALINHVUC, MASV, MAKHOA, MAGIANGVIEN, NAMHOC, MATRANGTHAI, MAGIAITHUONG, NHANXET
                             FROM DeTaiNCKH 
                             WHERE MAGIANGVIEN = @MAGIANGVIEN";
            }
            else
            {
                query = @"SELECT MADT, TENDT, MOTA, MALINHVUC, MASV, MAKHOA, MAGIANGVIEN, NAMHOC, MATRANGTHAI, MAGIAITHUONG, NHANXET
                             FROM DeTaiNCKH 
                             WHERE MASV = @MASV";
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                if (role == "GIANGVIEN")
                    cmd.Parameters.AddWithValue("@MAGIANGVIEN", username);
                else
                    cmd.Parameters.AddWithValue("@MASV", username);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Gán dữ liệu vào DataGridView
                dataGridView1.DataSource = dataTable;

                // Clear existing items in ComboBox
                cbTenDeTai.Items.Clear();
                cbTrangthai.Items.Clear();

                // Thêm tên đề tài vào ComboBox
                foreach (DataRow row in dataTable.Rows)
                {
                    if (!cbTenDeTai.Items.Contains(row["TENDT"].ToString()))
                    {
                        cbTenDeTai.Items.Add(row["TENDT"].ToString());
                    }
                    if (!cbTrangthai.Items.Contains(row["MATRANGTHAI"].ToString()))
                    {
                        cbTrangthai.Items.Add(row["MATRANGTHAI"].ToString());
                    }
                }
            }
        }



        private void cbTrangthai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            // Lấy mã đề tài
            string tendetai = cbTenDeTai.SelectedItem?.ToString();
            string trangThai;

            // Lấy trạng thái
            if(!cbTrangthai.Enabled)
            {
                trangThai = "TT03";
            }
            else
            {
                trangThai = cbTrangthai.Text;
            }
            //string trangThai = cbTrangthai.SelectedItem?.ToString();


            string mota = txtMota.Text;
            string newTenDeTai = txtTenDeTai.Text;


            string nhanxet = txtCmt.Text;

            // Cập nhật trạng thái
            string query = @"UPDATE DeTaiNCKH
                 SET MATRANGTHAI = COALESCE(@MATRANGTHAI, MATRANGTHAI),
                     MOTA = COALESCE(@MOTA, MOTA),
                     TENDT = COALESCE(@TENDT, TENDT),
                     NHANXET = COALESCE(@NHANXET, NHANXET)
                 WHERE TENDT = @tendetai";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@MATRANGTHAI", trangThai);
                cmd.Parameters.AddWithValue("@MOTA", mota);
                cmd.Parameters.AddWithValue("@TENDT", newTenDeTai);
                cmd.Parameters.AddWithValue("@tendetai", tendetai);
                cmd.Parameters.AddWithValue("@NHANXET", nhanxet);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật đề tài thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbTenDeTai.Text = "";
                cbTrangthai.Text = "";
                cbTrangthai.Enabled = true;
                FrmCapNhat_Load(sender, e);

            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtTenDeTai.Text = "";
            txtMota.Text = "";
            cbTrangthai.Text = "";
            cbTenDeTai.Text = "";
            FrmCapNhat_Load(sender, e);
        }

        private void cbTenDeTai_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            string selectedTenDeTai = cbTenDeTai.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedTenDeTai))
            {
                return;
            }



            string query = @"SELECT MATRANGTHAI, MOTA FROM DeTaiNCKH WHERE TENDT = @TENDT";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TENDT", selectedTenDeTai);

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string trangThai = reader["MATRANGTHAI"].ToString();
                        string mota = reader["MOTA"].ToString();

                        // Display the retrieved values in the appropriate controls
                        cbTrangthai.Text = trangThai;
                        txtMota.Text = mota;
                        txtTenDeTai.Text = selectedTenDeTai;

                        if (trangThai.Trim() == "TT03")
                        {
                            if (role == "GIANGVIEN")
                            {
                                panel1.Visible = false;
                                panel2.Visible = true;
                            }
                            cbTrangthai.Text = "Đã hoàn thành";
                            cbTrangthai.Enabled = false;
                        }
                        else
                        {
                            panel1.Visible = true;
                            panel2.Visible = false;
                            cbTrangthai.Enabled = true;
                        }
                    }
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}