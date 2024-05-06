namespace SenhaMVC
{
    public partial class SenhaView : Form, ISenhaView
    {

        SenhaController controller;
        public SenhaView()
        {
            InitializeComponent();
            ConfigureComboBoxColors();
        }

        #region Implementação da interface ISenhaView
        public ColorComboBox CorSelecionada1
        {
            get { return cbxCorSelecionada1; }
            set { cbxCorSelecionada1 = value; }
        }
        public ColorComboBox CorSelecionada2
        {
            get { return cbxCorSelecionada2; }
            set { cbxCorSelecionada2 = value; }
        }
        public ColorComboBox CorSelecionada3
        {
            get { return cbxCorSelecionada3; }
            set { cbxCorSelecionada3 = value; }
        }
        public ColorComboBox CorSelecionada4
        {
            get { return cbxCorSelecionada4; }
            set { cbxCorSelecionada4 = value; }
        }
        public ColorComboBox CorSelecionada5
        {
            get { return cbxCorSelecionada5; }
            set { cbxCorSelecionada5 = value; }
        }
        public DataGridView Jogadas
        {
            get { return dgvJogadas; }
            set { dgvJogadas = value; }
        }
        public DataGridView Resultados
        {
            get { return dgvResultados; }
            set { dgvResultados = value; }
        }
        #endregion

        void ISenhaView.SetController(SenhaController senhaController)
        {
            controller = senhaController;
        }
        private void btnJogar_Click(object sender, EventArgs e)
        {
            controller.EfetuarJogada();
            dgvJogadas.ClearSelection();
            dgvResultados.ClearSelection();
        }
    }
}