using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Player
    {
        //string playerName;
        double balance = 20.00;
        public Recipe recipe;
        public Inventory inventory;

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


        //Constructor
        public Player()
        {
            inventory = new Inventory();
            recipe = new Recipe();
        }


        public void DisplayBalance()
        {
            Console.WriteLine("Your balance is $" + balance);
        }


       public void DecidesHowMuchSugarToBuy()
        {
            Console.WriteLine("How many cups of sugar would you like to buy?");
            Console.WriteLine("If you want to purchase 10 cups for 1.00 press 1, if you want to purchase 20 cups for 1.50 press 2, if you want to purcase 50 cups for 2.50 press 3, if you dont want to purchase any cups of sugar press 4");
            
           switch(Console.ReadLine())
            {
                case "1":
                    inventory.Sugar += 10;
                    balance -= 1.00;
                    break;
                case "2":
                    inventory.Sugar += 20;
                    balance -= 1.50;
                    break;
                case "3":
                    inventory.Sugar += 50;
                    balance -= 2.50;
                    break;
                case "4":
                    inventory.Sugar += 0;
                    balance -= 0;
                    break;
                default:
                    Console.WriteLine("Not a valid option, try again");
                    DecidesHowMuchSugarToBuy();
                    break;

            }
        }

        public void DecidesHowManyLemonsToBuy()
        {
            Console.WriteLine("How many lemons would you like to buy?");
            Console.WriteLine("If you want to purchase 10 lemons for 2.00 press 1, if you want to purchase 20 lemons for 2.50 press 2, if you want to purcase 50 lemons for 4.00 press 3, if you dont want to purchase any lemons press 4");

            switch (Console.ReadLine())
            {
                case "1":
                    inventory.Lemons += 10;
                    balance -= 2.00;
                    break;
                case "2":
                    inventory.Lemons += 20;
                    balance -= 2.50;
                    break;
                case "3":
                    inventory.Lemons += 50;
                    balance -= 4.00;
                    break;
                case "4":
                    inventory.Lemons += 0;
                    balance -= 0;
                    break;
                default:
                    Console.WriteLine("Not a valid option, try again");
                    DecidesHowManyLemonsToBuy();
                    break;

            }
        }

        public void DecidesHowManyCupsToBuy()
        {
            Console.WriteLine("How many cups would you like to buy?");
            Console.WriteLine("If you want to purchase 50 cups for 3.00 press 1, if you want to purchase 100 cups for 4.50 press 2, if you want to purcase 150 cups for 5.00 press 3, if you dont want to purchase any cups press 4");

            switch (Console.ReadLine())
            {
                case "1":
                    inventory.Cups += 50;
                    balance -= 3.00;
                    break;
                case "2":
                    inventory.Cups += 100;
                    balance -= 4.50;
                    break;
                case "3":
                    inventory.Cups += 150;
                    balance -= 5.00;
                    break;
                case "4":
                    inventory.Cups += 0;
                    balance -= 0;
                    break;
                default:
                    Console.WriteLine("Not a valid option, try again");
                    DecidesHowManyCupsToBuy();
                    break;

            }
        }

        public void DecidesHowMuchIceToBuy()
        {
            Console.WriteLine("How much ice would you like to buy?");
            Console.WriteLine("If you want to purchase 100 cubes for 2.00 press 1, if you want to purchase 200 cubes for 3.00 press 2, if you want to purcase 300 cubes for 4.00 press 3, if you dont want to purchase any icecubes press 4");

            switch (Console.ReadLine())
            {
                case "1":
                    inventory.IceCubes += 100;
                    balance -= 2.00;
                    break;
                case "2":
                    inventory.IceCubes += 200;
                    balance -= 3.00;
                    break;
                case "3":
                    inventory.IceCubes += 300;
                    balance -= 4.00;
                    break;
                case "4":
                    inventory.IceCubes += 0;
                    balance -= 0;
                    break;
                default:
                    Console.WriteLine("Not a valid option, try again");
                    DecidesHowMuchIceToBuy();
                    break;

            }
        }










        public void DecideHowManyLemonsPerPitcher()
        {
            Console.WriteLine("How many lemons would you like to use in a pitcher?");

            try
            {

                recipe.LemonsUsed += Int32.Parse(Console.ReadLine());
                inventory.Lemons -= recipe.LemonsUsed;
                
            }
            catch
            {
                Console.WriteLine("Not a valid number, try again!");
                 DecideHowManyLemonsPerPitcher();
            }
        }

        public void DecideHowMuchSugarPerPitcher()
        {
            Console.WriteLine("How many cups of sugar would you like to use in a pitcher?");
            try
            {

                recipe.SugarUsed += Int32.Parse(Console.ReadLine());
                inventory.Sugar -= recipe.SugarUsed;
                
            }
            catch
            {
                Console.WriteLine("Not a valid number, try again!");
                DecideHowMuchSugarPerPitcher();
            }
        }

        public void DecideIcePerCup()
        {
            Console.WriteLine("How many icecubes would you like to use per cup?");
            try
            {
                recipe.IceUsed += Int32.Parse(Console.ReadLine());
                inventory.IceCubes -= recipe.IceUsed;
                
            }
            catch
            {
                Console.WriteLine("Not a valid number, try again!");
                DecideIcePerCup();
            }
        }

        public double DecidePricePerCup()
        {
            Console.WriteLine("How much would you like to charge for one cup?");
            try
            {
                recipe.PricePerCup = Double.Parse(Console.ReadLine());
                return recipe.PricePerCup;
            }
            catch
            {
                Console.WriteLine("Not a valid number, try again!");
                return DecidePricePerCup();
            }
            
            
        }
    }
}
