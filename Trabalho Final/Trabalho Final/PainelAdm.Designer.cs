namespace Trabalho_Final
{
    partial class PainelAdm
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
            this.Relatorios_botao = new System.Windows.Forms.Button();
            this.Cadastrar_Agua = new System.Windows.Forms.Button();
            this.Cadastrar_Energia = new System.Windows.Forms.Button();
            this.Sair_botao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Relatorios_botao
            // 
            this.Relatorios_botao.Location = new System.Drawing.Point(12, 29);
            this.Relatorios_botao.Name = "Relatorios_botao";
            this.Relatorios_botao.Size = new System.Drawing.Size(87, 58);
            this.Relatorios_botao.TabIndex = 0;
            this.Relatorios_botao.Text = "RELATORIOS";
            this.Relatorios_botao.UseVisualStyleBackColor = true;
            this.Relatorios_botao.Click += new System.EventHandler(this.Relatorios_botao_Click);
            // 
            // Cadastrar_Agua
            // 
            this.Cadastrar_Agua.Location = new System.Drawing.Point(105, 29);
            this.Cadastrar_Agua.Name = "Cadastrar_Agua";
            this.Cadastrar_Agua.Size = new System.Drawing.Size(87, 58);
            this.Cadastrar_Agua.TabIndex = 1;
            this.Cadastrar_Agua.Text = "CADASTRAR CONTA AGUA";
            this.Cadastrar_Agua.UseVisualStyleBackColor = true;
            this.Cadastrar_Agua.Click += new System.EventHandler(this.Cadastrar_Agua_Click);
            // 
            // Cadastrar_Energia
            // 
            this.Cadastrar_Energia.Location = new System.Drawing.Point(198, 29);
            this.Cadastrar_Energia.Name = "Cadastrar_Energia";
            this.Cadastrar_Energia.Size = new System.Drawing.Size(87, 58);
            this.Cadastrar_Energia.TabIndex = 2;
            this.Cadastrar_Energia.Text = "CADASTRAR CONTA ENERGIA";
            this.Cadastrar_Energia.UseVisualStyleBackColor = true;
            this.Cadastrar_Energia.Click += new System.EventHandler(this.Cadastrar_Energia_Click);
            // 
            // Sair_botao
            // 
            this.Sair_botao.Location = new System.Drawing.Point(105, 139);
            this.Sair_botao.Name = "Sair_botao";
            this.Sair_botao.Size = new System.Drawing.Size(87, 30);
            this.Sair_botao.TabIndex = 3;
            this.Sair_botao.Text = "Sair";
            this.Sair_botao.UseVisualStyleBackColor = true;
            this.Sair_botao.Click += new System.EventHandler(this.Sair_botao_Click);
            // 
            // PainelAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 193);
            this.Controls.Add(this.Sair_botao);
            this.Controls.Add(this.Cadastrar_Energia);
            this.Controls.Add(this.Cadastrar_Agua);
            this.Controls.Add(this.Relatorios_botao);
            this.Name = "PainelAdm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PainelAdm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PainelAdm_FormClosed);
            this.Load += new System.EventHandler(this.PainelAdm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Relatorios_botao;
        private System.Windows.Forms.Button Cadastrar_Agua;
        private System.Windows.Forms.Button Cadastrar_Energia;
        private System.Windows.Forms.Button Sair_botao;
    }
}