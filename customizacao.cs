using garagem13.dominio;

namespace garagem13
{
    public partial class TelaCustomizacao : Form
    {
        private int idCliente { get; set; }

        public TelaCustomizacao(int idCliente)
        {
            InitializeComponent();
            this.idCliente = idCliente;

            MessageBox.Show(idCliente.ToString());
        }

        //private Customizacao customizacao = new();

        //private readonly BindingSource BindingSource = new BindingSource();

        //private bool CriarPedido()
        //{
        //    Customizacao = new Customizacao();

        //    Customizacao.Aro = comboBoxAro.Text;
        //    Customizacao.Quadro = comboBoxQuadro.Text;
        //    Customizacao.Cor = comboBoxCor.Text;
        //    Customizacao.Motorizacao = comboBoxMotorizacao.Text;

        //    return true;
        //}

        private void buttonCriarPedidoC_Click(object sender, EventArgs e)
        {
            Form TelaOrcamento = new TelaOrcamento();
            TelaOrcamento.Show();
            this.Hide();
        }

        private void buttonVoltarC_Click(object sender, EventArgs e)
        {
            Form TelaCadastroCliente = new TelaCadastroCliente();
            TelaCadastroCliente.Show();
            this.Hide();
        }
    }
}
