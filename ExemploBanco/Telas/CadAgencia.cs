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
    public partial class CadAgencia : Form
    {
        public CadAgencia()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Agencia a = new Agencia();
            a.CadastrarAgencia();
        }
    }
}
