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
            customList.Add("Hello");

            IEnumerator<string> enumerator = customList.GetEnumerator();
        }
    }
}
  