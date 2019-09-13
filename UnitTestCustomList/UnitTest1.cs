using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomLists;

namespace UnitTestCustomList
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_AddToCustomList_IntGoesToIndexOne()
        {
            // arrange
            CustomList<int> Numbers = new CustomList<int>();
            int expected = 1;
            int actual;
            //act
            Numbers.Add(1);
            Numbers.Add(4);
            Numbers.Add(3);
            actual = Numbers[0];
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_AddToCustomList_AddFiveorMoreToCustomList()
        {
            CustomList<int> Numbers = new CustomList<int>();
            int expected = 0;
            int actual;

            Numbers.Add(5);
            Numbers.Add(4);
            Numbers.Add(3);
            Numbers.Add(2);
            Numbers.Add(1);
            Numbers.Add(0);

            actual = Numbers[5];

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Count_AddItemsToList_CountTheList()
        {
            CustomList<int> Numbers = new CustomList<int>();
            int expected = 1;
            int actual;

            Numbers.Add(2);
            actual = Numbers.Count;

            Assert.AreEqual(expected, actual);
        }
        public void Remove_AddItemsToList_RomoveAnItemValue()
        {
            CustomList<int> Numbers = new CustomList<int>();
            int expected = 3;
            int actual;

            Numbers.Add(5);
            Numbers.Add(4);
            Numbers.Add(2);
            Numbers.Add(3);
            Numbers.Add(1);
            Numbers.Remove(3);
            actual = Numbers[2];



            Assert.AreEqual(expected, actual);
        }
        public void Remove_AddItemsToList_RemoveAnItemAtIndex()
        {
            CustomList<int> Numbers = new CustomList<int>();
            int expected = 4;
            int actual;

            Numbers.Add(9);
            Numbers.Add(7);
            Numbers.Add(5);
            Numbers.Add(3);
            Numbers.Add(1);
            Numbers.Add(2);
            Numbers.Add(4);
            Numbers.RemoveAt(5);
            actual = Numbers[5];

            Assert.AreEqual(expected, actual);
        }

        
    }
}
