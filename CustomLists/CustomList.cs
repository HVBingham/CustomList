using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLists
{
    public class CustomList<T>
    {
        T[] array;
        int count;
        public T this[int i]
        {
            get { return array[i]; }
            set { array[i] = value; }
        }



        public CustomList()
        {
            array = new T[4];
            count = 0;
        }
     

        public void Add(T value)
        {
            if (count == 0)
            {
                
            }

        }
        public void Count(T value)
        {

        }

    }
}
