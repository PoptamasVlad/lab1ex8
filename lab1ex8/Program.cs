using System;

namespace lab1ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Se citesc doua numere de la tastatura, x si y. Scrieti un program care va verifica
            daca x este divizibil cu y.
            In cazul in care x este divizibil cu y, programul va afisa “divizibil” iar in caz contrar,
            “indivizibil”*/

            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if (x % y == 0)
            {
                Console.WriteLine("divizibil");
            }
            else
            {
                Console.WriteLine("indivizibil");
            }
        }
    }
}
