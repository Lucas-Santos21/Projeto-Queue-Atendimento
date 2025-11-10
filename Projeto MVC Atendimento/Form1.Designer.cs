namespace Projeto_MVC_Atendimento
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGerar = new System.Windows.Forms.Button();
            this.btnListarSenhas = new System.Windows.Forms.Button();
            this.btnAdicionarGuiche = new System.Windows.Forms.Button();
            this.btnChamar = new System.Windows.Forms.Button();
            this.btnListarAtendimentos = new System.Windows.Forms.Button();
            this.lstSenhas = new System.Windows.Forms.ListBox();
            this.lstAtendimentos = new System.Windows.Forms.ListBox();
            this.lblQtdGuiches = new System.Windows.Forms.Label();
            this.txtGuiche = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(119, 81);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(95, 23);
            this.btnGerar.TabIndex = 0;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // btnListarSenhas
            // 
            this.btnListarSenhas.Location = new System.Drawing.Point(119, 304);
            this.btnListarSenhas.Name = "btnListarSenhas";
            this.btnListarSenhas.Size = new System.Drawing.Size(95, 28);
            this.btnListarSenhas.TabIndex = 1;
            this.btnListarSenhas.Text = "Listar Senhas";
            this.btnListarSenhas.UseVisualStyleBackColor = true;
            this.btnListarSenhas.Click += new System.EventHandler(this.btnListarSenhas_Click);
            // 
            // btnAdicionarGuiche
            // 
            this.btnAdicionarGuiche.Location = new System.Drawing.Point(288, 199);
            this.btnAdicionarGuiche.Name = "btnAdicionarGuiche";
            this.btnAdicionarGuiche.Size = new System.Drawing.Size(85, 38);
            this.btnAdicionarGuiche.TabIndex = 2;
            this.btnAdicionarGuiche.Text = "Adicionar";
            this.btnAdicionarGuiche.UseVisualStyleBackColor = true;
            this.btnAdicionarGuiche.Click += new System.EventHandler(this.btnAdicionarGuiche_Click);
            // 
            // btnChamar
            // 
            this.btnChamar.Location = new System.Drawing.Point(583, 78);
            this.btnChamar.Name = "btnChamar";
            this.btnChamar.Size = new System.Drawing.Size(75, 23);
            this.btnChamar.TabIndex = 3;
            this.btnChamar.Text = "Chamar";
            this.btnChamar.UseVisualStyleBackColor = true;
            this.btnChamar.Click += new System.EventHandler(this.btnChamar_Click);
            // 
            // btnListarAtendimentos
            // 
            this.btnListarAtendimentos.Location = new System.Drawing.Point(431, 309);
            this.btnListarAtendimentos.Name = "btnListarAtendimentos";
            this.btnListarAtendimentos.Size = new System.Drawing.Size(200, 23);
            this.btnListarAtendimentos.TabIndex = 4;
            this.btnListarAtendimentos.Text = "Listar Atendimentos";
            this.btnListarAtendimentos.UseVisualStyleBackColor = true;
            this.btnListarAtendimentos.Click += new System.EventHandler(this.btnListarAtendimentos_Click);
            // 
            // lstSenhas
            // 
            this.lstSenhas.FormattingEnabled = true;
            this.lstSenhas.Location = new System.Drawing.Point(77, 110);
            this.lstSenhas.Name = "lstSenhas";
            this.lstSenhas.Size = new System.Drawing.Size(189, 173);
            this.lstSenhas.TabIndex = 5;
            // 
            // lstAtendimentos
            // 
            this.lstAtendimentos.FormattingEnabled = true;
            this.lstAtendimentos.Location = new System.Drawing.Point(397, 110);
            this.lstAtendimentos.Name = "lstAtendimentos";
            this.lstAtendimentos.Size = new System.Drawing.Size(276, 173);
            this.lstAtendimentos.TabIndex = 6;
            // 
            // lblQtdGuiches
            // 
            this.lblQtdGuiches.AutoSize = true;
            this.lblQtdGuiches.Location = new System.Drawing.Point(322, 172);
            this.lblQtdGuiches.Name = "lblQtdGuiches";
            this.lblQtdGuiches.Size = new System.Drawing.Size(13, 13);
            this.lblQtdGuiches.TabIndex = 7;
            this.lblQtdGuiches.Text = "0";
            // 
            // txtGuiche
            // 
            this.txtGuiche.Location = new System.Drawing.Point(477, 81);
            this.txtGuiche.Name = "txtGuiche";
            this.txtGuiche.Size = new System.Drawing.Size(100, 20);
            this.txtGuiche.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Qtde de Senhas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(413, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Guiche:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 476);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGuiche);
            this.Controls.Add(this.lblQtdGuiches);
            this.Controls.Add(this.lstAtendimentos);
            this.Controls.Add(this.lstSenhas);
            this.Controls.Add(this.btnListarAtendimentos);
            this.Controls.Add(this.btnChamar);
            this.Controls.Add(this.btnAdicionarGuiche);
            this.Controls.Add(this.btnListarSenhas);
            this.Controls.Add(this.btnGerar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Button btnListarSenhas;
        private System.Windows.Forms.Button btnAdicionarGuiche;
        private System.Windows.Forms.Button btnChamar;
        private System.Windows.Forms.Button btnListarAtendimentos;
        private System.Windows.Forms.ListBox lstSenhas;
        private System.Windows.Forms.ListBox lstAtendimentos;
        private System.Windows.Forms.Label lblQtdGuiches;
        private System.Windows.Forms.TextBox txtGuiche;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

