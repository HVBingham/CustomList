using CustomLists;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
        [TestMethod]
        public void Remove_RemoveItemFromList_RomoveAnItemValueFromList()
        {
            CustomList<int> Numbers = new CustomList<int>();
            int expected = 1;
            int actual;

            Numbers.Add(5);
            Numbers.Add(4);
            Numbers.Add(2);
            Numbers.Add(3);
            Numbers.Add(1);
            Numbers.Remove(3);
            actual = Numbers[3];



            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_RemoveItemFromList_RemoveMultipleItemValuesFromList()
        {
            CustomList<int> Numbers = new CustomList<int>();
            int expected = 7;
            int actual;

            Numbers.Add(5);
            Numbers.Add(4);
            Numbers.Add(2);
            Numbers.Add(3);
            Numbers.Add(1);
            Numbers.Add(0);
            Numbers.Add(6);
            Numbers.Add(7);
            Numbers.Add(9);
            Numbers.Add(8);
            Numbers.Remove(6);
            Numbers.Remove(1);
            Numbers.Remove(0);
            actual = Numbers[4];

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_RemoveItemsFromList_CountTheNewList()
        {
            CustomList<int> Numbers = new CustomList<int>();
            int expected = 3;
            int actual;

            Numbers.Add(5);
            Numbers.Add(4);
            Numbers.Add(2);
            Numbers.Add(9);
            Numbers.Add(8);
            Numbers.Remove(9);
            Numbers.Remove(8);
            actual = Numbers.Count;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToString_TakeInItems_ReturnThemAsAString()
        {
            CustomList<int> Numbers = new CustomList<int>();
            string expected = "543210";
            string actual;

            Numbers.Add(5);
            Numbers.Add(4);
            Numbers.Add(3);
            Numbers.Add(2);
            Numbers.Add(1);
            Numbers.Add(0);
            actual= Numbers.ToString();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ToString_TakeInItem_ReturnItAsAString()
        {
            CustomList<int> Numbers = new CustomList<int>();
            string expected = "5";
            string actual;

            Numbers.Add(5);
           
            actual = Numbers.ToString();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ToString_TakeInItemsAndRemoveItems_ReturnThemAsAString()
        {
            CustomList<int> Numbers = new CustomList<int>();
            string expected = "5420";
            string actual;

            Numbers.Add(5);
            Numbers.Add(4);
            Numbers.Add(3);
            Numbers.Add(2);
            Numbers.Add(1);
            Numbers.Add(0);
            Numbers.Remove(3);
            Numbers.Remove(1);
            actual = Numbers.ToString();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddLists_TakeInTwoLists_CombineListsToOne()
        {
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            CustomList<int> expected = new CustomList<int>();
            CustomList<int> combinedLists = new CustomList<int>();
            expected.Add(1);
            expected.Add(2);
            expected.Add(3);
            expected.Add(4);
            expected.Add(5);
            expected.Add(6);
            CustomList<int> actual = new CustomList<int>();

            list1.Add(1);
            list1.Add(2);
            list1.Add(3);
            list2.Add(4);
            list2.Add(5);
            list2.Add(6);
            combinedLists= list1+list2;
            actual = combinedLists;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddLists_TakeInTwoLists_CountCombinedLists()
        {
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            CustomList<int> combinedLists = new CustomList<int>();
            int expected = 6;
            int actual;
          
            list1.Add(1);
            list1.Add(2);
            list1.Add(3);
            list2.Add(4);
            list2.Add(5);
            list2.Add(6);
            combinedLists  = list1 + list2;
            actual = combinedLists.Count;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddLists_TakeInTwoLists_CountCombinedListsIfOneListIsEmpty()
        {
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            CustomList<int> combinedLists = new CustomList<int>();
            int expected = 3;
            int actual;

            list1.Add(1);
            list1.Add(2);
            list1.Add(3);
            combinedLists = list1 + list2;
            actual = combinedLists.Count;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        

    }
        
    
}
