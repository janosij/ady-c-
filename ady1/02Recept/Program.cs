using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Recept
{
    /// <summary>
    /// Pörkölt receptjének kiírása
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //feltételt vizsgálunk, ha péntek van, akkor hal, ha nem, akkor marha pörkölt
            //vedd észre, hogy az if sorát nem zárjuk ;-vel!!!

            if (DateTime.Today.DayOfWeek==DayOfWeek.Friday) //lekérdezzük a dátumot, összehasonlítjuk a péntekkel
            {
                Console.WriteLine("Halas kaja lesz"); //ha igaz a feltétel, akkor ez hajtódik végre
            }
            else //ez után lesz a hamis ág
            {
                Console.WriteLine("Marhahús"); //ha nem péntek van, akkor ezeket írja ki
                Console.WriteLine("Vöröshagyma");
                Console.WriteLine("Olaj");
                Console.WriteLine("Paprika");

            }
            Console.WriteLine(); //hagyjon ki egy üres sort

            /*Lehet változóval is! Ilyenkor létre kell hozni változóket, amelyek közül az egyik a valódi 
            aktuális napot tartalmazza, a másik, hogy ez a hét melyik napja, a harmadik meg azt, 
            hogy melyik nap szeretnénk halat enni*/

            var aktualis_nap = DateTime.Today; //milyen nap van ma
            
            var a_het_melyik_napja = aktualis_nap.DayOfWeek; //ez a hét melyik napja

            var halas_nap = DayOfWeek.Friday; //ezen a napon zabálunk halat

            if (a_het_melyik_napja==halas_nap)
            {
                Console.WriteLine("Halas kaja lesz"); //ha igaz a feltétel, akkor ez hajtódik végre
            }
            else //ez után lesz a hamis ág
            {
                Console.WriteLine("Marhahús"); //ha nem péntek van, akkor ezeket írja ki
                Console.WriteLine("Vöröshagyma");
                Console.WriteLine("Olaj");
                Console.WriteLine("Paprika");

            }

            Console.ReadKey(); //itt meg vár egy billentyű lenyomására
        }
    }
}
