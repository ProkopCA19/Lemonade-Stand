using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Weather
    {
        Random rnd = new Random();
        int actualDailyTemperature;
        int predictedDailyTemperature;
        string actualDailyConditions;
        string predictedDailyConditions;

        public List<string> conditions = new List<string>() { "sunny", "cloudy", "rainy", "windy", "foggy" };


        public int ActualDailyTemperature
        {
            get
            {
                return actualDailyTemperature;
            }
            set
            {
                actualDailyTemperature = value;
            }
        }

        public string ActualDailyConditions
        {
            get
            {
                return actualDailyConditions;
            }
            set
            {
                actualDailyConditions = value;
            }
        }


      

        int GetPredictedTemperature()
        {
            predictedDailyTemperature = rnd.Next(50, 101);
            return predictedDailyTemperature;
        }

        public int GetActualTemperature()
        {
            actualDailyTemperature = rnd.Next(GetPredictedTemperature() - 10, GetPredictedTemperature() + 10);
            return actualDailyTemperature;
        }

        public string GetPredictedDailyConditions()
        {
            int result;
            result = rnd.Next(0, conditions.Count);
            predictedDailyConditions = conditions[result];
           return predictedDailyConditions;
        }

        public string GetActualDailyConditions()
        {
            int result;
            result = rnd.Next(0, conditions.Count);
            actualDailyConditions = conditions[result];
            return actualDailyConditions;
        }

        public void DisplayPredictedWeather()
        {
            Console.WriteLine("The predicted forecast is " + GetPredictedTemperature() + " degrees and " + GetPredictedDailyConditions());
        }


        public void DisplayActualWeather()
        {
            Console.WriteLine("The weather today is " + GetActualTemperature() + " degrees and " + GetActualDailyConditions());
        }
    }


}
