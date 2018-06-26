using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Store
    {
        Inventory inventory = new Inventory();
        double dailySales;
        double cupsSold;


        public void DisplayInventory()
        {
            inventory.DisplayInventory();
        }
    }
}
