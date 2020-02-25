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

            CustomList<int> gn1 = new CustomList<int>();
            gn1.Add(2);
            gn1.Add(2);
            gn1.Add(2);
            gn1.Add(2);


            gn = gn + gn1;
            string me = gn.ToString();

        }
    }
}
