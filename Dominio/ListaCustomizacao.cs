namespace garagem13.Dominio
{
    internal class ListaCustomizacao
    {
        public int CustomizacaoId { get; set; }
        public int ClienteId { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Telefone { get; set; }

        public string? MarcaAro { get; set; }
        public int TamanhoAro { get; set; }
        public string? ModeloAro { get; set; }
        public decimal PrecoAro { get; set; }

        public string? MarcaQuadro { get; set; }
        public string? ModeloQuadro { get; set; }
        public decimal PrecoQuadro { get; set; }

        public string? MarcaTinta { get; set; }
        public string? TipoTinta { get; set; }
        public decimal PrecoTinta { get; set; }

        public string? MarcaMotor { get; set; }
        public string? ModeloMotor { get; set; }
        public int PotenciaMotor { get; set; }
        public decimal PrecoMotor { get; set; }
    }
}
