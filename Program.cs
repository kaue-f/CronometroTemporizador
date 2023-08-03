namespace Cronometro;

class Program
{
    static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("S = Segundo => 10s = 10 segundos");
        Console.WriteLine("M = Minuto => 1m = 1 minuto");
        Console.WriteLine("H = Hora => 1h = 1 hora");
        Console.WriteLine("0 = Sair");
        Console.WriteLine("----------------------");
        Console.WriteLine("Quanto tempo deseja contar?");

        string data = Console.ReadLine().ToLower();
        char type = char.Parse(data.Substring(data.Length - 1, 1)); //Pegar o ultimo digito
        int time = int.Parse(data.Substring(0, data.Length - 1)); //Pegar os digito do time

        int multiplicador = 1;

        // Multiplica m por s
        if (type == 'm')
            multiplicador = 60;

        // Multiplica h por s
        if (type == 'h')
            multiplicador = 3600;

        if (time == 0)
            System.Environment.Exit(0);

        PreStart(time * multiplicador);
    }

    static void PreStart(int time)
    {
        Console.Clear();
        Console.WriteLine("Ready...");
        Thread.Sleep(1000);
        Console.WriteLine("Set...");
        Thread.Sleep(1000);
        Console.WriteLine("Go...");
        Thread.Sleep(2500);

        Start(time);
    }

    static void Start(int time)
    {
        int currentTime = 0;

        while (currentTime != time)
        {
            Console.Clear();
            currentTime++;
            Console.WriteLine(currentTime);
            Thread.Sleep(1000);
        }

        Console.Clear();
        Console.WriteLine("Cronômetro Finalizado");
        Thread.Sleep(5000);
        Menu();
    }
}

