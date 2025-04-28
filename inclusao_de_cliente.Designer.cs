namespace garagem13
{
    partial class inclusao_de_cliente
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
            buttonVoltarIC = new Button();
            buttonIncluirIC = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // buttonVoltarIC
            // 
            buttonVoltarIC.Location = new Point(300, 255);
            buttonVoltarIC.Name = "buttonVoltarIC";
            buttonVoltarIC.Size = new Size(101, 23);
            buttonVoltarIC.TabIndex = 3;
            buttonVoltarIC.Text = "Voltar";
            buttonVoltarIC.UseVisualStyleBackColor = true;
            // 
            // buttonIncluirIC
            // 
            buttonIncluirIC.Location = new Point(300, 284);
            buttonIncluirIC.Name = "buttonIncluirIC";
            buttonIncluirIC.Size = new Size(101, 23);
            buttonIncluirIC.TabIndex = 2;
            buttonIncluirIC.Text = "Incluir";
            buttonIncluirIC.UseVisualStyleBackColor = true;
            buttonIncluirIC.Click += buttonIncluirIC_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(160, 86);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 4;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(160, 123);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 5;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(160, 160);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 6;
            label3.Text = "label3";
            // 
            // inclusao_de_cliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonVoltarIC);
            Controls.Add(buttonIncluirIC);
            Margin = new Padding(3, 2, 3, 2);
            Name = "inclusao_de_cliente";
            Text = "inclusao_de_cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonVoltarIC;
        private Button buttonIncluirIC;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}