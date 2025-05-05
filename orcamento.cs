namespace garagem13
{
    public partial class TelaOrcamento : Form
    {
        public TelaOrcamento()
        {
            InitializeComponent();
        }

        private void buttonCancelarO_Click(object sender, EventArgs e)
        {
            Form TelaOrcamento = new TelaCadastroCliente();
            TelaOrcamento.Show();
            this.Hide();
        }

        private void buttonAlterarO_Click(object sender, EventArgs e)
        {
            Form TelaOrcamento = new TelaCustomizacao();
            TelaOrcamento.Show();
            this.Hide();
        }
    }
}
