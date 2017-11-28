using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using Trabalho_Final.Relatorios;
using Trabalho_Final.Usuarios;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_Final
{
    public partial class MenuPrincipal: Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
             
        }

        private void button_Proximo_Click(object sender, EventArgs e)
        {
            if (Usuario.Valida(textBox_CPF.Text) == false)
            {
                MessageBox.Show("CPF INVALIDO!");
                textBox_CPF.Text = "";
            }
            else
            {
                Usuario USUARIO = new Usuario();
                USUARIO.setNome(textBox_Nome.Text);
                USUARIO.setCPF(textBox_CPF.Text);
                Hide();
                Escolha_Relatorio_Forms escolha = new Escolha_Relatorio_Forms(USUARIO);
                escolha.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastroUsuario cadastroNovo = new CadastroUsuario();
            Hide();
            cadastroNovo.ShowDialog();
            Show();
        }

        private void textBox_CPF_TextChanged(object sender, EventArgs e)
        {

        }
    }

            

}
