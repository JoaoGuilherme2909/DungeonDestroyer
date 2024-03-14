using System;

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
        
        void atacar(Entidade inimigo)
        {
            bool danoHeroi = false;
            Random rnd = new Random();
            int num = rnd.Next(50);

            switch (heroi.sorte)
            {
                case 0:
                    if (num <= 25)
                    {
                        danoHeroi = true;
                    }
                    else
                    {
                        danoHeroi = false;
                    }
                    break;
                case >= 10:
                    if(num <= 35)
                    {
                        danoHeroi = true;
                    }
                    else
                    {
                        danoHeroi = false;
                    }
                    break;  
            } 


            if (danoHeroi == true)
            {
                inimigo.vida -= heroi.dano;
            }
            else
            {
                heroi.vida -= inimigo.dano;
            }
        }

        void ganhoOuro()
        {
            switch(inimigos.Count)
            {
                case 5:
                    heroi.ouro += 50;
                    break;
                case 4:
                    heroi.ouro += 40;
                    break;
                case 3:
                    heroi.ouro += 30;
                    break;
                case 2:
                    heroi.ouro += 20;
                    break;
                case 1:
                    heroi.ouro += 10;
                    break;
            }
        }

        Heroi fim()
        {
            return heroi;
        }

   }
}
