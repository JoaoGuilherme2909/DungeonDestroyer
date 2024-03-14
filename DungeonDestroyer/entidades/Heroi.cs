namespace DungeonDestroyer.entidades;

class Heroi : Entidade
{

    private string _nome;
    private int _vida;
    private int _dano;
    private int _armadura;
    private int _sorte;
    private List<Entidade> _items = new List<Entidade>{};

    public string nome { set => _nome = value; get => _nome; }
    public int vida { set => _vida = value; get => _vida; }
    public int dano { set => _dano = value; get => _dano; }
    public int armadura { set => _armadura = value; get => _armadura; }
    public int sorte { set => _armadura = value; get => _armadura; }

    public Heroi(int vida, int dano, int armadura, int sorte) : base( vida, dano, armadura, sorte)
    {
        this.vida = vida; 
        this.dano = dano;
        this.sorte = sorte;
        this.armadura = armadura;
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

    void ChooseClass(int classe)
    {
        switch (classe)
        {
            case 1:
                sorte += 10;
                dano += 20;
                break;
            case 2:
                vida += 20;
                dano += 10;
                break;
            case 3:
                vida += 20;
                armadura += 10;
                break;
        }
    }

}
