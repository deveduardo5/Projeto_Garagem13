namespace garagem13
{
    public partial class TelaRevisao : Form
    {
        public TelaRevisao()
        {
            InitializeComponent();
        }

        private void buttonProsseguirR_Click(object sender, EventArgs e)
        {
            Form TelaRevisao = new TelaOrcamento();
            TelaRevisao.Show();
            this.Hide();
        }

        private void buttonVoltarR_Click(object sender, EventArgs e)
        {
            Form TelaRevisao = new TelaCustomizacao();
            TelaRevisao.Show();
            this.Hide();
        }
    }
}
