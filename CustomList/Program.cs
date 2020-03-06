using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class Program
    {
        static void Main(string[] args)
        {
            unsafe 
            {
                int* x;
                int y = 10;
                double[] arr = new double[20];
                arr[1] = 40.0;

                x = &y;
                *x = 200;
                *x = 15;
                *x = 82;
                *x = 77;
                *x = 1010;
                *x = 54321;
                *x = 3455021;
                
            }
            
            
            Console.ReadLine();
        }
    }
}
  