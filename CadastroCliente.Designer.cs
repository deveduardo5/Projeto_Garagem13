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
            ((System.ComponentModel.ISupportInitialize)dataGridViewCadastroCliente).BeginInit();
            SuspendLayout();
            // 
            // buttonCriarClienteCC
            // 
            buttonCriarClienteCC.Location = new Point(10, 307);
            buttonCriarClienteCC.Margin = new Padding(3, 2, 3, 2);
            buttonCriarClienteCC.Name = "buttonCriarClienteCC";
            buttonCriarClienteCC.Size = new Size(156, 22);
            buttonCriarClienteCC.TabIndex = 1;
            buttonCriarClienteCC.Text = "Criar Cliente";
            buttonCriarClienteCC.UseVisualStyleBackColor = true;
            buttonCriarClienteCC.Click += buttonIncluirCC_Click;
            // 
            // buttonCustomizacaoCC
            // 
            buttonCustomizacaoCC.Location = new Point(534, 307);
            buttonCustomizacaoCC.Margin = new Padding(3, 2, 3, 2);
            buttonCustomizacaoCC.Name = "buttonCustomizacaoCC";
            buttonCustomizacaoCC.Size = new Size(156, 22);
            buttonCustomizacaoCC.TabIndex = 3;
            buttonCustomizacaoCC.Text = "Customização";
            buttonCustomizacaoCC.UseVisualStyleBackColor = true;
            buttonCustomizacaoCC.Click += buttonCustomizacaoCC_Click_1;
            // 
            // dataGridViewCadastroCliente
            // 
            dataGridViewCadastroCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCadastroCliente.Location = new Point(10, 11);
            dataGridViewCadastroCliente.Margin = new Padding(3, 2, 3, 2);
            dataGridViewCadastroCliente.Name = "dataGridViewCadastroCliente";
            dataGridViewCadastroCliente.RowHeadersWidth = 51;
            dataGridViewCadastroCliente.Size = new Size(679, 271);
            dataGridViewCadastroCliente.TabIndex = 5;
            // 
            // TelaCadastroCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(dataGridViewCadastroCliente);
            Controls.Add(buttonCustomizacaoCC);
            Controls.Add(buttonCriarClienteCC);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TelaCadastroCliente";
            Text = "CadastroCliente";
            Load += TelaCadastroCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCadastroCliente).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button buttonCriarClienteCC;
        private Button buttonCustomizacaoCC;
        private DataGridView dataGridViewCadastroCliente;
    }
}