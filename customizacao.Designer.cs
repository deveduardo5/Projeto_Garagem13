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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            comboBox5 = new ComboBox();
            label6 = new Label();
            comboBox6 = new ComboBox();
            label7 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label8 = new Label();
            SuspendLayout();
            // 
            // buttonVoltarC
            // 
            buttonVoltarC.Location = new Point(295, 282);
            buttonVoltarC.Name = "buttonVoltarC";
            buttonVoltarC.Size = new Size(114, 23);
            buttonVoltarC.TabIndex = 3;
            buttonVoltarC.Text = "Voltar";
            buttonVoltarC.UseVisualStyleBackColor = true;
            buttonVoltarC.Click += buttonVoltarC_Click;
            // 
            // buttonCriarPedidoC
            // 
            buttonCriarPedidoC.Location = new Point(295, 253);
            buttonCriarPedidoC.Name = "buttonCriarPedidoC";
            buttonCriarPedidoC.Size = new Size(114, 23);
            buttonCriarPedidoC.TabIndex = 2;
            buttonCriarPedidoC.Text = "Criar Pedido";
            buttonCriarPedidoC.UseVisualStyleBackColor = true;
            buttonCriarPedidoC.Click += buttonCriarPedidoC_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 123);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 4;
            label1.Text = "Cor do quadro";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 77);
            label2.Name = "label2";
            label2.Size = new Size(114, 15);
            label2.TabIndex = 5;
            label2.Text = "Tamanho do quadro";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 41);
            label3.Name = "label3";
            label3.Size = new Size(26, 15);
            label3.TabIndex = 6;
            label3.Text = "Aro";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(347, 77);
            label4.Name = "label4";
            label4.Size = new Size(106, 15);
            label4.TabIndex = 7;
            label4.Text = "Potencia do motor";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(371, 36);
            label5.Name = "label5";
            label5.Size = new Size(82, 15);
            label5.TabIndex = 8;
            label5.Text = "Tipo de motor";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Preto", "Vermelho", "Branco" });
            comboBox1.Location = new Point(156, 115);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 9;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "15", "17", "19" });
            comboBox2.Location = new Point(156, 69);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 10;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "26'", "27,5'", "700'", "29'" });
            comboBox3.Location = new Point(156, 33);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 23);
            comboBox3.TabIndex = 11;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(459, 69);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(121, 23);
            comboBox4.TabIndex = 12;
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Items.AddRange(new object[] { "250W", "350W", "500W" });
            comboBox5.Location = new Point(459, 28);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(121, 23);
            comboBox5.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(371, 123);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 14;
            label6.Text = "Bateria";
            // 
            // comboBox6
            // 
            comboBox6.FormattingEnabled = true;
            comboBox6.Items.AddRange(new object[] { "36V", "48V" });
            comboBox6.Location = new Point(459, 123);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(121, 23);
            comboBox6.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(91, 183);
            label7.Name = "label7";
            label7.Size = new Size(64, 15);
            label7.TabIndex = 16;
            label7.Text = "Acelerador";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(182, 183);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(45, 19);
            radioButton1.TabIndex = 17;
            radioButton1.TabStop = true;
            radioButton1.Text = "Sim";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(250, 183);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(47, 19);
            radioButton2.TabIndex = 18;
            radioButton2.TabStop = true;
            radioButton2.Text = "Não";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(376, 183);
            label8.Name = "label8";
            label8.Size = new Size(0, 15);
            label8.TabIndex = 19;
            // 
            // TelaCustomizacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(label8);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label7);
            Controls.Add(comboBox6);
            Controls.Add(label6);
            Controls.Add(comboBox5);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonVoltarC);
            Controls.Add(buttonCriarPedidoC);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TelaCustomizacao";
            Text = "Customizacao";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonVoltarC;
        private Button buttonCriarPedidoC;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private ComboBox comboBox5;
        private Label label6;
        private ComboBox comboBox6;
        private Label label7;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label8;
    }
}