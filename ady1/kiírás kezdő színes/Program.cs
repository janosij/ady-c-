using System;

namespace Kezdo_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name; //változó létrehozása
            Console.WriteLine("Szia! Add meg a neved:"); //kiírás a képernyőre
            name = Console.ReadLine(); //beolvassuk a felhasználó által beírt értéket az előbb létrehozott változóba

            Console.WriteLine("Szia kedves " + name); //kiírjuk az eredményt

            Console.SetCursorPosition(20, 20); //arrébb tesszük a kurzort
            Console.BackgroundColor = ConsoleColor.DarkGreen; //háttérszínt adunk
            Console.ForegroundColor = ConsoleColor.Yellow; //betűszínt adunk
            Console.WriteLine("Szia kedves {0}", name); //kiírjuk újra, de más módszerrel!
            Console.ResetColor(); //visszaállunk eredeti színre
            Console.SetCursorPosition(25, 25);

            Console.WriteLine(name);


            Console.ReadKey(); //addig marad a képernyő, amíg nem nyomunk meg egy billentyűt
        }
    }
}
