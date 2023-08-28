using BancoIF.Telas;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoIF.Entidades
{
    internal class Movimentacao
    {
        public Conta ContaMov { get; set; }
        public int Id_mov { get; set; }
        public double Valor { get; set; }
        public string Tipo { get; set;}
        public Conta ContaDestino { get; set; }

        public void SalvarMovimentacao()
        {
            try
            {
                Movimentacao mc = BuscarMovimentacoes().OrderBy(x => x.Id_mov).LastOrDefault();
                if(mc != null)
                {
                    Id_mov = mc.Id_mov + 1;
                }
                else
                {
                    Id_mov = 1;
                }

                var file = File.AppendText(@"Arquivos/movimentacao.txt");
                file.WriteLine(Id_mov + "|" + ContaMov.Id_conta + "|" + Valor + "|" + Tipo + "|" + ContaDestino.Nconta);
                file.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao salvar a movimentação! " + ex.Message);
            }

        }

        public static List<Movimentacao> BuscarMovimentacoes()
        {
            List<Movimentacao> movimentacoes = new List<Movimentacao>();
            try
            {
                string sourcePath = @"Arquivos/movimentacao.txt";
                List<string> linhas = File.ReadAllLines(sourcePath).ToList();
                foreach (string line in linhas)
                {
                    string[] aux = line.Split('|');
                    Movimentacao m = new Movimentacao();
                    m.Id_mov = Convert.ToInt32(aux[0]);
                    Conta cOperacao = Conta.BuscarContas().SingleOrDefault(x => x.Id_conta == Convert.ToInt32(aux[1]));
                    m.ContaMov = cOperacao;
                    m.Valor = Convert.ToDouble(aux[2]);
                    m.Tipo = aux[3];
                   
                    Conta cDestino = Conta.BuscarContas().SingleOrDefault(x=> x.Id_conta == Convert.ToInt32(aux[4]));
                    m.ContaDestino = cDestino;

                    movimentacoes.Add(m);
                }
            }
            catch (Exception ex)
            {
                //Verificar aqui
                MessageBox.Show("Ocorreu um erro ao buscar as contas na base de dados "+ex.Message);
            }
            return movimentacoes;
        }


    }
}
