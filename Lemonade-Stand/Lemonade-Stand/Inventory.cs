using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Inventory
    {
        int cups;
        int lemons;
        int sugar;
        int icecubes;


        public int Cups
        {
            get
            {
                return cups;
            }
            set
            {
                cups = value;
            }
        }

        public int Lemons
        {
            get
            {
                return lemons;
            }
            set
            {
                lemons = value;
            }
        }

        public int Sugar
        {
            get
            {
                return sugar;
            }
            set
            {
                sugar = value;
            }
        }

        public int IceCubes
        {
            get
            {
                return icecubes;
            }
            set
            {
                icecubes = value;
            }
        }


        public void DisplayInventory()
        {
            Console.WriteLine("You have " + Lemons + "lemons in your inventory");
            Console.WriteLine("You have " + Sugar + "cups of sugar in your inventory");
            Console.WriteLine("You have " + IceCubes + "icecubes in your inventory");
            Console.WriteLine("You have " + Cups + "cups in your inventory");

        }

        //totalCups = purchasedCups - recipe1.cupsUsed;
    }
}
