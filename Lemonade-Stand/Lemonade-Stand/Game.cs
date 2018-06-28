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
       // Weather weather = new Weather();
        Player player = new Player();
        Customer customer = new Customer();
       // Recipe recipe = new Recipe();
        // Inventory inventory = new Inventory();

        public void RunGame()
        {
            Console.WriteLine("Welcome to lemonade stand!");
            //display predicted weather
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
            player.DisplayBalance();
            Console.ReadLine();
            
            day.SetDailyWeather();
            //make new customer list
            


        }
        
    }
}
