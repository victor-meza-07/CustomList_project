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

            int[] test = new int[3];
            int[] test1 = new int[4];
            int[] finalArray;

            if (test.Length > test1.Length)
            {
                finalArray = new int[test.Length + test1.Length];
                for (int i = 0, j =1; i < test.Length; i++, j++)
                {
                    if (i >= test1.Length)
                    {
                        finalArray[i] = test[i];
                    }
                    else 
                    {
                        finalArray[i] = test[i];
                        finalArray[j] = test1[i];
                    }
                }
            }
            else if (test.Length < test1.Length)
            {
                finalArray = new int[test.Length + test1.Length];
                for (int i = 0, j = 1; i < test.Length; i++, j++)
                {
                    if (i >= test.Length)
                    {
                        finalArray[i] = test1[i];
                    }
                    else
                    {
                        finalArray[i] = test1[i];
                        finalArray[j] = test[i];
                    }
                }
            }
            else 
            {
                finalArray = new int[test.Length + test1.Length];
                for (int i = 0, j = 0; i < test.Length; i++, j++)
                {
                    finalArray[i] = test[i];
                    finalArray[j] = test1[i];
                }
            }

        }
    }
}
  