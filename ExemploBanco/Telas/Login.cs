using BancoIF.Entidades;
using BancoIF.Telas;
using System.IO;

namespace Telas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            lb_senhaI.Text = "";

            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(tx_conta.Text == "admin" && tx_senha.Text == "abreu")
            {
                new CadAgencia().ShowDialog();
            }
            else { 

                int conta = 0;
                if (tx_conta.Text != "") { 
                    conta = Convert.ToInt32(tx_conta.Text);
                }
                string senha = tx_senha.Text;

                Conta c = Conta.BuscarContas().SingleOrDefault(x => x.Nconta == conta);
                Conta.valorTodasContas = 20;
                if (c != null && c.Senha.Equals(senha))
                {
                    lb_senhaI.Text = "";
                    new Home(c).ShowDialog();
                }
                else
                {
                    lb_senhaI.Text = "Número de Conta ou Senha Inválidos!";
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.Hide();
            new Cad_Conta().ShowDialog();
            //Close();
        }
    }
}