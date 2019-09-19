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
        public void Add_AddToCustomList_AddFiveorMoreToCustomList1()
        {
            CustomList<int> Numbers = new CustomList<int>();
            int expected = 13;
            int actual;

            Numbers.Add(5);
            Numbers.Add(4);
            Numbers.Add(3);
            Numbers.Add(2);
            Numbers.Add(1);
            Numbers.Add(10);
            Numbers.Add(13);
            Numbers.Add(12);
            Numbers.Add(11);
            Numbers.Add(18);

            actual = Numbers[6];

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_AddItemsToList_CountTheList()
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
        public void ToString_TakeInItemsAndRemoveItems_ReturnThemAsAString1()
        {
            CustomList<int> Numbers = new CustomList<int>() { 3, 9, 2, 7, 2, 1, 6 };
            string expected = "3927216";
            string actual;

            
            actual = Numbers.ToString();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddLists_TakeInTwoLists_CombineListsToOne()
        {
            CustomList<int> list1 = new CustomList<int>() { 0, 1, 3, 4, 5, 6, 7 };
            CustomList<int> list2 = new CustomList<int>() { 9, 8, 3 };
            int expected = 9;
            int actual;

            CustomList<int> combinedLists = new CustomList<int>();
           
            combinedLists = list1 + list2;
            actual = combinedLists[7];
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddLists_TakeInTwoLists_CombineListsToOne1()
        {
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            int expected = 4;
            int actual;
            
            CustomList<int> combinedLists= new CustomList<int>();
            list1.Add(1);
            list1.Add(2);
            list1.Add(3);
            list2.Add(4);
            list2.Add(5);
            list2.Add(6);
            combinedLists= list1+list2;
            actual = combinedLists[3];
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
        public void SubtractLists_RemoveSameValue_RemoveOneListFromAnother()
        {
            CustomList<int> list1 = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> list2 = new CustomList<int>() { 4, 5, 2 };
            CustomList<int> subtractedLists = new CustomList<int>();
            int expected =3 ;
            int actual;

           
            subtractedLists = list1 - list2;
            actual = subtractedLists[1];

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SubtractLists_RemoveSameValue_RemoveOneListFromAnother2()
        {
            CustomList<int> list1 = new CustomList<int>() { 1, 2, 3, 6, 9, 10};
            CustomList<int> list2 = new CustomList<int>() { 4, 5, 2, 10};
            CustomList<int> subtractedLists = new CustomList<int>();
            int expected = 6;
            int actual;


            subtractedLists = list1 - list2;
            actual = subtractedLists[2];

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SubtractLists_RemoveSameValue_GetCountWhenOneListIsRemovedFromAnother()
        {
            CustomList<int> list1 = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> list2 = new CustomList<int>() { 4, 5, 2 };
            CustomList<int> subtractedLists = new CustomList<int>();
            int expected = 2;
            int actual;


            subtractedLists = list1 - list2;
            actual = subtractedLists.Count;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SubtractLists_RemoveSameValue_GetCountWhenOneListIsRemoved()
        {
            CustomList<int> list1 = new CustomList<int>() { 1, 2, 3,5,4,6 };
            CustomList<int> list2 = new CustomList<int>() { 4, 5, 2 };
            CustomList<int> subtractedLists = new CustomList<int>();
            int expected = 3;
            int actual;


            subtractedLists = list1 - list2;
            actual = subtractedLists.Count;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ZipLists_CombineLists_CpombineListsInOrder()
        {
            CustomList<int> list1 = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> list2 = new CustomList<int>() { 2, 4, 6 };
            CustomList<int> zipedLists = new CustomList<int>();
            int expected = 2;
            int actual;


            zipedLists=zipedLists.Zip(list1, list2);
            actual = zipedLists[1];

            Assert.AreEqual(expected, actual);
        }
       [TestMethod]
       public void ZipLists_CombineBothLists_GetCountWhenOneListsAreZipped()
        {
            CustomList<int> list1 = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> list2 = new CustomList<int>() { 2, 4, 6 };
            CustomList<int> zipedLists = new CustomList<int>();
            int expected = 6;
            int actual;

            zipedLists=zipedLists.Zip(list1, list2);
            actual = zipedLists.Count;
            Assert.AreEqual(expected, actual);
                
        }
    }


        

}       
    
