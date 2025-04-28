using garagem13.Repositorio;

namespace garagem13.dominio
{
    internal class Customizacao
    {
        //public int Id { get; set; }
        public int ClienteId { get; set; }
        public string? Aro { get; set; }
        public string? Quadro { get; set; }
        public string? Cor { get; set; }
        public string? Tipo { get; set; }
        public string? Motorizacao { get; set; }

        private readonly CustomizacaoRepositorio repositorio = new();

        public bool Criar()
        {
            if (!Validar())
            {
                return false;
            }

            repositorio.Criar(this);
            return true;
        }

        private bool Validar()
        {
            return !string.IsNullOrWhiteSpace(Aro)
                && !string.IsNullOrWhiteSpace(Quadro)
                && !string.IsNullOrWhiteSpace(Cor)
                && !string.IsNullOrWhiteSpace(Tipo)
                && !string.IsNullOrWhiteSpace(Motorizacao)
                && ClienteId > 0;
        }
    }
}
