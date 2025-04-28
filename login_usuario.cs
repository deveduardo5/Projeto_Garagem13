using garagem13.banco_de_dados;
using MySql.Data.MySqlClient;

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
            Form login_usuario = new cadastro_de_cliente();
            login_usuario.Show();
            this.Hide();

            string email = textBoxEmail.Text.Trim();
            string senha = textBoxSenha.Text;

            // Validação de campos
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("O campo de e-mail não pode estar vazio.");
                return;
            }

            if (string.IsNullOrEmpty(senha) || senha.Length < 8)
            {
                MessageBox.Show("A senha deve conter no mínimo 8 caracteres.");
                return;
            }


        }  
        private void login_usuario_Load(object sender, EventArgs e)
        {

        }
    }
}
