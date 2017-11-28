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
        /// eu so quero passar por parametro uma conta veeeei
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
                        MessageBox.Show("TESTE");
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
                //tem um comando que analisa linha a linha sem o for
                string linhas = informa.ReadLine();
                do
                {
                    if (linhas.Contains(usuario.getCPF()))
                        preencherForms(linhas);

                } while (linhas != null);
            }
            Program.fecharArquivo(informa);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Escolha_Relatorio_Forms escolha = new Escolha_Relatorio_Forms();

            escolha.Show();//CADE? KKKKKKKKKK tbm nao entendi HAAAAAAAAA MLK deu errado eu acho kkkkkkk PQ? p
            ///o escolha que abriu foi um novo e nao o anterior, e qual diferen~ça? o Anterior continua no hide
            ///sera? sim hahaha olha
            ///viu? pera ai
            //DialogResult = DialogResult.OK;/// como assim? o show resolve eu acho, a ideia é exibir, ai ele clica
            /// uai
            /// 
            
        }
        public void preencherForms(string linha) {
            string[] linhas = linha.Split('\t');
  
            textBox_NomeUsu.Text = linhas[0];
            textBox_CPF.Text = linhas[1];
            textBox_Consumo.Text = linhas[2];
            textBox_Valor.Text = linhas[3];

            //ele ja tem o usuario ja em linhas, não? sim, mas eu nao queria fazer o for la
            //tanto faz, só fiz uma funcao separada pra preencher o forms com os dados, mas nao precisa de for aqui
            //precisa?  ja tem o usuario acho que nao
            //OQ? nao entendi esse vetor de string, como cada textbox vai saber que tal posição tem o que queremos?
            //pq pra mim ele só sabe o [0] o vetor tem 4 posicoes, cada uma com uma string aonde ele pega isso?
            //e onde diz que tem 4 pos?
            //no arquivo que vamos criar hahaha, ok prossiga kkk



        }
        ///tava pensando em ir dormir e amanha agnt termina, o que acha? :/ kkkkk pode ser, eu nao vi nada que vc fez
        ///to vendo video sobre isso kkkk
        ///nao rolou. é o que importa
        ///kkkkkk
        ///vou dormir pensando nisso
        ///amanha agnt da um jeito
        ///ou qlqr coisa, vi aqui que tem o Show e o ShowDialog, o showdialog bloqueia o cara de usar o forms anterior
    }
}
