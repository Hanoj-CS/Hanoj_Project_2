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
        static decimal months;
        static decimal weeks;
        static decimal days;
        static decimal hours;
        static decimal minutes;
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
                    success = !amountOfLayers.Contains(",");
                }
            }
            Result = Convert.ToDecimal(Math.Pow(2, doubleLayers) - 1);
            Console.WriteLine(Result + " zetten\n");
            OutputTimes();
            Console.WriteLine("Als je het oplost duurt het:\n{0} jaar\n{1} weken\n{2} dagen\n{3} uur\n{4} minuten en {5} seconden", years, weeks, days, hours, minutes, Result);
            Console.WriteLine("Programma afgelopen, Druk op een toets om te sluiten");
            Console.ReadKey();
        }
        static decimal temp = 0;
        static void OutputTimes()
        {
            // Jaren
            temp = Result % 31556926;
            years = (Result - temp) / 31556926;
            Result = Result - (years * 31556926);
            // Maanden
            temp = Result % 2629744;
            months = (Result - temp) / 2629744;
            Result = Result - (months * 2629744);
            // Weken
            temp = Result % 604800;
            weeks = (Result - temp) / 604800;
            Result = Result - (weeks * 604800);
            // Dagen
            temp = Result % 86400;
            days = (Result - temp) / 86400;
            Result = Result - (days * 86400);
            // Uur
            temp = Result % 3600;
            hours = (Result - temp) / 3600;
            Result = Result - (hours * 3600);
            // Minuten
            temp = Result % 60;
            minutes = (Result - temp) / 60;
            Result = Result - (minutes * 60);
            //Schrikkeljaren
    
            //while (Result > 2629744)
            //{
            //    months++;
            //    Result = Result - 2629744;
            //}
            //while (Result > 604800)
            //{
            //    weeks++;
            //    Result = Result - 604800;
            //}
            //while (Result > 2629744)
            //{
            //    months++;
            //    Result = Result - 2629744;
            //}
            //while (Result > 86400)
            //{
            //    days++;
            //    Result = Result - 86400;
            //}
            //while (Result > 3600)
            //{
            //    hours++;
            //    Result = Result - 3600;
            //}
            //while (Result > 60)
            //{
            //    minutes++;
            //    Result = Result - 60;
            //}

        }
        
    }
}
