using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Recipe
    {
        double cupsSold;
        double lemonsUsed;
        double sugarUsed;
        double iceUsed;
        int pitchers;
        double pricePerCup;
        double lemonsPerCup;
        double sugarPerCup;
        double totalLemonsUsed;
        double totalSugarUsed;

        public double TotalLemonsUsed
        {
            get
            {
                return totalLemonsUsed;
            }
            set
            {
                totalLemonsUsed = value;
            }
        }

        public double TotalSugarUsed
        {
            get
            {
                return totalSugarUsed;
            }
            set
            {
                totalSugarUsed = value;
            }
        }

        public double LemonsPerCup
        {
            get
            {
                return lemonsPerCup;
            }
            set
            {
                lemonsPerCup = value;
            }
        }

        public double SugarPerCup
        {
            get
            {
                return sugarPerCup;
            }
            set
            {
                sugarPerCup = value;
            }
        }

        public double LemonsUsed
        {
            get
            {
                return lemonsUsed;
            }
            set
            {
                lemonsUsed = value;
            }
        }

        public double SugarUsed
        {
            get
            {
                return sugarUsed;
            }
            set
            {
                sugarUsed = value;
            }
        }

        public double IceUsed
        {
            get
            {
                return iceUsed;
            }
            set
            {
                iceUsed = value;
            }
        }

        public double PricePerCup
        {
            get
            {
                return pricePerCup;
            }
            set
            {
                pricePerCup = value;
            }
        }

        public double CupsSold
        {
            get
            {
                return cupsSold;
            }
            set
            {
                cupsSold = value;
            }
        }

        public int Pitchers
        {
            get
            {
                return pitchers;
            }
            set
            {
                pitchers = value;

            }
        }

        public double GetSugarPerCup()
        {
            double sugarPerCup = Math.Round(sugarUsed / 5); //there are 5 cups in a pitcher
            return sugarPerCup;
        }

        public double GetLemonsPerCup()
        {
            double lemonsPerCup = Math.Round(lemonsUsed / 5);
            return lemonsPerCup;
        }

        public double GetTotalLemonsUsedForTheDay()
        {
            double totalLemonsUsed = LemonsPerCup * CupsSold;
            return totalLemonsUsed;
        }

        public double GetTotalSugarUsedForTheDay()
        {
            double totalSugarUsed = SugarPerCup * CupsSold;
            return totalSugarUsed;
        }
        public void DisplayRecipe()
        {
            Console.WriteLine("You have " + LemonsUsed + " lemons per pitcher");
            Console.WriteLine("You have " + SugarUsed + "cups of sugar per pitcher");
            Console.WriteLine("You have " + IceUsed + "icecubes per cup");
        }



    }

    }
