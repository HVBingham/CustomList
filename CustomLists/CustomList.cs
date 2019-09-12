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
        public int Count
        {
            get
            {
                return count;
            }
        }



        public CustomList()
        {
            array = new T[4];
            count = 0;
        }
     
        public void DoubleArraySize()
        {
            T[] placeHolder = new T[4 * 2];
            for (int i = 0; i < 4; i++)
            {
                placeHolder[i]= array[i];
            }
            array = placeHolder;
        }
        public void Add(T value)
        {
           if(count == )
            {

                
            }

        }
    
    }
}
