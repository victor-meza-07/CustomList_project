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
        private int capacity;
        private T[] underLyingArray;
        public Gauntlet()
        {
            count = 0;
            capacity = 0;
        }


        /// <summary>
        /// Adds an Item to the list
        /// </summary>
        public void Add(T item) 
        {
            try
            {

            }
            catch(Exception) 
            {

            }
        }
        
        
        
        
        /* Private Support Methods */
        
        /// <summary>
        /// Adds to the count of the Gaunlet
        /// </summary>
        private void SetNewCount() 
        {
            this.count++;
        }
        /// <summary>
        /// Checks if the underlying array is full
        /// </summary>
        private bool CheckFullStatus() 
        {
            bool full = false;
            if (this.count == this.capacity) 
            {
                full = true; 
            }
            return full;
        }
        
        //Should there be no underlying array, this will create one.
        private void CreateNewArray() 
        {
            bool NewOrExapnd = NewOrExpand();
            if (NewOrExapnd == true)
            {
                this.underLyingArray = new T[4];
                this.capacity = 4;
            }
            else 
            {
                //create a temporary Array of Equal Size to the one now
                //Copy all items of current array to that array
                //Resize Current Array
                //Copy Values from temporary array to the current array
               //Destroy the previous array.
            }
        }
        //Sets the default values of the new array

        //Will Return False if We need To Expand;
        private bool NewOrExpand() 
        {
            bool NOE = false;
            if (this.capacity == 0) 
            {
                NOE = true;
            }
            return NOE;
        }
        private void SetNewArrayExtraValues() 
        {
            for (int i = 0; i < this.capacity; i++)
            {
                this.underLyingArray[i] = default;
            }
        }
        
        
        
        private void CheckCount() 
        {

        }

    }
}
