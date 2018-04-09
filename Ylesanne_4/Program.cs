using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ylesanne_4
{
    class MainClass
    {
        public static void Main(string[] args)


        /* Programmis on defineeritud masiiv mis sisaldab umbes 30 erinevat 
 * timestamp’i mis illustreerivad inimeste sünniaega, näiteks 
 * vahemikus alates 1940 – 2010.Programmi ülesanne on leida nende 
 * timestamp’ide põhjal:
         maksimaalne vanus
         keskmine vanus aastates
         minimaalne vanus
         millisel kuul on kõige rohkem sünnipäevi
         kõik timestamp’id sorteerituna kasvavalt */
        
        {
            /*     Random rnd1 = new Random();
                  int[] aastad = Enumerable
                      .Repeat(0, 30)
                      .Select(i => rnd1.Next(1940, 2010))
                      .ToArray();
                  Random rnd2 = new Random();
                  int[] kuud = Enumerable
                      .Repeat(0, 30)
                      .Select(i => rnd2.Next(1, 12))
                      .ToArray();
                  Random rnd3 = new Random();
                  int[] p2evad = Enumerable
                      .Repeat(0, 30)
                      .Select(i => rnd3.Next(1, 31))
                      .ToArray();

                  int[] kuup2evad = new int[3];


                      //[aastad[0], kuud[0], p2evad[0]];



                  Console.WriteLine(string.Join(", ", aastad));*/

            List<DateTime> kuup2evad = new List<DateTime>();
            Random rnd = new Random();
            DateTime d = new DateTime(1940, 01, 01 ,01, 0, 0);

            for (int i = 0; i < 30; i++)
            {
                TimeSpan t = TimeSpan.FromDays(rnd.Next(0, 25550));
                kuup2evad.Add(d.Add(t));
            }

            kuup2evad.Sort();
            DateTime min = (kuup2evad.Min(date => date));
            DateTime max = (kuup2evad.Max(date => date));
            DateTime kuu = (kuup2evad.Max(month => month));
            DateTime nyyd = DateTime.Now;
            TimeSpan a = nyyd.Subtract(min);
            TimeSpan b = max.Subtract(min);
            TimeSpan c = nyyd.Subtract(max);
            int Esimene = Convert.ToInt32(a.Days.ToString());
            int Teine = Convert.ToInt32(b.Days.ToString());
            int Kolmas = Convert.ToInt32(c.Days.ToString());
            int Neljas = Convert.ToInt32(kuu.Month.ToString());

            Console.WriteLine(string.Join(", ", kuup2evad));
            Console.WriteLine("--------------------------");
            Console.WriteLine("Kõige vanem inimene listis on ");
            Console.WriteLine(Esimene / 365);
            Console.WriteLine("--------------------------");
            Console.WriteLine("Keskmine vanus on: ");
            Console.WriteLine(Teine / 365);
            Console.WriteLine("--------------------------");
            Console.WriteLine("Kõige noorem inimene listis on ");
            Console.WriteLine(Kolmas / 365);
            Console.WriteLine("--------------------------");
            Console.WriteLine("Kõige enam sünnipäevi on ");
            if (Neljas == 1)
            {
                Console.WriteLine("jaanuaris");
            }
            else if (Neljas == 2)
            {
                Console.WriteLine("veebruaris");
            }
            else if (Neljas == 3)
            {
                Console.WriteLine("märtsis");
            }
            else if (Neljas == 4)
            {
                Console.WriteLine("aprillis");
            }
            else if (Neljas == 5)
            {
                Console.WriteLine("mais");
            }
            else if (Neljas == 6)
            {
                Console.WriteLine("juunis");
            }
            else if (Neljas == 7)
            {
                Console.WriteLine("juulis");
            }
            else if (Neljas == 8)
            {
                Console.WriteLine("augustis");
            }
            else if (Neljas == 9)
            {
                Console.WriteLine("septembris");
            }
            else if (Neljas == 10)
            {
                Console.WriteLine("oktoobris");
            }
            else if (Neljas == 11)
            {
                Console.WriteLine("novembris");
            }
            else if (Neljas == 12)
            {
                Console.WriteLine("detsembris");
            }
        }
    }
}
