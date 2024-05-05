namespace SenhaMVC
{
    public class SenhaController
    {
        private ISenhaView senhaView;
        private SenhaModel senhaModel;
        public SenhaController(ISenhaView senhaView, SenhaModel senhaModel)
        {
            this.senhaView = senhaView;
            this.senhaModel = senhaModel;
            senhaView.SetController(this);
        }
        public void EfetuarJogada()
        {
            List<Tuple<string, Color>> jogadaEfetuada = new List<Tuple<string, Color>>()
            {
                Tuple.Create(senhaView.CorSelecionada1.Text, senhaView.CorSelecionada1.BackColor),
                Tuple.Create(senhaView.CorSelecionada2.Text, senhaView.CorSelecionada2.BackColor),
                Tuple.Create(senhaView.CorSelecionada3.Text, senhaView.CorSelecionada3.BackColor),
                Tuple.Create(senhaView.CorSelecionada4.Text, senhaView.CorSelecionada4.BackColor),
                Tuple.Create(senhaView.CorSelecionada5.Text, senhaView.CorSelecionada5.BackColor),
            };

            if (senhaModel.ValidaJogada(jogadaEfetuada))
            {
                senhaView.Jogadas.Rows.Add(FormataLinhaJogada(jogadaEfetuada));
                senhaModel.InserirJogada(jogadaEfetuada.Select(t => t.Item1).ToList());

                List<string> ultimoResultado = senhaModel.ObterUltimoResultado();
                senhaView.Resultados.Rows.Add(FormataLinhaResultado(ultimoResultado)); 
            }
            else
            {
                senhaView.ExibirMensagem("A jogada não é válida." +
                    "\nTodos os campos devem ser preenchidos com cores diferentes. " +
                    "\nRevise o que foi preenchido e tente novamente!");
            }
        }
        private DataGridViewRow FormataLinhaJogada(List<Tuple<string, Color>> jogadaEfetuada)
        {
            DataGridViewRow jogadaRow = new DataGridViewRow();
            foreach (var corSelecionada in jogadaEfetuada)
            {
                DataGridViewTextBoxCell cell = new DataGridViewTextBoxCell();
                cell.Value = corSelecionada.Item1;
                cell.Style.BackColor = corSelecionada.Item2;
                cell.Style.ForeColor = corSelecionada.Item2 == Color.Black ? Color.White : Color.Black;

                jogadaRow.Cells.Add(cell);
            }

            return jogadaRow;
        }
        private DataGridViewRow FormataLinhaResultado(List<string> ultimoResultado)
        {
            DataGridViewRow resultadoRow = new DataGridViewRow();
            foreach (var resultado in ultimoResultado)
            {
                DataGridViewTextBoxCell cell = new DataGridViewTextBoxCell();
                cell.Value = resultado;

                cell.Style.BackColor = resultado == "Preto" ? Color.Black : Color.White;
                cell.Style.ForeColor = resultado == "Preto" ? Color.White : Color.Black;

                resultadoRow.Cells.Add(cell);
            }

            return resultadoRow;
        }
        public bool JogoAcabou()
        {
            bool jogoAcabou = false;

            if (senhaModel.VerificarFimDeJogoPorLimite())
            {
                senhaView.ExibirMensagem("Você perdeu! A senha era: " + string.Join(", ", senhaModel.ObterSenhaGerada()));
                jogoAcabou = true;
            }

            if (senhaModel.VerificarFimDeJogoPorAcerto())
            {
                senhaView.ExibirMensagem("Você venceu! A senha era: " + string.Join(", ", senhaModel.ObterSenhaGerada()));
                jogoAcabou = true;
            }

            return jogoAcabou;
        }
        public void ReiniciarJogo()
        {
            senhaView.Resultados.Rows.Clear();
            senhaView.Jogadas.Rows.Clear();

            senhaModel.ReiniciarJogo();
        }
    }
}