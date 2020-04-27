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
    public partial class FrmProdutos : Form
    {
        public FrmProdutos()
        {
            InitializeComponent();
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            if (txtQuantidade.Text.Equals("Ex: 100, 200, 300..."))
            {
                txtQuantidade.Clear();
            }
        }
    }
}
