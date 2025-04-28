namespace garagem13
{
    partial class login_usuario
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
            buttonEntrar = new Button();
            textBoxSenha = new TextBox();
            textBoxEmail = new TextBox();
            labelErroLogin = new Label();
            labelSenha = new Label();
            labelEmail = new Label();
            labelTitulo = new Label();
            SuspendLayout();
            // 
            // buttonEntrar
            // 
            buttonEntrar.Location = new Point(370, 316);
            buttonEntrar.Name = "buttonEntrar";
            buttonEntrar.Size = new Size(94, 29);
            buttonEntrar.TabIndex = 13;
            buttonEntrar.Text = "Entrar";
            buttonEntrar.UseVisualStyleBackColor = true;
            buttonEntrar.Click += buttonEntrar_Click;
            // 
            // textBoxSenha
            // 
            textBoxSenha.Location = new Point(319, 216);
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.Size = new Size(229, 27);
            textBoxSenha.TabIndex = 12;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(319, 173);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(229, 27);
            textBoxEmail.TabIndex = 11;
            // 
            // labelErroLogin
            // 
            labelErroLogin.AutoSize = true;
            labelErroLogin.Location = new Point(349, 272);
            labelErroLogin.Name = "labelErroLogin";
            labelErroLogin.Size = new Size(12, 20);
            labelErroLogin.TabIndex = 10;
            labelErroLogin.Text = ".";
            // 
            // labelSenha
            // 
            labelSenha.AutoSize = true;
            labelSenha.Location = new Point(256, 219);
            labelSenha.Name = "labelSenha";
            labelSenha.Size = new Size(49, 20);
            labelSenha.TabIndex = 9;
            labelSenha.Text = "Senha";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(253, 176);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(52, 20);
            labelEmail.TabIndex = 8;
            labelEmail.Text = "E-mail";
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.BackColor = SystemColors.Control;
            labelTitulo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitulo.Location = new Point(307, 106);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(215, 28);
            labelTitulo.TabIndex = 7;
            labelTitulo.Text = "Entre com seu usuário";
            // 
            // login_usuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonEntrar);
            Controls.Add(textBoxSenha);
            Controls.Add(textBoxEmail);
            Controls.Add(labelErroLogin);
            Controls.Add(labelSenha);
            Controls.Add(labelEmail);
            Controls.Add(labelTitulo);
            Name = "login_usuario";
            Text = "login_usuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonEntrar;
        private TextBox textBoxSenha;
        private TextBox textBoxEmail;
        private Label labelErroLogin;
        private Label labelSenha;
        private Label labelEmail;
        private Label labelTitulo;
    }
}