using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabalho_Final.Conta;



namespace Trabalho_Final
{
    public partial class Escolha_Relatorio_Forms : Form
    {
        IConta contaEscolhida;
        public Escolha_Relatorio_Forms()
        {
            InitializeComponent();
        }

        private void Relatorio_Forms_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            contaEscolhida = new ContaAgua();
            //terminar botao
        }

        private void button1_Click(object sender, EventArgs e)
        {
            contaEscolhida = new ContaEnergia();
            //terminar botao

        }
    }
}
