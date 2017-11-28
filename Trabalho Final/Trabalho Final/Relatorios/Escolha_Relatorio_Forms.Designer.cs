namespace Trabalho_Final.Relatorios
{
    partial class Escolha_Relatorio_Forms
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ENERGIA_BOTAO = new System.Windows.Forms.Button();
            this.AGUA = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Relatorios_comboBox = new System.Windows.Forms.ComboBox();
            this.Sair_botao = new System.Windows.Forms.Button();
            this.Proximo_botao = new System.Windows.Forms.Button();
            this.Voltar_botao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Qual é o tipo de relatório desejado?";
            // 
            // ENERGIA_BOTAO
            // 
            this.ENERGIA_BOTAO.Location = new System.Drawing.Point(177, 59);
            this.ENERGIA_BOTAO.Name = "ENERGIA_BOTAO";
            this.ENERGIA_BOTAO.Size = new System.Drawing.Size(75, 23);
            this.ENERGIA_BOTAO.TabIndex = 2;
            this.ENERGIA_BOTAO.Text = "ENERGIA";
            this.ENERGIA_BOTAO.UseVisualStyleBackColor = true;
            this.ENERGIA_BOTAO.Click += new System.EventHandler(this.button1_Click);
            // 
            // AGUA
            // 
            this.AGUA.Location = new System.Drawing.Point(15, 59);
            this.AGUA.Name = "AGUA";
            this.AGUA.Size = new System.Drawing.Size(75, 23);
            this.AGUA.TabIndex = 3;
            this.AGUA.Text = "AGUA";
            this.AGUA.UseVisualStyleBackColor = true;
            this.AGUA.Click += new System.EventHandler(this.AGUA_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Escolha o Relatorio";
            // 
            // Relatorios_comboBox
            // 
            this.Relatorios_comboBox.FormattingEnabled = true;
            this.Relatorios_comboBox.Location = new System.Drawing.Point(15, 125);
            this.Relatorios_comboBox.Name = "Relatorios_comboBox";
            this.Relatorios_comboBox.Size = new System.Drawing.Size(248, 21);
            this.Relatorios_comboBox.TabIndex = 4;
            this.Relatorios_comboBox.SelectedIndexChanged += new System.EventHandler(this.Relatorios_comboBox_SelectedIndexChanged);
            // 
            // Sair_botao
            // 
            this.Sair_botao.Location = new System.Drawing.Point(24, 208);
            this.Sair_botao.Name = "Sair_botao";
            this.Sair_botao.Size = new System.Drawing.Size(75, 23);
            this.Sair_botao.TabIndex = 6;
            this.Sair_botao.Text = "SAIR";
            this.Sair_botao.UseVisualStyleBackColor = true;
            this.Sair_botao.Click += new System.EventHandler(this.Sair_botao_Click);
            // 
            // Proximo_botao
            // 
            this.Proximo_botao.Location = new System.Drawing.Point(186, 208);
            this.Proximo_botao.Name = "Proximo_botao";
            this.Proximo_botao.Size = new System.Drawing.Size(75, 23);
            this.Proximo_botao.TabIndex = 7;
            this.Proximo_botao.Text = "PROXIMO";
            this.Proximo_botao.UseVisualStyleBackColor = true;
            this.Proximo_botao.Click += new System.EventHandler(this.Proximo_botao_Click);
            // 
            // Voltar_botao
            // 
            this.Voltar_botao.Location = new System.Drawing.Point(105, 208);
            this.Voltar_botao.Name = "Voltar_botao";
            this.Voltar_botao.Size = new System.Drawing.Size(75, 23);
            this.Voltar_botao.TabIndex = 8;
            this.Voltar_botao.Text = "VOLTAR";
            this.Voltar_botao.UseVisualStyleBackColor = true;
            this.Voltar_botao.Click += new System.EventHandler(this.Voltar_botao_Click);
            // 
            // Escolha_Relatorio_Forms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 243);
            this.Controls.Add(this.Voltar_botao);
            this.Controls.Add(this.Proximo_botao);
            this.Controls.Add(this.Sair_botao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Relatorios_comboBox);
            this.Controls.Add(this.AGUA);
            this.Controls.Add(this.ENERGIA_BOTAO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Escolha_Relatorio_Forms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorio";
            this.Load += new System.EventHandler(this.Relatorio_Forms_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ENERGIA_BOTAO;
        private System.Windows.Forms.Button AGUA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Relatorios_comboBox;
        private System.Windows.Forms.Button Sair_botao;
        private System.Windows.Forms.Button Proximo_botao;
        private System.Windows.Forms.Button Voltar_botao;
    }
}