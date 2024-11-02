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
    public partial class FrmDKDT : Form
    {
        public FrmDKDT()
        {
            InitializeComponent();
        }

        private void FrmDKDT_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nhom1_dotnetDataSetOffical.Khoa' table. You can move, or remove it, as needed.
            this.khoaTableAdapter.Fill(this.nhom1_dotnetDataSetOffical.Khoa);
            // TODO: This line of code loads data into the 'nhom1_dotnetDataSetOffical.LinhVuc' table. You can move, or remove it, as needed.
            this.linhVucTableAdapter.Fill(this.nhom1_dotnetDataSetOffical.LinhVuc);

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
