using garagem13.Repositorio;

namespace garagem13.dominio
{
    internal class Cliente
    {
        private readonly ClienteRepositorio ClienteRepositorio = new();

        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Idade { get; set; }
        public string? Email { get; set; }
        public string? Telefone { get; set; }
        public Endereco? Endereco { get; set; }

        public string Validar()
        {
            if (string.IsNullOrWhiteSpace(Nome))
            {
                return "O campo Nome é obrigatório";
            }

            if (!Nome.Contains(' '))
            {
                return "O campo Nome deve conter nome e sobrenome";
            }

            // Falta validação para idade

            if (string.IsNullOrWhiteSpace(Email))
            {
                return "O campo Email é obrigatório";
            }

            if (!Email.Contains('@') && !Email.Contains('.'))
            {
                return "O campo Email deve ser um email válido";
            }

            var clienteExistente = ClienteRepositorio.BuscarClientePorEmail(Email);
            if (clienteExistente != null && clienteExistente?.Id != Id)
            {
                return "Já existe um cliente com esse email.";
            }

            if (string.IsNullOrWhiteSpace(Telefone) || Telefone.Length != 11)
            {
                return "O campo Telefone é obrigatório";
            }

            clienteExistente = ClienteRepositorio.BuscarClientePorTelefone(Telefone);
            if (clienteExistente != null && clienteExistente?.Id != Id)
            {
                return "Já existe um cliente com esse telefone.";
            }

            return string.Empty;
        }

        public static List<Cliente> ListarClientes()
        {
            ClienteRepositorio repositorio = new();
            return repositorio.ListarClientes();
        }

        public void InserirCliente()
        {
            ClienteRepositorio.InserirCliente(this);
        }
    }
}

