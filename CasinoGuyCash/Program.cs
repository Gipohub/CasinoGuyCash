// See https://aka.ms/new-console-template for more information
using CasinoGuyCash;
using static Guy;

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Name Player:");
string? player = Console.ReadLine().ToString().Capitalize();

Random random = new Random(DateTime.Now.Millisecond);
    
    for (bool a = false; a == false;)
    {
    string coconut = ""; 
    
        for (; coconut == ""; coconut = Console.ReadLine())
        {
            Console.Write("How much money ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(player);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" have?: ");
        }
    if (coconut.Length > 7) coconut = coconut.Remove(8);

    if (int.TryParse(coconut, out int cash))
    {
        Guy Player = new() { Cash = cash, Name = player };

        Console.Write("Hello ");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write(Player.Name);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(", your cash count is ");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write( Player.Cash); 
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(", okay");
        
        
        for (bool b = false; b == false;)
        {
            Console.WriteLine("Enter your odds (at 1 is easy - to 9 is hard):");
            string? odds = Console.ReadLine();

            if (int.TryParse(odds, out int easyHard))
            {

                if (easyHard >= 1 && easyHard <= 9)
                {
                    Console.WriteLine("Your odds is: " + easyHard);
                    double dealOdds = easyHard / 10.0;

                    for (bool c = false; c == false;)
                    {
                        Console.Write("Your cash count is: ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(Player.Cash);
                        Console.ForegroundColor = ConsoleColor.Green;

                        if (Player.Cash <= 0)
                        {
                            Console.Write("Casino ");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("win");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(", congratulations!");

                            return;
                        };
                        Console.Write("How much do you give the cash (or a nothing to exit and 'c' to change odds) : ");
                        string deal = Console.ReadLine();

                        
                        if (deal == "") return;
                        if (deal == null) return;
                        if (deal.Length > 7) deal = deal.Remove(8);

                        if (int.TryParse(deal, out int dealCash) && dealCash >= 0)
                        {

                            if (dealCash > Player.Cash)
                            {
                                Console.Write("YourMaxCount is: ");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write(Player.Cash);
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.Write(", and you deal it");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine(" , it's (f)all in");
                                dealCash = Player.Cash;
                            }

                            double rndmOdds = random.NextDouble();
                            rndmOdds = Math.Round(rndmOdds, 1);
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(Player.Name);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(" Value chance " + dealOdds);
                            Console.WriteLine("Casino random chance " + rndmOdds);

                            if (dealOdds <= rndmOdds)
                            {

                                //double luck = 1.0 - dealOdds;

                                //int win = Convert.ToInt32(luck);
                                Player.Cash += dealCash * easyHard / 10;
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.WriteLine("You Win!");
                                Console.ForegroundColor = ConsoleColor.Green;
                            }
                            else
                            {
                                Player.Cash -= dealCash;
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("You Lose!");
                                Console.ForegroundColor = ConsoleColor.Green;


                            }
                        }


                        else if (deal == "c") { c = true; }

                        else
                        {

                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.Write("Nan,");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(" give me true natural number pls");
                            Console.ForegroundColor = ConsoleColor.Green;


                        }
                        // c = true;
                    }


                }
                else if (easyHard <= 0)
                {
                    Console.WriteLine("So easy");
                }
                else
                {
                    Console.WriteLine("So hardly");
                }
            }
            else
            {
                Console.WriteLine("char not num");

            }
            //b = true;
        }
        
        
    }
        else
        {
            Console.WriteLine("Please enter any number.");
        }
   // a = true;
    }

    
