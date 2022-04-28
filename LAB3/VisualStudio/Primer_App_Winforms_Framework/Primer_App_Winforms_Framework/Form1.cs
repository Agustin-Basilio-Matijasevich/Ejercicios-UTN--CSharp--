using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primer_App_Winforms_Framework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSaludo_Click(object sender, EventArgs e)
        {
            lblSaludo.Text = "Qnda Prro";
            imgApretame.Visible = false;
            imgHolis.Visible = true;
            btnExit.Visible = true;
        }

        private void btnSaludo_MouseEnter(object sender, EventArgs e)
        {
            lblSaludo.Text = "Apretame PTO";
            imgApretame.Visible = true;
        }

        private void btnSaludo_MouseLeave(object sender, EventArgs e)
        {
            lblSaludo.Text = "";
            imgApretame.Visible = false;
            imgHolis.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblSaludo.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Size tam = new Size(1, 1);
            this.Text = "Adiopue!!!";

            for (int i = 0; i < this.Size.Height; i++)
            {
                this.Size = Size.Subtract(this.Size, tam);
                Thread.Sleep(1);
            }
            
        }
    }
}
