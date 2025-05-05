using garagem13.dominio;

namespace garagem13
{
    public partial class TelaLoginUsuario : Form
    {
        public TelaLoginUsuario()
        {
            InitializeComponent();
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            string email = textBoxEmailLU.Text.Trim();
            string senha = textBoxSenhaLU.Text;

            //Validação de campos

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(senha))
            {
                MessageBox.Show("Preencha e-mail e senha corretamente!");
                return;
            }

            if (string.IsNullOrEmpty(senha) || senha.Length < 8)
            {
                MessageBox.Show("Senha incorreta.");
                return;
            }

            var funcionario = new Funcionario
            {
                Email = textBoxEmailLU.Text,
                Senha = textBoxSenhaLU.Text
            };
            var funcionarioLogado = funcionario.Login();
            if (funcionarioLogado != null)
            {
                var TelaLoginUsuario = new TelaCadastroCliente();
                TelaLoginUsuario.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Email ou senha inválidos.", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
