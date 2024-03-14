namespace DungeonDestroyer.entidades.inimigos
{
   class Batalha
   {
        private Heroi heroi;
        private List<Entidade> inimigos;

        public Batalha(Heroi heroi, List<Entidade>inimigos)
        {
            this.heroi = heroi;
            this.inimigos = inimigos;
        }
        
        void atacar(Entidade inimigo, int dano, bool danoHeroi)
        {
            if (danoHeroi == true)
            {
                inimigo.vida -= heroi.dano;
            }
            else
            {
                heroi.vida -= inimigo.dano;
            }
        }

        Heroi fim()
        {
            return heroi;
        }

   }
}
