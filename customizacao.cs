namespace garagem13
{
    public partial class TelaCustomizacao : Form
    {
        public TelaCustomizacao()
        {
            InitializeComponent();
        }

        private void buttonCriarPedidoC_Click(object sender, EventArgs e)
        {
            Form TelaCustomizacao = new TelaRevisao();
            TelaCustomizacao.Show();
            this.Hide();
        }

        private void buttonVoltarC_Click(object sender, EventArgs e)
        {
            Form TelaCustomizacao = new TelaCadastroCliente();
            TelaCustomizacao.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
