using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Customer
    {
        public int customerDemand = 100;
        Random rnd = new Random();
        public List<Customer> customer = new List<Customer>();
        public double customerCash;
        int customersThatBuy;

        public int CustomersThatBuy
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


        public void SetDemandByPrice(Recipe recipe)
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

        


        public void SetDamandByConditions(Weather weather)
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

        public void SetDemandByRecipe(Recipe recipe)
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


        public void DisplayTotalCustomersForTheDay()
        {
            Console.WriteLine("You had " + CustomersThatBuy + " customers buy a cup of lemonade from you today");
        }
}
    
    }

