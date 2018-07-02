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
                day.SetDailyWeather();
                day.weather.DisplayActualWeather();
                day.AddCustomers(day.weather);
                day.customer.SetCustomerCash();
                day.customer.SetDemandByPrice(player.recipe);
                day.customer.SetDamandByConditions(day.weather);
                day.customer.SetDemandByRecipe(player.recipe);
                day.SetCustomersThatPurchase(player.recipe, player.inventory);
                day.GetTotalNumberofCupsSold(player, day.customer);
                player.recipe.GetTotalLemonsUsedForTheDay();
                player.recipe.GetTotalSugarUsedForTheDay();
                day.AdjustInventory(player);
                day.CalculateDailySales(player.recipe);
                Console.WriteLine("");
                day.DisplayDailySales();
                day.CalculateDailyBalance(player);
                Console.WriteLine("");
                day.DisplayPlayerBalance(player);
                Console.WriteLine("========================================================================");
                Console.WriteLine("");

                i++;
            }

            Console.WriteLine("You finshed! Your ending balance is $" + player.Balance);
            Console.WriteLine("");
            DisplayNetGainOrLoss();



            void DisplayNetGainOrLoss()
            {

                if (player.Balance < 20)
                {
                    Console.WriteLine("Your net loss is $" + (20 - player.Balance));
                }
                else if (player.Balance > 20)
                {
                    Console.WriteLine("Your net gain is $" + (player.Balance - 20));
                }
            }


            Console.ReadLine();
        }
        
    }
}
