namespace Projekt;
using System;
using System.ComponentModel;
using System.Threading;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        Logo();
        Menu();

        Console.ReadKey();


    }

    static void Logo()
    {
        Cconsole.Clear();
        Console.WriteLine("                                                                                        __");
        Console.WriteLine("                                                                                       /_/");
        Console.WriteLine(" ______	   __         ______    ____   __           __         ______    ________    ______    __            __");
        Console.WriteLine("|   _  \\  |  |	     /	__  \\  |    \\ |  |         |  |       /  __  \\  |__    __|  /  __  \\  |  |    __    |  |");
        Console.WriteLine("|  |_|  | |  |      |  |  |  | |  |  \\|  |	   |  |      |  |  |  |    |  |    |  |  |  |  \\  \\  /  \\  /  / ");
        Console.WriteLine("|   ___/  |  |      |  |__|  | |  |\\  \\  |         |  |      |  |__|  |    |  |    |  |__|  |   \\  \\/    \\/  /");
        Console.WriteLine("|  |      |  |____  |   __   | |  | \\    |         |  |____  |        |    |  |    |        |    \\    /\\    /");
        Console.WriteLine("|__|	  |_______| |__|  |__| |__|  \\___|  	   |_______|  \\______/     |__|     \\______/      \\__/  \\__/");

        Thread.Sleep(4000);

    }
    static void Menu()
    {

        string menuStart = "";
        int x,menuStartInt;
        Console.Clear();
        Console.WriteLine("<------------MENU------------>");
        Console.WriteLine("\t1.  Zaloguj");
        Console.WriteLine("\t2.  Utwórz konto");
        Console.WriteLine("<---------------------------->");
        Console.WriteLine(menuStart);
        Console.Write("-> ");
        menuStart = Console.ReadLine();
        while (true)
        {
            if (Int32.TryParse(menuStart, out x))
            {
                menuStartInt = Convert.ToInt32(menuStart);
                if (menuStartInt == 1 || menuStartInt == 2)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("W menu nie ma takiej wartości, spróbuj ponownie.");
                }
            }
            else
            {
                Console.WriteLine("W menu nie ma takiej wartości, spróbuj ponownie.");
            }
            Console.Write("-> ");
            menuStart = Console.ReadLine();
        }
        Console.WriteLine("zalogowano");
        Console.WriteLine("Działa");
    }
}
