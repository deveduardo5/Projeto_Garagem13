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
            labelSenha = new Label();
            labelEmail = new Label();
            labelTitulo = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonEntrar
            // 
            buttonEntrar.Location = new Point(331, 283);
            buttonEntrar.Margin = new Padding(3, 2, 3, 2);
            buttonEntrar.Name = "buttonEntrar";
            buttonEntrar.Size = new Size(82, 22);
            buttonEntrar.TabIndex = 13;
            buttonEntrar.Text = "Entrar";
            buttonEntrar.UseVisualStyleBackColor = true;
            buttonEntrar.Click += buttonEntrar_Click;
            // 
            // textBoxSenha
            // 
            textBoxSenha.Location = new Point(279, 230);
            textBoxSenha.Margin = new Padding(3, 2, 3, 2);
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.Size = new Size(201, 23);
            textBoxSenha.TabIndex = 12;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(279, 194);
            textBoxEmail.Margin = new Padding(3, 2, 3, 2);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(201, 23);
            textBoxEmail.TabIndex = 11;
            // 
            // labelSenha
            // 
            labelSenha.AutoSize = true;
            labelSenha.Location = new Point(223, 238);
            labelSenha.Name = "labelSenha";
            labelSenha.Size = new Size(39, 15);
            labelSenha.TabIndex = 9;
            labelSenha.Text = "Senha";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(223, 202);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(41, 15);
            labelEmail.TabIndex = 8;
            labelEmail.Text = "E-mail";
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.BackColor = SystemColors.Control;
            labelTitulo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitulo.Location = new Point(279, 159);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(170, 21);
            labelTitulo.TabIndex = 7;
            labelTitulo.Text = "Entre com seu usuário";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.original_0E2F809E_0FEB_45EE_B16D_009238021042;
            pictureBox1.Location = new Point(244, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(269, 155);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // login_usuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(pictureBox1);
            Controls.Add(buttonEntrar);
            Controls.Add(textBoxSenha);
            Controls.Add(textBoxEmail);
            Controls.Add(labelSenha);
            Controls.Add(labelEmail);
            Controls.Add(labelTitulo);
            Margin = new Padding(3, 2, 3, 2);
            Name = "login_usuario";
            Text = "login_usuario";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonEntrar;
        private TextBox textBoxSenha;
        private TextBox textBoxEmail;
        private Label labelSenha;
        private Label labelEmail;
        private Label labelTitulo;
        private PictureBox pictureBox1;
    }
}