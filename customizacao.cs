using garagem13.dominio;
using garagem13.Dominio;

namespace garagem13
{
    public partial class TelaCustomizacao : Form
    {
        private int IdCliente { get; set; }
        private List<Produto> Aros { get; set; }
        private List<Produto> Quadros { get; set; }
        private List<Produto> Cores { get; set; }
        private List<Produto> Motores { get; set; }
        private decimal Total { get; set; }

        public TelaCustomizacao(int idCliente)
        {
            InitializeComponent();
            this.IdCliente = idCliente;

            var Produto = new Produto();

            Aros = Produto.ListarAros();
            Quadros = Produto.ListarQuadros();
            Cores = Produto.ListarCores();
            Motores = Produto.ListarMotores();
        }

        private void TelaCustomizacao_Load(object sender, EventArgs e)
        {
            Aros.ForEach(a => comboBoxAro.Items.Add(a.GetStringAro()));
            Quadros.ForEach(q => comboBoxQuadro.Items.Add(q.GetStringQuadro()));
            Cores.ForEach(c => comboBoxCor.Items.Add(c.GetStringCor()));
            Motores.ForEach(m => comboBoxMotor.Items.Add(m.GetStringMotor()));
        }

        private void CalcularTotal()
        {
            Total = (comboBoxAro.SelectedIndex < 0 ? 0 : Aros[comboBoxAro.SelectedIndex].Preco)
                + (comboBoxQuadro.SelectedIndex < 0 ? 0 : Quadros[comboBoxQuadro.SelectedIndex].Preco)
                + (comboBoxCor.SelectedIndex < 0 ? 0 : Cores[comboBoxCor.SelectedIndex].Preco)
                + (comboBoxMotor.SelectedIndex < 0 ? 0 : Motores[comboBoxMotor.SelectedIndex].Preco);

            textBoxTotal.Text = $"R$ {Total}";
        }

        private void comboBoxAro_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void comboBoxQuadro_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void comboBoxCor_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void comboBoxMotor_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }
        
        private void buttonCriarPedidoC_Click(object sender, EventArgs e)
        {
        }

        private void buttonVoltarC_Click(object sender, EventArgs e)
        {
            Form TelaCadastroCliente = new TelaCadastroCliente();
            TelaCadastroCliente.Show();
            this.Hide();
        }
    }
}
