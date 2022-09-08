using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectbeazika
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastroDeClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastrocliente var = new Cadastrocliente();
            var.ShowDialog();
        }

        private void menuusuario1_Click(object sender, EventArgs e)
        {
            Cadastrousuario var = new Cadastrousuario();
            var.ShowDialog();
        }

        private void menuproduto_Click(object sender, EventArgs e)
        {
            Cadastroproduto var = new Cadastroproduto();
            var.ShowDialog();
        }
    }
}
