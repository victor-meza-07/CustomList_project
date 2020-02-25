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
            gn.Add(2);
            gn.Add(2);
            gn.Add(2);

            CustomList<string> gn1 = new CustomList<string>();
            gn1.Add("2");
            
            string me = gn.ToString();

        }
    }
}
