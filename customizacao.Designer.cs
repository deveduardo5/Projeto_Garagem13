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
            buttonMontar = new Button();
            comboBox4 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            labelMotorizacao = new Label();
            labelCor = new Label();
            labelQuadro = new Label();
            labelAro = new Label();
            groupBoxOrcamento = new GroupBox();
            buttonCalcular = new Button();
            dataGridViewOrcamento = new DataGridView();
            buttonCancelarPedido = new Button();
            groupBoxCustomizacao.SuspendLayout();
            groupBoxOrcamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrcamento).BeginInit();
            SuspendLayout();
            // 
            // buttonVoltarC
            // 
            buttonVoltarC.Location = new Point(564, 291);
            buttonVoltarC.Name = "buttonVoltarC";
            buttonVoltarC.Size = new Size(114, 23);
            buttonVoltarC.TabIndex = 3;
            buttonVoltarC.Text = "Voltar";
            buttonVoltarC.UseVisualStyleBackColor = true;
            buttonVoltarC.Click += buttonVoltarC_Click;
            // 
            // buttonCriarPedidoC
            // 
            buttonCriarPedidoC.Location = new Point(286, 291);
            buttonCriarPedidoC.Name = "buttonCriarPedidoC";
            buttonCriarPedidoC.Size = new Size(114, 23);
            buttonCriarPedidoC.TabIndex = 2;
            buttonCriarPedidoC.Text = "Criar Pedido";
            buttonCriarPedidoC.UseVisualStyleBackColor = true;
            buttonCriarPedidoC.Click += buttonCriarPedidoC_Click;
            // 
            // groupBoxCustomizacao
            // 
            groupBoxCustomizacao.Controls.Add(buttonMontar);
            groupBoxCustomizacao.Controls.Add(comboBox4);
            groupBoxCustomizacao.Controls.Add(comboBox3);
            groupBoxCustomizacao.Controls.Add(comboBox2);
            groupBoxCustomizacao.Controls.Add(comboBox1);
            groupBoxCustomizacao.Controls.Add(labelMotorizacao);
            groupBoxCustomizacao.Controls.Add(labelCor);
            groupBoxCustomizacao.Controls.Add(labelQuadro);
            groupBoxCustomizacao.Controls.Add(labelAro);
            groupBoxCustomizacao.Location = new Point(12, 12);
            groupBoxCustomizacao.Name = "groupBoxCustomizacao";
            groupBoxCustomizacao.Size = new Size(330, 264);
            groupBoxCustomizacao.TabIndex = 4;
            groupBoxCustomizacao.TabStop = false;
            groupBoxCustomizacao.Text = "Customização";
            // 
            // buttonMontar
            // 
            buttonMontar.Location = new Point(103, 235);
            buttonMontar.Name = "buttonMontar";
            buttonMontar.Size = new Size(108, 23);
            buttonMontar.TabIndex = 8;
            buttonMontar.Text = "Montar Pedido";
            buttonMontar.UseVisualStyleBackColor = true;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(58, 137);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(240, 23);
            comboBox4.TabIndex = 7;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(58, 105);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(240, 23);
            comboBox3.TabIndex = 6;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(58, 69);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(240, 23);
            comboBox2.TabIndex = 5;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(58, 34);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(240, 23);
            comboBox1.TabIndex = 4;
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
            // groupBoxOrcamento
            // 
            groupBoxOrcamento.Controls.Add(buttonCalcular);
            groupBoxOrcamento.Controls.Add(dataGridViewOrcamento);
            groupBoxOrcamento.Location = new Point(348, 12);
            groupBoxOrcamento.Name = "groupBoxOrcamento";
            groupBoxOrcamento.Size = new Size(330, 264);
            groupBoxOrcamento.TabIndex = 5;
            groupBoxOrcamento.TabStop = false;
            groupBoxOrcamento.Text = "Orçamento";
            // 
            // buttonCalcular
            // 
            buttonCalcular.Location = new Point(131, 235);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(75, 23);
            buttonCalcular.TabIndex = 9;
            buttonCalcular.Text = "Calcular";
            buttonCalcular.UseVisualStyleBackColor = true;
            // 
            // dataGridViewOrcamento
            // 
            dataGridViewOrcamento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrcamento.Location = new Point(6, 22);
            dataGridViewOrcamento.Name = "dataGridViewOrcamento";
            dataGridViewOrcamento.Size = new Size(318, 150);
            dataGridViewOrcamento.TabIndex = 0;
            // 
            // buttonCancelarPedido
            // 
            buttonCancelarPedido.Location = new Point(12, 291);
            buttonCancelarPedido.Name = "buttonCancelarPedido";
            buttonCancelarPedido.Size = new Size(102, 23);
            buttonCancelarPedido.TabIndex = 10;
            buttonCancelarPedido.Text = "Cancelar Pedido";
            buttonCancelarPedido.UseVisualStyleBackColor = true;
            // 
            // TelaCustomizacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(buttonCancelarPedido);
            Controls.Add(groupBoxOrcamento);
            Controls.Add(groupBoxCustomizacao);
            Controls.Add(buttonVoltarC);
            Controls.Add(buttonCriarPedidoC);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TelaCustomizacao";
            Text = "Customizacao";
            groupBoxCustomizacao.ResumeLayout(false);
            groupBoxCustomizacao.PerformLayout();
            groupBoxOrcamento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrcamento).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonVoltarC;
        private Button buttonCriarPedidoC;
        private GroupBox groupBoxCustomizacao;
        private GroupBox groupBoxOrcamento;
        private Button buttonMontar;
        private ComboBox comboBox4;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label labelMotorizacao;
        private Label labelCor;
        private Label labelQuadro;
        private Label labelAro;
        private Button buttonCalcular;
        private DataGridView dataGridViewOrcamento;
        private Button buttonCancelarPedido;
    }
}