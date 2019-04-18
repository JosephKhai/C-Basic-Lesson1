using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Dam maw?");
            Console.ReadLine();

            Console.WriteLine("Na min at in!");
            string min = Console.ReadLine();

            Console.WriteLine("Na suah kum at in!");
            int suahkum = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Tu kum bang kum hiam?");
            int tukum = Convert.ToInt16(Console.ReadLine());

            int kumphazah = tukum - suahkum;



            Console.WriteLine(min + " " + "pen kum " + " " + kumphazah + " " + "pha hi.");
            Console.ReadLine();
      
        }
    }
}
