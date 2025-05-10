using garagem13.Repositorio;

namespace garagem13.dominio
{
    internal class Customizacao
    {
        private readonly CustomizacaoRepositorio CustomizacaoRepositorio = new();

        public int Id { get; set; }
        public int Aro { get; set; }
        public int Quadro { get; set; }
        public int Cor { get; set; }
        public int Motorizacao { get; set; }
        public int Cliente { get; set; }

        public string Criar()
        {
            if (Aro < 1)
            {
                return "Escolha um aro.";
            }

            if (Quadro < 1)
            {
                return "Escolha um quadro.";
            }

            if (Cor < 1)
            {
                return "Escolha uma cor.";
            }

            if (Motorizacao < 1)
            {
                return "Escolha um motor.";
            }

            CustomizacaoRepositorio.Criar(this);
            return string.Empty;
        }
    }
}
