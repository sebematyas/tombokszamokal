using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Tracing;

namespace tombokszamokal
{
    internal class Program
    {
        static Random r = new Random();
        static int[] tomb = new int [15];
        static void feltoltes()
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = r.Next(-20, 20);
            
            }
            foreach (int item in tomb)
            {
                Console.WriteLine(item + " ");
            }
        }
        static void osszegzes()
        {
            int osszeg = 0;
            foreach (int item in tomb)
            {
                osszeg += item;
            }
        }
        static void negativdb()
        {
            int negativdb = 0;
            foreach (int item in tomb)
            {
                if (item < 0)
                {
                    negativdb += 1; 
                }              
            }
        }
        static void eldontes()
        {
            int i = 0;
            while ( i < tomb.Length && tomb[i] != 0)
            {
                i++;
            }
        }
        static void kereses()
        {
            int i = 0;
            int kereset = 0;
            while (i < tomb.Length && tomb[i] == kereset)
            {
                i++;
            }
            if (i < tomb.Length)
            {
                Console.WriteLine($"a keresett szam az {i}elemen talalhato ");
            }
            else
            {
                Console.WriteLine("a keresset szam nincs a listaba ");
            }
        }
        static void kivalasztas()
            {
                tomb[8] = 10;
                int i = 0;
                while (tomb[i] != 10 )
                {
                    i++;
                }
                Console.WriteLine($" a keresett szam a {i+1} helyen van ");
            }



            static void Main(string[] args)
        {
            feltoltes();
            osszegzes();
            negativdb();
            kereses();
            kivalasztas();
            }
    }
}
