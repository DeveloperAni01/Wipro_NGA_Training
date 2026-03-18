using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CW
{
    internal class CwArithmatic
    {
        //public int calc(int x) ///outputparameter
        //{
        //    int sq = x * x;
        //    int cube = x * x * x;
        //    int quad = x * x * x * x;
        //    Console.WriteLine(sq);
        //   y = cube;
        //    return quad;
        //}
        public void calc(params int[] scores) 
        {
            //int sq = x * x;
            //int cube = x * x * x;
            //int quad = x * x * x * x;

            //int[] res = new int[3];
            //res[0] = sq;
            //res[1] = cube;
            //res[2] = quad;
            //return res;
            Console.WriteLine("outputs are");
            Console.WriteLine(scores[0]);
            Console.WriteLine(scores[1]);
            Console.WriteLine(scores[2]);
            Console.WriteLine(scores[3]);
            
        }
    }
}
