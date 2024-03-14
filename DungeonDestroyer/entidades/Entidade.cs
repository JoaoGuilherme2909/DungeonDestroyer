using System;

namespace DungeonDestroyer.entidades;

internal class Entidade
{
    private string nome { set; get; }
    private int vida { set; get; }
    private int dano { set; get; }
    private int armadura { set; get; }
    private int sorte { set; get; }

    public Entidade(int vida, int dano, int armadura, int sorte)
    {
        this.nome = nome;
        this.armadura = armadura;
        this.dano = dano;
        this.sorte = sorte;
    }
}
