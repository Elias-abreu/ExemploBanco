using BancoIF.Telas;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoIF.Entidades
{
    internal class Conta
    {
        public int Id_conta { get; set; }
        public int Nconta { get; set; }
        public double SaldoTotal { get; set; }
        public string Senha { get;set; }
        public DateTime DataCriacao { get; set; }
        public string Chavepix { get; set; }
        public Agencia Agencia { get; set; }
        public Usuario Usuario { get; set; }

        public static double valorTodasContas;

        public Conta() { }

       
        public Conta(int id_conta, int nconta, double saldoTotal, string senha, DateTime dataCriacao, string chavepix, Agencia agencia, Usuario usuario)
        {
            Id_conta = id_conta;
            Nconta = nconta;
            SaldoTotal = saldoTotal;
            Senha = senha;
            this.DataCriacao = dataCriacao;
            this.Chavepix = chavepix;
            Agencia = agencia;
            Usuario = usuario;

            Agencia a = new Agencia();
        }

        public double Depositar(double valor)
        {
            if(valor <= 0)
            {
                MessageBox.Show("Valores negativos não podem ser depositados!");
            }
            else { 
                this.SaldoTotal += valor;
                List<Conta> todas = BuscarContas();
                Conta c = todas.SingleOrDefault(x => x.Id_conta == Id_conta);
                c.SaldoTotal = SaldoTotal;
                List<string> linhas = new List<string>();
                foreach (Conta co in todas)
                {
                    linhas.Add(co.Id_conta + "|" + co.Nconta + "|" + co.SaldoTotal + "|" + co.DataCriacao +
                        "|" + co.Chavepix + "|" + co.Senha + "|" + co.Agencia.Id + "|" + co.Usuario.Id_user);
                }
                File.WriteAllLines(@"Arquivos/contas.txt", linhas);
                Movimentacao m = new Movimentacao();
                m.Valor = valor;
                m.Tipo = "Deposito";
                m.ContaMov = this;
                m.ContaDestino = this;
                m.SalvarMovimentacao();
                MessageBox.Show("Valor depositado com sucesso!");
            }
            return this.SaldoTotal;
        }

        public double Sacar(double valor)
        {
            if(valor > SaldoTotal)
            {
                MessageBox.Show("Saldo insuficiente!");
            }
            else {
                this.SaldoTotal -= valor;
                List<Conta> todas = BuscarContas();
                Conta c = todas.SingleOrDefault(x => x.Id_conta == Id_conta);
                c.SaldoTotal = SaldoTotal;
                List<string> linhas = new List<string>();
                foreach (Conta co in todas)
                {
                    linhas.Add(co.Id_conta + "|" + co.Nconta + "|" + co.SaldoTotal + "|" + co.DataCriacao +
                        "|" + co.Chavepix + "|" + co.Senha + "|" + co.Agencia.Id + "|" + co.Usuario.Id_user);
                }
                File.WriteAllLines(@"Arquivos/contas.txt", linhas);

                Movimentacao m = new Movimentacao();
                m.Valor = valor;
                m.Tipo = "Saque";
                m.ContaMov = this;
                m.ContaDestino = this;
                m.SalvarMovimentacao();
                MessageBox.Show("Valor sacado com sucesso!");
            }
            return this.SaldoTotal;
        }

        public int CadastrarConta()
        {
            try
            {
                Conta c = BuscarContas().OrderBy(x=> x.Id_conta).LastOrDefault();
                if (c != null)
                {
                    Nconta = c.Nconta + 1;
                    Id_conta = c.Id_conta + 1;
                }
                else
                {
                    Nconta = 1;
                    Id_conta = 1;
                }
                var file = File.AppendText(@"Arquivos/contas.txt");
                file.WriteLine(Id_conta+"|"+Nconta+"|"+SaldoTotal+"|"+DataCriacao+
                    "|"+Chavepix+"|"+Senha+"|"+Agencia.Id+"|"+Usuario.Id_user); 
                file.Close();
                MessageBox.Show("Conta criada com sucesso, o número da conta é "+Nconta);
            }catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao salvar a conta! "+ex.Message);
            }
            
            return Id_conta;
        }

        public static List<Conta> BuscarContas()
        {
            List<Conta> contas = new List<Conta>();
            try {
                List<Agencia> agencias = Agencia.BuscarAgencias();
                List<Usuario> usuarios = Usuario.BuscarTodos();                
                string sourcePath = @"Arquivos/contas.txt";
                List<string> linhas = File.ReadAllLines(sourcePath).ToList();
                foreach (string line in linhas)
                {
                    string[] aux = line.Split('|');
                    Conta conta = new Conta();
                    conta.Id_conta = Convert.ToInt32(aux[0]);
                    conta.Nconta = Convert.ToInt32(aux[1]);
                    conta.SaldoTotal = Convert.ToDouble(aux[2]);
                    conta.DataCriacao = Convert.ToDateTime(aux[3]);
                    conta.Chavepix = aux[4];
                    conta.Senha = aux[5];

                    Agencia a = agencias.SingleOrDefault(a => a.Id == Convert.ToInt32(aux[6]));
                    conta.Agencia = a;

                    Usuario usuario = usuarios.SingleOrDefault(a => a.Id_user == Convert.ToInt32(aux[7]));
                    conta.Usuario = usuario;
                    contas.Add(conta);                    
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao buscar as contas na base de dados "+ex.Message);
            }
            return contas;
        }

        public bool Transferir(int NcontaDes,double valor)
        {
            if(valor > 0)
            {
                List<Conta> contas = BuscarContas();
                Conta destino = contas.SingleOrDefault(x=>x.Nconta == NcontaDes);
                if(destino == null)
                {
                    MessageBox.Show("Conta de destino não identificada!");
                    return false;
                }
                Conta c = contas.SingleOrDefault(x => x.Id_conta == Id_conta);
                destino.SaldoTotal += valor;
                this.SaldoTotal -= valor;
                c.SaldoTotal = SaldoTotal;
                List<string> linhas = new List<string>();
                foreach (Conta co in contas)
                {
                    linhas.Add(co.Id_conta + "|" + co.Nconta + "|" + co.SaldoTotal + "|" + co.DataCriacao +
                        "|" + co.Chavepix + "|" + co.Senha + "|" + co.Agencia.Id + "|" + co.Usuario.Id_user);
                }
                File.WriteAllLines(@"Arquivos/contas.txt", linhas);

                Movimentacao m = new Movimentacao();
                m.Valor = valor;
                m.Tipo = "Transferência";
                m.ContaMov = this;
                m.ContaDestino = destino;
                m.SalvarMovimentacao();
                MessageBox.Show("Transferência realizada com sucesso!");
                return true;
            }
            else
            {
                MessageBox.Show("Valores negativos não podem ser transferidos!");
                return false;
            }
        }

        public bool EnviarPix(string chavepix, double valor)
        {
            if (valor > 0)
            {
                List<Conta> contas = BuscarContas();
                Conta destino = contas.SingleOrDefault(x => x.Chavepix.Equals(chavepix));
                if (destino == null)
                {
                    MessageBox.Show("Chave pix não enviado!");
                    return false;
                }
                Conta c = contas.SingleOrDefault(x => x.Id_conta == Id_conta);
                destino.SaldoTotal += valor;
                this.SaldoTotal -= valor;
                c.SaldoTotal = SaldoTotal;
                List<string> linhas = new List<string>();
                foreach (Conta co in contas)
                {
                    linhas.Add(co.Id_conta + "|" + co.Nconta + "|" + co.SaldoTotal + "|" + co.DataCriacao +
                        "|" + co.Chavepix + "|" + co.Senha + "|" + co.Agencia.Id + "|" + co.Usuario.Id_user);
                }
                File.WriteAllLines(@"Arquivos/contas.txt", linhas);

                Movimentacao m = new Movimentacao();
                m.Valor = valor;
                m.Tipo = "Pix Enviado";
                m.ContaMov = this;
                m.ContaDestino = destino;
                m.SalvarMovimentacao();
                MessageBox.Show("Pix enviado com sucesso!");
                return true;
            }
            else
            {
                MessageBox.Show("Valores negativos não podem ser transferidos!");
                return false;
            }
        }
    }
}
