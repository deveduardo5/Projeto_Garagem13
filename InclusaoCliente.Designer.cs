namespace garagem13
{
    partial class TelaInclusaoCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInclusaoCliente));
            buttonVoltarIC = new Button();
            buttonIncluirIC = new Button();
            labelNome = new Label();
            labelIdade = new Label();
            Email = new Label();
            labelTelefone = new Label();
            textBoxNome = new TextBox();
            textBoxEmail = new TextBox();
            textBoxIdade = new TextBox();
            labelLogradouro = new Label();
            labelNumero = new Label();
            labelComplemento = new Label();
            labelCEP = new Label();
            labelBairro = new Label();
            textBoxLogradouro = new TextBox();
            textBoxNumero = new TextBox();
            textBoxComplemento = new TextBox();
            textBoxBairro = new TextBox();
            textBoxMunicipio = new TextBox();
            textBoxEstado = new TextBox();
            labelMunicipio = new Label();
            labelEstado = new Label();
            maskedTextBoxCEP = new MaskedTextBox();
            maskedTextBoxTelefone = new MaskedTextBox();
            labelCadastro = new Label();
            labelErro = new Label();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // buttonVoltarIC
            // 
            buttonVoltarIC.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonVoltarIC.Location = new Point(14, 756);
            buttonVoltarIC.Margin = new Padding(4, 5, 4, 5);
            buttonVoltarIC.Name = "buttonVoltarIC";
            buttonVoltarIC.Size = new Size(191, 39);
            buttonVoltarIC.TabIndex = 3;
            buttonVoltarIC.Text = "Voltar";
            buttonVoltarIC.UseVisualStyleBackColor = true;
            buttonVoltarIC.Click += buttonVoltarIC_Click_1;
            // 
            // buttonIncluirIC
            // 
            buttonIncluirIC.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonIncluirIC.Location = new Point(233, 745);
            buttonIncluirIC.Margin = new Padding(4, 5, 4, 5);
            buttonIncluirIC.Name = "buttonIncluirIC";
            buttonIncluirIC.Size = new Size(191, 39);
            buttonIncluirIC.TabIndex = 2;
            buttonIncluirIC.Text = "Incluir";
            buttonIncluirIC.UseVisualStyleBackColor = true;
            buttonIncluirIC.Click += buttonIncluirIC_Click;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(27, 61);
            labelNome.Margin = new Padding(4, 0, 4, 0);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(58, 21);
            labelNome.TabIndex = 4;
            labelNome.Text = "Nome";
            // 
            // labelIdade
            // 
            labelIdade.AutoSize = true;
            labelIdade.Location = new Point(27, 90);
            labelIdade.Margin = new Padding(4, 0, 4, 0);
            labelIdade.Name = "labelIdade";
            labelIdade.Size = new Size(63, 21);
            labelIdade.TabIndex = 5;
            labelIdade.Text = "Idade";
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Location = new Point(22, 137);
            Email.Margin = new Padding(4, 0, 4, 0);
            Email.Name = "Email";
            Email.Size = new Size(63, 21);
            Email.TabIndex = 6;
            Email.Text = "Email";
            // 
            // labelTelefone
            // 
            labelTelefone.AutoSize = true;
            labelTelefone.Location = new Point(7, 187);
            labelTelefone.Margin = new Padding(4, 0, 4, 0);
            labelTelefone.Name = "labelTelefone";
            labelTelefone.Size = new Size(97, 21);
            labelTelefone.TabIndex = 7;
            labelTelefone.Text = "Telefone";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(107, 53);
            textBoxNome.Margin = new Padding(4);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(298, 29);
            textBoxNome.TabIndex = 8;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(107, 134);
            textBoxEmail.Margin = new Padding(4);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(298, 29);
            textBoxEmail.TabIndex = 9;
            // 
            // textBoxIdade
            // 
            textBoxIdade.Location = new Point(112, 90);
            textBoxIdade.Margin = new Padding(4);
            textBoxIdade.Name = "textBoxIdade";
            textBoxIdade.Size = new Size(298, 29);
            textBoxIdade.TabIndex = 10;
            // 
            // labelLogradouro
            // 
            labelLogradouro.AutoSize = true;
            labelLogradouro.Location = new Point(44, 45);
            labelLogradouro.Margin = new Padding(4, 0, 4, 0);
            labelLogradouro.Name = "labelLogradouro";
            labelLogradouro.Size = new Size(46, 21);
            labelLogradouro.TabIndex = 12;
            labelLogradouro.Text = "Rua";
            // 
            // labelNumero
            // 
            labelNumero.AutoSize = true;
            labelNumero.Location = new Point(21, 121);
            labelNumero.Margin = new Padding(4, 0, 4, 0);
            labelNumero.Name = "labelNumero";
            labelNumero.Size = new Size(83, 21);
            labelNumero.TabIndex = 13;
            labelNumero.Text = "Número";
            // 
            // labelComplemento
            // 
            labelComplemento.AutoSize = true;
            labelComplemento.Location = new Point(-6, 84);
            labelComplemento.Margin = new Padding(4, 0, 4, 0);
            labelComplemento.Name = "labelComplemento";
            labelComplemento.Size = new Size(137, 21);
            labelComplemento.TabIndex = 14;
            labelComplemento.Text = "Complemento";
            // 
            // labelCEP
            // 
            labelCEP.AutoSize = true;
            labelCEP.Location = new Point(61, 170);
            labelCEP.Margin = new Padding(4, 0, 4, 0);
            labelCEP.Name = "labelCEP";
            labelCEP.Size = new Size(43, 21);
            labelCEP.TabIndex = 15;
            labelCEP.Text = "CEP";
            labelCEP.Click += labelCEP_Click;
            // 
            // labelBairro
            // 
            labelBairro.AutoSize = true;
            labelBairro.Location = new Point(44, 207);
            labelBairro.Margin = new Padding(4, 0, 4, 0);
            labelBairro.Name = "labelBairro";
            labelBairro.Size = new Size(77, 21);
            labelBairro.TabIndex = 16;
            labelBairro.Text = "Bairro";
            // 
            // textBoxLogradouro
            // 
            textBoxLogradouro.Location = new Point(143, 113);
            textBoxLogradouro.Margin = new Padding(4);
            textBoxLogradouro.Name = "textBoxLogradouro";
            textBoxLogradouro.Size = new Size(177, 29);
            textBoxLogradouro.TabIndex = 17;
            // 
            // textBoxNumero
            // 
            textBoxNumero.Location = new Point(134, 37);
            textBoxNumero.Margin = new Padding(4);
            textBoxNumero.Name = "textBoxNumero";
            textBoxNumero.Size = new Size(243, 29);
            textBoxNumero.TabIndex = 18;
            // 
            // textBoxComplemento
            // 
            textBoxComplemento.Location = new Point(134, 76);
            textBoxComplemento.Margin = new Padding(4);
            textBoxComplemento.Name = "textBoxComplemento";
            textBoxComplemento.Size = new Size(186, 29);
            textBoxComplemento.TabIndex = 19;
            // 
            // textBoxBairro
            // 
            textBoxBairro.Location = new Point(134, 199);
            textBoxBairro.Margin = new Padding(4);
            textBoxBairro.Name = "textBoxBairro";
            textBoxBairro.Size = new Size(243, 29);
            textBoxBairro.TabIndex = 21;
            // 
            // textBoxMunicipio
            // 
            textBoxMunicipio.Location = new Point(134, 238);
            textBoxMunicipio.Margin = new Padding(4);
            textBoxMunicipio.Name = "textBoxMunicipio";
            textBoxMunicipio.Size = new Size(243, 29);
            textBoxMunicipio.TabIndex = 22;
            // 
            // textBoxEstado
            // 
            textBoxEstado.Location = new Point(134, 277);
            textBoxEstado.Margin = new Padding(4);
            textBoxEstado.MaxLength = 2;
            textBoxEstado.Name = "textBoxEstado";
            textBoxEstado.Size = new Size(172, 29);
            textBoxEstado.TabIndex = 23;
            // 
            // labelMunicipio
            // 
            labelMunicipio.AutoSize = true;
            labelMunicipio.Location = new Point(24, 246);
            labelMunicipio.Margin = new Padding(4, 0, 4, 0);
            labelMunicipio.Name = "labelMunicipio";
            labelMunicipio.Size = new Size(102, 21);
            labelMunicipio.TabIndex = 24;
            labelMunicipio.Text = "Município";
            labelMunicipio.Click += labelMunicipio_Click;
            // 
            // labelEstado
            // 
            labelEstado.AutoSize = true;
            labelEstado.Location = new Point(50, 285);
            labelEstado.Margin = new Padding(4, 0, 4, 0);
            labelEstado.Name = "labelEstado";
            labelEstado.Size = new Size(76, 21);
            labelEstado.TabIndex = 25;
            labelEstado.Text = "Estado";
            // 
            // maskedTextBoxCEP
            // 
            maskedTextBoxCEP.Location = new Point(150, 162);
            maskedTextBoxCEP.Margin = new Padding(4);
            maskedTextBoxCEP.Mask = "00000-000";
            maskedTextBoxCEP.Name = "maskedTextBoxCEP";
            maskedTextBoxCEP.Size = new Size(163, 29);
            maskedTextBoxCEP.TabIndex = 26;
            // 
            // maskedTextBoxTelefone
            // 
            maskedTextBoxTelefone.Location = new Point(112, 179);
            maskedTextBoxTelefone.Margin = new Padding(4);
            maskedTextBoxTelefone.Mask = "(00) 00000-0000";
            maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            maskedTextBoxTelefone.Size = new Size(163, 29);
            maskedTextBoxTelefone.TabIndex = 27;
            // 
            // labelCadastro
            // 
            labelCadastro.AutoSize = true;
            labelCadastro.BackColor = Color.Transparent;
            labelCadastro.Font = new Font("Stencil", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCadastro.ForeColor = SystemColors.ActiveCaptionText;
            labelCadastro.Location = new Point(150, 75);
            labelCadastro.Margin = new Padding(4, 0, 4, 0);
            labelCadastro.Name = "labelCadastro";
            labelCadastro.Size = new Size(387, 38);
            labelCadastro.TabIndex = 28;
            labelCadastro.Text = "CADASTRO DE CLIENTE ";
            // 
            // labelErro
            // 
            labelErro.AutoSize = true;
            labelErro.Location = new Point(75, 812);
            labelErro.Margin = new Padding(4, 0, 4, 0);
            labelErro.Name = "labelErro";
            labelErro.Size = new Size(0, 25);
            labelErro.TabIndex = 29;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(textBoxNome);
            groupBox1.Controls.Add(labelNome);
            groupBox1.Controls.Add(textBoxIdade);
            groupBox1.Controls.Add(maskedTextBoxTelefone);
            groupBox1.Controls.Add(labelIdade);
            groupBox1.Controls.Add(textBoxEmail);
            groupBox1.Controls.Add(Email);
            groupBox1.Controls.Add(labelTelefone);
            groupBox1.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(14, 128);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(442, 241);
            groupBox1.TabIndex = 30;
            groupBox1.TabStop = false;
            groupBox1.Text = "DADOS PESSOAIS";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(21, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(122, 101);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(maskedTextBoxCEP);
            groupBox2.Controls.Add(labelCEP);
            groupBox2.Controls.Add(textBoxNumero);
            groupBox2.Controls.Add(labelLogradouro);
            groupBox2.Controls.Add(textBoxLogradouro);
            groupBox2.Controls.Add(labelEstado);
            groupBox2.Controls.Add(labelNumero);
            groupBox2.Controls.Add(textBoxEstado);
            groupBox2.Controls.Add(labelMunicipio);
            groupBox2.Controls.Add(textBoxComplemento);
            groupBox2.Controls.Add(labelComplemento);
            groupBox2.Controls.Add(textBoxMunicipio);
            groupBox2.Controls.Add(textBoxBairro);
            groupBox2.Controls.Add(labelBairro);
            groupBox2.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = SystemColors.ActiveCaptionText;
            groupBox2.Location = new Point(14, 375);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(410, 331);
            groupBox2.TabIndex = 31;
            groupBox2.TabStop = false;
            groupBox2.Text = "Endereço";
            // 
            // TelaInclusaoCliente
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(919, 869);
            Controls.Add(groupBox2);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Controls.Add(labelErro);
            Controls.Add(labelCadastro);
            Controls.Add(buttonVoltarIC);
            Controls.Add(buttonIncluirIC);
            Margin = new Padding(4);
            Name = "TelaInclusaoCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InclusaoCliente";
            Load += TelaInclusaoCliente_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonVoltarIC;
        private Button buttonIncluirIC;
        private Label labelNome;
        private Label labelIdade;
        private Label Email;
        private Label labelTelefone;
        private TextBox textBoxNome;
        private TextBox textBoxEmail;
        private TextBox textBoxIdade;
        private Label labelLogradouro;
        private Label labelNumero;
        private Label labelComplemento;
        private Label labelCEP;
        private Label labelBairro;
        private TextBox textBoxLogradouro;
        private TextBox textBoxNumero;
        private TextBox textBoxComplemento;
        private TextBox textBoxBairro;
        private TextBox textBoxMunicipio;
        private TextBox textBoxEstado;
        private Label labelMunicipio;
        private Label labelEstado;
        private MaskedTextBox maskedTextBoxCEP;
        private MaskedTextBox maskedTextBoxTelefone;
        private Label labelCadastro;
        private Label labelErro;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private GroupBox groupBox2;
    }
}