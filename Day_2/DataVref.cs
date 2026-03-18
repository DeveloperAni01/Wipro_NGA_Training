using System;
using System.Collections.Generic;
using System.Text;

namespace Wipro_Training.Day_2
{
    internal class DataVref
    {

        public void calculate(ref int x, int y) 
        {

            x += 5;
            y += 5;
            Console.WriteLine(x + y);
        }
    }
}
