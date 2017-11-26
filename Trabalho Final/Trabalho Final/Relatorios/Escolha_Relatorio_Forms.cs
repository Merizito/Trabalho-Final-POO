using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Trabalho_Final.Conta;



namespace Trabalho_Final
{
    public partial class Escolha_Relatorio_Forms : Form
    {
        Trabalho_Final.Conta.IConta contaEscolhida;
        StreamReader arquivoCombobox;
        string escolha;



        public Escolha_Relatorio_Forms()
        {
            InitializeComponent();
        }

        private void Relatorio_Forms_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = 0;
            escolha = "agua";
            ENERGIA_BOTAO.Enabled = false;
            AGUA_BOTAO.Enabled = false;
            contaEscolhida = new ContaAgua();
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

        private void button1_Click(object sender, EventArgs e)
        {
            escolha = "energia";
            int i = 0;

            ENERGIA_BOTAO.Enabled = false;
            AGUA_BOTAO.Enabled = false;

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
            try
            {
                if (Relatorios_comboBox.Text == "" || Relatorios_comboBox.Text == null)
                    throw new NullReferenceException();
                else
                    contaEscolhida.setRelatorio(Relatorios_comboBox.Text);
            }
            catch (NullReferenceException) {

            }

        }
    }
}
