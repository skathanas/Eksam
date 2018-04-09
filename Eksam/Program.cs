using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksam1
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            /* Ülesanne 1

             Luua programm mis küsib inimeste nimesi niikaua kuni sisestatakse 
             erimärk „-1“. Iga sisestatud nimi lisatakse massiivi mis kuvatakse 
                         kasutajale programmi lõpus välja.Kindlasti tuleb 
                         veenduda, et esimene täht oleks suur.Selle võid 
             lahendada nii, et palud kasutajal sisestada sisendi õigel 
             kujul või siis vaikimisi teed programmis esimese tähe alati suureks.*/

            var nimed = new List<string>();
            while (true)
            {
                Console.WriteLine("Sisesta inimese nimi või -1 et väljuda");
                var nimi = Console.ReadLine();
                nimed.Add(nimi);
                if (nimi == "-1")
                {
                    nimed.Remove(nimi);
                    Console.WriteLine("Tänud, nimed on: ");
                    break;
                }


            }
 
            var Nimed2 = new List<string>();
            foreach (string nimi in nimed)
            {
                string Suurt2ht = char.ToUpper(nimi[0]) + nimi.ToLower().Substring(1);
                Nimed2.Add(Suurt2ht);
            }
            foreach (var Suurt2ht in Nimed2)
                Console.WriteLine(Suurt2ht);


            Console.WriteLine("Vajuta üleval paremal nurgas X et väljuda");
            Console.ReadLine();
        }
    }
}
