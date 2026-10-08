using System.Collections;
using System.Diagnostics;
using System.IO.Compression;
using System.Reflection.Metadata;
using System.Security;
using System.Security.AccessControl;
using System.Security.Cryptography;
using Microsoft.VisualBasic;
class Program
{
    static void Main()
    {
        Console.WriteLine("Tryck på valfri knapp för att starta");
       
        Console.ReadKey(intercept: true);
        Thread.Sleep(1000);
        Console.WriteLine("Välkommen till CastTheDice");

        Console.WriteLine("Vad är ditt namn kära spelare");

        var Name = Console.ReadLine();

        Console.WriteLine($"Välkommen {Name} till CastTheDice");

        Console.WriteLine("Spelet fungerar så här helt enkelt, du ska kasta 2 tärningarna");

        Console.WriteLine("Om summan av tärningarna är 12");

        Console.WriteLine("Så vinner du");

        Console.WriteLine("Lyckas du inte få siffran så får du försöka igen");

        Console.WriteLine("Har du förtått instuktionerna?");

        var Answer = Console.ReadLine() ?? "";

        Answer = Answer.ToLower();

        if (Answer == "ja")
        {
            Console.WriteLine($"Bra, lycka till {Name}");
        }
        else if (Answer == "nej")
        {
            Console.WriteLine("Två tärningar ska bli 12, du löser det kompis");
        }
        else
        {
            Console.WriteLine("Fel kommando, förstår du reglerna");


            var Answer2 = Console.ReadLine() ?? "";

            Answer2 = Answer2.ToLower();

            if (Answer2 == "ja")
            {
                Console.WriteLine("Underbart Lycka till");
            }
            else if (Answer2 == "nej")
            {
                Console.WriteLine("Två tärningar ska bli 12, du löser det kompis");
            }

        }
        Console.WriteLine("Tryck på valfri knapp för att börja spelet");
        Console.ReadKey(intercept: true);

        Random random = new Random();

        random.Next(1, 7);

        while (true)
        {
            Console.Clear();
            int Dice1 = random.Next(1, 7);

            int Dice2 = random.Next(1, 7);

            int TotalSum = Dice1 + Dice2;

            Console.WriteLine(TotalSum);

            if (TotalSum == 12)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Grattis du har vunnit");
                Console.WriteLine("Vill du spela igen eller är du nöjd");
                Console.WriteLine("Tryck enter eller nej");
                Console.ResetColor();

                 var quit = Console.ReadLine();
                 if(quit == "nej")
                 return;
                else if(quit == "")
                {
                    Console.WriteLine("Bra spelat");
                    continue;
                }
                
                
                  

                
                
            }

            
            
            else
            {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Inte riktigt du fick {TotalSum}");
            Console.WriteLine("Vill du kasta igen och jaga 12? Tryck enter eller skriv Nej");
            Console.ResetColor();
            }
            
            while (true)
            {
                
                var Type = Console.ReadLine() ?? "";
                Type = Type.ToLower();


                if (Type == "nej")
                    return;

                else if (Type == "")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Jag försår inte, Vill du kasta igen tryck enter skriv eller Nej");
                }
            }



        }

    }
}
