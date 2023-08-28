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
using Microsoft.VisualBasic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BancoIF.Telas
{
    public partial class Home : Form
    {
        Conta c;
        internal Home(Conta c)
        {
            InitializeComponent();
            this.c = c;
        }



        private void Home_Load(object sender, EventArgs e)
        {
            preencherGri();
        }

        private void bt_depositar_Click(object sender, EventArgs e)
        {
            new Depositar(c).ShowDialog();
            preencherGri();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Sacar(c).ShowDialog();
            preencherGri();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Transferir(c).ShowDialog();
            preencherGri();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new FormPix(c).ShowDialog();
            preencherGri();
        }

        private void preencherGri()
        {
            lb_saldo.Text = "Saldo da Conta R$ " + c.SaldoTotal;
            lb_user.Text = "Seja bem Vindo " + c.Usuario.Nome;
            List<Movimentacao> moviments = Movimentacao.BuscarMovimentacoes().Where(x => x.ContaMov.Id_conta == c.Id_conta).OrderByDescending(x => x.Id_mov).ToList();

            listView1.Items.Clear();
            for (int i = 0; i < moviments.Count; i++)
            {
                listView1.Items.Add(new ListViewItem(new string[] { moviments[i].Tipo, moviments[i].Valor.ToString() }));
            }

            listView1.View = View.Details;
        }
    }
}
