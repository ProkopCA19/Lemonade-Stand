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
        double startingAllowance;
        int purchasedCups;
        int purchasedLemons;
        int purchasedSugar;
        int purchasedIce;
        Recipe recipe1 = new Recipe();










        int DecidesHowManyCupsToBuy()
        {
            Console.WriteLine("How many cups would you like to buy?");
            purchasedCups = Int32.Parse(Console.ReadLine());
            return purchasedCups;
        }

        int DecidesHowManyLemonsToBuy()
        {
            Console.WriteLine("How many lemons would you like to buy?");
            purchasedLemons = Int32.Parse(Console.ReadLine());
            return purchasedLemons;
        }

        int DecidesHowMuchSugarToBuy()
        {
            Console.WriteLine("How many cups of sugar would you like to buy?");
            purchasedSugar = Int32.Parse(Console.ReadLine());
            return purchasedSugar;
        }

        int DecidesHowMuchIceToBuy()
        {
            Console.WriteLine("How much ice would you like to buy?");
            purchasedIce = Int32.Parse(Console.ReadLine());
            return purchasedIce;
        }





        double DecidesPricePerCup()
        {
            Console.WriteLine("What would you like your price per cup to be?");


        }


        int DecideHowManyLemonsPerPitcher()
        {
            Console.WriteLine("How many lemons would you like to use?");
            recipe1.lemonsUsed += Int32.Parse(Console.ReadLine());
            return recipe1.lemonsUsed;
        }

        int DecideHowMuchSugarPerPitcher()
        {
            Console.WriteLine("How many cups of sugar would you like to use?");
            recipe1.sugarUsed += Int32.Parse(Console.ReadLine());
            return recipe1.sugarUsed;
        }

        int DecideIcePerCup()
        {
            Console.WriteLine("How many icecubes would you like to use?");
            recipe1.iceUsed += Int32.Parse(Console.ReadLine());
            return recipe1.iceUsed;
        }
    }
}
