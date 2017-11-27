using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        public Exibir_Relatorio_Forms(Conta conta) {
            InitializeComponent();

            tipo = conta.getTipo();
        }//ah, consegui nao

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

        ///tava pensando em ir dormir e amanha agnt termina, o que acha? :/ kkkkk pode ser, eu nao vi nada que vc fez
        ///to vendo video sobre isso kkkk
        ///nao rolou. é o que importa
        ///kkkkkk
        ///vou dormir pensando nisso
        ///amanha agnt da um jeito
        ///ou qlqr coisa, vi aqui que tem o Show e o ShowDialog, o showdialog bloqueia o cara de usar o forms anterior
    }
}
