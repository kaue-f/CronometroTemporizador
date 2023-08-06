namespace CronometroTemporizador;

class Program
{
    static void Main(string[] args)
    {
        Menu();
    }

    public static void Menu()
    {
        Console.Clear();
        Console.WriteLine("1 - Cronômetro");
        Console.WriteLine("2 - Temporizador");
        Console.WriteLine("0 - Sair");
        Console.WriteLine("----------------------");
        Console.WriteLine("Selecione uma opção");

        var opcao = Console.ReadLine().ToLower();

        switch (opcao)
        {
            case "1": Cronometro.Menu(); break;
            case "2": Temporizador.Menu(); break;
            default: System.Environment.Exit(0); break;
        }
    }
}

