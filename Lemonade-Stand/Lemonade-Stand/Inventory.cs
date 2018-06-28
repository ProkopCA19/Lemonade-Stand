using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Inventory
    {
        int cups=0;
        public int Cups{ get { return cups; }  set { cups = value; } }
        int lemons=0;
        public int Lemons { get { return lemons; } set { lemons = value; } }
        int sugar=0;
        public int Sugar { get { return sugar; } set { sugar = value; } }
        int icecubes=0;
        public int IceCubes { get { return icecubes; } set { icecubes = value; } }



        public Inventory()
        {
            
        }



        public void DisplayInventory()
        {
            Console.WriteLine("You now have " + Lemons + " lemons in your inventory");
            Console.WriteLine("You now have " + Sugar + " cups of sugar in your inventory");
            Console.WriteLine("You now have " + IceCubes + " icecubes in your inventory");
            Console.WriteLine("You now have " + Cups + " cups in your inventory");

        }

        
    }
}
