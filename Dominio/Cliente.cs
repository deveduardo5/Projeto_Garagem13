using System.Text.RegularExpressions;
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
        public string? Logradouro { get; set; }
        public string? Numero { get; set; }
        public string? Complemento { get; set; }
        public string? Bairro { get; set; }
        public string? Municipio { get; set; }
        public string? Estado { get; set; }
        public string? CEP { get; set; }

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

            if (string.IsNullOrWhiteSpace(Idade))
            {
                return "O campo Idade é obrigatório";
            }

            if (!int.TryParse(Idade, out int idadeNumerica) || idadeNumerica <= 0 || idadeNumerica > 120)
            {
                return "A idade deve ser um número entre 1 e 120";
            }

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

            if (!Regex.IsMatch(Telefone, @"^\d{11}$"))
            {
                return "O campo Telefone deve conter exatamente 11 dígitos numéricos.";
            }

            clienteExistente = ClienteRepositorio.BuscarClientePorTelefone(Telefone);
            if (clienteExistente != null && clienteExistente?.Id != Id)
            {
                return "Já existe um cliente com esse telefone.";
            }

            if (string.IsNullOrWhiteSpace(CEP) || CEP.Length != 8)
            {
                return "O campo CEP é obrigatório";
            }

            if (!Regex.IsMatch(CEP, @"^\d{8}$"))
            {
                return "O campo CEP deve conter exatamente 8 dígitos numéricos.";
            }

            if (string.IsNullOrWhiteSpace(Logradouro))
            {
                return "O campo Logradouro é obrigatório";
            }

            if (string.IsNullOrWhiteSpace(Numero))
            {
                return "O campo Número é obrigatório";
            }

            if (string.IsNullOrWhiteSpace(Bairro))
            {
                return "O campo Bairro é obrigatório";
            }

            if (string.IsNullOrWhiteSpace(Municipio))
            {
                return "O campo Município é obrigatório";
            }

            if (string.IsNullOrWhiteSpace(Estado))
            {
                return "O campo Estado é obrigatório";
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

