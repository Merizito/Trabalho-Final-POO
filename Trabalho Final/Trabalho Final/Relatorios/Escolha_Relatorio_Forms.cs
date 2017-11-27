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
using Trabalho_Final.Contas;



namespace Trabalho_Final.Relatorios
{
    
    public partial class Escolha_Relatorio_Forms : Form
    {
        Contas.Conta contaEscolhida;  //certo
        StreamReader arquivoCombobox;
        string escolha;


        public Escolha_Relatorio_Forms()
        {
            InitializeComponent();
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
            contaEscolhida = new ContaAgua();/// que botao é esse? entao, o nome nao trocou aqui mas é o AGUA
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
            try
            {
                if (Relatorios_comboBox.Text == "" || Relatorios_comboBox.Text == null)
                    throw new NullReferenceException();
                else
                {
                    contaEscolhida.setRelatorio(Relatorios_comboBox.Text);
                    Program.contaRelatorio = contaEscolhida;//aaaaaaahhh
                    Exibir_Relatorio_Forms teste = new Exibir_Relatorio_Forms(contaEscolhida);
                    //eu tinha pensado em algo como, e se usarmos hide? ou entao, dermos o close la no exibir
                    // o hide pode funcionar, o close no exibir nao vai dar, vai fechar o proprio exibir
                    //tendi nao
                    //sobre o close, era tentar com um objeto desse forms, ou referencia dele
                    //sobre o show nao sei, mas se nao funcionar podemos usar o app.run kkkk
                    //deixa eu tentar com o close no exibir aqu pera ai, tenta ai kkkk
                    //ele faz isso no main, ele cria um objeto do forms2 e usa o objeto.showDialog
                    teste.ShowDialog();   //entendi como close funciona
                    ///close é hard, só fecha e boa
                    ///dane-se os outros o 
                    ///vc consegue ver video?sim
                    ///o que o cara fez deve funcionar, só que, o forms anterior fica aberto agnt conseguiu fazer isso, e escondemos
                    ///o forms anterior, talvez seja melhor nao esconder,  alias talvez funciona com hide posso te mandar ai? pode
                    ///pode ir pulando pq ne kkkkk
                    ///sabe onde mostar o codigo nao?
                    ///
                    
                }///        :..........) chorando de felicidade man
                ///acho que agnt pode usar isso haahha pakas, sim tipo....
                ///nao vai fechar a anterior ne, mas ele bloqueia mesmo? tipo vc consegue clicar no forms anterior?
                ///agr ta melhor nossaaaaaa, o outro recuso que ele fez tbm resolve, se liga.... deixa só conferir aqui
            }
            catch (NullReferenceException erro) {
                MessageBox.Show(erro.Message);
            }
            

        }

        private void Sair_botao_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
