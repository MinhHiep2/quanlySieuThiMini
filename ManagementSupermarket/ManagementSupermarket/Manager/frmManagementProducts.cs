using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Markup;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ComboBox = System.Windows.Forms.ComboBox;
using Image = System.Drawing.Image;

namespace ManagementSupermarket
{
    public partial class frmManagementProducts : Form
    {
        //public frmManagementProducts()
        //{
        //    InitializeComponent();
        //    this.TopLevel = false;
        //    this.FormBorderStyle = FormBorderStyle.None;
        //    this.Dock = DockStyle.Fill;
        //}
        public frmManagementProducts()
        {
            InitializeComponent();
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
