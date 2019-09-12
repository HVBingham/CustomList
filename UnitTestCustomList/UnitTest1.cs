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
            Numbers.Add(2);
            Numbers.Add(3);
            actual = Numbers[1];
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_AddToCustomList_AddFiveorMoreToCustomList()
        {
            CustomList<int> Numbers = new CustomList<int>();
            int expected = 5;
            int actual;

            Numbers.Add(0);
            Numbers.Add(1);
            Numbers.Add(2);
            Numbers.Add(3);
            Numbers.Add(4);
            Numbers.Add(5);
            actual = Numbers[5];

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]


    }
}
