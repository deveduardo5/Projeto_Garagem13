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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaLoginUsuario));
            buttonEntrar = new Button();
            textBoxSenhaLU = new TextBox();
            textBoxEmailLU = new TextBox();
            labelTitulo = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // buttonEntrar
            // 
            buttonEntrar.Location = new Point(149, 433);
            buttonEntrar.Margin = new Padding(4);
            buttonEntrar.Name = "buttonEntrar";
            buttonEntrar.Size = new Size(118, 35);
            buttonEntrar.TabIndex = 13;
            buttonEntrar.Text = "Entrar";
            buttonEntrar.UseVisualStyleBackColor = true;
            buttonEntrar.Click += buttonEntrar_Click;
            // 
            // textBoxSenhaLU
            // 
            textBoxSenhaLU.Location = new Point(99, 367);
            textBoxSenhaLU.Margin = new Padding(4);
            textBoxSenhaLU.Name = "textBoxSenhaLU";
            textBoxSenhaLU.Size = new Size(257, 31);
            textBoxSenhaLU.TabIndex = 12;
            textBoxSenhaLU.UseSystemPasswordChar = true;
            textBoxSenhaLU.TextChanged += textBoxSenhaLU_TextChanged;
            // 
            // textBoxEmailLU
            // 
            textBoxEmailLU.Location = new Point(99, 301);
            textBoxEmailLU.Margin = new Padding(4);
            textBoxEmailLU.Name = "textBoxEmailLU";
            textBoxEmailLU.Size = new Size(257, 31);
            textBoxEmailLU.TabIndex = 11;
            textBoxEmailLU.TextChanged += textBoxEmailLU_TextChanged;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.BackColor = SystemColors.Control;
            labelTitulo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitulo.Location = new Point(399, 265);
            labelTitulo.Margin = new Padding(4, 0, 4, 0);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(0, 32);
            labelTitulo.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.original_0E2F809E_0FEB_45EE_B16D_009238021042;
            pictureBox1.Location = new Point(27, 14);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(338, 265);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(27, 287);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(65, 45);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(27, 352);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(65, 46);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 16;
            pictureBox3.TabStop = false;
            // 
            // TelaLoginUsuario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 500);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(buttonEntrar);
            Controls.Add(textBoxSenhaLU);
            Controls.Add(textBoxEmailLU);
            Controls.Add(labelTitulo);
            Margin = new Padding(4);
            Name = "TelaLoginUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginUsuario";
            Load += TelaLoginUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonEntrar;
        private TextBox textBoxSenhaLU;
        private TextBox textBoxEmailLU;
        private Label labelTitulo;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}