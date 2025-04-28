namespace garagem13
{
    public partial class inclusao_de_cliente : Form
    {
        public inclusao_de_cliente()
        {
            InitializeComponent();
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            Form inclusao_de_cliente = new cadastro_de_cliente();
            inclusao_de_cliente.Show();
            this.Hide();
        }

        private void buttonIncluirIC_Click(object sender, EventArgs e)
        {
            Form inclusao_de_cliente = new cadastro_de_cliente();
            inclusao_de_cliente.Show();
            this.Hide();
        }
    }
}
