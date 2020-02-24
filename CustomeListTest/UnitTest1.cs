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
            int cGaunletCount = gauntlet.Count;
            int expected = 1;
            int actual;

            //Act
            gauntlet.Collect(object1);
            actual = gauntlet.Count;
            
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_newGenericObjectToList_NewArrayIsCreated()
        {
            //Arrange
            Gauntlet<string> gauntlet = new Gauntlet<string>();
            string Soultone = "Soul";
            string expected = null;
            string actual;

            //Act
            gauntlet.Collect(Soultone);
            gauntlet.Collect(Soultone);
            gauntlet.Collect(Soultone);
            gauntlet.Collect(Soultone);
            gauntlet.Collect(Soultone);

            //Gotta add an indexing function

            //Assert
            
        }
        [TestMethod]
        public void Add_newGenericObjectToList_ObjectIsPlacedInProperListIndex()
        {
            //Arrange
            //Act 
            //Assert
        }
        [TestMethod]
        public void Add_newGenericObjectToList_NewArraySizeisSufficientToHoldDouble()
        {
            //Arrange
            //Act 
            //Assert
        }
        [TestMethod]
        public void Add_newGenericObjectToList_ErrorThrowsWhenMismatchedItemsareAdded()
        {
            //Arrange
            //Act 
            //Assert
        }
    }
}
