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
        public void DecrementarQteMovimentos()
        {
            QtMovimentos--;
        }


        public bool ExisteMovimentosPossiveis ()
        {
            bool[,] mat = MovimentosPossiveis();
            for (int i = 0; i<Tab.Linhas; i++)
            {
                for (int j = 0; j<Tab.Colunas; j++)
                {
                    if (mat[i,j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public bool PodeMoverPara (Posicao pos)
        {
            return MovimentosPossiveis()[pos.Linha, pos.Coluna];
        }

        public abstract bool[,] MovimentosPossiveis();
    }
}
