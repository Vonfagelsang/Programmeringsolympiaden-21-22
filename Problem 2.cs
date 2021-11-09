using System;
using System.Linq;
namespace proggramerings_olympiaden
{
    class Program
    {
        static void Main(string[] args)
        {
Console.WriteLine("Ord:");
string Ord = Console.ReadLine();
Console.WriteLine("Mening:");
string Mening = Console.ReadLine();  
  
string result = string.Join(" ", Mening  
  
.Split(' ')  
  
.Select(x => new String(x.Reverse().ToArray())));  
  

 int temp;

            string s = result;

            string[] a = s.Split(' ');

            int k = a.Length - 1;

            temp = k;

           for (int i = k; temp >= 0; k--)

            {

                Console.Write(a[temp] + "" + ' ');

                --temp;

            }

        }
    }
}
