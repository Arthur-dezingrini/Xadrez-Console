namespace tabuleiro
{
    internal class Tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        private Peca[,] pecas;

        public Tabuleiro(int linha, int colunas)
        {
            Linhas = linha;
            Colunas = colunas;
            pecas = new Peca[Linhas, Colunas];
        }

        public Peca Peca(int linha, int coluna) 
        {
            return pecas[linha, coluna];
        }

        public void ColocarPeca (Peca p, Posicao pos) 
        {
            pecas[pos.Linha, pos.Coluna] = p;
            p.Posicao = pos;
        }
    }
}
