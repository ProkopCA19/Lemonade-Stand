using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Inventory
    {
        double cups=0;
        public double Cups{ get { return cups; }  set { cups = value; } }
        double lemons=0;
        public double Lemons { get { return lemons; } set { lemons = value; } }
        double sugar=0;
        public double Sugar { get { return sugar; } set { sugar = value; } }
        double icecubes=0;
        public double IceCubes { get { return icecubes; } set { icecubes = value; } }



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
