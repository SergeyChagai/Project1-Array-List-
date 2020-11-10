using MyLib;
using System;
using System.Reflection;
using System.Text;

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
            if (Length >= _array.Length)
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
            for (int i = Length - 1; i >= 0; i--)
            {
                newArray[i + 1] = _array[i];
            }
            _array = newArray;
            _array[0] = n;
            Length++;
        }

        public void AddToIndex(int index, int n)
        {
            if (index < 0)
                throw new Exception("Index can not be negative");
            if (index >= Length)
                Length = index + 1;
            while (Length >= _array.Length)
            {
                RizeSize();
            }
            int[] newArray = new int[_array.Length];
            Array.Copy(_array, newArray, index);
            for (int i = Length - 1; i >= index; i--)
            {
                newArray[i + 1] = _array[i];
            }
            _array = newArray;
            _array[index] = n;
            Length++;
        }

        public void Delete()
        {
            if (Length <= _array.Length / 2)
            {
                ReduceSize();
            }
            Length--;
        }

        public void DeleteFromOrigin()
        {
           
            int[] newArray = new int[_array.Length];
            for (int i = 0; i < Length; i++)
            {
                if (Length > 1)
                    newArray[i] = _array[i + 1];
            }
            if (Length <= _array.Length / 2)
            {
                ReduceSize();
            }
            _array = newArray;
            Length--;
        }

        public void DeleteFromIndex(int index)
        {
            if (index < 0)
                throw new Exception("Index can not be negative");
            if (index >= Length)
                throw new Exception("Element whith this index does not exist");
            
            int[] newArray = new int[_array.Length];
            Array.Copy(_array, newArray, index);
            for (int i = index; i + 1 < Length; i++)
            {
                newArray[i] = _array[i + 1];
            }
            _array = newArray;
            Length--;
        }

        public int AccessToIndex(int i)
        {
            if (i >= Length)
                throw new Exception("Element whith this index does not exist");
            return _array[i];
        }

        public int IndexOfElement(int n)
        {
            for(int i = 0; i < Length; i++)
            {
                if (_array[i] == n)
                    return i;
            }
            throw new Exception("List does not contain this element");
        }

        public void ChangeElement(int index, int n)
        {
            if (index >= Length)
                throw new Exception("List does not contain this element");
            _array[index] = n;
        }
        public bool Equals(ArrayList obj)
        {
            for (int i = 0; i < this.Length || i < obj.Length; i++)
            {
                if (this._array[i] != obj._array[i])
                    return false;
            }
            return true;
        }

        public void Reverse()
        {
            int[] newArray = new int[_array.Length];
            for(int i = 0; i < Length; i++)
            {
                newArray[i] = _array[Length - i - 1];
            }
            _array = newArray;
        }

        public int FindMax()
        {
            int max = _array[0];
            for (int i = 1; i < Length; i++)
            {
                max = _array[i] > max ? _array[i] : max;
            }
            return max;
        }

        public int FindMin()
        {
            int min = _array[0];
            for (int i = 1; i < Length; i++)
            {
                min = _array[i] < min ? _array[i] : min;
            }
            return min;
        }

        public int IndexOfMax()
        {
            int i_max = 0;
            for (int i = 1; i < Length; i++)
            {
                i_max = _array[i] > _array[i_max] ? i : i_max;
            }
            return i_max;
        }

        public int IndexOfMin()
        {
            int i_min = 0;
            for (int i = 1; i < Length; i++)
            {
                i_min = _array[i] < _array[i_min] ? i : i_min;
            }
            return i_min;
        }

        private void Cut()
        {
            int[] newArray = new int[Length];
            Array.Copy(_array, newArray, Length);
            _array = newArray;
        }

        public void SortIncrease()
        {
            Cut();
            int[] newArray = MyArray.SortIncrease(_array);
            _array = newArray;
        }
        public void SortDecrease()
        {
            Cut();
            int[] newArray = MyArray.SortDecrease(_array);
            _array = newArray;
        }

        public void DeleteFirstElementWhithValue(int n)
        {
            DeleteFromIndex(IndexOfElement(n));
        }

        public void DeleteAllElementsWhitsValue(int n)
        {
            for (int i = 0; i < Length; i++)
            {
                if (_array[i] == n)
                    DeleteFromIndex(i);
            }
        }

        public void AddArray(int[] arr)
        {
            Cut();
            if (Length + arr.Length >= _array.Length)
                RizeSize(Length + arr.Length - _array.Length);
            for (int i = 0; i < arr.Length; i++)
            {
                _array[Length + i] = arr[i];
            }
        }

        public void AddArrayToOrigin(int[] arr)
        {
            int[] newArray = new int[arr.Length + Length];
            Array.Copy(arr, newArray, arr.Length);
            Array.Copy(_array, 0, newArray, arr.Length, Length);
            _array = newArray;
        }
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

        private void ReduceSize(int size = 1)
        {
            int newLength = _array.Length;
            while (newLength > _array.Length - size)
            {
                newLength = (int)(newLength * 0.66d);
            }
            int[] newArray = new int[newLength];
            Array.Copy(_array, newArray, _array.Length);
            _array = newArray;
        }

    }
}
