using System;

namespace DungeonDestroyer.entidades;

internal class Entidade
{
    private int _vida;
    private int _dano;
    private int _armadura;
    private int _sorte;

    public int vida { set => _vida = value; get => _vida; }
    public int dano { set => _dano = value; get => _dano; }
    public int armadura { set => _armadura = value; get => _armadura; }
    public int sorte { set => _sorte = value; get => _sorte; }

    public Entidade(int vida, int dano, int armadura, int sorte)
    {
        this.armadura = armadura;
        this.dano = dano;
        this.sorte = sorte;
    }
}
