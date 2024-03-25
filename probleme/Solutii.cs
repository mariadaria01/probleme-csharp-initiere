using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace probleme
{
    public class Solutii
    {
        // Se da o lista de numere si o valoare n, sa se stearga fiecare valoare egala cu n
        // gasita in lista si sa se returneze numarul de elemente diferite de n. (Cate au ramas)
        public static void Problema1()
        {
            int[] lista = { 0, 1, 2, 2, 3, 0, 4, 2 };
            int n = 2;

            // Console.WriteLine(); // cout << (text) << endl;
            // Console.Write(); // cout << (text);

            int c = Functii.RemoveValueII(ref lista, n);
            Functii.AfisareVector(lista);
            Console.WriteLine(c);
        }
        // Se dau două şiruri cu elemente numere naturale.Determinaţi câte dintre elementele
        // primului şir sunt mai mari decât toate elementele celui de-al doilea şir.

        public static void Problema2()
        {
            int[] x = { 7, 8, 10, 1, 9 };
            int[] y = { 1, 3, 6, 2, 7, 3 };

            Console.WriteLine(Functii.CateElementeMajorante(x, y));
        }

    }
}
