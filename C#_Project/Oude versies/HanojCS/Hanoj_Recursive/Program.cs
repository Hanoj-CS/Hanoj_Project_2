using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HanojCS
{

    /*
1 = 1 zet
2 = 2×1 + 1 = 3 zetten
3 = 2×3 + 1 = 7 zetten
4 = 2×7 + 1 = 15 zetten
5 = 2x15 + 1 = 31 zetten
6 = 2x31 + 1 = 63 zetten
7 = 2x63 + 1 = 127 zetten

 2 x Y + 1 = 127
 2 x 

(127 -1) / 2
      */
    class Program
    {
        static decimal Layers;
        static bool success;
        static void Main(string[] args)
        {
            while (success == false)
            {
                Console.WriteLine("Hoeveel lagen heb je?(1 tm 95)");
                string amountOfLayers = Console.ReadLine();
                success = Decimal.TryParse(amountOfLayers, out Layers);
                if (success)
                {
                    if (Layers > 95 || Layers < 1)
                    {
                        success = false;
                    }
                }
            }
            Hanoj();
            Console.WriteLine(previousnum);
            Console.WriteLine("Programma afgelopen, Druk op een toets om te sluiten");
            Console.ReadKey();
        }
        static decimal previousnum = 0;
        static int count;
        static void Hanoj()
        {
            count++;
            previousnum = 2 * previousnum + 1;
            if (count == Layers) { count++; }
            else
                Hanoj();
        }
    }
}
