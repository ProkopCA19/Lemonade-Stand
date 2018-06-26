using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Recipe
    {
        //int cupsUsed;
         int lemonsUsed;
         int sugarUsed;
         int iceUsed;

        public int LemonsUsed
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

        public int SugarUsed
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

        public int IceUsed
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

       public void DisplayRecipe()
        {
            Console.WriteLine("You have " + LemonsUsed + " lemons per pitcher" );
            Console.WriteLine("You have " + SugarUsed + "cups of sugar per pitcher");
            Console.WriteLine("You have " + IceUsed + "icecubes per cup");
        }


    }


}
