namespace Trabalho_Final
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
            this.AGUA_BOTAO = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Relatorios_comboBox = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
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
            this.ENERGIA_BOTAO.Location = new System.Drawing.Point(171, 59);
            this.ENERGIA_BOTAO.Name = "ENERGIA_BOTAO";
            this.ENERGIA_BOTAO.Size = new System.Drawing.Size(75, 23);
            this.ENERGIA_BOTAO.TabIndex = 2;
            this.ENERGIA_BOTAO.Text = "ENERGIA";
            this.ENERGIA_BOTAO.UseVisualStyleBackColor = true;
            this.ENERGIA_BOTAO.Click += new System.EventHandler(this.button1_Click);
            // 
            // AGUA_BOTAO
            // 
            this.AGUA_BOTAO.Location = new System.Drawing.Point(15, 59);
            this.AGUA_BOTAO.Name = "AGUA_BOTAO";
            this.AGUA_BOTAO.Size = new System.Drawing.Size(75, 23);
            this.AGUA_BOTAO.TabIndex = 3;
            this.AGUA_BOTAO.Text = "AGUA";
            this.AGUA_BOTAO.UseVisualStyleBackColor = true;
            this.AGUA_BOTAO.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Escolha o Relatorio";
            // 
            // Relatorios_comboBox
            // 
            this.Relatorios_comboBox.FormattingEnabled = true;
            this.Relatorios_comboBox.Location = new System.Drawing.Point(140, 125);
            this.Relatorios_comboBox.Name = "Relatorios_comboBox";
            this.Relatorios_comboBox.Size = new System.Drawing.Size(123, 21);
            this.Relatorios_comboBox.TabIndex = 4;
            this.Relatorios_comboBox.SelectedIndexChanged += new System.EventHandler(this.Relatorios_comboBox_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 208);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "SAIR";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(188, 208);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "PROXIMO";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(107, 208);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 8;
            this.button5.Text = "VOLTAR";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Escolha_Relatorio_Forms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 243);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Relatorios_comboBox);
            this.Controls.Add(this.AGUA_BOTAO);
            this.Controls.Add(this.ENERGIA_BOTAO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Escolha_Relatorio_Forms";
            this.Text = "Relatorio";
            this.Load += new System.EventHandler(this.Relatorio_Forms_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ENERGIA_BOTAO;
        private System.Windows.Forms.Button AGUA_BOTAO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Relatorios_comboBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}