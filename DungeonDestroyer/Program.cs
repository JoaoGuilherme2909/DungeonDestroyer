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
        Heroi h1 = new Heroi(vida:500, dano: 30, armadura: 20, sorte: 0, armorPen: 0, ouro:0);

        if (escolha.Equals("S", StringComparison.CurrentCultureIgnoreCase))
        {
            jogo = true;
            Console.WriteLine("Vamos criar um herói para você!\n");
            Console.WriteLine("Stats do seu herói:");
            Console.WriteLine($"    vida: {h1.vida}");
            Console.WriteLine($"    dano: {h1.dano}");
            Console.WriteLine($"    armadura: {h1.armadura}");
            Console.WriteLine($"    sorte: {h1.sorte}");
            Console.WriteLine($"    penetração de armadura: {h1.armorPen}\n");
            Console.WriteLine($"Digete uma das opções para escolher a sua classe como herói: 1 - assassino, 2 - guerreiro, 3 - tank\n");
            int escolhaClasse = int.Parse(Console.ReadLine());
            h1.ChooseClass(escolhaClasse);
            Console.WriteLine("Classe escolhida!!!");
            
            Console.WriteLine("Stats do seu herói atualizados:");
            Console.WriteLine($"    vida: {h1.vida}");
            Console.WriteLine($"    dano: {h1.dano}");
            Console.WriteLine($"    armadura: {h1.armadura}");
            Console.WriteLine($"    sorte: {h1.sorte}\n");
            Console.WriteLine($"    penetração de armadura: {h1.armorPen}\n");
            Console.WriteLine("Por último precimos de um nome para seu hérói: ");
            h1.nome = Console.ReadLine();

            Console.WriteLine($"Sua aventura está prestes a começar, boa sorte {h1.nome}, seja o herói que o mundo precisa!!!");

        }
        else
        {
            Console.WriteLine("Ent tchau");
            jogo = false; 
        }
        while (jogo == true)
        {
            Console.WriteLine($"Você adentra na masmorra, Você vê um caminho escuro a sua frente e uma loja de items a esquerda, pra onde deseja ir? 1 - ir para frente, 2- ir para a loja");
            int EscolhaCaminho = int.Parse(Console.ReadLine());

        }
    }
}