using System;

namespace proggramerings_olympiaden
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vikt = new int [5];//I gram
            double C4 = (0.229 * 0.324) * (0.229 * 0.324);//1 Kuvert i meter (behövs två)
            double A3 = (0.297 * 0.420) * (0.297 * 0.420);//2 Affischer i meter
            double A4 = (0.210 * 0.297) * (0.210 * 0.297);//1 Informationsblad i meter
            Console.WriteLine("Hur många Kuvert?");
            vikt[1] = int.Parse(Console.ReadLine());
            double tal1 = (Math.Round((vikt[1] / 2) / C4));
            Console.WriteLine("Hur många Affischer?");
            vikt[2] = int.Parse(Console.ReadLine());
            double tal2 = (Math.Round(vikt[2] / A3));
            Console.WriteLine("Hur många Informationsblad?");
            vikt[3] = int.Parse(Console.ReadLine());
            double tal3 = (Math.Round(vikt[3] / A4));
            double tal4 = (Math.Round((tal1 + tal2 + tal3) / 450, 6));
            Console.WriteLine(tal4);  
        }
    }
}
