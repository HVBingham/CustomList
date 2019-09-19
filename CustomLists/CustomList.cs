using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CustomLists
{
    public class CustomList<T>:IEnumerable
    {
         T[] array;
        int count;
        int capacity;
        public T this[int i]
        {
            get {
                if (i < 0 || i >= count)
                {
                    throw new ArgumentOutOfRangeException("Nope.No go.");
                }
                return array[i]; }
            set
            {
                if (i >= 0 || i < count)
                { array[i] = value; }
            }
        }
   
        public int Count
        {
            get { return count;}
        }
        public int Capacity
        {
            get{ return capacity; }
            set{ capacity = value;}
        }
        public CustomList()
        {
            capacity = 4;
            array = new T[capacity];
            count = 0;
            
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
            for (int i = 0; i < count; i++)
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
       
       
        public IEnumerator GetEnumerator()
        {
            for(int index = 0; index<Count; index++)
            {
                yield return array[index];
            }

        }
       public override string ToString()
        {
            StringBuilder sb = new StringBuilder();


        }
       
    }

}
