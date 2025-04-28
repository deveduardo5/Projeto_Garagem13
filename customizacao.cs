namespace garagem13
{
    public partial class customizacao : Form
    {
        public customizacao()
        {
            InitializeComponent();
        }

        private void buttonCriarPedidoC_Click(object sender, EventArgs e)
        {
            Form customizacao = new revisao();
            customizacao.Show();
            this.Hide();
        }

        private void buttonVoltarC_Click(object sender, EventArgs e)
        {
            Form customizacao = new cadastro_de_cliente();
            customizacao.Show();
            this.Hide();
        }
    }
}
