using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Ylesanne_2
{
    class MainClass
    {
        /*Ülesanne 2

Sul on programmis defineeritud massiiv järgnevate nimedega: 
Kaur, Mattias, Kristel, Heleri, Trevor, Kristjan, Kelli, Kevin, Maarika, Laura.
Programm küsib kasutaja käest sisendit. Sisendiks võib olla üks sõna, lause või 
miks mitte ka 10 lauset. Ülesanne on kasutajale programmi lõpus kuvada tema sisestatud 
sisend, aga nii, et kõik nimed oleks kindlasti suure algustähega.
Näiteks kui kasutaja sisestab teksti: „kevin ja heleri mängisid koos liivakastis. 
trevor vaatas pealt ning kristel kiikus.“ siis tulemuseks peab olema: „Kevin ja 
Heleri mängisid koos liivakastis. Trevor vaatas pealt ning Kristel kiikus.“*/

        public static void Main(string[] args)
        {

            string[] nimed = new string[10] { "Kaur", "Mattias", "Kristel", "Heleri", "Trevor", "Kristjan", "Kelli", "Kevin", "Maarika", "Laura" };
            Console.WriteLine("Kirjuta mulle üks lugu kasutades massiivis olevaid nimesid.");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Nimed massiivis on " + string.Join(", ", nimed));
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("--------------NB! Nimed on case-sensitive ;(---------------");
            Console.WriteLine("-----------------------------------------------------------");

            string input = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(input))
            {

                Console.WriteLine("Sisestatud mitte midagi!");
                return;
            }

            string[] s6nad = input.Split(' ');
            var intersect = nimed.Intersect(s6nad);
            Console.WriteLine("Kasutatud nimed on " + string.Join(", ", intersect));

        }
    }
}


