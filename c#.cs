using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*   Console.Write("Enter a number: ");
               int number = Convert.ToInt32(Console.ReadLine());
               Console.WriteLine("You entered: " + number);
               Console.ReadKey();*/
            /* int x = 10;
               int y = x; 

               Console.WriteLine("Initial values:");
               Console.WriteLine("x = " + x);
               Console.WriteLine("y = " + y);
               x = 20; 
               Console.WriteLine("After modifying x:");
               Console.WriteLine("x = " + x);
               Console.WriteLine("y = " + y);
               Console.ReadKey();*/


            Person p1 = new Person { Name = "Abdallah" };
            Person p2 = p1;

            Console.WriteLine("Initial values:");
            Console.WriteLine("p1.Name = " + p1.Name);
            Console.WriteLine("p2.Name = " + p2.Name);

            p1.Name = " osama";

            Console.WriteLine("After modifying p1:");
            Console.WriteLine("p1.Name = " + p1.Name);
            Console.WriteLine("p2.Name = " + p2.Name);

            Console.ReadKey();


        }
        public class Person
        {
            public string Name { get; set; }
        }
    }
}
