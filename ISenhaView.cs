namespace SenhaMVC
{
    public interface ISenhaView
    {
        void SetController(SenhaController senhaController);
        void ExibirMensagem(string mensagem) { MessageBox.Show(mensagem); }
        ColorComboBox CorSelecionada1 { get; set; }
        ColorComboBox CorSelecionada2 { get; set; }
        ColorComboBox CorSelecionada3 { get; set; }
        ColorComboBox CorSelecionada4 { get; set; }
        ColorComboBox CorSelecionada5 { get; set; }
        DataGridView Jogadas { get; set; }
        DataGridView Resultados { get; set; }
    }
}