using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Game
    {
        Day day = new Day();
        public Player player = new Player();
        //Customer customer = new Customer();
        int i = 0;

      

        public void RunGame()
        {

            Console.WriteLine("Welcome to lemonade stand!");
            Console.WriteLine("Try to make as much money as you can in 7 days by selling lemonade at your lemonade stand.");
            Console.WriteLine("First you have to buy your cups, lemons, sugar, and ice cubes, then create your recipe based on the weather and conditions.");
            Console.WriteLine("You can try to change the recipe and your prices to see if you can do better sales from day to day.");
            Console.WriteLine("At the end of the game, you'll see how much money you made.");
            Console.WriteLine("");
            Console.WriteLine("");


            while (i < day.NumberOfTotalDays)
            {
                Console.WriteLine("Its a new day!");
                day.DisplayPredictedWeather();
                Console.WriteLine("");
                player.inventory.DisplayInventory();
                Console.WriteLine("");
                player.DisplayBalance();
                Console.WriteLine("");
                player.DecidesHowManyCupsToBuy();
                player.DecidesHowManyLemonsToBuy();
                player.DecidesHowMuchSugarToBuy();
                player.DecidesHowMuchIceToBuy();
                player.inventory.DisplayInventory();
                Console.WriteLine("");
                Console.WriteLine("Now its time to make your recipe!");
                Console.WriteLine("");
                player.DecideHowManyLemonsPerPitcher();
                Console.WriteLine("");
                player.DecideHowMuchSugarPerPitcher();
                Console.WriteLine("");
                player.DecideIcePerCup();
                Console.WriteLine("");
                player.DecidePricePerCup();
                Console.WriteLine("");
                player.inventory.DisplayInventory();
                Console.WriteLine("");
                Console.WriteLine("Now its time to open the stand!");
                Console.WriteLine("");
                player.recipe.GetSugarPerCup();
                player.recipe.GetLemonsPerCup();

                day.SetCustomerInformation(player);

                i++;
            }

            Console.WriteLine("You finshed! Your ending balance is $" + player.Balance);
            Console.ReadLine();
        }
        
    }
}
