namespace tabuleiro
{
    public class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qteMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca( Cor cor, Tabuleiro tab)
        {
            Posicao = null;
            this.cor = cor;
            this.qteMovimentos = 0;
            this.tab = tab;
        }
    
        
    }
}
