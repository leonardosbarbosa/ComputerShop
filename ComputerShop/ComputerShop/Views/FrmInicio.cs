using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerShop.Views
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSair_MouseHover(object sender, EventArgs e)
        {
            btnSair.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void btnSair_MouseLeave(object sender, EventArgs e)
        {
            btnSair.ForeColor = Color.FromArgb(0,0,0);
        }
    }
}
