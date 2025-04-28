namespace garagem13
{
    partial class customizacao
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
            buttonVoltarC = new Button();
            buttonCriarPedidoC = new Button();
            SuspendLayout();
            // 
            // buttonVoltarC
            // 
            buttonVoltarC.Location = new Point(337, 376);
            buttonVoltarC.Margin = new Padding(3, 4, 3, 4);
            buttonVoltarC.Name = "buttonVoltarC";
            buttonVoltarC.Size = new Size(130, 31);
            buttonVoltarC.TabIndex = 3;
            buttonVoltarC.Text = "Voltar";
            buttonVoltarC.UseVisualStyleBackColor = true;
            buttonVoltarC.Click += buttonVoltarC_Click;
            // 
            // buttonCriarPedidoC
            // 
            buttonCriarPedidoC.Location = new Point(337, 337);
            buttonCriarPedidoC.Margin = new Padding(3, 4, 3, 4);
            buttonCriarPedidoC.Name = "buttonCriarPedidoC";
            buttonCriarPedidoC.Size = new Size(130, 31);
            buttonCriarPedidoC.TabIndex = 2;
            buttonCriarPedidoC.Text = "Criar Pedido";
            buttonCriarPedidoC.UseVisualStyleBackColor = true;
            buttonCriarPedidoC.Click += buttonCriarPedidoC_Click;
            // 
            // customizacao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonVoltarC);
            Controls.Add(buttonCriarPedidoC);
            Name = "customizacao";
            Text = "customizacao";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonVoltarC;
        private Button buttonCriarPedidoC;
    }
}