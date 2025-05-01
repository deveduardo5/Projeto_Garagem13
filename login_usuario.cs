using garagem13.dominio;

namespace garagem13
{
    public partial class login_usuario : Form
    {
        public login_usuario()
        {
            InitializeComponent();
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text.Trim();
            string senha = textBoxSenha.Text;

            // Validação de campos

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Informe e-mail e senha validos");
                return;
            }
            if (string.IsNullOrEmpty(email) || string.IsNullOrWhiteSpace(senha))

            {
                MessageBox.Show("Informe e-mail e senha validos");
                return;
            }

            if (string.IsNullOrEmpty(senha) || senha.Length < 8)
            {
                MessageBox.Show("Senha incorreta.");
                return;
            }
            var funcionario = new Funcionario
            {
                Email = textBoxEmail.Text,
                Senha = textBoxSenha.Text
            };
            var funcionarioLogado = funcionario.Login();

            if (funcionarioLogado != null)
            {
                var formularioCadastroCliente = new cadastro_de_cliente();
                formularioCadastroCliente.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Email ou senha inválidos.", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
