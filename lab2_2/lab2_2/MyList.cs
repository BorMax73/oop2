using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace lab2_2
{
    public class MyList<T>
    {
        public T[] list;

       
        public T this[int index]
        {
            get => list[index];
            set => list[index] = value;
        }

        public int Count
        {
            get => list.Length;
        }
        public void Append(T element)
        {

            Array.Resize(ref list, list.Length +1);
            list[list.Length -1] = element;
        }

    } 
}