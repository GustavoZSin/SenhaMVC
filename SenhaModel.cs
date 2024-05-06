namespace SenhaMVC
{
    public class SenhaModel
    {
        private List<string> senhaGerada;
        private List<List<string>> jogadas;
        private List<List<string>> resultados;
        public SenhaModel()
        {
            this.GerarSenha();
            jogadas = new List<List<string>>();
            resultados = new List<List<string>>();
        }
        private void GerarSenha()
        {
            List<string> coresDisponiveis = new List<string>() { "Vermelho", "Verde", "Amarelo", "Azul", "Branco", "Preto", "Rosa", "Cinza" };
            senhaGerada = new List<string>();

            Random random = new Random();
            while (senhaGerada.Count < 5)
            {
                int index = random.Next(coresDisponiveis.Count);
                string cor = coresDisponiveis[index];
                senhaGerada.Add(cor);
                coresDisponiveis.RemoveAt(index);
            }
        }
        public List<string> ObterSenhaGerada()
        {
            return senhaGerada;
        }
        public void InserirJogada(List<string> jogadaEfetuada)
        {
            resultados.Add(CompararJogada(jogadaEfetuada));
            jogadas.Add(jogadaEfetuada);
        }
        private List<string> CompararJogada(List<string> jogadaEfetuada)
        {
            List<string> resultado = new List<string>();

            for (int i = 0; i < jogadaEfetuada.Count; i++)
            {
                string cor = jogadaEfetuada[i];
                if (senhaGerada.Contains(cor))
                {
                    if (senhaGerada[i] == cor)
                        resultado.Add("Preto");
                    else
                        resultado.Add("Branco");
                }
                else
                {
                    resultado.Add(string.Empty);
                }
            }

            return resultado.OrderByDescending(x => x).ToList();
        }
        public bool VerificarFimDeJogoPorLimite()
        {
            return jogadas.Count >= 10;
        }
        public bool VerificarFimDeJogoPorAcerto()
        {
            return resultados.Any(r => r.All(c => c == "Preto"));
        }
        public List<string> ObterUltimoResultado()
        {
            return resultados.Last();
        }
        public void ReiniciarJogo()
        {
            jogadas = new List<List<string>>();
            resultados = new List<List<string>>();

            GerarSenha();
        }

        public bool ValidaJogada(List<Tuple<string, Color>> jogadaEfetuada)
        {
            foreach (var corSelecionada in jogadaEfetuada)
            {
                if (corSelecionada.Item1 == string.Empty || jogadaEfetuada.Count(cor => cor.Item1 == corSelecionada.Item1) > 1)
                    return false;
            }

            return true;
        }
    }
}