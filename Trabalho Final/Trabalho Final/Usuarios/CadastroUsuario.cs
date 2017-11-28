using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Final.Usuarios
{
    class CadastroUsuario :Form
    {
        private TextBox textBox_Nome;
        private TextBox textBox_CPF;
        private Label label1;
        private Label label2;
        private Button button_Confirmar;
        private ComboBox comboBox_Tipo;
        private Label label3;
        private Button button_Voltar;

        public CadastroUsuario() {

           InitializeComponent();

            comboBox_Tipo.Text = "Residencial";
            comboBox_Tipo.Text = "Comercial";

        }

        private void InitializeComponent()
        {
            this.textBox_Nome = new System.Windows.Forms.TextBox();
            this.textBox_CPF = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Confirmar = new System.Windows.Forms.Button();
            this.button_Voltar = new System.Windows.Forms.Button();
            this.comboBox_Tipo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_Nome
            // 
            this.textBox_Nome.Location = new System.Drawing.Point(87, 12);
            this.textBox_Nome.Name = "textBox_Nome";
            this.textBox_Nome.Size = new System.Drawing.Size(100, 20);
            this.textBox_Nome.TabIndex = 0;
            // 
            // textBox_CPF
            // 
            this.textBox_CPF.Location = new System.Drawing.Point(87, 50);
            this.textBox_CPF.Name = "textBox_CPF";
            this.textBox_CPF.Size = new System.Drawing.Size(100, 20);
            this.textBox_CPF.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "CPF";
            // 
            // button_Confirmar
            // 
            this.button_Confirmar.Location = new System.Drawing.Point(193, 10);
            this.button_Confirmar.Name = "button_Confirmar";
            this.button_Confirmar.Size = new System.Drawing.Size(85, 23);
            this.button_Confirmar.TabIndex = 4;
            this.button_Confirmar.Text = "Confirmar";
            this.button_Confirmar.UseVisualStyleBackColor = true;
            this.button_Confirmar.Click += new System.EventHandler(this.button_Confirmar_Click);
            // 
            // button_Voltar
            // 
            this.button_Voltar.Location = new System.Drawing.Point(193, 50);
            this.button_Voltar.Name = "button_Voltar";
            this.button_Voltar.Size = new System.Drawing.Size(85, 23);
            this.button_Voltar.TabIndex = 5;
            this.button_Voltar.Text = "Voltar";
            this.button_Voltar.UseVisualStyleBackColor = true;
            this.button_Voltar.Click += new System.EventHandler(this.button_Voltar_Click);
            // 
            // comboBox_Tipo
            // 
            this.comboBox_Tipo.FormattingEnabled = true;
            this.comboBox_Tipo.Items.AddRange(new object[] {
            "Comercial",
            "Residencial"});
            this.comboBox_Tipo.Location = new System.Drawing.Point(87, 93);
            this.comboBox_Tipo.Name = "comboBox_Tipo";
            this.comboBox_Tipo.Size = new System.Drawing.Size(100, 21);
            this.comboBox_Tipo.TabIndex = 6;
            this.comboBox_Tipo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_Tipo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tipo";
            // 
            // CadastroUsuario
            // 
            this.ClientSize = new System.Drawing.Size(284, 201);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_Tipo);
            this.Controls.Add(this.button_Voltar);
            this.Controls.Add(this.button_Confirmar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_CPF);
            this.Controls.Add(this.textBox_Nome);
            this.Name = "CadastroUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Usuário";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CadastroUsuario_FormClosed);
            this.Load += new System.EventHandler(this.CadastroUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void CadastroUsuario_Load(object sender, EventArgs e)
        {

        }

        private void CadastroUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void button_Confirmar_Click(object sender, EventArgs e)
        {
            string nome;

            if (Usuario.Valida(textBox_CPF.Text) == false)
            {
                MessageBox.Show("CPF INVALIDO!");
                textBox_CPF.Text = "";
            }
            else if (textBox_Nome.Text == null)
                MessageBox.Show("DIGITE UM NOME");
            else if (comboBox_Tipo.Text == null || comboBox_Tipo.Text == "")
                MessageBox.Show("ESCOLHA UM TIPO!");
            else
            {
                if (Usuario.ProcuraCPF(textBox_CPF.Text) == false)
                {
                    string diretorio = Directory.GetCurrentDirectory();
                    if (!Directory.Exists(diretorio + @"\" + textBox_CPF.Text))
                    {

                        Directory.CreateDirectory(diretorio + @"\" + textBox_CPF.Text);

                    }
                    nome = diretorio + @"\" + textBox_CPF.Text + @"\" + textBox_Nome.Text;

                    StreamWriter CADNOVO = Program.criarArquivo(nome);
                    Program.fecharArquivo(CADNOVO);
                    StreamWriter cadastronovo = Program.escreverArquivo(nome.ToUpper());
                    StreamWriter arq_usuario = Program.escreverArquivo("USUARIOS");
                    arq_usuario.WriteLine(textBox_Nome.Text.ToUpper() + "\t" + textBox_CPF.Text.Replace("/", "").Replace(".", "").Replace("-", "").Replace(" ", "") + "\t");
                    Program.fecharArquivo(arq_usuario);
                    cadastronovo.WriteLine(textBox_Nome.Text + "\t" + textBox_CPF.Text.Replace("/", "").Replace(".", "").Replace("-", "").Replace(" ", "") + "\t" + comboBox_Tipo.Text.ToUpper() + "\t");
                    Program.fecharArquivo(cadastronovo);
                    MessageBox.Show("CADASTRO REALIZADO COM SUCESSO!");
                    Close();
                }
                else
                    MessageBox.Show("USUARIO JA CADASTRADO!");

            }

        }

        private void button_Voltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox1_Tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
