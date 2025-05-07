namespace garagem13
{
    partial class TelaOrcamento
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
            buttonConcluirO = new Button();
            buttonCancelarO = new Button();
            SuspendLayout();
            // 
            // buttonConcluirO
            // 
            buttonConcluirO.Location = new Point(514, 304);
            buttonConcluirO.Name = "buttonConcluirO";
            buttonConcluirO.Size = new Size(176, 23);
            buttonConcluirO.TabIndex = 5;
            buttonConcluirO.Text = "Concluir Pedido";
            buttonConcluirO.UseVisualStyleBackColor = true;
            // 
            // buttonCancelarO
            // 
            buttonCancelarO.Location = new Point(10, 304);
            buttonCancelarO.Name = "buttonCancelarO";
            buttonCancelarO.Size = new Size(176, 23);
            buttonCancelarO.TabIndex = 3;
            buttonCancelarO.Text = "Cancelar Pedido";
            buttonCancelarO.UseVisualStyleBackColor = true;
            buttonCancelarO.Click += buttonCancelarO_Click;
            // 
            // TelaOrcamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(buttonConcluirO);
            Controls.Add(buttonCancelarO);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TelaOrcamento";
            Text = "Orcamento";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonConcluirO;
        private Button buttonCancelarO;
    }
}