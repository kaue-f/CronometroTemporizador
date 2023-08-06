namespace CronometroTemporizador
{
    public class Cronometro
    {
        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = Segundo => 10s = 10 segundos");
            Console.WriteLine("M = Minuto => 1m = 1 minuto");
            Console.WriteLine("H = Hora => 1h = 1 hora");
            Console.WriteLine("0 = Voltar");

            Console.WriteLine("Quanto tempo deseja contar?");

            string data = Console.ReadLine().ToLower();

            if (data == "0")
                data = "0s";

            char type = char.Parse(data.Substring(data.Length - 1, 1)); //Pegar o ultimo digito
            int time = int.Parse(data.Substring(0, data.Length - 1)); //Pegar os digito do time

            int multiplicador;

            switch (type)
            {
                case 's': multiplicador = 1; PreStart(time * multiplicador); break;
                case 'm': multiplicador = 60; PreStart(time * multiplicador); break;
                case 'h': multiplicador = 3600; PreStart(time * multiplicador); break;
                default: Program.Menu(); break;
            }

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
            Console.Beep();
            Console.WriteLine("Cronômetro Finalizado");
            Thread.Sleep(3000);
            Program.Menu();
        }
    }


}