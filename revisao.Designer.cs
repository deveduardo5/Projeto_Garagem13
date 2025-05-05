namespace garagem13
{
    partial class TelaRevisao
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
            buttonVoltarR = new Button();
            buttonProsseguirR = new Button();
            SuspendLayout();
            // 
            // buttonVoltarR
            // 
            buttonVoltarR.Location = new Point(305, 377);
            buttonVoltarR.Margin = new Padding(3, 4, 3, 4);
            buttonVoltarR.Name = "buttonVoltarR";
            buttonVoltarR.Size = new Size(203, 31);
            buttonVoltarR.TabIndex = 3;
            buttonVoltarR.Text = "Voltar";
            buttonVoltarR.UseVisualStyleBackColor = true;
            buttonVoltarR.Click += buttonVoltarR_Click;
            // 
            // buttonProsseguirR
            // 
            buttonProsseguirR.Location = new Point(305, 339);
            buttonProsseguirR.Margin = new Padding(3, 4, 3, 4);
            buttonProsseguirR.Name = "buttonProsseguirR";
            buttonProsseguirR.Size = new Size(203, 31);
            buttonProsseguirR.TabIndex = 2;
            buttonProsseguirR.Text = "Prosseguir com pedido";
            buttonProsseguirR.UseVisualStyleBackColor = true;
            buttonProsseguirR.Click += buttonProsseguirR_Click;
            // 
            // TelaRevisao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonVoltarR);
            Controls.Add(buttonProsseguirR);
            Name = "TelaRevisao";
            Text = "Revisao";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonVoltarR;
        private Button buttonProsseguirR;
    }
}