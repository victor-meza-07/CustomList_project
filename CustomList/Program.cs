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

            CustomList<int> gn = new CustomList<int>();

            gn.Add(1);
            gn.Add(1);
            gn.Add(1);
            gn.Add(1);

            string me = gn.ToString();

        }
    }
}
