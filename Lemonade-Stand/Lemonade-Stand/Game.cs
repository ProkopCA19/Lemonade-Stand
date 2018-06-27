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
        Weather weather = new Weather();
        Player player = new Player();
        Customer customer = new Customer();
        Recipe recipe = new Recipe();
        Inventory inventory = new Inventory();
        Store store = new Store();

       public void RunGame()
        {
            Console.WriteLine("Welcome to lemonade stand!");
            Console.WriteLine("");
            weather.DisplayPredictedWeather();
            Console.WriteLine("");
            player.DisplayBalance();
            Console.WriteLine("");
            player.DecidesHowManyCupsToBuy();
            player.DecidesHowManyLemonsToBuy();
            player.DecidesHowMuchSugarToBuy();
            player.DecidesHowMuchIceToBuy();
            inventory.DisplayInventory();
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
            inventory.DisplayInventory();
            Console.ReadLine();
            day.SetDailyWeather();      ////stops working here
            weather.DisplayActualWeather();
            day.GetCustomerInformation();
            customer.DisplayTotalCustomersForTheDay();
            store.CalculateDailySales();
            store.CalculateDailyBalance();
            store.DisplayDailySales();
            store.DisplayDailyBalance();
            

        }


        //display weather conditions
        //buy inventory, subtract money from allowance
        //set recipe, subtract used ingredients from purchased ingredients
        //have customers buy cups of lemonade
        //get total sales
        //get running total
        //buy more inventory
        //reset recipe
    }
}
