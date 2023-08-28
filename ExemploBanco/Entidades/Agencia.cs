using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace BancoIF.Entidades
{
    internal class Agencia
    {
        public int Id { get; set; }
        public string NumeroAgencia { get; set; }
        public string Cep { get; set; }
        public string Cidade { get; set;}
        public string Rua { get; set; }

        public Agencia() {
            Usuario u = new Usuario();
        }
        public Agencia(int id, string numeroAgencia, string cep, string cidade, string rua) {
            Id = id;
            NumeroAgencia = numeroAgencia;
            Cep = cep;
            Cidade = cidade;
            Rua = rua;
        }

        public bool CadastrarAgencia()
        {
            try {
                XElement arquivo = XElement.Load(@"arquivos\agencias.xml");

                arquivo.Add(new XAttribute("codigo", this.Id));
                arquivo.Add(new XAttribute("N agencia", this.NumeroAgencia ));
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar a agência");
            }
            return false;
        }
        public static List<Agencia> BuscarAgencias()
        {
            List<Agencia> agencias = new List<Agencia>
            {
                new Agencia(01,"0184-9","78900000","Jipa","SN"),
                new Agencia(02,"0184-8","78900000","Cáceres","SN"),
                new Agencia(03,"0136-2","78900000","Porto Velho","SN"),
                new Agencia(03,"0136-2","78900000","Jaru","SN")
            };
            return agencias;
        }
    }
}
