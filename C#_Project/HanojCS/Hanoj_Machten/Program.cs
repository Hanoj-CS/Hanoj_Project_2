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
                Console.WriteLine("Hoeveel lagen heb je?(0 tm 95)");
                string amountOfLayers = Console.ReadLine();
                success = double.TryParse(amountOfLayers, out doubleLayers);
                if (success)
                {
                    if (doubleLayers > 95 || doubleLayers < 0)
                    {
                        success = false;
                    }
                    
                }
            }
            Result = Convert.ToDecimal(Math.Pow(2, doubleLayers) - 1);
            Console.WriteLine(Result + " zetten\n");
            OutputTimes();
            Console.WriteLine("Als je het oplost duurt het:\n{0} jaar, {1} weken, {2} dagen, {3} uur, {4} minuten en {5} seconden", years, weeks, days, hours, minutes, Result);
            Console.WriteLine("Programma afgelopen, Druk op een toets om te sluiten");
            Console.ReadKey();
        }
      
        static void OutputTimes()
        {

            while (Result > 3155692600000000000)
            {
                years = years + 100000000000;
                Result = Result - 3155692600000000000;
            }
            while (Result > 31556926000)
            {
                years = years + 1000;
                Result = Result - 31556926000;
            }
            while (Result > 31556926)
            {
                years++;
                Result = Result - 31556926;
            }
            while (Result > 2629744)
            {
                months++;
                Result = Result - 2629744;
            }
            while (Result > 604800)
            {
                weeks++;
                Result = Result - 604800;
            }
            while (Result > 2629744)
            {
                months++;
                Result = Result - 2629744;
            }
            while (Result > 86400)
            {
                days++;
                Result = Result - 86400;
            }
            while (Result > 3600)
            {
                hours++;
                Result = Result - 3600;
            }
            while (Result > 60)
            {
                minutes++;
                Result = Result - 60;
            }

        }
        
    }
}
