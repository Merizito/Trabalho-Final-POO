using System;
using Trabalho_Final.Contas;
using Trabalho_Final.Usuarios;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_Final.Relatorios
{
    public partial class RelatorioDoisMeses : Form
    {
        Usuario usuario;
        Conta conta;
        public RelatorioDoisMeses()
        {
            InitializeComponent();
        }
        public RelatorioDoisMeses(Conta _conta, Usuario _usuarios)
        {
            conta = _conta;
            usuario = _usuarios;
            InitializeComponent();
            string diretorio = Directory.GetCurrentDirectory();
            StreamReader ler = Program.abrirArquivo(diretorio + @"\" + conta.getTipo() + @"\relatorio" + usuario.getTipo());


        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
