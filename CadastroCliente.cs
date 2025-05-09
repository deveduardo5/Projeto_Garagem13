using garagem13.dominio;

namespace garagem13
{
    public partial class TelaCadastroCliente : Form
    {
        public TelaCadastroCliente()
        {
            InitializeComponent();
        }

        private void buttonIncluirCC_Click(object sender, EventArgs e)
        {
            var telaInclusao = new TelaInclusaoCliente(this);
            telaInclusao.Show();
            this.Hide();
        }

        private void buttonCustomizacaoCC_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewCadastroCliente.SelectedRows.Count <= 0 || dataGridViewCadastroCliente.SelectedRows[0].Cells.Count <= 0 || dataGridViewCadastroCliente.SelectedRows[0].Cells[0].Value == null)
            {
                MessageBox.Show("Selecione um cliente");
                return;
            }

            int idCliente = (int)dataGridViewCadastroCliente.SelectedRows[0].Cells[0].Value;
            Form TelaCadastroCliente = new TelaCustomizacao(idCliente);
            TelaCadastroCliente.Show();
            this.Hide();
        }

        public void AtualizarGrid()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = Cliente.ListarClientes();
            dataGridViewCadastroCliente.DataSource = bs;
        }

        private void TelaCadastroCliente_Load(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void dataGridViewCadastroCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

