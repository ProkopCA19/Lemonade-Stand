using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Day
    {
        List<Customer> customerList;
        public Weather weather;
        public Customer customer;
        double dailySales;
        int potentialCustomers;
        Random rnd = new Random();




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


        public void SetCustomersThatPurchase(Recipe recipe, Inventory inventory)
        {
            if (customer.customerDemand > 80 && customer.customerCash > recipe.PricePerCup)
            {
                customer.CustomersThatBuy = rnd.Next(customerList.Count - 10, customerList.Count);


            }
            else if (customer.customerDemand < 80 && customer.customerDemand > 60 && customer.customerCash > recipe.PricePerCup)
            {
                customer.CustomersThatBuy = rnd.Next(customerList.Count - 15, customerList.Count);


            }
            else if (customer.customerDemand < 60 && customer.customerDemand > 40 && customer.customerCash > recipe.PricePerCup)
            {
               customer.CustomersThatBuy = rnd.Next(customerList.Count - 20, customerList.Count);


            }
            else if (customer.customerDemand < 40 && customer.customerCash > recipe.PricePerCup)
            {
                customer.CustomersThatBuy = rnd.Next(customerList.Count - 25, customerList.Count);


            }
        }


        public double CalculateDailySales(Recipe recipe)
        {
            dailySales = recipe.PricePerCup * recipe.CupsSold;
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


        public void GetTotalNumberofCupsSold(Player player, Customer customer)
        {
            player.recipe.CupsSold = customer.CustomersThatBuy;
        }



        public void AdjustInventory(Player player)
        {

            player.inventory.Cups -= player.recipe.CupsSold;
            player.inventory.Sugar -= player.recipe.TotalSugarUsed;
            player.inventory.Lemons -= player.recipe.TotalLemonsUsed;
            player.inventory.IceCubes -= player.recipe.IceUsed;

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





    }
}
