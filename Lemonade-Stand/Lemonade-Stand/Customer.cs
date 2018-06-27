using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Customer
    {
        int customerDemand = 100;
        Recipe recipe = new Recipe();
        Weather weather = new Weather();
        Random rnd = new Random();
        public List<Customer> customer = new List<Customer>();
        int potentialCustomers;
        public double customerCash;
        double customersThatBuy;

        public double CustomersThatBuy
        {
            get
            {
                return customersThatBuy;
            }
            set
            {
                customersThatBuy = value;
            }
        }


        public double SetCustomerCash()
        {
            customerCash = rnd.Next(1, 30) * .10;
            return customerCash;
        }

        public List<Customer> AddCustomers(Weather weather)
        {
            potentialCustomers = weather.ActualDailyTemperature / 2;
            for (int i = 0; i < potentialCustomers; i++)
            {
                Customer newCustomer = new Customer();
                customer.Add(newCustomer);
                newCustomer.SetCustomerCash();
            }
            return customer;
        }


        public void HasDemandByPrice()
        {
            if (recipe.PricePerCup >= 3.00 && recipe.PricePerCup <= 5.00)
            {
                customerDemand -= 20;
            }
            else if (recipe.PricePerCup >= 1.00 && recipe.PricePerCup <= 3.00)
            {
                customerDemand -= 10;
            }
            else if (recipe.PricePerCup >= .75 && recipe.PricePerCup <= 1.00)
            {
                customerDemand -= 5;
            }
            else if (recipe.PricePerCup >= .50 && recipe.PricePerCup <= .75)
            {
                customerDemand -= 3;
            }
            else if (recipe.PricePerCup >= .30 && recipe.PricePerCup <= .50)
            {
                customerDemand -= 2;
            }
            else if (recipe.PricePerCup >= .20 && recipe.PricePerCup <= .30)
            {
                customerDemand--;
            }
            else if (recipe.PricePerCup <= .20)
            {
                customerDemand++;
            }
        }

        


        public void HasDamandByConditions()
        {
            if (weather.ActualDailyConditions == "sunny")
            {
                customerDemand -= 1;
            }
            else if(weather.ActualDailyConditions == "cloudy")
            {
                customerDemand -= 10;
            }
            else if(weather.ActualDailyConditions == "rainy")
            {
                customerDemand -= 20;
            }
            else if(weather.ActualDailyConditions == "windy")
            {
                customerDemand -= 15;
            }
            else if(weather.ActualDailyConditions == "foggy")
            {
                customerDemand -= 5;
            }
        }

        public void HasDemandByRecipe()
        {
            if(recipe.LemonsUsed > recipe.SugarUsed)
            {
                customerDemand -= 15;
            }
            else if (recipe.LemonsUsed < recipe.SugarUsed)
            {
                customerDemand -= 1;
            }
            else if (recipe.LemonsUsed == recipe.SugarUsed)
            {
                customerDemand -= 5;
            }
           
        }









        public void GetCustomersThatPurchase()
        {
        if (customerDemand > 80 && customerCash > recipe.PricePerCup)
            {
            customersThatBuy = rnd.Next(customer.Count - 10, customer.Count);
                recipe.CupsUsed = CustomersThatBuy;
            }
        else if (customerDemand < 80 && customerDemand > 60 && customerCash > recipe.PricePerCup)
            {
            customersThatBuy = rnd.Next(customer.Count - 15, customer.Count);
                recipe.CupsUsed = CustomersThatBuy;
            }
        else if (customerDemand < 60 && customerDemand > 40 && customerCash > recipe.PricePerCup)
            {
                customersThatBuy = rnd.Next(customer.Count - 20, customer.Count);
                recipe.CupsUsed = CustomersThatBuy;
            }
        else if (customerDemand < 40 && customerCash > recipe.PricePerCup)
            {
                customersThatBuy = rnd.Next(customer.Count - 25, customer.Count);
                recipe.CupsUsed = CustomersThatBuy;
            }

}
    }
}
