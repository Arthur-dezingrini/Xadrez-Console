using tabuleiro;

namespace tabuleiro
{
    abstract class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QtMovimentos { get; protected set; }
        public Tabuleiro Tab { get; protected set; }

        public Peca(Cor cor, Tabuleiro tab)
        {
            Posicao = null;
            Cor = cor;
            Tab = tab;
            QtMovimentos = 0;
        }

        public void IcrementarQteMovimentos()
        {
            QtMovimentos++;
        }

        public abstract bool[,] MovimentosPossiveis();
    }
}
