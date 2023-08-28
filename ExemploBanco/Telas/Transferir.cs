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
    public partial class Transferir : Form
    {
        Conta c;
        internal Transferir(Conta c)
        {
            InitializeComponent();
            this.c = c;
        }

        private void Transferir_Load(object sender, EventArgs e)
        {
            List<Agencia> agencias = Agencia.BuscarAgencias();

            cb_agencias.DataSource = agencias;
            cb_agencias.DisplayMember = "Cidade";
            cb_agencias.ValueMember = "NumeroAgencia";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nContaDes = Convert.ToInt32(textBox2.Text);
            double valor = Convert.ToDouble(textBox1.Text);
            bool transf = c.Transferir(nContaDes, valor);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void cb_agencias_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
