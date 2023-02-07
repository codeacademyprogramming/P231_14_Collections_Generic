using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    internal class MyIntList
    {
        public int[] Arr = new int[0];

        public void Add(int value)
        {
            Array.Resize(ref Arr, Arr.Length + 1);
            Arr[Arr.Length - 1] = value;
        }

        public void Remove(int index)
        {
            if (index < 0 || index >= Arr.Length)
                throw new IndexOutOfRangeException();


            for (int i = index; i < Arr.Length - 1; i++)
            {
                Arr[i] = Arr[i + 1];
            }


            Array.Resize(ref Arr, Arr.Length - 1);
        }
    }
}
