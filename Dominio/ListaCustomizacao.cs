namespace garagem13.Dominio
{
    internal class ListaCustomizacao
    {
        public int CustomizacaoId { get; set; }
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }

        public string MarcaAro { get; set; }
        public int TamanhoAro { get; set; }
        public string ModeloAro { get; set; }
        public decimal PrecoAro { get; set; }

        public string MarcaQuadro { get; set; }
        public string ModeloQuadro { get; set; }
        public decimal PrecoQuadro { get; set; }

        public string MarcaTinta { get; set; }
        public string TipoTinta { get; set; }
        public decimal PrecoTinta { get; set; }

        public string MarcaMotor { get; set; }
        public string ModeloMotor { get; set; }
        public int PotenciaMotor { get; set; }
        public decimal PrecoMotor { get; set; }

        //public string? ClienteNome { get; set; }
        //public string? ClienteEmail { get; set; }
        //public string? ClienteTelefone { get; set; }


        //public string? AroMarca { get; set; }
        //public int AroTamanhoEmPolegadas { get; set; }
        //public string? AroModelo { get; set; }
        //public decimal AroPreco { get; set; }

        //public string? QuadroMarca { get; set; }
        //public string? QuadroModelo { get; set; }
        //public decimal QuadroPreco { get; set; }

        //public string? CorMarca { get; set; }
        //public string? CorTipo { get; set; }
        //public decimal CorPreco { get; set; }

        //public string? MarcaMotor { get; set; }
        //public int MotorPotencia { get; set; }
        //public string? MotorModelo { get; set; }
        //public decimal MotorPreco { get; set; }
    }
}
