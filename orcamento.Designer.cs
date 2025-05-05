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
            buttonAlterarO = new Button();
            buttonCancelarO = new Button();
            SuspendLayout();
            // 
            // buttonConcluirO
            // 
            buttonConcluirO.Location = new Point(587, 406);
            buttonConcluirO.Margin = new Padding(3, 4, 3, 4);
            buttonConcluirO.Name = "buttonConcluirO";
            buttonConcluirO.Size = new Size(201, 31);
            buttonConcluirO.TabIndex = 5;
            buttonConcluirO.Text = "Concluir Pedido";
            buttonConcluirO.UseVisualStyleBackColor = true;
            // 
            // buttonAlterarO
            // 
            buttonAlterarO.Location = new Point(299, 406);
            buttonAlterarO.Margin = new Padding(3, 4, 3, 4);
            buttonAlterarO.Name = "buttonAlterarO";
            buttonAlterarO.Size = new Size(201, 31);
            buttonAlterarO.TabIndex = 4;
            buttonAlterarO.Text = "Alterar Customização";
            buttonAlterarO.UseVisualStyleBackColor = true;
            buttonAlterarO.Click += buttonAlterarO_Click;
            // 
            // buttonCancelarO
            // 
            buttonCancelarO.Location = new Point(12, 406);
            buttonCancelarO.Margin = new Padding(3, 4, 3, 4);
            buttonCancelarO.Name = "buttonCancelarO";
            buttonCancelarO.Size = new Size(201, 31);
            buttonCancelarO.TabIndex = 3;
            buttonCancelarO.Text = "Cancelar Pedido";
            buttonCancelarO.UseVisualStyleBackColor = true;
            buttonCancelarO.Click += buttonCancelarO_Click;
            // 
            // TelaOrcamento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonConcluirO);
            Controls.Add(buttonAlterarO);
            Controls.Add(buttonCancelarO);
            Name = "TelaOrcamento";
            Text = "Orcamento";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonConcluirO;
        private Button buttonAlterarO;
        private Button buttonCancelarO;
    }
}