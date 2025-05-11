namespace garagem13
{
    partial class TelaCadastroCliente
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
            buttonCriarClienteCC = new Button();
            buttonCustomizacaoCC = new Button();
            dataGridViewCadastroCliente = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCadastroCliente).BeginInit();
            SuspendLayout();
            // 
            // buttonCriarClienteCC
            // 
            buttonCriarClienteCC.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCriarClienteCC.Location = new Point(17, 457);
            buttonCriarClienteCC.Margin = new Padding(4, 3, 4, 3);
            buttonCriarClienteCC.Name = "buttonCriarClienteCC";
            buttonCriarClienteCC.Size = new Size(223, 37);
            buttonCriarClienteCC.TabIndex = 1;
            buttonCriarClienteCC.Text = "Criar Cliente";
            buttonCriarClienteCC.UseVisualStyleBackColor = true;
            buttonCriarClienteCC.Click += buttonIncluirCC_Click;
            // 
            // buttonCustomizacaoCC
            // 
            buttonCustomizacaoCC.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCustomizacaoCC.Location = new Point(764, 457);
            buttonCustomizacaoCC.Margin = new Padding(4, 3, 4, 3);
            buttonCustomizacaoCC.Name = "buttonCustomizacaoCC";
            buttonCustomizacaoCC.Size = new Size(223, 37);
            buttonCustomizacaoCC.TabIndex = 3;
            buttonCustomizacaoCC.Text = "Customização";
            buttonCustomizacaoCC.UseVisualStyleBackColor = true;
            buttonCustomizacaoCC.Click += buttonCustomizacaoCC_Click_1;
            // 
            // dataGridViewCadastroCliente
            // 
            dataGridViewCadastroCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCadastroCliente.Location = new Point(17, 65);
            dataGridViewCadastroCliente.Margin = new Padding(4, 3, 4, 3);
            dataGridViewCadastroCliente.Name = "dataGridViewCadastroCliente";
            dataGridViewCadastroCliente.RowHeadersWidth = 51;
            dataGridViewCadastroCliente.Size = new Size(970, 367);
            dataGridViewCadastroCliente.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 19);
            label1.Name = "label1";
            label1.Size = new Size(431, 43);
            label1.TabIndex = 6;
            label1.Text = "Clientes Cadastrados";
            label1.Click += label1_Click;
            // 
            // TelaCadastroCliente
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 510);
            Controls.Add(label1);
            Controls.Add(dataGridViewCadastroCliente);
            Controls.Add(buttonCustomizacaoCC);
            Controls.Add(buttonCriarClienteCC);
            Margin = new Padding(4, 3, 4, 3);
            Name = "TelaCadastroCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CadastroCliente";
            Load += TelaCadastroCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCadastroCliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonCriarClienteCC;
        private Button buttonCustomizacaoCC;
        private DataGridView dataGridViewCadastroCliente;
        private Label label1;
    }
}