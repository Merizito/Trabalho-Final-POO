using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using Trabalho_Final.Usuarios;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_Final.Contas
{
    public partial class Cadastrar_Conta : Form
    {
        Conta novaConta;
        Usuario usuario;
        public Cadastrar_Conta()
        {

            InitializeComponent();
        }
        public Cadastrar_Conta(string tipo,Usuario usuario)
        {
            this.usuario = usuario;
            if (tipo.ToUpper() == "agua".ToUpper())
            {
                this.Text = "Conta Agua";
                novaConta = new ContaAgua();
         }
            else if (tipo.ToUpper() == "energia".ToUpper()) {
                novaConta = new ContaEnergia();
                this.Text = "Conta Energia";

            }



            InitializeComponent();
        }
        private void Cadastrar_Conta_Load(object sender, EventArgs e)
        {

        }

        private void Fechar_botao_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Confirmar_botao_Click(object sender, EventArgs e)
        {
            string Caminho = Directory.GetCurrentDirectory();

            if (File.Exists(Caminho + @"\" + usuario.getCPF() + @"\" + "relatorio" + novaConta.getTipo()+".txt"))
            {
                StreamWriter escreve = Program.escreverArquivo(Caminho + @"\" + usuario.getCPF() + @"\" + "relatorio" + novaConta.getTipo());
                escreve.WriteLine(textBox_Data.Text + "\t" + textBox_Consumo.Text + "\t" + novaConta.getValor());
                Program.fecharArquivo(escreve);
                MessageBox.Show("Conta criada com sucesso!", "Confirmação!");
                Close();
            }
            else {
                Directory.CreateDirectory(Caminho + @"\" + usuario.getCPF());
                StreamWriter criar = Program.criarArquivo(Caminho + @"\" + usuario.getCPF() + @"\" + "relatorio" + novaConta.getTipo());
                Program.fecharArquivo(criar);
                StreamWriter escreve = Program.escreverArquivo(Caminho + @"\" + usuario.getCPF() + @"\" + "relatorio" + novaConta.getTipo());
                escreve.WriteLine(textBox_Data.Text + "\t" + textBox_Consumo.Text + "\t" + novaConta.getValor());
                Program.fecharArquivo(escreve);
                MessageBox.Show("Conta criada com sucesso!", "Confirmação!");
                Close();
            }
        }

        
    }
}
