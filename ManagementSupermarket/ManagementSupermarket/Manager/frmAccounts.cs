using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;

namespace ManagementSupermarket.Manager
{
    public partial class frmAccounts : Form
    {
        private string s_role;
        private string s_idEmployee;
        string nameForm = "Form Account";
        public frmAccounts(string idEmployee, string role)
        {
            this.s_idEmployee = idEmployee;
            this.s_role = role;
            InitializeComponent();
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
        }
    }
}
