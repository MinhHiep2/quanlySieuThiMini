using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementSupermarket
{
    public partial class frmChangePassword : Form
    {
        public frmChangePassword(string id)
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMKHienTai.Clear();
            txtNhapLai.Clear();
            txtMKMoi.Clear();
        }
    }
}
