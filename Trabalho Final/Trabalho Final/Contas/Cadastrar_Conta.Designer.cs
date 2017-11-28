namespace Trabalho_Final.Contas
{
    partial class Cadastrar_Conta
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
            this.textBox_Consumo = new System.Windows.Forms.TextBox();
            this.textBox_Data = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Fechar_botao = new System.Windows.Forms.Button();
            this.Confirmar_botao = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_Consumo
            // 
            this.textBox_Consumo.Location = new System.Drawing.Point(95, 47);
            this.textBox_Consumo.Name = "textBox_Consumo";
            this.textBox_Consumo.Size = new System.Drawing.Size(100, 20);
            this.textBox_Consumo.TabIndex = 0;
            // 
            // textBox_Data
            // 
            this.textBox_Data.Location = new System.Drawing.Point(95, 82);
            this.textBox_Data.Name = "textBox_Data";
            this.textBox_Data.Size = new System.Drawing.Size(100, 20);
            this.textBox_Data.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Consumo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data";
            // 
            // Fechar_botao
            // 
            this.Fechar_botao.Location = new System.Drawing.Point(30, 124);
            this.Fechar_botao.Name = "Fechar_botao";
            this.Fechar_botao.Size = new System.Drawing.Size(75, 23);
            this.Fechar_botao.TabIndex = 4;
            this.Fechar_botao.Text = "Fechar";
            this.Fechar_botao.UseVisualStyleBackColor = true;
            this.Fechar_botao.Click += new System.EventHandler(this.Fechar_botao_Click);
            // 
            // Confirmar_botao
            // 
            this.Confirmar_botao.Location = new System.Drawing.Point(120, 124);
            this.Confirmar_botao.Name = "Confirmar_botao";
            this.Confirmar_botao.Size = new System.Drawing.Size(75, 23);
            this.Confirmar_botao.TabIndex = 5;
            this.Confirmar_botao.Text = "Confirmar";
            this.Confirmar_botao.UseVisualStyleBackColor = true;
            this.Confirmar_botao.Click += new System.EventHandler(this.Confirmar_botao_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 6;
            // 
            // Cadastrar_Conta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 180);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Confirmar_botao);
            this.Controls.Add(this.Fechar_botao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Data);
            this.Controls.Add(this.textBox_Consumo);
            this.Name = "Cadastrar_Conta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Conta";
            this.Load += new System.EventHandler(this.Cadastrar_Conta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Consumo;
        private System.Windows.Forms.TextBox textBox_Data;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Fechar_botao;
        private System.Windows.Forms.Button Confirmar_botao;
        private System.Windows.Forms.Label label3;
    }
}