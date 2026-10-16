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

            static void Main(string[] args)
        {
            osszegzes();
            negativdb();
        }
    }
}
