namespace garagem13
{
    partial class TelaCustomizacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCustomizacao));
            buttonVoltarC = new Button();
            buttonCriarPedidoC = new Button();
            groupBoxCustomizacao = new GroupBox();
            textBoxTotal = new TextBox();
            label1 = new Label();
            comboBoxMotor = new ComboBox();
            comboBoxCor = new ComboBox();
            comboBoxQuadro = new ComboBox();
            comboBoxAro = new ComboBox();
            labelMotorizacao = new Label();
            labelCor = new Label();
            labelQuadro = new Label();
            labelAro = new Label();
            dataGridViewCustomizacao = new DataGridView();
            PEDIDOS = new GroupBox();
            groupBoxCustomizacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomizacao).BeginInit();
            PEDIDOS.SuspendLayout();
            SuspendLayout();
            // 
            // buttonVoltarC
            // 
            buttonVoltarC.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonVoltarC.Location = new Point(24, 473);
            buttonVoltarC.Margin = new Padding(4, 5, 4, 5);
            buttonVoltarC.Name = "buttonVoltarC";
            buttonVoltarC.Size = new Size(163, 38);
            buttonVoltarC.TabIndex = 3;
            buttonVoltarC.Text = "Voltar";
            buttonVoltarC.UseVisualStyleBackColor = true;
            buttonVoltarC.Click += buttonVoltarC_Click;
            // 
            // buttonCriarPedidoC
            // 
            buttonCriarPedidoC.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCriarPedidoC.Location = new Point(736, 464);
            buttonCriarPedidoC.Margin = new Padding(4, 5, 4, 5);
            buttonCriarPedidoC.Name = "buttonCriarPedidoC";
            buttonCriarPedidoC.Size = new Size(277, 38);
            buttonCriarPedidoC.TabIndex = 2;
            buttonCriarPedidoC.Text = "Criar Customização";
            buttonCriarPedidoC.UseVisualStyleBackColor = true;
            buttonCriarPedidoC.Click += buttonCriarPedidoC_Click;
            // 
            // groupBoxCustomizacao
            // 
            groupBoxCustomizacao.Controls.Add(textBoxTotal);
            groupBoxCustomizacao.Controls.Add(label1);
            groupBoxCustomizacao.Controls.Add(comboBoxMotor);
            groupBoxCustomizacao.Controls.Add(comboBoxCor);
            groupBoxCustomizacao.Controls.Add(comboBoxQuadro);
            groupBoxCustomizacao.Controls.Add(comboBoxAro);
            groupBoxCustomizacao.Controls.Add(labelMotorizacao);
            groupBoxCustomizacao.Controls.Add(labelCor);
            groupBoxCustomizacao.Controls.Add(labelQuadro);
            groupBoxCustomizacao.Controls.Add(labelAro);
            groupBoxCustomizacao.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBoxCustomizacao.Location = new Point(17, 20);
            groupBoxCustomizacao.Margin = new Padding(4, 5, 4, 5);
            groupBoxCustomizacao.Name = "groupBoxCustomizacao";
            groupBoxCustomizacao.Padding = new Padding(4, 5, 4, 5);
            groupBoxCustomizacao.Size = new Size(497, 405);
            groupBoxCustomizacao.TabIndex = 4;
            groupBoxCustomizacao.TabStop = false;
            groupBoxCustomizacao.Text = "Customização";
            // 
            // textBoxTotal
            // 
            textBoxTotal.Enabled = false;
            textBoxTotal.Location = new Point(330, 357);
            textBoxTotal.Margin = new Padding(4, 5, 4, 5);
            textBoxTotal.Name = "textBoxTotal";
            textBoxTotal.ReadOnly = true;
            textBoxTotal.Size = new Size(167, 29);
            textBoxTotal.TabIndex = 8;
            textBoxTotal.Text = "R$ 0.00";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(191, 365);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(131, 21);
            label1.TabIndex = 5;
            label1.Text = "Valor Total:";
            // 
            // comboBoxMotor
            // 
            comboBoxMotor.FormattingEnabled = true;
            comboBoxMotor.Location = new Point(83, 228);
            comboBoxMotor.Margin = new Padding(4, 5, 4, 5);
            comboBoxMotor.Name = "comboBoxMotor";
            comboBoxMotor.Size = new Size(414, 29);
            comboBoxMotor.TabIndex = 7;
            comboBoxMotor.SelectedIndexChanged += comboBoxMotor_SelectedIndexChanged;
            // 
            // comboBoxCor
            // 
            comboBoxCor.FormattingEnabled = true;
            comboBoxCor.Location = new Point(83, 175);
            comboBoxCor.Margin = new Padding(4, 5, 4, 5);
            comboBoxCor.Name = "comboBoxCor";
            comboBoxCor.Size = new Size(414, 29);
            comboBoxCor.TabIndex = 6;
            comboBoxCor.SelectedIndexChanged += comboBoxCor_SelectedIndexChanged;
            // 
            // comboBoxQuadro
            // 
            comboBoxQuadro.FormattingEnabled = true;
            comboBoxQuadro.Location = new Point(83, 115);
            comboBoxQuadro.Margin = new Padding(4, 5, 4, 5);
            comboBoxQuadro.Name = "comboBoxQuadro";
            comboBoxQuadro.Size = new Size(414, 29);
            comboBoxQuadro.TabIndex = 5;
            comboBoxQuadro.SelectedIndexChanged += comboBoxQuadro_SelectedIndexChanged;
            // 
            // comboBoxAro
            // 
            comboBoxAro.FormattingEnabled = true;
            comboBoxAro.Location = new Point(83, 57);
            comboBoxAro.Margin = new Padding(4, 5, 4, 5);
            comboBoxAro.Name = "comboBoxAro";
            comboBoxAro.Size = new Size(414, 29);
            comboBoxAro.TabIndex = 4;
            comboBoxAro.SelectedIndexChanged += comboBoxAro_SelectedIndexChanged;
            // 
            // labelMotorizacao
            // 
            labelMotorizacao.AutoSize = true;
            labelMotorizacao.Location = new Point(17, 242);
            labelMotorizacao.Margin = new Padding(4, 0, 4, 0);
            labelMotorizacao.Name = "labelMotorizacao";
            labelMotorizacao.Size = new Size(70, 21);
            labelMotorizacao.TabIndex = 3;
            labelMotorizacao.Text = "Motor";
            // 
            // labelCor
            // 
            labelCor.AutoSize = true;
            labelCor.Location = new Point(37, 188);
            labelCor.Margin = new Padding(4, 0, 4, 0);
            labelCor.Name = "labelCor";
            labelCor.Size = new Size(45, 21);
            labelCor.TabIndex = 2;
            labelCor.Text = "Cor";
            // 
            // labelQuadro
            // 
            labelQuadro.AutoSize = true;
            labelQuadro.Location = new Point(7, 128);
            labelQuadro.Margin = new Padding(4, 0, 4, 0);
            labelQuadro.Name = "labelQuadro";
            labelQuadro.Size = new Size(81, 21);
            labelQuadro.TabIndex = 1;
            labelQuadro.Text = "Quadro";
            // 
            // labelAro
            // 
            labelAro.AutoSize = true;
            labelAro.Location = new Point(37, 70);
            labelAro.Margin = new Padding(4, 0, 4, 0);
            labelAro.Name = "labelAro";
            labelAro.Size = new Size(45, 21);
            labelAro.TabIndex = 0;
            labelAro.Text = "Aro";
            // 
            // dataGridViewCustomizacao
            // 
            dataGridViewCustomizacao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCustomizacao.Location = new Point(19, 48);
            dataGridViewCustomizacao.Margin = new Padding(4, 5, 4, 5);
            dataGridViewCustomizacao.Name = "dataGridViewCustomizacao";
            dataGridViewCustomizacao.RowHeadersWidth = 62;
            dataGridViewCustomizacao.Size = new Size(496, 233);
            dataGridViewCustomizacao.TabIndex = 5;
            // 
            // PEDIDOS
            // 
            PEDIDOS.BackColor = Color.Transparent;
            PEDIDOS.Controls.Add(dataGridViewCustomizacao);
            PEDIDOS.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PEDIDOS.Location = new Point(541, 29);
            PEDIDOS.Name = "PEDIDOS";
            PEDIDOS.Size = new Size(522, 313);
            PEDIDOS.TabIndex = 6;
            PEDIDOS.TabStop = false;
            PEDIDOS.Text = "LISTA DE PEDIDOS";
            // 
            // TelaCustomizacao
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1068, 554);
            Controls.Add(PEDIDOS);
            Controls.Add(groupBoxCustomizacao);
            Controls.Add(buttonVoltarC);
            Controls.Add(buttonCriarPedidoC);
            Margin = new Padding(4, 3, 4, 3);
            Name = "TelaCustomizacao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customizacao";
            Load += TelaCustomizacao_Load;
            groupBoxCustomizacao.ResumeLayout(false);
            groupBoxCustomizacao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomizacao).EndInit();
            PEDIDOS.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button buttonVoltarC;
        private Button buttonCriarPedidoC;
        private GroupBox groupBoxCustomizacao;
        private ComboBox comboBoxMotor;
        private ComboBox comboBoxCor;
        private ComboBox comboBoxQuadro;
        private ComboBox comboBoxAro;
        private Label labelMotorizacao;
        private Label labelCor;
        private Label labelQuadro;
        private Label labelAro;
        private Label label1;
        private TextBox textBoxTotal;
        private DataGridView dataGridViewCustomizacao;
        private GroupBox PEDIDOS;
    }
}