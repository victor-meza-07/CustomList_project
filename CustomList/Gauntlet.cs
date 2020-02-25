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
        public T this[int i]
        { 
            get 
            {
                if (i > (this.count - 1)) { throw new ArgumentOutOfRangeException(); }
                else { return underLyingArray[i]; }
            } 
            set 
            {
                if (i > (this.count - 1)) { throw new ArgumentOutOfRangeException(); }
                else { underLyingArray[i] = value; }
            } 
        }
        public int Capacity { get { return capacity; } }


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
        public void Collect(T item)
        {
            bool checkIFFull = CheckFullStatus();
            if (checkIFFull == true)
            {
                CreateArray(); // Null Exception with strings 
                AddItemToUnderlyingArray(item);
            }
            else 
            {
                AddItemToUnderlyingArray(item);
            }
        }
        /// <summary>
        /// Will Remove The first Instance of An Item in your list
        /// </summary>
        /// <param name="item"></param>
        public void Lose(T item) 
        {
            //Get First Instance Index
            int index = Return_FirstInstanceIndice(item);
            //Check if Item was found;
            bool found = Return_IfItemWasFound(index);
            //Delete Item at that position in the underlying array
            Delete_ItemAtGivenIndexIfFound(found, index);

            //If not -> Maintain Current Array
            T[] temporary = CreateTemporaryArray(this.capacity);
            //Copy all values to temporary array
            CopyValuesToTemporaryArray(temporary, this.capacity);
            //Default all values on current array
            SetNewArrayDefaultValues(this.underLyingArray, this.capacity);
            //Copy all values to current array REMEBER to Sift All Positions Back one from first instance of object
            Shift_ItemsToCurrentArray(index, temporary, this.capacity);
            
        }



        /* Private Support Methods */


        
        private void Delete_ItemAtGivenIndexIfFound(bool found, int index) 
        {
            if (found == true) 
            {
                underLyingArray[index] = default;
            }
        }
        private int Return_FirstInstanceIndice(T item) 
        {
            int index = 0;

            for (int i = 0; i < count; i++)
            {
                if (item.Equals(underLyingArray[i]))
                {
                    index = i;
                    break;
                }
                else 
                {
                    index = -1;
                }
            }

            return index;
        }
        private bool Return_IfItemWasFound(int index) 
        {
            bool found = false;

            if (index > -1) 
            {
                found = true;
            }

            return found;
        }
        private void Shift_ItemsToCurrentArray(int indexOfFirstIndex, T[] tempArray, int tempCapacity) 
        {
            for (int i = 0; i < tempCapacity; i++)
            {
                if (i == indexOfFirstIndex)
                {
                    underLyingArray[i] = tempArray[i + 1];
                }
                else 
                {
                    underLyingArray[i] = tempArray[i];
                }
            }
            RemoveFromCount();
        }











        private void AddItemToUnderlyingArray(T item) 
        {
            int index = IndexToAddTo(item);
            underLyingArray[index] = item;
            AddToCount();
        }
        private int IndexToAddTo(T item) 
        {
            int index = 0;
            
            for (int i = 0; i < this.capacity; i++)
            {
                
                if (underLyingArray[i] == default) 
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
        /// <summary>
        /// Adds to the count of the Gaunlet
        /// </summary>
        private void AddToCount() 
        {
            this.count++;
        }
        private void RemoveFromCount() 
        {
            this.count--;
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
        private void CreateArray() 
        {
            bool NewOrExapnd = NewOrExpand();
            if (NewOrExapnd == true)
            {
                this.capacity = 4;
                underLyingArray = new T[this.capacity];
                SetNewArrayDefaultValues(underLyingArray, this.capacity);
            }
            else 
            {
                int tempCapacity = SetTempCapacity();
                T[] temporary = CreateTemporaryArray(tempCapacity); 
                SetNewArrayDefaultValues(temporary, tempCapacity);
                
                CopyValuesToTemporaryArray(temporary, tempCapacity);
                ExapndCurrentArray();
                underLyingArray = new T[this.capacity];

                SetNewArrayDefaultValues(underLyingArray, this.capacity);
                CopyValuesToCurrentArray(temporary, tempCapacity);
               //Destroy the previous array (Happens AutoMagically)
            }
        }
        private bool NewOrExpand() 
        {
            bool NOE = false;
            if (this.capacity == 0) 
            {
                NOE = true;
            }
            return NOE;
        }
        private void SetNewArrayDefaultValues(T[] arrayToDefaultize, int capacityOfArray) 
        {
            
            for (int i = 0; i < capacityOfArray; i++)
            {
                arrayToDefaultize[i] = default;
            }
        }
        private int SetTempCapacity() 
        {
            return this.capacity;
        }
        private T[] CreateTemporaryArray(int tempCapacity) 
        {
            T[] temporary = new T[tempCapacity];
            return temporary;
           
        }
        private void CopyValuesToTemporaryArray(T[] tempArray, int tempCapacity) 
        {
            for (int i = 0; i < tempCapacity; i++)
            {
                tempArray[i] = underLyingArray[i];
            }
        }
        private void CopyValuesToCurrentArray(T[] tempArray, int tempCapacity) 
        {
            for (int i = 0; i < tempCapacity; i++)
            {
                this.underLyingArray[i] = tempArray[i];
            }
        }
        private void ExapndCurrentArray()
        {
            this.capacity *= 2;
        }
    }
}
