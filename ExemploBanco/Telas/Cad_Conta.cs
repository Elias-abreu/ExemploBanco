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
    public partial class Cad_Conta : Form
    {
        Usuario ps;
        public Cad_Conta()
        {
            InitializeComponent();
        }

        private void Cad_Conta_Load(object sender, EventArgs e)
        {
            List<Agencia> agencias = Agencia.BuscarAgencias();

            cb_agencias.DataSource = agencias;
            cb_agencias.DisplayMember = "Cidade";
            cb_agencias.ValueMember = "NumeroAgencia";
            lb_senha.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (tx_senha1.Text == tx_senha2.Text)
                {
                    if (ps == null)
                    {
                        ps = new Usuario();
                        ps.Cpf = mask_cpf.Text;
                        ps.Nome = tx_nome.Text;
                        ps.Rg = tx_rg.Text;
                        ps.DataNascimento = DateOnly.Parse(tx_dataN.Text);
                        ps.Sexo = cb_sexo.Text;
                        ps.CadastrarUsuario();
                    }
                    Object o = cb_agencias.SelectedValue;
                    Agencia agencia = Agencia.BuscarAgencias().SingleOrDefault(x => x.NumeroAgencia.Equals(o.ToString()));

                    Conta c = new Conta();
                    c.SaldoTotal = 0;
                    c.Senha = tx_senha1.Text;
                    c.DataCriacao = DateTime.Now;
                    c.Chavepix = mask_cpf.Text;
                    c.Agencia = agencia;
                    c.Usuario = ps;

                    c.CadastrarConta();
                }
                else
                {
                    lb_senha.Text = "Senhas não conferem!";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void maskedTextBox2_Leave(object sender, EventArgs e)
        {
            string cpf = mask_cpf.Text;
            if (cpf.Length == 14)
            {
                ps = Usuario.BuscarTodos().SingleOrDefault(x => x.Cpf.Equals(cpf));
                if (ps != null)
                {
                    tx_nome.Text = ps.Nome;
                    tx_rg.Text = ps.Rg;
                    tx_dataN.Text = string.Format("{0:dd/MM/yyyy}", ps.DataNascimento);
                    cb_sexo.Text = ps.Sexo;
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mask_cpf_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
