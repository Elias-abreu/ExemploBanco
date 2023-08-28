using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BancoIF.Entidades;

namespace BancoIF.Telas
{
    public partial class Sacar : Form
    {
        Conta c;
        internal Sacar(Conta c)
        {
            InitializeComponent();
            this.c = c;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(textBox1.Text);
            c.Sacar(valor);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
