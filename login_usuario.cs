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

            DataBase conn = new DataBase();
            string query = "SELECT * FROM funcionario WHERE email = @email AND senha = @senha";

            using (MySqlCommand cmd = new MySqlCommand(query, conn.AbrirConexao()))
            {
                cmd.Parameters.AddWithValue("@email", textBoxEmail.Text);
                cmd.Parameters.AddWithValue("@senha", textBoxSenha.Text);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        MessageBox.Show("Login realizado com sucesso!");
                        Form login_usuario = new cadastro_de_cliente();
                        login_usuario.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Email ou senha inválidos!");
                    }
                }
                conn.FecharConexao();
            }
        }
    }
}
