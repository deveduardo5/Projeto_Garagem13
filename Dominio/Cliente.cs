using garagem13.Repositorio;

namespace garagem13.dominio
{
    //internal class Cliente
    //{
    //    public int Id { get; set; }
    //    public string? Nome { get; set; }
    //    public int Idade { get; set; }
    //    public int IdEndereco { get; set; }
    //    public string? Email { get; set; }
    //    public int Telefone { get; set; }

    //    private readonly ClienteRepositorio repositorio = new();

    //    public bool Criar()
    //    {
    //        if (!Validar()) return false;


    //        repositorio.Criar(this);
    //        return true;
    //    }

    //    private bool Validar()
    //    {
    //        return !string.IsNullOrWhiteSpace(Nome)
    //            && Idade > 0
    //            && IdEndereco > 0
    //            && !string.IsNullOrWhiteSpace(Email)
    //            && Telefone > 0;
    //    }
    //}

    internal class Cliente
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public int Idade { get; set; }
        public int IdEndereco { get; set; }
        public string? Email { get; set; }
        public string Telefone { get; set; }

        private readonly ClienteRepositorio repositorio = new();

        public bool Criar()
        {
            if (!Validar()) return false;
            repositorio.Criar(this);
            return true;
        }

        private bool Validar()
        {
            return !string.IsNullOrWhiteSpace(Nome)
                && Idade > 0
                && IdEndereco > 0
                && !string.IsNullOrWhiteSpace(Email)
                && Email.Contains("@")
                && !string.IsNullOrWhiteSpace(Telefone)
                && Telefone.All(char.IsDigit)
                && Telefone.Length >= 8;
        }
    }
}

