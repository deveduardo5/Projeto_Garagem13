namespace garagem13
{
    partial class inclusao_de_cliente
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
            SuspendLayout();
            // 
            // buttonVoltarIC
            // 
            buttonVoltarIC.Location = new Point(343, 340);
            buttonVoltarIC.Margin = new Padding(3, 4, 3, 4);
            buttonVoltarIC.Name = "buttonVoltarIC";
            buttonVoltarIC.Size = new Size(115, 31);
            buttonVoltarIC.TabIndex = 3;
            buttonVoltarIC.Text = "Voltar";
            buttonVoltarIC.UseVisualStyleBackColor = true;
            // 
            // buttonIncluirIC
            // 
            buttonIncluirIC.Location = new Point(343, 379);
            buttonIncluirIC.Margin = new Padding(3, 4, 3, 4);
            buttonIncluirIC.Name = "buttonIncluirIC";
            buttonIncluirIC.Size = new Size(115, 31);
            buttonIncluirIC.TabIndex = 2;
            buttonIncluirIC.Text = "Incluir";
            buttonIncluirIC.UseVisualStyleBackColor = true;
            buttonIncluirIC.Click += buttonIncluirIC_Click;
            // 
            // inclusao_de_cliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonVoltarIC);
            Controls.Add(buttonIncluirIC);
            Name = "inclusao_de_cliente";
            Text = "inclusao_de_cliente";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonVoltarIC;
        private Button buttonIncluirIC;
    }
}