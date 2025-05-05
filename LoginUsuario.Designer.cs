namespace garagem13
{
    partial class TelaLoginUsuario
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
            textBoxSenhaLU = new TextBox();
            textBoxEmailLU = new TextBox();
            labelSenhaLU = new Label();
            labelEmailLU = new Label();
            labelTitulo = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonEntrar
            // 
            buttonEntrar.Location = new Point(381, 398);
            buttonEntrar.Name = "buttonEntrar";
            buttonEntrar.Size = new Size(94, 29);
            buttonEntrar.TabIndex = 13;
            buttonEntrar.Text = "Entrar";
            buttonEntrar.UseVisualStyleBackColor = true;
            buttonEntrar.Click += buttonEntrar_Click;
            // 
            // textBoxSenhaLU
            // 
            textBoxSenhaLU.Location = new Point(319, 307);
            textBoxSenhaLU.Name = "textBoxSenhaLU";
            textBoxSenhaLU.Size = new Size(229, 27);
            textBoxSenhaLU.TabIndex = 12;
            // 
            // textBoxEmailLU
            // 
            textBoxEmailLU.Location = new Point(319, 259);
            textBoxEmailLU.Name = "textBoxEmailLU";
            textBoxEmailLU.Size = new Size(229, 27);
            textBoxEmailLU.TabIndex = 11;
            // 
            // labelSenhaLU
            // 
            labelSenhaLU.AutoSize = true;
            labelSenhaLU.Location = new Point(255, 317);
            labelSenhaLU.Name = "labelSenhaLU";
            labelSenhaLU.Size = new Size(49, 20);
            labelSenhaLU.TabIndex = 9;
            labelSenhaLU.Text = "Senha";
            // 
            // labelEmailLU
            // 
            labelEmailLU.AutoSize = true;
            labelEmailLU.Location = new Point(255, 269);
            labelEmailLU.Name = "labelEmailLU";
            labelEmailLU.Size = new Size(52, 20);
            labelEmailLU.TabIndex = 8;
            labelEmailLU.Text = "E-mail";
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.BackColor = SystemColors.Control;
            labelTitulo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitulo.Location = new Point(319, 212);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(215, 28);
            labelTitulo.TabIndex = 7;
            labelTitulo.Text = "Entre com seu usuário";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.original_0E2F809E_0FEB_45EE_B16D_009238021042;
            pictureBox1.Location = new Point(279, 1);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(307, 207);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // TelaLoginUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(870, 451);
            Controls.Add(pictureBox1);
            Controls.Add(buttonEntrar);
            Controls.Add(textBoxSenhaLU);
            Controls.Add(textBoxEmailLU);
            Controls.Add(labelSenhaLU);
            Controls.Add(labelEmailLU);
            Controls.Add(labelTitulo);
            Name = "TelaLoginUsuario";
            Text = "LoginUsuario";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonEntrar;
        private TextBox textBoxSenhaLU;
        private TextBox textBoxEmailLU;
        private Label labelSenhaLU;
        private Label labelEmailLU;
        private Label labelTitulo;
        private PictureBox pictureBox1;
    }
}