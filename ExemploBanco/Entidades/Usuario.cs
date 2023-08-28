using BancoIF.Telas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoIF.Entidades
{
    internal class Usuario
    {
        public int Id_user { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Sexo { get; set; }
        public string Rg { get; set; }

        public DateOnly DataNascimento { get;set; }

        public Usuario() { }

        public Usuario(string nome, string cpf, string sexo, string rg, DateOnly dataNascimento)
        {
            Nome = nome;
            Cpf = cpf;
            Sexo = sexo;
            Rg = rg;
            DataNascimento = dataNascimento;
        }

        public int CadastrarUsuario()
        {
            Usuario ultimo = BuscarTodos().OrderBy(x=>x.Id_user).LastOrDefault();
            Id_user = ultimo.Id_user + 1;
            try
            {
                var file = File.AppendText(@"Arquivos/usuarios.txt");
                file.WriteLine(Id_user + "|" + Nome + "|" + Cpf+"|"+Sexo+"|" + Rg+ "|" + DataNascimento);
                file.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao ler os usuários "+ex.Message);
            }
            return Id_user;
        }

        public static List<Usuario> BuscarTodos()
        {
            List<Usuario> userTodos = new List<Usuario>();
            string sourcePath = @"Arquivos/usuarios.txt";
            List<string> linhas = File.ReadAllLines(sourcePath).ToList();
            foreach (string linha in linhas)
            {
                string[] auxiliar = linha.Split('|');
                Usuario u = new Usuario();
                u.Id_user = Convert.ToInt32(auxiliar[0]);
                u.Nome = auxiliar[1];
                u.Cpf = auxiliar[2];
                u.Sexo = auxiliar[3];
                u.Rg = auxiliar[4];
                u.DataNascimento = DateOnly.Parse(auxiliar[5]);
                userTodos.Add(u);
            }
            return userTodos;
        }
    }
}
