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

            //LOOPS THROUGH PROPERLY, THE NUMBER BEHIND J WILL CLEAR ITS VALUES.

            int[] test = new int[4];
            test[0] = 0;
            test[1] = 2;
            test[2] = 4;
            test[3] = 6;
            int[] test1 = new int[4];
            test1[0] = 1;
            test1[1] = 3;
            test1[2] = 5;
            test1[3] = 7;
            int[] finalArray;

            if (test.Length > test1.Length)
            {
                int FirstArraypos = 0;
                int secondArrayPos = 1;
                finalArray = new int[test.Length + test1.Length];
                for (int i = 0; i < test.Length; i++)
                {
                    if (i >= test1.Length)
                    {
                        finalArray[FirstArraypos] = test[i];
                        FirstArraypos++;
                    }
                    else 
                    {
                        finalArray[FirstArraypos] = test[i];
                        finalArray[secondArrayPos] = test1[i];
                        FirstArraypos += 2;
                        secondArrayPos += 2;
                    }
                }
            }
            else if (test.Length < test1.Length)
            {
                int FirstArraypos = 0;
                int secondArrayPos = 1;
                finalArray = new int[test.Length + test1.Length];
                for (int i = 0; i < test1.Length; i++)
                {
                    if (i >= test.Length)
                    {
                        finalArray[FirstArraypos] = test1[i];
                        FirstArraypos++;
                    }
                    else
                    {
                        finalArray[FirstArraypos] = test[i];
                        finalArray[secondArrayPos] = test1[i];
                        FirstArraypos += 2;
                        secondArrayPos += 2;
                    }
                }
            }
            else 
            {
                finalArray = new int[test.Length + test1.Length];
                int FirstArraypos = 0;
                int secondArrayPos = 1;
                for (int i = 0; i < test.Length; i++)
                {
                    finalArray[FirstArraypos] = test[i];
                    finalArray[secondArrayPos] = test1[i];

                    FirstArraypos += 2;
                    secondArrayPos += 2;
                }
            }

        }
    }
}
  