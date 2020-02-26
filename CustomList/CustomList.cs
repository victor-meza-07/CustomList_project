using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
    {
        public int Count { get { return count; } }
        public T this[int i]
        { 
            get 
            {
                if (i >= this.count) { throw new ArgumentOutOfRangeException(); }
                else { return underLyingArray[i]; }
            } 
            set 
            {
                if (i >= this.count) { throw new ArgumentOutOfRangeException(); }
                else { underLyingArray[i] = value; }
            } 
        }
        
        public int Capacity { get { return capacity; } }


        private int count;
        private int capacity;
        private T[] underLyingArray;


        public CustomList()
        {
            count = 0;
            capacity = 0;
        }
        public static CustomList<T> operator +(CustomList<T> listOne, CustomList<T> listTwo) 
        {
            CustomList<T> customList = new CustomList<T>();
            int listOneCapacity = listOne.Capacity;
            int listTwoCapacity = listTwo.Capacity;

            customList.capacity = listOneCapacity + listTwoCapacity;
            customList.underLyingArray = new T[customList.Capacity];

            for (int i = 0; i < listOne.count; i++)
            {
                customList.count++;
                customList[i] = listOne[i];
                
            }
            int CounterForSecondList = 0;
            for (int i = (listOne.count); i < (listTwo.count + listOne.count); i++)
            {
                customList.count++;
                customList[i] = listTwo[CounterForSecondList];
                CounterForSecondList++;
                
            }
            return customList;
        }
        public static CustomList<T> operator -(CustomList<T> listOne, CustomList<T> listTwo) 
        {
            CustomList<T> returnedList = new CustomList<T>();

            bool doWeShareItems = true;
            do
            {
                
                for (int i = (listOne.Count - 1); i >= 0; i--)
                {
                    for (int j = 0; j < listTwo.Count; j++) // removes item properly, but keeps looping after item has been removed
                    {
                        if (listOne.Count == 0) 
                        {
                            break;
                        }
                        else if (listOne[i].Equals(listTwo[j])) 
                        {
                            T item = listTwo[j];
                            listOne.Remove(item);
                        }
                    }
                }
                doWeShareItems = false;
            }
            while (doWeShareItems == true);
            returnedList = listOne;

            return returnedList;
        }


        /// <summary>
        /// Adds an Item to the list
        /// </summary>
        public void Add(T item)
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
        public void Remove(T item) 
        {
            //Get First Instance Index
            int index = Return_FirstInstanceIndice(item);
            //Check if Item was found;
            bool found = Return_IfItemWasFound(index);
            //Delete Item at that position in the underlying array
            Delete_ItemAtGivenIndexIfFound(found, index);

            if (found == true) 
            {
                //If not -> Maintain Current Array
                T[] temporary = CreateTemporaryArray(this.capacity);
                //Copy all values to temporary array
                CopyValuesToTemporaryArray(temporary, this.capacity);
                //Default all values on current array
                SetNewArrayDefaultValues(this.underLyingArray, this.capacity);
                //Copy all values to current array REMEBER to Sift All Positions Back one from first instance of object
                Shift_ItemsToCurrentArray(index, temporary, this.capacity);
            }
            
        }
        /// <summary>
        /// Will Turn Every Item as one string with line breaks at end of every item
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(null);
            

            if (count > 0) 
            {
                for (int i = 0; i < this.count; i++)
                {
                    if (i == 0) { sb.AppendLine(underLyingArray[i].ToString()); }
                    else 
                    {
                        if (underLyingArray[i] != default) 
                        {
                            sb.AppendLine(underLyingArray[i].ToString());
                        }
                    }
                }
            }

            string returned = sb.ToString();

            return returned;
        }
        /// <summary>
        /// Will Return a new List of the two inputed in alternating order
        /// </summary>
        /// <param name="listOne"></param>
        /// <param name="listTwo"></param>
        /// <returns></returns>
        public CustomList<T> Zip(CustomList<T> listOne, CustomList<T> listTwo) 
        {
            CustomList<T> returnedList = new CustomList<T>();

            //TODO: THIS WILL BE THE ZIP FUNCTION
            
            if (listOne.Count > listTwo.Count) 
            {
                for (int i = 0; i < listOne.Count; i++)
                {
                    if (i >= listTwo.Count) 
                    {
                        returnedList.Add(listOne[i]);
                    }
                    else 
                    {
                        returnedList.Add(listOne[i]);
                        returnedList.Add(listTwo[i]);
                    }
                }
            }
            else if (listOne.Count < listTwo.Count) 
            {
                for (int i = 0; i < listTwo.Count; i++)
                {
                    if (i >= listOne.Count)
                    {
                        returnedList.Add(listTwo[i]);
                    }
                    else 
                    {
                        returnedList.Add(listOne[i]);
                        returnedList.Add(listTwo[i]);
                    }
                }
            }
            else 
            {
                for (int i = 0; i < listOne.Count; i++)
                {
                    returnedList.Add(listOne[i]);
                    returnedList.Add(listTwo[i]);
                }
            }

            return returnedList;
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
                if (i >= indexOfFirstIndex)
                {
                    if (i == (tempCapacity - 1))
                    {
                        underLyingArray[i - 1] = tempArray[i];
                    }
                    else 
                    {
                        underLyingArray[i] = tempArray[i + 1];
                    }
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
            int index = this.count;
            underLyingArray[index] = item;
            AddToCount();
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
