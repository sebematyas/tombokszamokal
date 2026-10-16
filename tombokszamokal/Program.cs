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
            static void Main(string[] args)
        {
            
        }
    }
}
