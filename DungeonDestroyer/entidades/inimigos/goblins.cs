namespace DungeonDestroyer.entidades.inimigos
{
    class goblins : Entidade
    {
        public goblins(int vida, int dano, int armadura, int sorte) : base(vida, dano, armadura, sorte)
        {
            this.vida = vida;
            this.dano = dano;  
            this.armadura = armadura;   
            this.sorte = sorte;
        }
    }
}
