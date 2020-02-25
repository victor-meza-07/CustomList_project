using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomeListTest
{
    [TestClass]
    public class UnitTest1
    {
        
        
        [TestMethod]
        public void Add_newGenericObjectToList_ListCountIncrease()
        {
            //Arrange
            CustomList<int> gauntlet = new CustomList<int>();
            int object1 = 1;
            int expected = 1;
            int actual;

            //Act
            gauntlet.Add(object1);
            actual = gauntlet.Count;
            
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [ExpectedException (typeof(ArgumentOutOfRangeException))]
        public void Add_newGenericObjectToList_NewArrayIsCreated()
        {
            //Arrange
            CustomList<string> gauntlet = new CustomList<string>();
            string Soultone;
            

            //Act
            Soultone = gauntlet[10];
            //Gotta add an indexing function (override)
          
            //Argument out of range expection
            //Assert
    
        }
        [TestMethod]
        public void Add_newGenericObjectToList_ObjectIsPlacedInProperListIndex()
        {

            //Arrange
            CustomList<int> gauntlet = new CustomList<int>(); 
            int element1 = 1;
            int expected = element1;
            int actual;
            //Act 
            gauntlet.Add(element1);
            actual = gauntlet[0];
            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        [ExpectedException (typeof(ArgumentOutOfRangeException))]
        public void Add_newGenericObjectToList_NewArraySizeisSufficientToHoldDouble()
        {
            //Arrange
            CustomList<string> gauntlet = new CustomList<string>();
            string object1 = "Look at Me";
            string expected = "Test";
            string actual;

            //Act
            gauntlet.Add(object1);
            gauntlet.Add(object1);
            gauntlet.Add(object1);
            gauntlet.Add(object1);
            gauntlet.Add(object1);
            gauntlet[7] = expected;
            actual = gauntlet[7];

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_newGenericObjectToList_GenericObjectHasOwnIndice() 
        {
            //Arrange
            CustomList<string> gauntlet = new CustomList<string>();
            string object1 = "Victor";
            string object2 = "Nevin";
            string expected = "Victor";
            string actual;

            //Act
            gauntlet.Add(object1);
            gauntlet.Add(object2);
            actual = gauntlet[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_newIntObjectToList_IntObjectIsRecognizedAndOwnDefaultIsAdded() 
        {
            CustomList<int> gauntlet = new CustomList<int>();
            int element1 = 1;
            int expected = 1;
            int actual;

            gauntlet.Add(element1);
            actual = gauntlet[0];

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_newBoolObjectToList_BoolObjectIsRecognized() 
        {
            CustomList<bool> gauntlet = new CustomList<bool>();
            bool element1 = true;
            bool expected = true;
            bool actual;

            gauntlet.Add(element1);
            actual = gauntlet[0];

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_FiveBewObjects_ListCapIncreasesToDouble() 
        {
            CustomList<int> gauntlet = new CustomList<int>();
            int element1 = 1;
            int expected = 8;
            int actual;

            gauntlet.Add(element1);
            gauntlet.Add(element1);
            gauntlet.Add(element1);
            gauntlet.Add(element1);
            gauntlet.Add(element1);

            actual = gauntlet.Capacity;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_GenericObject_CountDecreases() 
        {
            CustomList<int> gauntlet = new CustomList<int>();
            int element1 = 1;
            int expected = 0;
            int actual;

            gauntlet.Add(element1);
            gauntlet.Remove(element1);
            actual = gauntlet.Count;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_ItemNotInList_RemoveDoesNotBreak() 
        {
            CustomList<int> gauntlet = new CustomList<int>();
            int element1 = 1;
            int expected = 1;
            int actual;

            gauntlet.Add(element1);
            gauntlet.Remove(2);
            actual = gauntlet.Count;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_ItemsAreShiftedOneIndiceValue() 
        {
            CustomList<string> gauntlet = new CustomList<string>();
            string element1 = "Hello";
            string element2 = " ";
            string element3 = "World";
            string expected = "World";
            string actual;

            gauntlet.Add(element1);
            gauntlet.Add(element2);
            gauntlet.Add(element3);
            gauntlet.Remove(element2);

            actual = gauntlet[1];

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_OnlyFirstInstance_OnlyFirstInstanceIsRemoved() 
        {
            CustomList<string> gauntlet = new CustomList<string>();
            string element1 = "Hello";
            string element2 = "World";
            string expected = "Hello";
            string actual;

            gauntlet.Add(element1);
            gauntlet.Add(element2);
            gauntlet.Add(element1);
            gauntlet.Add(element2);
            gauntlet.Add(element1);
            gauntlet.Add(element2);

            gauntlet.Remove(element1);
            actual = gauntlet[1];

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Remove_OneItem_CountOnlyDecreasesBy1() 
        {
            CustomList<string> gauntlet = new CustomList<string>();
            string element1 = "Hello";
            string element2 = "World";
            int expected = 5;
            int actual;

            gauntlet.Add(element1);
            gauntlet.Add(element2);
            gauntlet.Add(element1);
            gauntlet.Add(element2);
            gauntlet.Add(element1);
            gauntlet.Add(element2);

            gauntlet.Remove(element1);
            actual = gauntlet.Count;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ToString_AllItems_TurnedToOneString() 
        {
            CustomList<int> customList = new CustomList<int>();
            int one = 1;
            string expected = "1\r\n1\r\n1\r\n";
            string actual;

            customList.Add(one);
            customList.Add(one);
            customList.Add(one);

            actual = customList.ToString();

            Assert.AreEqual(expected, actual);


        }
    }
}
