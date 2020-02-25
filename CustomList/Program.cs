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

            CustomList<string> gn = new CustomList<string>();
            gn.Add("Howdy");
            gn.Add("Hello");
            gn.Add("Mr SandMan");
            gn.Add("Something Else");
            gn.Remove("Hello");

            string x = gn.ToString();
            Console.WriteLine(x+"Text");
        }
    }
}
