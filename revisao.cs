namespace garagem13
{
    public partial class revisao : Form
    {
        public revisao()
        {
            InitializeComponent();
        }

        private void buttonProsseguirR_Click(object sender, EventArgs e)
        {
            Form revisao = new orcamento();
            revisao.Show();
            this.Hide();
        }

        private void buttonVoltarR_Click(object sender, EventArgs e)
        {
            Form revisao = new customizacao();
            revisao.Show();
            this.Hide();
        }
    }
}
