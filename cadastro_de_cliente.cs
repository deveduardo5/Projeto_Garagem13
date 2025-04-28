namespace garagem13
{
    public partial class cadastro_de_cliente : Form
    {
        public cadastro_de_cliente()
        {
            InitializeComponent();
        }

        private void buttonIncluirCC_Click(object sender, EventArgs e)
        {
            Form cadastro_de_cliente = new inclusao_de_cliente();
            cadastro_de_cliente.Show();
            this.Hide();
        }

        private void buttonCustomizacaoCC_Click(object sender, EventArgs e)
        {
            Form cadastro_de_cliente = new customizacao();
            cadastro_de_cliente.Show();
            this.Hide();
        }
    }
}

