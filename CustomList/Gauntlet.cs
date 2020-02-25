﻿using System;
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
            //Delete Item at that position in the underlying array
            //check if count is Half of array capacity
                
                //If So -> Copy Array to temp array of half size
                //Copy all items to Temp Array
                //Half the capacity of current array
                //Copy Items Back to the current array - 1 position after the First Instance
                //Delete Temporary Array

                //If not -> Maintain Current Array
                //Copy all values to temporary array
                //Default all values on current array
                //Copy all values to current array REMEBER to Sift All Positions Back one from first instance of object
            
            //Decrease Count By 1
            //Update Capacity;
        }



        /* Private Support Methods */

        private int Return_FirstInstanceIndice(T item) 
        {
            int index = 0;

            for (int i = 0; i < count; i++)
            {
                if (item.Equals(underLyingArray[i])) 
                {
                    index = 1;
                    break;
                }
            }

            return index;
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
