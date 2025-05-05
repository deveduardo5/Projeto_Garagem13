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
            buttonPesquisarCC.Location = new Point(610, 12);
            buttonPesquisarCC.Name = "buttonPesquisarCC";
            buttonPesquisarCC.Size = new Size(178, 29);
            buttonPesquisarCC.TabIndex = 0;
            buttonPesquisarCC.Text = "Pesquisar";
            buttonPesquisarCC.UseVisualStyleBackColor = true;
            // 
            // buttonIncluirCC
            // 
            buttonIncluirCC.Location = new Point(11, 409);
            buttonIncluirCC.Name = "buttonIncluirCC";
            buttonIncluirCC.Size = new Size(178, 29);
            buttonIncluirCC.TabIndex = 1;
            buttonIncluirCC.Text = "Incluir";
            buttonIncluirCC.UseVisualStyleBackColor = true;
            buttonIncluirCC.Click += buttonIncluirCC_Click;
            // 
            // buttonDeletarCC
            // 
            buttonDeletarCC.Location = new Point(314, 409);
            buttonDeletarCC.Name = "buttonDeletarCC";
            buttonDeletarCC.Size = new Size(178, 29);
            buttonDeletarCC.TabIndex = 2;
            buttonDeletarCC.Text = "Deletar";
            buttonDeletarCC.UseVisualStyleBackColor = true;
            // 
            // buttonCustomizacaoCC
            // 
            buttonCustomizacaoCC.Location = new Point(610, 409);
            buttonCustomizacaoCC.Name = "buttonCustomizacaoCC";
            buttonCustomizacaoCC.Size = new Size(178, 29);
            buttonCustomizacaoCC.TabIndex = 3;
            buttonCustomizacaoCC.Text = "Customização";
            buttonCustomizacaoCC.UseVisualStyleBackColor = true;
            buttonCustomizacaoCC.Click += buttonCustomizacaoCC_Click_1;
            // 
            // textBoxPesquisarCC
            // 
            textBoxPesquisarCC.Location = new Point(11, 12);
            textBoxPesquisarCC.Name = "textBoxPesquisarCC";
            textBoxPesquisarCC.Size = new Size(578, 27);
            textBoxPesquisarCC.TabIndex = 4;
            // 
            // dataGridViewCadastroCliente
            // 
            dataGridViewCadastroCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCadastroCliente.Location = new Point(11, 67);
            dataGridViewCadastroCliente.Name = "dataGridViewCadastroCliente";
            dataGridViewCadastroCliente.RowHeadersWidth = 51;
            dataGridViewCadastroCliente.Size = new Size(776, 309);
            dataGridViewCadastroCliente.TabIndex = 5;
            // 
            // TelaCadastroCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(dataGridViewCadastroCliente);
            Controls.Add(textBoxPesquisarCC);
            Controls.Add(buttonCustomizacaoCC);
            Controls.Add(buttonDeletarCC);
            Controls.Add(buttonIncluirCC);
            Controls.Add(buttonPesquisarCC);
            Name = "TelaCadastroCliente";
            Text = "CadastroCliente";
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