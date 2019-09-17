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
        int capacity;
        public T this[int i]
        {
            get { return array[i]; }
            set { array[i] = value; }
        }
   
        public int Count
        {
            get { return count;}
        }

        public CustomList()
        {
            capacity = 4;
            array = new T[capacity];
            count = 0;
            
        }
        public IEnumerator<T> GetEnumerator(T Value)
        {

            for(int i=0; i<count; i++)
            {
                yield return array[i];
            }
        }
        private void IncreaseCapacity()
        {
            capacity += capacity;
        }
        private void DoubleArraySize()
        {
            T[] placeHolder = new T[capacity];
            for (int i = 0; i < count; i++)
            {
                placeHolder[i]= array[i];
            }
            array = placeHolder;
        }
        public void Add(T value)
        {
            if (CheckCapacity())
            {
                DoubleArraySize();
            }        
                array[count] = value;
                 count++;
        }
    
        private bool CheckCapacity()
        {
            if (capacity <= count)
            {
                IncreaseCapacity();
                return true;
            }
            else
            {
                return false;
            }
        }
      
    
        public void Remove(T Value)
        {
            for(int i = 0; i<count;i++)
                if (Value.Equals(array[i]))
                {
                    MoveIndexOver(i);
                    count--;
                }


        }
  

        private void MoveIndexOver(int intex)
        {
            int i;
           for(i=intex; i < count; i++)
            {
                array[i] = array[i + 1];
            }
            array[i] = default(T);

        }

    }
}
