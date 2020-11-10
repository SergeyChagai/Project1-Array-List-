﻿using System;
using System.Reflection;

namespace ArrayList
{
    public class ArrayList
    {
        private int[] _array;                       //поле массива
        public int Length { get; private set; }     //свойство объекта - полезная длина

        public ArrayList()                          //конструктор
        {
            _array = new int[3];
            Length = 0;
        }

        public void Add(int n)
        {
            if(Length >= _array.Length)
            {
                RizeSize();
            }
            _array[Length] = n;
            Length++;
        }

        public void AddToOrigin(int n)
        {
            if (Length >= _array.Length)
            {
                RizeSize();
            }
            int[] newArray = new int[_array.Length];
            for (int i = _array.Length - 1; i >= 0; i--)
            {
                newArray[i + 1] = _array[i];
            }
            _array = newArray;
            _array[0] = n;
            Length++;
        }

        public void AddToIndex(int index, int n)
        {
            if (Length >= _array.Length)
            {
                RizeSize();
            }
            int[] newArray = new int[_array.Length];
            for (int i = _array.Length - 1; i >= index; i--)
            {
                newArray[i + 1] = _array[i];
            }
            _array = newArray;
            _array[index] = n;
            Length++;
        }
        //public override bool Equals(object obj)
        //{
        //    bool rep = false;
        //    for (int i = 0; i < )
        //}

        private void RizeSize(int size = 1)
        {
            int newLength = _array.Length;
            while(newLength < _array.Length + size)
            {
                newLength = (int)(newLength * 1.33d + 1);
            }
            int[] newArray = new int[newLength];
            Array.Copy(_array, newArray, _array.Length);
            _array = newArray;
        }
    }
}
