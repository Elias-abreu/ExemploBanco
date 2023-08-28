using BancoIF.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoIF.Telas
{
    public partial class FormPix : Form
    {
        Conta c;
        internal FormPix(Conta c)
        {
            InitializeComponent();
            this.c = c;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string chavePix = textBox2.Text;
            double valor = Convert.ToDouble(textBox1.Text);
            bool transf = c.EnviarPix(chavePix, valor);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
