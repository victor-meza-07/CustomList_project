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
            Gauntlet<int> gauntlet = new Gauntlet<int>();
            int object1 = 1;
            int expected = 1;
            int actual;

            //Act
            gauntlet.Collect(object1);
            actual = gauntlet.Count;
            
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [ExpectedException (typeof(ArgumentOutOfRangeException))]
        public void Add_newGenericObjectToList_NewArrayIsCreated()
        {
            //Arrange
            Gauntlet<string> gauntlet = new Gauntlet<string>();
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
            Gauntlet<int> gauntlet = new Gauntlet<int>(); 
            int element1 = 1;
            int expected = element1;
            int actual;
            //Act 
            gauntlet.Collect(element1);
            actual = gauntlet[0];
            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        [ExpectedException (typeof(ArgumentOutOfRangeException))]
        public void Add_newGenericObjectToList_NewArraySizeisSufficientToHoldDouble()
        {
            //Arrange
            Gauntlet<string> gauntlet = new Gauntlet<string>();
            string object1 = "Look at Me";
            string expected = "Test";
            string actual;

            //Act
            gauntlet.Collect(object1);
            gauntlet.Collect(object1);
            gauntlet.Collect(object1);
            gauntlet.Collect(object1);
            gauntlet.Collect(object1);
            gauntlet[7] = expected;
            actual = gauntlet[7];

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_newGenericObjectToList_GenericObjectHasOwnIndice() 
        {
            //Arrange
            Gauntlet<string> gauntlet = new Gauntlet<string>();
            string object1 = "Victor";
            string object2 = "Nevin";
            string expected = "Victor";
            string actual;

            //Act
            gauntlet.Collect(object1);
            gauntlet.Collect(object2);
            actual = gauntlet[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_newIntObjectToList_IntObjectIsRecognizedAndOwnDefaultIsAdded() 
        {
            Gauntlet<int> gauntlet = new Gauntlet<int>();
            int element1 = 1;
            int expected = 1;
            int actual;

            gauntlet.Collect(element1);
            actual = gauntlet[0];

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_newBoolObjectToList_BoolObjectIsRecognized() 
        {
            Gauntlet<bool> gauntlet = new Gauntlet<bool>();
            bool element1 = true;
            bool expected = true;
            bool actual;

            gauntlet.Collect(element1);
            actual = gauntlet[0];

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_FiveBewObjects_ListCapIncreasesToDouble() 
        {
            Gauntlet<int> gauntlet = new Gauntlet<int>();
            int element1 = 1;
            int expected = 8;
            int actual;

            gauntlet.Collect(element1);
            gauntlet.Collect(element1);
            gauntlet.Collect(element1);
            gauntlet.Collect(element1);
            gauntlet.Collect(element1);

            actual = gauntlet.Capacity;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_GenericObject_CountDecreases() 
        {
            Gauntlet<int> gauntlet = new Gauntlet<int>();
            int element1 = 1;
            int expected = 0;
            int actual;

            gauntlet.Collect(element1);
            gauntlet.Lose(element1);
            actual = gauntlet.Count;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_ItemNotInList_RemoveDoesNotBreak() 
        {
            Gauntlet<int> gauntlet = new Gauntlet<int>();
            int element1 = 1;
            int expected = 1;
            int actual;

            gauntlet.Collect(element1);
            gauntlet.Lose(2);
            actual = gauntlet.Count;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_ItemsAreShiftedOneIndiceValue() 
        {
            Gauntlet<string> gauntlet = new Gauntlet<string>();
            string element1 = "Hello";
            string element2 = " ";
            string element3 = "World";
            string expected = "World";
            string actual;

            gauntlet.Collect(element1);
            gauntlet.Collect(element2);
            gauntlet.Collect(element3);
            gauntlet.Lose(element2);

            actual = gauntlet[1];

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_OnlyFirstInstance_OnlyFirstInstanceIsRemoved() 
        {
            Gauntlet<string> gauntlet = new Gauntlet<string>();
            string element1 = "Hello";
            string element2 = "World";
            string expected = "Hello";
            string actual;

            gauntlet.Collect(element1);
            gauntlet.Collect(element2);
            gauntlet.Collect(element1);
            gauntlet.Collect(element2);
            gauntlet.Collect(element1);
            gauntlet.Collect(element2);

            gauntlet.Lose(element1);
            actual = gauntlet[1];

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Remove_OneItem_CountOnlyDecreasesBy1() 
        {
            Gauntlet<string> gauntlet = new Gauntlet<string>();
            string element1 = "Hello";
            string element2 = "World";
            int expected = 5;
            int actual;

            gauntlet.Collect(element1);
            gauntlet.Collect(element2);
            gauntlet.Collect(element1);
            gauntlet.Collect(element2);
            gauntlet.Collect(element1);
            gauntlet.Collect(element2);

            gauntlet.Lose(element1);
            actual = gauntlet.Count;

            Assert.AreEqual(expected, actual);
        }

    }
}
