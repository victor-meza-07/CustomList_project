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
            CustomList<string> customList = new CustomList<string>();
            CustomList<string> customList1 = new CustomList<string>();
            customList.Add("One");
            customList.Add("One");
            customList.Add("One");
            customList.Add("One");
            customList.Add("One");
            customList.Add("One");
            customList.Add("One");
            customList.Add("One");
            customList.Add("One");
            customList1.Add("Two");
            customList1.Add("Two");
            customList1.Add("Two");
            customList1.Add("Two");
            customList1.Add("Two");
            customList1.Add("Two");
            customList1.Add("Two");
            customList1.Add("Two");


            customList += customList1;

            string newBoy = customList[-1];

            Console.WriteLine(newBoy);
            Console.ReadLine();
        }
    }
}
  