namespace Calculadora
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.quatro = new System.Windows.Forms.Button();
            this.divisao = new System.Windows.Forms.Button();
            this.nove = new System.Windows.Forms.Button();
            this.oito = new System.Windows.Forms.Button();
            this.sete = new System.Windows.Forms.Button();
            this.seis = new System.Windows.Forms.Button();
            this.cinco = new System.Windows.Forms.Button();
            this.dois = new System.Windows.Forms.Button();
            this.um = new System.Windows.Forms.Button();
            this.multiplicacao = new System.Windows.Forms.Button();
            this.tres = new System.Windows.Forms.Button();
            this.igual = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.virgula = new System.Windows.Forms.Button();
            this.mais = new System.Windows.Forms.Button();
            this.menos = new System.Windows.Forms.Button();
            this.apagar = new System.Windows.Forms.Button();
            this.lblOperacao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 34);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(237, 55);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // quatro
            // 
            this.quatro.Location = new System.Drawing.Point(12, 158);
            this.quatro.Name = "quatro";
            this.quatro.Size = new System.Drawing.Size(75, 53);
            this.quatro.TabIndex = 1;
            this.quatro.Text = "4";
            this.quatro.UseVisualStyleBackColor = true;
            this.quatro.Click += new System.EventHandler(this.quatro_Click);
            // 
            // divisao
            // 
            this.divisao.Location = new System.Drawing.Point(255, 95);
            this.divisao.Name = "divisao";
            this.divisao.Size = new System.Drawing.Size(75, 57);
            this.divisao.TabIndex = 2;
            this.divisao.Text = "/";
            this.divisao.UseVisualStyleBackColor = true;
            this.divisao.Click += new System.EventHandler(this.divisao_Click);
            // 
            // nove
            // 
            this.nove.Location = new System.Drawing.Point(174, 95);
            this.nove.Name = "nove";
            this.nove.Size = new System.Drawing.Size(75, 57);
            this.nove.TabIndex = 3;
            this.nove.Text = "9";
            this.nove.UseVisualStyleBackColor = true;
            this.nove.Click += new System.EventHandler(this.nove_Click);
            // 
            // oito
            // 
            this.oito.Location = new System.Drawing.Point(93, 95);
            this.oito.Name = "oito";
            this.oito.Size = new System.Drawing.Size(75, 57);
            this.oito.TabIndex = 4;
            this.oito.Text = "8";
            this.oito.UseVisualStyleBackColor = true;
            this.oito.Click += new System.EventHandler(this.oito_Click);
            // 
            // sete
            // 
            this.sete.Location = new System.Drawing.Point(12, 95);
            this.sete.Name = "sete";
            this.sete.Size = new System.Drawing.Size(75, 57);
            this.sete.TabIndex = 5;
            this.sete.Text = "7";
            this.sete.UseVisualStyleBackColor = true;
            this.sete.Click += new System.EventHandler(this.sete_Click);
            // 
            // seis
            // 
            this.seis.Location = new System.Drawing.Point(174, 158);
            this.seis.Name = "seis";
            this.seis.Size = new System.Drawing.Size(75, 53);
            this.seis.TabIndex = 6;
            this.seis.Text = "6";
            this.seis.UseVisualStyleBackColor = true;
            this.seis.Click += new System.EventHandler(this.seis_Click);
            // 
            // cinco
            // 
            this.cinco.Location = new System.Drawing.Point(93, 158);
            this.cinco.Name = "cinco";
            this.cinco.Size = new System.Drawing.Size(75, 53);
            this.cinco.TabIndex = 7;
            this.cinco.Text = "5";
            this.cinco.UseVisualStyleBackColor = true;
            this.cinco.Click += new System.EventHandler(this.cinco_Click);
            // 
            // dois
            // 
            this.dois.Location = new System.Drawing.Point(93, 217);
            this.dois.Name = "dois";
            this.dois.Size = new System.Drawing.Size(75, 58);
            this.dois.TabIndex = 8;
            this.dois.Text = "2";
            this.dois.UseVisualStyleBackColor = true;
            this.dois.Click += new System.EventHandler(this.dois_Click);
            // 
            // um
            // 
            this.um.Location = new System.Drawing.Point(12, 217);
            this.um.Name = "um";
            this.um.Size = new System.Drawing.Size(75, 58);
            this.um.TabIndex = 9;
            this.um.Text = "1";
            this.um.UseVisualStyleBackColor = true;
            this.um.Click += new System.EventHandler(this.um_Click);
            // 
            // multiplicacao
            // 
            this.multiplicacao.Location = new System.Drawing.Point(255, 158);
            this.multiplicacao.Name = "multiplicacao";
            this.multiplicacao.Size = new System.Drawing.Size(75, 53);
            this.multiplicacao.TabIndex = 10;
            this.multiplicacao.Text = "X";
            this.multiplicacao.UseVisualStyleBackColor = true;
            this.multiplicacao.Click += new System.EventHandler(this.multiplicacao_Click);
            // 
            // tres
            // 
            this.tres.Location = new System.Drawing.Point(174, 217);
            this.tres.Name = "tres";
            this.tres.Size = new System.Drawing.Size(75, 58);
            this.tres.TabIndex = 11;
            this.tres.Text = "3";
            this.tres.UseVisualStyleBackColor = true;
            this.tres.Click += new System.EventHandler(this.button11_Click);
            // 
            // igual
            // 
            this.igual.Location = new System.Drawing.Point(174, 281);
            this.igual.Name = "igual";
            this.igual.Size = new System.Drawing.Size(75, 53);
            this.igual.TabIndex = 12;
            this.igual.Text = "=";
            this.igual.UseVisualStyleBackColor = true;
            this.igual.Click += new System.EventHandler(this.igual_Click);
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(93, 281);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(75, 53);
            this.zero.TabIndex = 13;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // virgula
            // 
            this.virgula.Location = new System.Drawing.Point(12, 281);
            this.virgula.Name = "virgula";
            this.virgula.Size = new System.Drawing.Size(75, 53);
            this.virgula.TabIndex = 14;
            this.virgula.Text = ",";
            this.virgula.UseVisualStyleBackColor = true;
            this.virgula.Click += new System.EventHandler(this.virgula_Click);
            // 
            // mais
            // 
            this.mais.Location = new System.Drawing.Point(255, 281);
            this.mais.Name = "mais";
            this.mais.Size = new System.Drawing.Size(75, 53);
            this.mais.TabIndex = 15;
            this.mais.Text = "+";
            this.mais.UseVisualStyleBackColor = true;
            this.mais.Click += new System.EventHandler(this.mais_Click);
            // 
            // menos
            // 
            this.menos.Location = new System.Drawing.Point(255, 217);
            this.menos.Name = "menos";
            this.menos.Size = new System.Drawing.Size(75, 53);
            this.menos.TabIndex = 16;
            this.menos.Text = "-";
            this.menos.UseVisualStyleBackColor = true;
            this.menos.Click += new System.EventHandler(this.menos_Click);
            // 
            // apagar
            // 
            this.apagar.Location = new System.Drawing.Point(255, 36);
            this.apagar.Name = "apagar";
            this.apagar.Size = new System.Drawing.Size(75, 53);
            this.apagar.TabIndex = 17;
            this.apagar.Text = "C";
            this.apagar.UseVisualStyleBackColor = true;
            this.apagar.Click += new System.EventHandler(this.apagar_Click);
            // 
            // lblOperacao
            // 
            this.lblOperacao.AutoSize = true;
            this.lblOperacao.Location = new System.Drawing.Point(23, 56);
            this.lblOperacao.Name = "lblOperacao";
            this.lblOperacao.Size = new System.Drawing.Size(0, 13);
            this.lblOperacao.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 450);
            this.Controls.Add(this.lblOperacao);
            this.Controls.Add(this.apagar);
            this.Controls.Add(this.menos);
            this.Controls.Add(this.mais);
            this.Controls.Add(this.virgula);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.igual);
            this.Controls.Add(this.tres);
            this.Controls.Add(this.multiplicacao);
            this.Controls.Add(this.um);
            this.Controls.Add(this.dois);
            this.Controls.Add(this.cinco);
            this.Controls.Add(this.seis);
            this.Controls.Add(this.sete);
            this.Controls.Add(this.oito);
            this.Controls.Add(this.nove);
            this.Controls.Add(this.divisao);
            this.Controls.Add(this.quatro);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button quatro;
        private System.Windows.Forms.Button divisao;
        private System.Windows.Forms.Button nove;
        private System.Windows.Forms.Button oito;
        private System.Windows.Forms.Button sete;
        private System.Windows.Forms.Button seis;
        private System.Windows.Forms.Button cinco;
        private System.Windows.Forms.Button dois;
        private System.Windows.Forms.Button um;
        private System.Windows.Forms.Button multiplicacao;
        private System.Windows.Forms.Button tres;
        private System.Windows.Forms.Button igual;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button virgula;
        private System.Windows.Forms.Button mais;
        private System.Windows.Forms.Button menos;
        private System.Windows.Forms.Button apagar;
        private System.Windows.Forms.Label lblOperacao;
    }
}

