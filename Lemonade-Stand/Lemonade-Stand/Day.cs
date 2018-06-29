using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Day
    {
        //Weather weather = new Weather();
        //Customer customer = new Customer();
        List<Customer> customerList;
        public Weather weather;
        public Customer customer;
        double dailySales;
        int potentialCustomers;




        public Day()
        {
            weather = new Weather();
            customer = new Customer();
        }


        public void DisplayPredictedWeather()
        {
            weather.DisplayPredictedWeather();
        }
        public void SetDailyWeather()
        {
            weather.GetActualTemperature();
            weather.GetActualDailyConditions();
        }



        public void SetCustomerInformation(Player player)

        {
            SetDailyWeather();
            weather.DisplayActualWeather();
            AddCustomers(weather);
            customer.SetCustomerCash();
            customer.SetDemandByPrice(player.recipe);
            customer.SetDamandByConditions(weather);
            customer.SetDemandByRecipe(player.recipe);
            customer.SetCustomersThatPurchase(player.recipe, player.inventory);
            /////////////////////////////////////////////////////////////
            player.recipe.GetTotalLemonsUsedForTheDay();
            player.recipe.GetTotalSugarUsedForTheDay();
            //
            AdjustInventory(player, customer);
            CalculateDailySales(player.recipe);
            DisplayDailySales();
            CalculateDailyBalance(player);
            DisplayPlayerBalance(player);
            Console.WriteLine("");
            Console.WriteLine("");
        }


        public List<Customer> AddCustomers(Weather weather)
        {
            potentialCustomers = weather.ActualDailyTemperature / 2;
            customerList = new List<Customer>();
            for (int i = 0; i < potentialCustomers; i++)
            {
                Customer newCustomer = new Customer();
                newCustomer.SetCustomerCash();
                customerList.Add(newCustomer);

            }
            return customerList;
        }


        public double CalculateDailySales(Recipe recipe)
        {
            dailySales = recipe.PricePerCup * recipe.CupsUsed;
            return dailySales;
        }

        public void DisplayDailySales()
        {
            Console.WriteLine("You made $" + dailySales + " today");
        }

        public void CalculateDailyBalance(Player player)
        {
            player.Balance += dailySales;

        }

        public void DisplayPlayerBalance(Player player)
        {
            player.DisplayBalance();
        }




        int numOfTotalDays = 7;
        public int NumberOfTotalDays
        {
            get
            {
                return numOfTotalDays;
            }
            set
            {
                numOfTotalDays = value;
            }
        }


        public void AdjustInventory(Player player, Customer customer)
        {
            player.recipe.CupsUsed = customer.CustomersThatBuy;

            player.inventory.Cups -= player.recipe.CupsUsed;
            player.inventory.Sugar -= player.recipe.TotalSugarUsed;
            player.inventory.Lemons -= player.recipe.TotalLemonsUsed;
            player.inventory.IceCubes -= player.recipe.IceUsed;

        }





    }
}
