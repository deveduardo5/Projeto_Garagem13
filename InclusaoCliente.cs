using garagem13.dominio;

namespace garagem13
{
    public partial class TelaInclusaoCliente : Form
    {
        private Cliente Cliente = new();

        private readonly BindingSource BindingSource = new BindingSource();

        public TelaInclusaoCliente(TelaCadastroCliente telaCadastro)
        {
            InitializeComponent();
        }

        private bool CriarCliente()
        {
            Cliente = new Cliente();

            Cliente.Nome = textBoxNome.Text;
            Cliente.Idade = textBoxIdade.Text;
            Cliente.Email = textBoxEmail.Text;
            Cliente.Telefone = maskedTextBoxTelefone.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");
            Cliente.Logradouro = textBoxLogradouro.Text;
            Cliente.Numero = textBoxNumero.Text;
            Cliente.Bairro = textBoxBairro.Text;
            Cliente.CEP = maskedTextBoxCEP.Text.Replace("-", "");
            Cliente.Municipio = textBoxMunicipio.Text;
            Cliente.Estado = textBoxEstado.Text;
            Cliente.Complemento = textBoxComplemento.Text;

            string validacaoCLiente = Cliente.Validar();
            if (!string.IsNullOrWhiteSpace(validacaoCLiente))
            {
                labelErro.Text = validacaoCLiente;
                return false;
            }

            return true;
        }

        private void LimparForm()
        {
            textBoxNome.Clear();
            textBoxIdade.Clear();
            textBoxEmail.Clear();
            maskedTextBoxTelefone.Clear();

            textBoxLogradouro.Clear();
            textBoxNumero.Clear();
            textBoxBairro.Clear();
            maskedTextBoxCEP.Clear();
            textBoxMunicipio.Clear();
            textBoxEstado.Clear();
            textBoxComplemento.Clear();

            labelErro.Text = string.Empty;
        }

        private void buttonIncluirIC_Click(object sender, EventArgs e)
        {
            if (!CriarCliente())
            {
                return;
            }

            Cliente.InserirCliente();
            LimparForm();

            Form inclusao_de_cliente = new TelaCadastroCliente();
            inclusao_de_cliente.Show();
            this.Hide();
        }

        private void buttonVoltarIC_Click_1(object sender, EventArgs e)
        {
            Form TelaInclusaoCliente = new TelaCadastroCliente();
            TelaInclusaoCliente.Show();
            this.Hide();
        }

        private void TelaInclusaoCliente_Load(object sender, EventArgs e)
        {

        }

        private void labelCEP_Click(object sender, EventArgs e)
        {

        }

        private void labelMunicipio_Click(object sender, EventArgs e)
        {

        }
    }
}
