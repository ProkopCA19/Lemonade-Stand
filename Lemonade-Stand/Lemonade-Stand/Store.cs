using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Store
    {   Recipe recipe = new Recipe();
        Inventory inventory = new Inventory();
        Customer customer = new Customer();
        Player player = new Player();
        double dailySales;


        public void Displnventory()
        {
            inventory.DisplayInventory();
        }

        public double CalculateDailySales()
        {
            dailySales = recipe.PricePerCup * recipe.CupsUsed;
            return dailySales;
        }

        public void CalculateDailyBalance()
        {
            player.Balance += dailySales;

        }

    }
}
