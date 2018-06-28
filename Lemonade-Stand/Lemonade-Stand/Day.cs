using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Day
    {
        Weather weather = new Weather();
        Customer customer = new Customer();
        double dailySales;
       // List<Customer> customers = new List<Customer>();

     


        public void DisplayPredictedWeather()
        {
            weather.DisplayPredictedWeather();
        }
        public void SetDailyWeather()
        {
            weather.GetActualTemperature();
            weather.GetActualDailyConditions();
        }

        //public List<Customer> AddCustomers(Weather weather)
        //{
        //    potentialCustomers = weather.ActualDailyTemperature / 2;
        //    for (int i = 0; i < potentialCustomers; i++)
        //    {
        //        Customer newCustomer = new Customer();
        //        customer.Add(newCustomer);
        //        newCustomer.SetCustomerCash();
        //    }
        //    return customer;
        //}









        public void GetCustomerInformation()

        {
         
            customer.AddCustomers(weather); 
            customer.SetCustomerCash();
            customer.HasDemandByPrice();
            customer.HasDamandByConditions();
            customer.HasDemandByRecipe();
            customer.GetCustomersThatPurchase();
        }


        public double CalculateDailySales(Recipe recipe) //move to day class
        {
            dailySales = recipe.PricePerCup * recipe.CupsUsed;
            return dailySales;
        }

        public void DisplayDailySales()
        {
            Console.WriteLine("You made $" + dailySales + " today"); //move to day class
        }

        public void CalculateDailyBalance(Player player) //move to day class 
        {
            player.Balance += dailySales;

        }


    }
}
