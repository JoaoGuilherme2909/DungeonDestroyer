using DungeonDestroyer.entidades;

class Program
{

    public static int Generate(int range)
    {
        Random rnd = new Random();
        int num = rnd.Next(range);
        return num;
    }

    static void Main()
    {
        bool jogo;
        Console.WriteLine("Bem vindo ao Dungeon Destroyer!");
        Console.WriteLine("Deseja começar um jogo? S ou N");
        string? escolha = Console.ReadLine();
        Heroi h1 = new Heroi(500, 30, 20, 0);

        if (escolha.Equals("S", StringComparison.CurrentCultureIgnoreCase))
        {
            jogo = true;
            Console.WriteLine("Vamos criar um herói para você!");
            Console.WriteLine("Stats do seu herói:");
            Console.WriteLine($"    vida: {h1.vida}");
            Console.WriteLine($"    dano: {h1.dano}");
            Console.WriteLine($"    armadura: {h1.armadura}");
            Console.WriteLine($"    sorte: {h1.sorte}");
        }
        else
        {
            Console.WriteLine("Ent tchau");
            jogo = false; 
        }
        /*while (jogo == true)
        {

            
        }*/
    }
}