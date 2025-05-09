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
            dataGridView1 = new DataGridView();
            groupBoxCustomizacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttonVoltarC
            // 
            buttonVoltarC.Location = new Point(12, 303);
            buttonVoltarC.Name = "buttonVoltarC";
            buttonVoltarC.Size = new Size(114, 23);
            buttonVoltarC.TabIndex = 3;
            buttonVoltarC.Text = "Voltar";
            buttonVoltarC.UseVisualStyleBackColor = true;
            buttonVoltarC.Click += buttonVoltarC_Click;
            // 
            // buttonCriarPedidoC
            // 
            buttonCriarPedidoC.Location = new Point(173, 303);
            buttonCriarPedidoC.Name = "buttonCriarPedidoC";
            buttonCriarPedidoC.Size = new Size(194, 23);
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
            groupBoxCustomizacao.Location = new Point(12, 12);
            groupBoxCustomizacao.Name = "groupBoxCustomizacao";
            groupBoxCustomizacao.Size = new Size(355, 243);
            groupBoxCustomizacao.TabIndex = 4;
            groupBoxCustomizacao.TabStop = false;
            groupBoxCustomizacao.Text = "Customização";
            // 
            // textBoxTotal
            // 
            textBoxTotal.Enabled = false;
            textBoxTotal.Location = new Point(231, 214);
            textBoxTotal.Name = "textBoxTotal";
            textBoxTotal.ReadOnly = true;
            textBoxTotal.Size = new Size(118, 23);
            textBoxTotal.TabIndex = 8;
            textBoxTotal.Text = "R$ 0.00";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(161, 217);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 5;
            label1.Text = "Valor Total:";
            // 
            // comboBoxMotor
            // 
            comboBoxMotor.FormattingEnabled = true;
            comboBoxMotor.Location = new Point(58, 137);
            comboBoxMotor.Name = "comboBoxMotor";
            comboBoxMotor.Size = new Size(291, 23);
            comboBoxMotor.TabIndex = 7;
            comboBoxMotor.SelectedIndexChanged += comboBoxMotor_SelectedIndexChanged;
            // 
            // comboBoxCor
            // 
            comboBoxCor.FormattingEnabled = true;
            comboBoxCor.Location = new Point(58, 105);
            comboBoxCor.Name = "comboBoxCor";
            comboBoxCor.Size = new Size(291, 23);
            comboBoxCor.TabIndex = 6;
            comboBoxCor.SelectedIndexChanged += comboBoxCor_SelectedIndexChanged;
            // 
            // comboBoxQuadro
            // 
            comboBoxQuadro.FormattingEnabled = true;
            comboBoxQuadro.Location = new Point(58, 69);
            comboBoxQuadro.Name = "comboBoxQuadro";
            comboBoxQuadro.Size = new Size(291, 23);
            comboBoxQuadro.TabIndex = 5;
            comboBoxQuadro.SelectedIndexChanged += comboBoxQuadro_SelectedIndexChanged;
            // 
            // comboBoxAro
            // 
            comboBoxAro.FormattingEnabled = true;
            comboBoxAro.Location = new Point(58, 34);
            comboBoxAro.Name = "comboBoxAro";
            comboBoxAro.Size = new Size(291, 23);
            comboBoxAro.TabIndex = 4;
            comboBoxAro.SelectedIndexChanged += comboBoxAro_SelectedIndexChanged;
            // 
            // labelMotorizacao
            // 
            labelMotorizacao.AutoSize = true;
            labelMotorizacao.Location = new Point(12, 145);
            labelMotorizacao.Name = "labelMotorizacao";
            labelMotorizacao.Size = new Size(40, 15);
            labelMotorizacao.TabIndex = 3;
            labelMotorizacao.Text = "Motor";
            // 
            // labelCor
            // 
            labelCor.AutoSize = true;
            labelCor.Location = new Point(26, 113);
            labelCor.Name = "labelCor";
            labelCor.Size = new Size(26, 15);
            labelCor.TabIndex = 2;
            labelCor.Text = "Cor";
            // 
            // labelQuadro
            // 
            labelQuadro.AutoSize = true;
            labelQuadro.Location = new Point(5, 77);
            labelQuadro.Name = "labelQuadro";
            labelQuadro.Size = new Size(47, 15);
            labelQuadro.TabIndex = 1;
            labelQuadro.Text = "Quadro";
            // 
            // labelAro
            // 
            labelAro.AutoSize = true;
            labelAro.Location = new Point(26, 42);
            labelAro.Name = "labelAro";
            labelAro.Size = new Size(26, 15);
            labelAro.TabIndex = 0;
            labelAro.Text = "Aro";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(373, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(481, 243);
            dataGridView1.TabIndex = 5;
            // 
            // TelaCustomizacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(866, 338);
            Controls.Add(dataGridView1);
            Controls.Add(groupBoxCustomizacao);
            Controls.Add(buttonVoltarC);
            Controls.Add(buttonCriarPedidoC);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TelaCustomizacao";
            Text = "Customizacao";
            Load += TelaCustomizacao_Load;
            groupBoxCustomizacao.ResumeLayout(false);
            groupBoxCustomizacao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DataGridView dataGridView1;
    }
}