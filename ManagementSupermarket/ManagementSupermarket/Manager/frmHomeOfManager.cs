using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Ink;

namespace ManagementSupermarket
{
    public partial class frmHomeOfManager : Form
    {
        public frmHomeOfManager(string idEmployee, string role)
        {
            InitializeComponent();
        }

        private void frmHomeOfManager_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmHomeOfManager_Load_1(object sender, EventArgs e)
        {

        }

        private void lbl_Home_Click(object sender, EventArgs e)
        {

        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (frmOrder oder = new frmOrder())
            {
                oder.ShowDialog();
            }
            this.Show();
        }
    }
}
