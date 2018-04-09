using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ylesanne_3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
          /*  Ülesanne 3
Proramm küsib kasutaja käest kolme sisendit: 
a) minimaalne aasta arv, 
b) maksimaalne aasta arv, 
c) suvaliselt genereeritavate andmete hulka.
Vastavalt sisestatud andmetele genereeritakse 
suvalislet etteantud vahemikus ja hulgal timestamp’e.*/
           

            Console.WriteLine("Sisestage palun minimaalne neljakohaline aastaarv");
            string min = Console.ReadLine();
            int aasta1;
            if (int.TryParse(min, out aasta1) && min.Length == 4)
            {

                Console.WriteLine("Sisestage palun maksimaalne neljakohaline aastaarv");
                string max = Console.ReadLine();
                int aasta2;
                if (int.TryParse(max, out aasta2) && max.Length == 4 && aasta2 > aasta1)
                {
                    Console.WriteLine("Kui palju timestampe soovite?");
                    int kogus = Convert.ToInt32(Console.ReadLine());

 
                    Random random = new Random();
                    int[] aastad = Enumerable
                        .Repeat(0, kogus)
                        .Select(i => random.Next(aasta1, aasta2))
                        .ToArray();

                   
                    Array.Sort(aastad);
                    Console.WriteLine("Aastate vahemik on: ");
                        Console.WriteLine(string.Join(", ", aastad));



                }
                else
                {
                    Console.WriteLine("Viga aasta arvus!");
                    return;
                }

            }
            else
            {
                Console.WriteLine("Viga aasta arvus!");
                return;
            }


        }
    }
}
