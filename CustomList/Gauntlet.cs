using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class Gauntlet<T>
    {
        public int Count { get { return count; } }
        private int count;
        public Gauntlet()
        {}
        List<int> ts = new List<int>();

        /// <summary>
        /// Adds to the count of the Gaunlet
        /// </summary>
        private void SetNewCount() 
        {
            this.count++;
        }

    }
}
