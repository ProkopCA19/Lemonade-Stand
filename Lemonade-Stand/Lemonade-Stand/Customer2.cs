using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Customer2
    {
        int customerDemand = 100;
        Recipe recipe = new Recipe();
        Weather weather = new Weather;




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


        void HasDemandByTemperature()
        {
            if (weather.ActualDailyTemperature >= 90 && weather.ActualDailyTemperature <= 100)
            {
                customerDemand++;
            }
            else if (weather.ActualDailyTemperature >= 80 && weather.ActualDailyTemperature <= 90)
            {
                customerDemand -= 1;
            }
            else if (weather.ActualDailyTemperature >= 70 && weather.ActualDailyTemperature <= 80)
            {
                customerDemand -= 5;
            }
            else if (weather.ActualDailyTemperature >= 60 && weather.ActualDailyTemperature <= 70)
            {
                customerDemand -= 10;
            }
            else if (weather.ActualDailyTemperature >= 50 && weather.ActualDailyTemperature <= 60)
            {
                customerDemand -= 20;
            }
        }


        public void HasDamandByConditions()
        {

        }
    }
    }
}
