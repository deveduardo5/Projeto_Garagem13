using garagem13.Repositorio;

namespace garagem13.dominio
{
    internal class Customizacao
    {
        private readonly CustomizacaoRepositorio CustomizacaoRepositorio = new();

        public int Id { get; set; }
        public string? Aro { get; set; }
        public string? Quadro { get; set; }
        public string? Cor { get; set; }
        public string? Motorizacao { get; set; }
        public Cliente? Cliente { get; set; }

        public static List<Customizacao> ListarCustomizacao()
        {
            CustomizacaoRepositorio repositorio = new();
            return repositorio.ListarCustomizacao();
        }

        //public bool Criar()
        //{
        //    if (!Validar())
        //    {
        //        return false;
        //    }

        //    repositorio.Criar(this);
        //    return true;
        //}

        //private bool Validar()
        //{
        //    return !string.IsNullOrWhiteSpace(Aro)
        //        && !string.IsNullOrWhiteSpace(Quadro)
        //        && !string.IsNullOrWhiteSpace(Cor)
        //        && !string.IsNullOrWhiteSpace(Tipo)
        //        && !string.IsNullOrWhiteSpace(Motorizacao)
        //        && ClienteId > 0;
        //}
    }
}
