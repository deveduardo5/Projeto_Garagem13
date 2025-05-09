using garagem13.dominio;

namespace garagem13
{
    public partial class TelaInclusaoCliente : Form
    {
        private Cliente Cliente = new()
        {
            Endereco = new()
        };

        private readonly BindingSource BindingSource = new BindingSource();

        public TelaInclusaoCliente(TelaCadastroCliente telaCadastro)
        {
            InitializeComponent();
        }

        private bool CriarCliente()
        {
            Cliente = new Cliente();
            Cliente.Endereco = new Endereco();

            Cliente.Endereco.Logradouro = textBoxLogradouro.Text;
            Cliente.Endereco.Numero = textBoxNumero.Text;
            Cliente.Endereco.Bairro = textBoxBairro.Text;
            Cliente.Endereco.CEP = maskedTextBoxCEP.Text.Replace("-", "");
            Cliente.Endereco.Municipio = textBoxMunicipio.Text;
            Cliente.Endereco.Estado = textBoxEstado.Text;
            Cliente.Endereco.Complemento = textBoxComplemento.Text;

            Cliente.Nome = textBoxNome.Text;
            Cliente.Idade = textBoxIdade.Text;
            Cliente.Email = textBoxEmail.Text;
            Cliente.Telefone = maskedTextBoxTelefone.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");

            string validacaoCLiente = Cliente.Validar();
            if (!string.IsNullOrWhiteSpace(validacaoCLiente))
            {
                labelErro.Text = validacaoCLiente;
                return false;
            }

            string validacaoEndereco = Cliente.Endereco.Validar();
            if (!string.IsNullOrWhiteSpace(validacaoEndereco))
            {
                labelErro.Text = validacaoEndereco;
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
    }
}
