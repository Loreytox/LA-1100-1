Random random = new();
string eingabe;

do
{
    int zahl = random.Next(1, 100);
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("Geben Sie bitte eine Zahl zwischen 1 und 100: ");
    int versuch = Convert.ToInt32(Console.ReadLine());
    
    while (versuch != zahl)
    {
        if (versuch == zahl)
        {
            Console.WriteLine(":::::::::::::::::::::::::::::::::");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Nice.");
        }
        if (versuch > 100)
        {
            Console.WriteLine(":::::::::::::::::::::::::::::::::");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Nur Zahlen zwischen 1 und 100!");
        }
        if (versuch < 0)
        {
            Console.WriteLine(":::::::::::::::::::::::::::::::::");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Nur Zahlen über 0!");
        }
        if (versuch < zahl)
        {
            Console.WriteLine(":::::::::::::::::::::::::::::::::");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Falsch! Die gesuchte Zahl ist grösser als " + versuch + ".");
        }
        if (versuch > zahl)
        {
            Console.WriteLine(":::::::::::::::::::::::::::::::::");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Falsch! Die gesuchte Zahl ist kleiner als " + versuch + ".");
        }
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Geben Sie bitte eine andere zahl als {0}:", versuch);
        versuch = Convert.ToInt32(Console.ReadLine());       
    }
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Die gesuchte Zahl war tatsächlich " + versuch + "!");
    versuch = 0;
    Console.Write("Möchten Sie weiterspielen? [ja|nein] ");
    eingabe = Console.ReadLine();

} while (eingabe == "ja");
