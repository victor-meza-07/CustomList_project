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

            Gauntlet<string> gn = new Gauntlet<string>();
            gn.Collect("Howdy");
            gn.Collect("Hello");
            gn.Collect("Mr SandMan");
            gn.Collect("Something Else");
            gn.Lose("Hello");

            string x = gn[1];
        }
    }
}
