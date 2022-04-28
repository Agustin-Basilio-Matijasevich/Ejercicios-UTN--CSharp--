using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Segunda_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblOutTexto1.Text = "";
        }

        private void btnTexto1_Click(object sender, EventArgs e)
        {
            lblOutTexto1.Text = tbTexto1.Text;
            tbTexto1.Text = "";
        }

        private void tbTexto1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTexto1_Click(sender, e);
            }
        }
    }
}
