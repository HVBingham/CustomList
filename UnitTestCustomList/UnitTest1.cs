using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomLists;

namespace UnitTestCustomList
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_AddToCustomList_IntGoesToIndexZero()
        {
            // arrange
            CustomList<int> Numbers = new CustomList<int>();
            int expected = 1;
            int actual;
            //act
            Numbers.Add(1);
            actual = Numbers[0];

            //assert
            Assert.AreEqual(expected, actual);

        }
    }
}
