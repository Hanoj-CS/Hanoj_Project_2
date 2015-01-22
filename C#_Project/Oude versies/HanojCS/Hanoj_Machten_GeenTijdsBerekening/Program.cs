using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HanojCS
{

    /*
2^(i)-1
      */
    class Program
    {
        static decimal Result;
        static double doubleLayers;
        static bool success;
        static decimal years;
        static int months;
        static int weeks;
        static int days;
        static int hours;
        static int minutes;
        static void Main(string[] args)
        {
            while (success == false)
            {
                Console.WriteLine("Hoeveel lagen heb je?(1 tm 95)");
                string amountOfLayers = Console.ReadLine();
                success = double.TryParse(amountOfLayers, out doubleLayers);
                if (success)
                {
                    if (doubleLayers > 95 || doubleLayers < 1)
                    {
                        success = false;
                    }
                }
            }
            Result = Convert.ToDecimal(Math.Pow(2, doubleLayers) - 1);
            Console.WriteLine(Result + " zetten\n");
            Console.WriteLine("Programma afgelopen, Druk op een toets om te sluiten");
            Console.ReadKey();
        }

    }
}
