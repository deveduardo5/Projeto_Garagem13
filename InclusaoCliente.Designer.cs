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
            SuspendLayout();
            // 
            // buttonVoltarIC
            // 
            buttonVoltarIC.Location = new Point(300, 276);
            buttonVoltarIC.Name = "buttonVoltarIC";
            buttonVoltarIC.Size = new Size(101, 23);
            buttonVoltarIC.TabIndex = 3;
            buttonVoltarIC.Text = "Voltar";
            buttonVoltarIC.UseVisualStyleBackColor = true;
            buttonVoltarIC.Click += buttonVoltarIC_Click_1;
            // 
            // buttonIncluirIC
            // 
            buttonIncluirIC.Location = new Point(300, 305);
            buttonIncluirIC.Name = "buttonIncluirIC";
            buttonIncluirIC.Size = new Size(101, 23);
            buttonIncluirIC.TabIndex = 2;
            buttonIncluirIC.Text = "Incluir";
            buttonIncluirIC.UseVisualStyleBackColor = true;
            buttonIncluirIC.Click += buttonIncluirIC_Click;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(35, 85);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(40, 15);
            labelNome.TabIndex = 4;
            labelNome.Text = "Nome";
            // 
            // labelIdade
            // 
            labelIdade.AutoSize = true;
            labelIdade.Location = new Point(38, 106);
            labelIdade.Name = "labelIdade";
            labelIdade.Size = new Size(36, 15);
            labelIdade.TabIndex = 5;
            labelIdade.Text = "Idade";
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Location = new Point(38, 134);
            Email.Name = "Email";
            Email.Size = new Size(36, 15);
            Email.TabIndex = 6;
            Email.Text = "Email";
            // 
            // labelTelefone
            // 
            labelTelefone.AutoSize = true;
            labelTelefone.Location = new Point(21, 156);
            labelTelefone.Name = "labelTelefone";
            labelTelefone.Size = new Size(51, 15);
            labelTelefone.TabIndex = 7;
            labelTelefone.Text = "Telefone";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(84, 80);
            textBoxNome.Margin = new Padding(3, 2, 3, 2);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(210, 23);
            textBoxNome.TabIndex = 8;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(84, 129);
            textBoxEmail.Margin = new Padding(3, 2, 3, 2);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(210, 23);
            textBoxEmail.TabIndex = 9;
            // 
            // textBoxIdade
            // 
            textBoxIdade.Location = new Point(84, 104);
            textBoxIdade.Margin = new Padding(3, 2, 3, 2);
            textBoxIdade.Name = "textBoxIdade";
            textBoxIdade.Size = new Size(210, 23);
            textBoxIdade.TabIndex = 10;
            // 
            // labelLogradouro
            // 
            labelLogradouro.AutoSize = true;
            labelLogradouro.Location = new Point(375, 110);
            labelLogradouro.Name = "labelLogradouro";
            labelLogradouro.Size = new Size(69, 15);
            labelLogradouro.TabIndex = 12;
            labelLogradouro.Text = "Logradouro";
            // 
            // labelNumero
            // 
            labelNumero.AutoSize = true;
            labelNumero.Location = new Point(396, 131);
            labelNumero.Name = "labelNumero";
            labelNumero.Size = new Size(51, 15);
            labelNumero.TabIndex = 13;
            labelNumero.Text = "Número";
            // 
            // labelComplemento
            // 
            labelComplemento.AutoSize = true;
            labelComplemento.Location = new Point(360, 156);
            labelComplemento.Name = "labelComplemento";
            labelComplemento.Size = new Size(84, 15);
            labelComplemento.TabIndex = 14;
            labelComplemento.Text = "Complemento";
            // 
            // labelCEP
            // 
            labelCEP.AutoSize = true;
            labelCEP.Location = new Point(422, 82);
            labelCEP.Name = "labelCEP";
            labelCEP.Size = new Size(28, 15);
            labelCEP.TabIndex = 15;
            labelCEP.Text = "CEP";
            // 
            // labelBairro
            // 
            labelBairro.AutoSize = true;
            labelBairro.Location = new Point(409, 181);
            labelBairro.Name = "labelBairro";
            labelBairro.Size = new Size(38, 15);
            labelBairro.TabIndex = 16;
            labelBairro.Text = "Bairro";
            // 
            // textBoxLogradouro
            // 
            textBoxLogradouro.Location = new Point(457, 104);
            textBoxLogradouro.Margin = new Padding(3, 2, 3, 2);
            textBoxLogradouro.Name = "textBoxLogradouro";
            textBoxLogradouro.Size = new Size(210, 23);
            textBoxLogradouro.TabIndex = 17;
            // 
            // textBoxNumero
            // 
            textBoxNumero.Location = new Point(457, 129);
            textBoxNumero.Margin = new Padding(3, 2, 3, 2);
            textBoxNumero.Name = "textBoxNumero";
            textBoxNumero.Size = new Size(210, 23);
            textBoxNumero.TabIndex = 18;
            // 
            // textBoxComplemento
            // 
            textBoxComplemento.Location = new Point(457, 154);
            textBoxComplemento.Margin = new Padding(3, 2, 3, 2);
            textBoxComplemento.Name = "textBoxComplemento";
            textBoxComplemento.Size = new Size(210, 23);
            textBoxComplemento.TabIndex = 19;
            // 
            // textBoxBairro
            // 
            textBoxBairro.Location = new Point(457, 178);
            textBoxBairro.Margin = new Padding(3, 2, 3, 2);
            textBoxBairro.Name = "textBoxBairro";
            textBoxBairro.Size = new Size(210, 23);
            textBoxBairro.TabIndex = 21;
            // 
            // textBoxMunicipio
            // 
            textBoxMunicipio.Location = new Point(457, 203);
            textBoxMunicipio.Margin = new Padding(3, 2, 3, 2);
            textBoxMunicipio.Name = "textBoxMunicipio";
            textBoxMunicipio.Size = new Size(210, 23);
            textBoxMunicipio.TabIndex = 22;
            // 
            // textBoxEstado
            // 
            textBoxEstado.Location = new Point(457, 228);
            textBoxEstado.Margin = new Padding(3, 2, 3, 2);
            textBoxEstado.MaxLength = 2;
            textBoxEstado.Name = "textBoxEstado";
            textBoxEstado.Size = new Size(210, 23);
            textBoxEstado.TabIndex = 23;
            // 
            // labelMunicipio
            // 
            labelMunicipio.AutoSize = true;
            labelMunicipio.Location = new Point(386, 206);
            labelMunicipio.Name = "labelMunicipio";
            labelMunicipio.Size = new Size(61, 15);
            labelMunicipio.TabIndex = 24;
            labelMunicipio.Text = "Município";
            // 
            // labelEstado
            // 
            labelEstado.AutoSize = true;
            labelEstado.Location = new Point(404, 230);
            labelEstado.Name = "labelEstado";
            labelEstado.Size = new Size(42, 15);
            labelEstado.TabIndex = 25;
            labelEstado.Text = "Estado";
            // 
            // maskedTextBoxCEP
            // 
            maskedTextBoxCEP.Location = new Point(457, 77);
            maskedTextBoxCEP.Margin = new Padding(3, 2, 3, 2);
            maskedTextBoxCEP.Mask = "00000-000";
            maskedTextBoxCEP.Name = "maskedTextBoxCEP";
            maskedTextBoxCEP.Size = new Size(115, 23);
            maskedTextBoxCEP.TabIndex = 26;
            // 
            // maskedTextBoxTelefone
            // 
            maskedTextBoxTelefone.Location = new Point(84, 154);
            maskedTextBoxTelefone.Margin = new Padding(3, 2, 3, 2);
            maskedTextBoxTelefone.Mask = "(00) 00000-0000";
            maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            maskedTextBoxTelefone.Size = new Size(115, 23);
            maskedTextBoxTelefone.TabIndex = 27;
            // 
            // labelCadastro
            // 
            labelCadastro.AutoSize = true;
            labelCadastro.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCadastro.Location = new Point(281, 26);
            labelCadastro.Name = "labelCadastro";
            labelCadastro.Size = new Size(128, 30);
            labelCadastro.TabIndex = 28;
            labelCadastro.Text = "CADASTRO";
            // 
            // labelErro
            // 
            labelErro.AutoSize = true;
            labelErro.Location = new Point(84, 284);
            labelErro.Name = "labelErro";
            labelErro.Size = new Size(10, 15);
            labelErro.TabIndex = 29;
            labelErro.Text = ".";
            // 
            // TelaInclusaoCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(labelErro);
            Controls.Add(labelCadastro);
            Controls.Add(maskedTextBoxTelefone);
            Controls.Add(maskedTextBoxCEP);
            Controls.Add(labelEstado);
            Controls.Add(labelMunicipio);
            Controls.Add(textBoxEstado);
            Controls.Add(textBoxMunicipio);
            Controls.Add(textBoxBairro);
            Controls.Add(textBoxComplemento);
            Controls.Add(textBoxNumero);
            Controls.Add(textBoxLogradouro);
            Controls.Add(labelBairro);
            Controls.Add(labelCEP);
            Controls.Add(labelComplemento);
            Controls.Add(labelNumero);
            Controls.Add(labelLogradouro);
            Controls.Add(textBoxIdade);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxNome);
            Controls.Add(labelTelefone);
            Controls.Add(Email);
            Controls.Add(labelIdade);
            Controls.Add(labelNome);
            Controls.Add(buttonVoltarIC);
            Controls.Add(buttonIncluirIC);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TelaInclusaoCliente";
            Text = "InclusaoCliente";
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
    }
}