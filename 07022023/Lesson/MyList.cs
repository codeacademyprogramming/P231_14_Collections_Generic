﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    internal class MyList<T>
    {
        public T[] Arr = new T[0];

        public void Add(T value)
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
