namespace garagem13
{
    public partial class orcamento : Form
    {
        public orcamento()
        {
            InitializeComponent();
        }

        private void buttonCancelarO_Click(object sender, EventArgs e)
        {
            Form orcamento = new cadastro_de_cliente();
            orcamento.Show();
            this.Hide();
        }

        private void buttonAlterarO_Click(object sender, EventArgs e)
        {
            Form orcamento = new customizacao();
            orcamento.Show();
            this.Hide();
        }
    }
}
