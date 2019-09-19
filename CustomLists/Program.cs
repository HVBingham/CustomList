using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLists
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> list1 = new CustomList<int>()
            {1,2,3};
           
            CustomList<int> list2 = new CustomList<int>() { 1, 4, 5 };
            CustomList<int> list;
            list = list1 - list2;
            Console.WriteLine(list.GetEnumerator());
            Console.ReadLine();

           

        }
    }
}
