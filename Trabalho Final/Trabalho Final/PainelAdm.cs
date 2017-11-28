using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Trabalho_Final.Usuarios;
using System.Drawing;
using System.Linq;
using Trabalho_Final.Relatorios;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_Final
{
    public partial class PainelAdm : Form
    {
        Usuario usuario;
        public PainelAdm()
        {
            InitializeComponent();
        }
        public PainelAdm(Usuario usuario)
        {
            this.usuario = usuario;
            InitializeComponent();
        }

        private void PainelAdm_Load(object sender, EventArgs e)
        {

        }
        

        private void PainelAdm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Escolha_Relatorio_Forms escolha = new Escolha_Relatorio_Forms(usuario);
            escolha.ShowDialog();
            Show();
        }
    }
}
