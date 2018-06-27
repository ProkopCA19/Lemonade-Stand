using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Player
    {
        string playerName;
        double balance = 20.00;
        Recipe recipe1 = new Recipe();
        Inventory inventory1 = new Inventory();

        public double Balance
        {
            get
            {
                return balance;
            }
            set
            {
                balance = value;
            }
        }




        void DecidesHowMuchSugarToBuy()
        {
            Console.WriteLine("How many cups of sugar would you like to buy?");
            Console.WriteLine("If you want to purchase 10 cups for 1.00 press 1, if you want to purchase 20 cups for 1.50 press 2, if you want to purcase 50 cups for 2.50 press 3");
            
           switch(Console.ReadLine())
            {
                case "1":
                    inventory1.Sugar += 10;
                    balance -= 1.00;
                    break;
                case "2":
                    inventory1.Sugar += 20;
                    balance -= 1.50;
                    break;
                case "3":
                    inventory1.Sugar += 50;
                    balance -= 2.50;
                    break;
                default:
                    Console.WriteLine("Not a valid option, try again");
                    DecidesHowMuchSugarToBuy();
                    break;

            }
        }

        void DecidesHowManyLemonsToBuy()
        {
            Console.WriteLine("How many lemons would you like to buy?");
            Console.WriteLine("If you want to purchase 10 lemons for 2.00 press 1, if you want to purchase 20 lemons for 2.50 press 2, if you want to purcase 50 lemons for 4.00 press 3");

            switch (Console.ReadLine())
            {
                case "1":
                    inventory1.Lemons += 10;
                    balance -= 2.00;
                    break;
                case "2":
                    inventory1.Lemons += 20;
                    balance -= 2.50;
                    break;
                case "3":
                    inventory1.Sugar += 50;
                    balance -= 4.00;
                    break;
                default:
                    Console.WriteLine("Not a valid option, try again");
                    DecidesHowManyLemonsToBuy();
                    break;

            }
        }

        void DecidesHowManyCupsToBuy()
        {
            Console.WriteLine("How many cups would you like to buy?");
            Console.WriteLine("If you want to purchase 50 cups for 3.00 press 1, if you want to purchase 100 cups for 4.50 press 2, if you want to purcase 150 cups for 5.00 press 3");

            switch (Console.ReadLine())
            {
                case "1":
                    inventory1.Cups += 50;
                    balance -= 3.00;
                    break;
                case "2":
                    inventory1.Cups += 100;
                    balance -= 4.50;
                    break;
                case "3":
                    inventory1.Cups += 150;
                    balance -= 5.00;
                    break;
                default:
                    Console.WriteLine("Not a valid option, try again");
                    DecidesHowManyCupsToBuy();
                    break;

            }
        }

        void DecidesHowMuchIceToBuy()
        {
            Console.WriteLine("How much ice would you like to buy?");
            Console.WriteLine("If you want to purchase 100 cubes for 2.00 press 1, if you want to purchase 200 cubes for 3.00 press 2, if you want to purcase 300 cubes for 4.00 press 3");

            switch (Console.ReadLine())
            {
                case "1":
                    inventory1.IceCubes += 100;
                    balance -= 2.00;
                    break;
                case "2":
                    inventory1.IceCubes += 200;
                    balance -= 3.00;
                    break;
                case "3":
                    inventory1.IceCubes += 300;
                    balance -= 4.00;
                    break;
                default:
                    Console.WriteLine("Not a valid option, try again");
                    DecidesHowMuchIceToBuy();
                    break;

            }
        }










        int DecideHowManyLemonsPerPitcher()
        {
            Console.WriteLine("How many lemons would you like to use in a pitcher? Enter a number between 1 and 100");

            if (Int32.Parse(Console.ReadLine()) <= 100 && Int32.Parse(Console.ReadLine()) > 0)
            {

                recipe1.LemonsUsed += Int32.Parse(Console.ReadLine());
                inventory1.Lemons -= recipe1.LemonsUsed;
                return recipe1.LemonsUsed;
            }
            else
            {
                return DecideHowManyLemonsPerPitcher();
            }
        }

        int DecideHowMuchSugarPerPitcher()
        {
            Console.WriteLine("How many cups of sugar would you like to use in a pitcher? Enter a number between 1 and 100");
            if (Int32.Parse(Console.ReadLine()) <= 100 && Int32.Parse(Console.ReadLine()) > 0)
            {

                recipe1.SugarUsed += Int32.Parse(Console.ReadLine());
                inventory1.Sugar -= recipe1.SugarUsed;
                return recipe1.SugarUsed;
            }
            else
            {
                return DecideHowMuchSugarPerPitcher();
            }
        }

        int DecideIcePerCup()
        {
            Console.WriteLine("How many icecubes would you like to use per cup? Enter a number between 1 and 100");
            if (Int32.Parse(Console.ReadLine()) <= 100 && Int32.Parse(Console.ReadLine()) > 0)
            {
                recipe1.IceUsed += Int32.Parse(Console.ReadLine());
                inventory1.IceCubes -= recipe1.IceUsed;
                return recipe1.IceUsed;
            }
            else
            {
                return DecideIcePerCup();
            }
        }

        double DecidePricePerCup()
        {
            Console.WriteLine("How much would you like to charge for one cup? Set a price under $3.00");
            if (Double.Parse(Console.ReadLine()) < 3.00)
            {
                recipe1.PricePerCup = Double.Parse(Console.ReadLine());
                return recipe1.PricePerCup;
            }
            else
            {
                return DecidePricePerCup();
            }
            
            
        }
    }
}
