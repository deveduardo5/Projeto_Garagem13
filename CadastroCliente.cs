using garagem13.dominio;

namespace garagem13
{
    public partial class TelaCadastroCliente : Form
    {
        //private readonly BindingSource BindingSource = [];

        public TelaCadastroCliente()
        {
            InitializeComponent();
        }

        private void buttonIncluirCC_Click(object sender, EventArgs e)
        {
            var telaInclusao = new TelaInclusaoCliente(this);
            telaInclusao.Show();
            this.Hide();

            //Form TelaCadastroCliente = new TelaInclusaoCliente();
            //TelaCadastroCliente.Show();
            //this.Hide();
        }

        private void buttonCustomizacaoCC_Click_1(object sender, EventArgs e)
        {
            Form TelaCadastroCliente = new TelaCustomizacao();
            TelaCadastroCliente.Show();
            this.Hide();
        }

        public void AtualizarGrid()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = Cliente.ListarClientes();
            dataGridViewCadastroCliente.DataSource = bs;
        }

        //private void FormCadastroCliente_Load(object sender, EventArgs e)
        //{

        //    BindingSource.DataSource = Cliente.ListarClientes();
        //    dataGridViewCadastroCliente.DataSource = BindingSource;
        //}
    }
}

