using garagem13.Repositorio;

namespace garagem13.dominio
{
    internal class Funcionario
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Senha { get; set; }

        private readonly FuncionarioRepositorio repositorio = new();

        public Funcionario? Login()
        {
            if (string.IsNullOrWhiteSpace(Email) || string.IsNullOrWhiteSpace(Senha))
            {
                return null;
            }
            return repositorio.BuscarPorEmailSenha(Email, Senha);
        }
    }
}
