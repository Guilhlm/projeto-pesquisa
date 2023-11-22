namespace Arquivo_texto
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
            this.buttonsalvar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonler = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.labeltitulo1 = new System.Windows.Forms.Label();
            this.labeltitulo2 = new System.Windows.Forms.Label();
            this.labeltitulo3 = new System.Windows.Forms.Label();
            this.rbtelefone = new System.Windows.Forms.RadioButton();
            this.rbemail = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelcontato = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelnome = new System.Windows.Forms.Label();
            this.labelemail = new System.Windows.Forms.Label();
            this.labeltelefone = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonsalvar
            // 
            this.buttonsalvar.Location = new System.Drawing.Point(164, 268);
            this.buttonsalvar.Name = "buttonsalvar";
            this.buttonsalvar.Size = new System.Drawing.Size(84, 65);
            this.buttonsalvar.TabIndex = 0;
            this.buttonsalvar.Text = "SALVAR";
            this.buttonsalvar.UseVisualStyleBackColor = true;
            this.buttonsalvar.Click += new System.EventHandler(this.buttonsalvar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(11, 32);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(237, 48);
            this.textBox1.TabIndex = 2;
            // 
            // buttonler
            // 
            this.buttonler.Location = new System.Drawing.Point(12, 268);
            this.buttonler.Name = "buttonler";
            this.buttonler.Size = new System.Drawing.Size(85, 65);
            this.buttonler.TabIndex = 3;
            this.buttonler.Text = "LER";
            this.buttonler.UseVisualStyleBackColor = true;
            this.buttonler.Click += new System.EventHandler(this.buttonler_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(11, 114);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(238, 48);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(11, 190);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(238, 48);
            this.textBox3.TabIndex = 5;
            // 
            // labeltitulo1
            // 
            this.labeltitulo1.AutoSize = true;
            this.labeltitulo1.Location = new System.Drawing.Point(9, 16);
            this.labeltitulo1.Name = "labeltitulo1";
            this.labeltitulo1.Size = new System.Drawing.Size(35, 13);
            this.labeltitulo1.TabIndex = 6;
            this.labeltitulo1.Text = "Nome";
            // 
            // labeltitulo2
            // 
            this.labeltitulo2.AutoSize = true;
            this.labeltitulo2.Location = new System.Drawing.Point(8, 98);
            this.labeltitulo2.Name = "labeltitulo2";
            this.labeltitulo2.Size = new System.Drawing.Size(49, 13);
            this.labeltitulo2.TabIndex = 7;
            this.labeltitulo2.Text = "Telefone";
            // 
            // labeltitulo3
            // 
            this.labeltitulo3.AutoSize = true;
            this.labeltitulo3.Location = new System.Drawing.Point(8, 174);
            this.labeltitulo3.Name = "labeltitulo3";
            this.labeltitulo3.Size = new System.Drawing.Size(32, 13);
            this.labeltitulo3.TabIndex = 8;
            this.labeltitulo3.Text = "Email";
            // 
            // rbtelefone
            // 
            this.rbtelefone.AutoSize = true;
            this.rbtelefone.Location = new System.Drawing.Point(286, 33);
            this.rbtelefone.Name = "rbtelefone";
            this.rbtelefone.Size = new System.Drawing.Size(70, 17);
            this.rbtelefone.TabIndex = 9;
            this.rbtelefone.TabStop = true;
            this.rbtelefone.Text = "Telefone ";
            this.rbtelefone.UseVisualStyleBackColor = true;
            // 
            // rbemail
            // 
            this.rbemail.AutoSize = true;
            this.rbemail.Location = new System.Drawing.Point(286, 63);
            this.rbemail.Name = "rbemail";
            this.rbemail.Size = new System.Drawing.Size(49, 17);
            this.rbemail.TabIndex = 10;
            this.rbemail.TabStop = true;
            this.rbemail.Text = "email";
            this.rbemail.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(286, 141);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(210, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // labelcontato
            // 
            this.labelcontato.AutoSize = true;
            this.labelcontato.Location = new System.Drawing.Point(283, 117);
            this.labelcontato.Name = "labelcontato";
            this.labelcontato.Size = new System.Drawing.Size(74, 13);
            this.labelcontato.TabIndex = 13;
            this.labelcontato.Text = "Nome contato";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Telefone:";
            // 
            // labelnome
            // 
            this.labelnome.AutoSize = true;
            this.labelnome.Location = new System.Drawing.Point(362, 193);
            this.labelnome.Name = "labelnome";
            this.labelnome.Size = new System.Drawing.Size(75, 13);
            this.labelnome.TabIndex = 19;
            this.labelnome.Text = "respostaNome";
            // 
            // labelemail
            // 
            this.labelemail.AutoSize = true;
            this.labelemail.Location = new System.Drawing.Point(362, 225);
            this.labelemail.Name = "labelemail";
            this.labelemail.Size = new System.Drawing.Size(72, 13);
            this.labelemail.TabIndex = 18;
            this.labelemail.Text = "respostaEmail";
            // 
            // labeltelefone
            // 
            this.labeltelefone.AutoSize = true;
            this.labeltelefone.Location = new System.Drawing.Point(362, 256);
            this.labeltelefone.Name = "labeltelefone";
            this.labeltelefone.Size = new System.Drawing.Size(89, 13);
            this.labeltelefone.TabIndex = 17;
            this.labeltelefone.Text = "respostaTelefone";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 506);
            this.Controls.Add(this.labelnome);
            this.Controls.Add(this.labelemail);
            this.Controls.Add(this.labeltelefone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelcontato);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.rbemail);
            this.Controls.Add(this.rbtelefone);
            this.Controls.Add(this.labeltitulo3);
            this.Controls.Add(this.labeltitulo2);
            this.Controls.Add(this.labeltitulo1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.buttonler);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonsalvar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonsalvar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonler;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label labeltitulo1;
        private System.Windows.Forms.Label labeltitulo2;
        private System.Windows.Forms.Label labeltitulo3;
        private System.Windows.Forms.RadioButton rbtelefone;
        private System.Windows.Forms.RadioButton rbemail;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelcontato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelnome;
        private System.Windows.Forms.Label labelemail;
        private System.Windows.Forms.Label labeltelefone;
    }
}

