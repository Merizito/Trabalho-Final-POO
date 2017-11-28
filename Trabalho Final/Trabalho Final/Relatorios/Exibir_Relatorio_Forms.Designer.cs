namespace Trabalho_Final.Relatorios
{
    partial class Exibir_Relatorio_Forms
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exibir_Relatorio_Forms));
            this.Sair_botao = new System.Windows.Forms.Button();
            this.textBox_NomeUsu = new System.Windows.Forms.TextBox();
            this.textBox_CPF = new System.Windows.Forms.TextBox();
            this.textBox_Consumo = new System.Windows.Forms.TextBox();
            this.textBox_Valor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Sair_botao
            // 
            resources.ApplyResources(this.Sair_botao, "Sair_botao");
            this.Sair_botao.Name = "Sair_botao";
            this.Sair_botao.UseVisualStyleBackColor = true;
            this.Sair_botao.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_NomeUsu
            // 
            resources.ApplyResources(this.textBox_NomeUsu, "textBox_NomeUsu");
            this.textBox_NomeUsu.Name = "textBox_NomeUsu";
            // 
            // textBox_CPF
            // 
            resources.ApplyResources(this.textBox_CPF, "textBox_CPF");
            this.textBox_CPF.Name = "textBox_CPF";
            // 
            // textBox_Consumo
            // 
            resources.ApplyResources(this.textBox_Consumo, "textBox_Consumo");
            this.textBox_Consumo.Name = "textBox_Consumo";
            // 
            // textBox_Valor
            // 
            resources.ApplyResources(this.textBox_Valor, "textBox_Valor");
            this.textBox_Valor.Name = "textBox_Valor";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // Exibir_Relatorio_Forms
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Valor);
            this.Controls.Add(this.textBox_Consumo);
            this.Controls.Add(this.textBox_CPF);
            this.Controls.Add(this.textBox_NomeUsu);
            this.Controls.Add(this.Sair_botao);
            this.Name = "Exibir_Relatorio_Forms";
            this.Load += new System.EventHandler(this.Exibir_Relatorio_Forms_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Sair_botao;
        private System.Windows.Forms.TextBox textBox_NomeUsu;
        private System.Windows.Forms.TextBox textBox_CPF;
        private System.Windows.Forms.TextBox textBox_Consumo;
        private System.Windows.Forms.TextBox textBox_Valor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}