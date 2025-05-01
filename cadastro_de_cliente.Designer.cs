namespace garagem13
{
    partial class cadastro_de_cliente
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
            buttonPesquisarCC = new Button();
            buttonIncluirCC = new Button();
            buttonDeletarCC = new Button();
            buttonCustomizacaoCC = new Button();
            textBoxPesquisarCC = new TextBox();
            dataGridViewCadastroCliente = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCadastroCliente).BeginInit();
            SuspendLayout();
            // 
            // buttonPesquisarCC
            // 
            buttonPesquisarCC.Location = new Point(534, 9);
            buttonPesquisarCC.Margin = new Padding(3, 2, 3, 2);
            buttonPesquisarCC.Name = "buttonPesquisarCC";
            buttonPesquisarCC.Size = new Size(156, 22);
            buttonPesquisarCC.TabIndex = 0;
            buttonPesquisarCC.Text = "Pesquisar";
            buttonPesquisarCC.UseVisualStyleBackColor = true;
            // 
            // buttonIncluirCC
            // 
            buttonIncluirCC.Location = new Point(10, 307);
            buttonIncluirCC.Margin = new Padding(3, 2, 3, 2);
            buttonIncluirCC.Name = "buttonIncluirCC";
            buttonIncluirCC.Size = new Size(156, 22);
            buttonIncluirCC.TabIndex = 1;
            buttonIncluirCC.Text = "Incluir";
            buttonIncluirCC.UseVisualStyleBackColor = true;
            buttonIncluirCC.Click += buttonIncluirCC_Click;
            // 
            // buttonDeletarCC
            // 
            buttonDeletarCC.Location = new Point(275, 307);
            buttonDeletarCC.Margin = new Padding(3, 2, 3, 2);
            buttonDeletarCC.Name = "buttonDeletarCC";
            buttonDeletarCC.Size = new Size(156, 22);
            buttonDeletarCC.TabIndex = 2;
            buttonDeletarCC.Text = "Deletar";
            buttonDeletarCC.UseVisualStyleBackColor = true;
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
            // 
            // textBoxPesquisarCC
            // 
            textBoxPesquisarCC.Location = new Point(10, 9);
            textBoxPesquisarCC.Margin = new Padding(3, 2, 3, 2);
            textBoxPesquisarCC.Name = "textBoxPesquisarCC";
            textBoxPesquisarCC.Size = new Size(506, 23);
            textBoxPesquisarCC.TabIndex = 4;
            // 
            // dataGridViewCadastroCliente
            // 
            dataGridViewCadastroCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCadastroCliente.Location = new Point(10, 50);
            dataGridViewCadastroCliente.Margin = new Padding(3, 2, 3, 2);
            dataGridViewCadastroCliente.Name = "dataGridViewCadastroCliente";
            dataGridViewCadastroCliente.RowHeadersWidth = 51;
            dataGridViewCadastroCliente.Size = new Size(679, 232);
            dataGridViewCadastroCliente.TabIndex = 5;
            // 
            // cadastro_de_cliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(dataGridViewCadastroCliente);
            Controls.Add(textBoxPesquisarCC);
            Controls.Add(buttonCustomizacaoCC);
            Controls.Add(buttonDeletarCC);
            Controls.Add(buttonIncluirCC);
            Controls.Add(buttonPesquisarCC);
            Margin = new Padding(3, 2, 3, 2);
            Name = "cadastro_de_cliente";
            Text = "cadastro_de_cliente";
            ((System.ComponentModel.ISupportInitialize)dataGridViewCadastroCliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonPesquisarCC;
        private Button buttonIncluirCC;
        private Button buttonDeletarCC;
        private Button buttonCustomizacaoCC;
        private TextBox textBoxPesquisarCC;
        private DataGridView dataGridViewCadastroCliente;
    }
}