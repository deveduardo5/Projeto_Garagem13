using garagem13.Repositorio;

namespace garagem13.Dominio
{
    internal class Produto
    {
        public int Id { get; set; }
        public string? Marca { get; set; }
        public string? Modelo { get; set; }
        public int? TamanhoEmPolegadas { get; set; }
        public string? TipoDeTinta { get; set; }
        public int? Potencia { get; set; }
        public decimal Preco { get; set; }

        public string GetStringAro()
        {
            return $"{Marca}, {Modelo}, {TamanhoEmPolegadas}, R$ {Preco}";
        }

        public string GetStringQuadro()
        {
            return $"{Marca}, {Modelo}, {TamanhoEmPolegadas}, R$ {Preco}";
        }

        public string GetStringCor()
        {
            return $"{Marca}, {TipoDeTinta}, R$ {Preco}";
        }

        public string GetStringMotor()
        {
            return $"{Marca}, {Modelo}, {Potencia}, R$ {Preco}";
        }

        public List<Produto> ListarAros()
        {
            return new CustomizacaoRepositorio().ListarAros();
        }

        public List<Produto> ListarQuadros()
        {
            return new CustomizacaoRepositorio().ListarQuadros();
        }

        public List<Produto> ListarCores()
        {
            return new CustomizacaoRepositorio().ListarCores();
        }

        public List<Produto> ListarMotores()
        {
            return new CustomizacaoRepositorio().ListarMotores();
        }
    }
}
