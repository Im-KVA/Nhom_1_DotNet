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
    public partial class FrmThongtin : Form
    {
        private string studentId;

        public FrmThongtin(string studentId)
        {
            InitializeComponent();
            this.studentId = studentId;
        }

        private void FrmThongtin_Load(object sender, EventArgs e)
        {

        }
    }
}
