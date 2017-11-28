using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using Trabalho_Final.Usuarios;
using System.IO;
using System.Text;
using Trabalho_Final.Contas;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_Final.Relatorios
{
    public partial class Exibir_Relatorio_Forms : Form
    {
        string tipo;
        public Exibir_Relatorio_Forms()
        {
            InitializeComponent();
        }

        private void Exibir_Relatorio_Forms_Load(object sender, EventArgs e)
        {
            
        }
       
        public Exibir_Relatorio_Forms(Conta conta, Usuario usuario) {

            InitializeComponent();

            if (conta.getTipo() == "agua")
                relatoriosAgua(conta, usuario);
            else if (conta.getTipo() == "energia")
                relatoriosEnergia(conta, usuario);
            else
                MessageBox.Show("TIPO ERRADO");

        }




        public void relatoriosAgua(Conta conta, Usuario usuario) {

            StreamReader informa = Program.abrirArquivo("USUARIOS");

            if (conta.getRelatorio().ToUpper()==("VALOR TOTAL DA MINHA CONTA"))
            {
                string linhas;
                do
                {
                    linhas = informa.ReadLine();
                    if(linhas !=null){
                        if (linhas.Contains(usuario.getCPF()))
                            preencherForms(linhas);
                    }
                } while (linhas != null);
            }



            Program.fecharArquivo(informa);

        }
        public void relatoriosEnergia(Conta conta, Usuario usuario)
        {
            StreamReader informa = Program.abrirArquivo("USUARIOS");

            if (conta.getRelatorio().ToUpper().Contains("VALOR"))
            {
                
                string linhas = informa.ReadLine();
                do
                {
                    if (linhas.Contains(usuario.getCPF()))
                        preencherForms(linhas);

                } while (linhas != null);
            }
            Program.fecharArquivo(informa);

        }

        private void Fechar_botao_Click(object sender, EventArgs e)
        {
            Close();
            
        }
        public void preencherForms(string linha) {
            string[] linhas = linha.Split('\t');
  
            textBox_NomeUsu.Text = linhas[0];
            textBox_CPF.Text = linhas[1];
            textBox_Consumo.Text = linhas[2];
            textBox_Valor.Text = linhas[3];

        }
        
    }
}
