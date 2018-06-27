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
        Store store = new Store();

        public void DisplayPredictedWeather()
        {
            weather.DisplayPredictedWeather();
        }
        public void SetDailyWeather()
        {
            weather.GetActualTemperature();
            weather.GetActualDailyConditions();
        }
        public void GetCustomerInformation()
        {
            customer.AddCustomers(weather); 
            customer.SetCustomerCash();
            customer.HasDemandByPrice();
            customer.HasDamandByConditions();
            customer.HasDemandByRecipe();
            customer.GetCustomersThatPurchase();
        }

        public void GetDailySalesAndBalance()
        {
            store.CalculateDailyBalance();
            store.CalculateDailyBalance();
        }

    }
}
