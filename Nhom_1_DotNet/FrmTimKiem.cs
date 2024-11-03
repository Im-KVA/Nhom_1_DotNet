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
    public partial class FrmTimKiem : Form
    {
        private SqlConnection connection;
        private string connectionString = "Data Source=NUEE\\SQLEXPRESS;Initial Catalog=Nhom1_dotnet;Integrated Security=True;TrustServerCertificate=True";

        public FrmTimKiem()
        {
            InitializeComponent();
        }

        private void LoadData(string query = "SELECT * FROM DeTaiNCKH")
        {
            // Create a new connection to the database
            connection = new SqlConnection(connectionString);

            // Open the connection
            connection.Open();

            // Create a new SqlDataAdapter to execute the query
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

            // Create a new DataTable to store the results
            DataTable table = new DataTable();

            // Fill the DataTable with the results from the query
            adapter.Fill(table);

            // Bind the DataTable to the DataGridView
            dataGridView1.DataSource = table;

            // Close the connection
            connection.Close();
        }

        private void FrmTimKiem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nhom1_dotnetDataSetOffical.DeTaiNCKH' table. You can move, or remove it, as needed.
            this.deTaiNCKHTableAdapter.Fill(this.nhom1_dotnetDataSetOffical.DeTaiNCKH);

        }

        private void FrmTimKiem_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nhom1_dotnetDataSetOffical1.GiangVien' table. You can move, or remove it, as needed.
            this.giangVienTableAdapter.Fill(this.nhom1_dotnetDataSetOffical1.GiangVien);
            // TODO: This line of code loads data into the 'nhom1_dotnetDataSetOffical1.LinhVuc' table. You can move, or remove it, as needed.
            this.linhVucTableAdapter.Fill(this.nhom1_dotnetDataSetOffical1.LinhVuc);
            // TODO: This line of code loads data into the 'nhom1_dotnetDataSetOffical1.Khoa' table. You can move, or remove it, as needed.
            this.khoaTableAdapter.Fill(this.nhom1_dotnetDataSetOffical1.Khoa);
            // TODO: This line of code loads data into the 'nhom1_dotnetDataSetOffical1.DeTaiNCKH' table. You can move, or remove it, as needed.
            this.deTaiNCKHTableAdapter1.Fill(this.nhom1_dotnetDataSetOffical1.DeTaiNCKH);

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            // Build the filter expression based on selected criteria
            List<string> filters = new List<string>();

            // Check if MALINHVUC has a selected value
            if (cboLinhVuc.SelectedItem != null)
            {
                string malinhvuc = cboLinhVuc.SelectedValue.ToString();
                filters.Add($"MALINHVUC = '{malinhvuc}'");
            }

            // Check if MAKHOA has a selected value
            if (cboKhoa.SelectedItem != null)
            {
                string makhoa = cboKhoa.SelectedValue.ToString();
                filters.Add($"MAKHOA = '{makhoa}'");
            }

            // Check if MAGIANGVIEN has a selected value
            if (cboMaGV.SelectedItem != null)
            {
                string magiangvien = cboMaGV.SelectedValue.ToString();
                filters.Add($"MAGIANGVIEN = '{magiangvien}'");
            }

            // Check if NAMHOC has a value
            if (!string.IsNullOrWhiteSpace(txtNAMHOC.Text))
            {
                string namhoc = txtNAMHOC.Text.Trim();
                filters.Add($"NAMHOC = '{namhoc}'");
            }

            // Combine the filters with AND
            string filterExpression = string.Join(" AND ", filters);

            // Access the DataTable for the DeTaiNCKH table
            DataTable table = nhom1_dotnetDataSetOfficial2.Tables["DeTaiNCKH"];

            if (!string.IsNullOrEmpty(filterExpression))
            {
                // Filter the rows in the table based on the filter expression
                DataRow[] filteredRows = table.Select(filterExpression);

                // Create a new DataTable to display filtered results
                DataTable filteredTable = table.Clone();

                // Import the filtered rows into the new DataTable
                foreach (DataRow row in filteredRows)
                {
                    filteredTable.ImportRow(row);
                }

                // Bind the filtered DataTable to the DataGridView
                dataGridView1.DataSource = filteredTable;
            }
            else
            {
                // If no filters are applied, show all records
                dataGridView1.DataSource = table;
            }

        }

        private void lblGV_Click(object sender, EventArgs e)
        {

        }


        private void FrmTimKiem_Load_2(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nhom1_dotnetDataSetOffical1.LinhVuc' table. You can move, or remove it, as needed.
            this.linhVucTableAdapter1.Fill(this.nhom1_dotnetDataSetOffical1.LinhVuc);
            // TODO: This line of code loads data into the 'nhom1_dotnetDataSetOffical1.Khoa' table. You can move, or remove it, as needed.
            this.khoaTableAdapter1.Fill(this.nhom1_dotnetDataSetOffical1.Khoa);
            // TODO: This line of code loads data into the 'nhom1_dotnetDataSetOffical1.GiangVien' table. You can move, or remove it, as needed.
            this.giangVienTableAdapter1.Fill(this.nhom1_dotnetDataSetOffical1.GiangVien);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmTimKiem_Load_3(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataOfficial.DeTaiNCKH' table. You can move, or remove it, as needed.
            this.deTaiNCKHTableAdapter4.Fill(this.dataOfficial.DeTaiNCKH);
            // TODO: This line of code loads data into the 'nhom1_dotnetDataSet2.DeTaiNCKH' table. You can move, or remove it, as needed.
            this.deTaiNCKHTableAdapter3.Fill(this.nhom1_dotnetDataSet2.DeTaiNCKH);
            // TODO: This line of code loads data into the 'nhom1_dotnetDataSetOfficial2.LinhVuc' table. You can move, or remove it, as needed.
            this.linhVucTableAdapter2.Fill(this.nhom1_dotnetDataSetOfficial2.LinhVuc);
            // TODO: This line of code loads data into the 'nhom1_dotnetDataSetOfficial2.GiangVien' table. You can move, or remove it, as needed.
            this.giangVienTableAdapter3.Fill(this.nhom1_dotnetDataSetOfficial2.GiangVien);
            // TODO: This line of code loads data into the 'nhom1_dotnetDataSetOfficial2.Khoa' table. You can move, or remove it, as needed.
            this.khoaTableAdapter2.Fill(this.nhom1_dotnetDataSetOfficial2.Khoa);
            // TODO: This line of code loads data into the 'nhom1_dotnetDataSetOfficial2.DeTaiNCKH' table. You can move, or remove it, as needed.
            this.deTaiNCKHTableAdapter2.Fill(this.nhom1_dotnetDataSetOfficial2.DeTaiNCKH);
            // TODO: This line of code loads data into the 'nhom1_dotnetDataSet1.GiangVien' table. You can move, or remove it, as needed.
            this.giangVienTableAdapter2.Fill(this.nhom1_dotnetDataSet1.GiangVien);

        }

        private void cboMaGV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ClearForm()
        {
            // Reset all comboboxes to their default state
            cboLinhVuc.SelectedIndex = -1;
            cboKhoa.SelectedIndex = -1;
            cboMaGV.SelectedIndex = -1;
            txtNAMHOC.Clear();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnAll_Click_1(object sender, EventArgs e)
        {
            // Load all data from the DeTaiNCKH table
            ClearForm();
            LoadData();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cboKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
