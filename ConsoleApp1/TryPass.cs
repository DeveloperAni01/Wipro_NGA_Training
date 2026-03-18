using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class TryPass
    {
        public void example()
        {
            Console.WriteLine("enter yout age: ");
            //exception handliing
            //try
            //{
            //    byte age = byte.Parse(Console.ReadLine());

            //    if (age <= 0) { Console.WriteLine("enter valid age!!"); }

            //    else if (age > 18)
            //    {
            //        Console.WriteLine("adult");
            //    }
            //    else
            //    {
            //        Console.WriteLine("not adult");
            //    }
            //}
            //catch
            //{
            //    Console.WriteLine("try after some time");
            //}

            //use try parse
            byte age = 0;
            byte.TryParse(Console.ReadLine(), out age);
            Console.WriteLine(age);
            if (age <= 0) { Console.WriteLine("enter valid age!!"); }

            else if (age > 18)
            {
                Console.WriteLine("adult");
            }
            else
            {
                Console.WriteLine("not adult");
            }

        }
    }
}
