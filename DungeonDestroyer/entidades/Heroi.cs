using System.Security.Cryptography.X509Certificates;

namespace DungeonDestroyer.entidades;

class Heroi : Entidade
{

    private string _nome;
    /*private int _vida;
    private int _dano;
    private int _armadura;
    private int _sorte;*/
    private int _armorPen;
    private int _ouro;
    private List<Entidade> _items = new List<Entidade>{};

    public string nome { set => _nome = value; get => _nome; }
    /*public int vida { set => _vida = value; get => _vida; }
    public int dano { set => _dano = value; get => _dano; }
    public int armadura { set => _armadura = value; get => _armadura; }
    public int sorte { set => _sorte = value; get => _sorte; }*/
    public int armorPen { set => _armorPen = value; get => _armorPen; }
    public int ouro { set => _ouro = value; get => _ouro; }

    public Heroi(int vida, int dano, int armadura, int sorte, int armorPen, int ouro) : base( vida, dano, armadura, sorte)
    {
        this.vida = vida; 
        this.dano = dano;
        this.sorte = sorte;
        this.armadura = armadura;
        this.armorPen = armorPen;
        this.ouro = ouro;
    }

    List<Entidade> GetItems()
    {
        return _items;
    } 

    void addItem(Entidade item)
    {
        _items.Add(item);
    }

    void removeItem(Entidade item)
    {
        _items.Remove(item);
    }

    public void ChooseClass(int classe)
    {
        switch (classe)
        {
            case 1:
                sorte += 10;
                dano += 20;
                armorPen += 10;
                break;
            case 2:
                vida += 50;
                dano += 30;
                break;
            case 3:
                vida += 70;
                armadura += 20;
                break;
        }
    }

}
