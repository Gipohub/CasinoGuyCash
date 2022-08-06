// See https://aka.ms/new-console-template for more information
using static Guy;

Console.WriteLine("Name Player:");
string player = Console.ReadLine().ToString();
Console.WriteLine("Count " + player + ":");
string coconut = Console.ReadLine();
Random random = new Random();
double rndmOdds = random.NextDouble();

    if (coconut == "") return;

    for (bool a = false; a == false;)
    {
        if (int.TryParse(coconut, out int amount))
        {
            Guy Player = new() { Cash = amount, Name = player };
            
            Console.WriteLine(rndmOdds);
            
            
            Console.WriteLine("Hello " + Player.Name + ", your cash count is " + Player.Cash);
        Console.WriteLine("your odds (0.1 - 0.9):");
        string odds = Console.ReadLine();
        for (bool b = false; b == false;)
            if (!double.TryParse(odds, out double result))
            {
            Console.WriteLine("NaD");
            }
        else
        {

        }
            Console.Write("How much do you give the cash: ");
        Console.Write();


        string whichGuy;
            Guy who, count;
        
        a = true;
        }
        else
        {
            Console.WriteLine("Please enter an amount (or a nofing to exit).");
            string nChar = Console.ReadLine();
            if (nChar == "") return;
        }
    }

    
