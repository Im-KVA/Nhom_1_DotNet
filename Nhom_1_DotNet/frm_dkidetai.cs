using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom_1_DotNet
{
    public partial class frm_dkidetai : Form
    {
        private RichTextBox txtMoTa;
        private ComboBox cboLinhVuc;
        private ComboBox cboKhoa;
        private Button btnDangKy;
        private Label lblTitle;
        private Label lblMaDeTai;
        private Label lblTenDeTai;
        private Label lblMoTa;
        private Label lblLinhVuc;
        private Label lblKhoa;
        private Label lblGVHD;
        private Label lblNamHoc;

        public frm_dkidetai()
        {
            InitializeComponent();
        }
       
        private void frm_dkidetai_Load(object sender, EventArgs e)
        {

        }

        private void txtMaDeTai_TextChanged(object sender, EventArgs e)
        {

        }

        private void frm_dkidetai_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nhom1_dotnetDataSet1.Khoa' table. You can move, or remove it, as needed.
            this.khoaTableAdapter.Fill(this.nhom1_dotnetDataSet1.Khoa);
            // TODO: This line of code loads data into the 'nhom1_dotnetDataSet.LinhVuc' table. You can move, or remove it, as needed.
            this.linhVucTableAdapter.Fill(this.nhom1_dotnetDataSet.LinhVuc);

        }

        private void btnDangki_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                MessageBox.Show("Đăng ký đề tài thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtMaDeTai.Text))
            {
                MessageBox.Show("Vui lòng nhập mã đề tài!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTenDeTai.Text))
            {
                MessageBox.Show("Vui lòng nhập tên đề tài!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            if (string.IsNullOrWhiteSpace(txtGVHD.Text))
            {
                MessageBox.Show("Vui lòng nhập tên giảng viên hướng dẫn!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            
            return true;
        }
        private void ClearForm()
        {
            txtMaDeTai.Clear();
            txtTenDeTai.Clear();
            txtMoTa.Clear();
            cboLinhVuc.SelectedIndex = -1;
            cboKhoa.SelectedIndex = -1;
            txtGVHD.Clear();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ClearForm();

        }

    }
}
