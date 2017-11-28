using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Trabalho_Final.Usuarios;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Trabalho_Final.Contas;



namespace Trabalho_Final.Relatorios
{
    
    public partial class Escolha_Relatorio_Forms : Form
    {
        Contas.Conta contaEscolhida;  
        StreamReader arquivoCombobox;
        string escolha;
        Usuario usuario;

        public Escolha_Relatorio_Forms()
        {
            InitializeComponent();
        }
        public Escolha_Relatorio_Forms(Usuario usu)
        {
            usuario = usu;
            InitializeComponent(); // CHEGA NO ESCOLHA 
        }

        private void Relatorio_Forms_Load(object sender, EventArgs e)
        {

        }

        private void AGUA_Click(object sender, EventArgs e)
        {




            int i = 0;
            escolha = "agua";
            ENERGIA_BOTAO.Enabled = false;
            AGUA.Enabled = false;
            contaEscolhida = new ContaAgua();
            arquivoCombobox = Program.abrirArquivo(escolha.ToLower());
            string texto = arquivoCombobox.ReadToEnd();
            string[] vetor = texto.Split('\n', '-');
            for (i = 0; i < vetor.Length; i++) // VC ESCOLHE AGUA OU ENERGIA
            {
                try
                {
                    Relatorios_comboBox.Items.Add(vetor[i]);
                    i++; //ELE PREENCHE O COMBOBOX
                }
                catch (StackOverflowException)
                {
                    i = vetor.Length;
                }
            }
            Program.fecharArquivo(arquivoCombobox);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            escolha = "energia";
            int i = 0;

            ENERGIA_BOTAO.Enabled = false;
            AGUA.Enabled = false;

            contaEscolhida = new ContaEnergia();
            arquivoCombobox = Program.abrirArquivo(escolha.ToLower());

            string texto = arquivoCombobox.ReadToEnd();
            string[] vetor = texto.Split('\n', '-');

            for (i = 0; i < vetor.Length; i++)
            {
                try
                {
                    Relatorios_comboBox.Items.Add(vetor[i]);
                    i++;
                }
                catch (StackOverflowException)
                {
                    i = vetor.Length;
                }
            }


            Program.fecharArquivo(arquivoCombobox);


        }

        private void Relatorios_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Proximo_botao_Click(object sender, EventArgs e)
        {

            contaEscolhida.setRelatorio(Relatorios_comboBox.Text);
            Program.contaRelatorio = contaEscolhida;
            Hide();
            Relatorios_comboBox.Items.Clear();
            ENERGIA_BOTAO.Enabled = true;
            AGUA.Enabled = true;
            Exibir_Relatorio_Forms exibirrelatorio = new Exibir_Relatorio_Forms(contaEscolhida, usuario);
            exibirrelatorio.ShowDialog();
            Show();
            /*
            try
            {
                if (Relatorios_comboBox.Text == null)
                    throw new NullReferenceException();
                else
                {
                    contaEscolhida.setRelatorio(Relatorios_comboBox.Text);
                    Program.contaRelatorio = contaEscolhida;
                    Hide();
                    Exibir_Relatorio_Forms exibirrelatorio = new Exibir_Relatorio_Forms(contaEscolhida, usuario);
                    exibirrelatorio.ShowDialog();  
                    

                    
                    
                }
            }
            catch (NullReferenceException erro) {
                MessageBox.Show(erro.Message);
            }*/
            

        }

        private void Sair_botao_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Voltar_botao_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
