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

        public ArrayList()                          //конструктор1
        {
            _array = new int[3];
            Length = 0;
        }

        public ArrayList(int n)                     //конструктор2
        {
            _array = new int[3];
            _array[0] = n;
            Length = 1;
        }

        public ArrayList(int[] arr)                 //конструктор3
        {
            _array = new int[arr.Length];
            Array.Copy(arr, _array, arr.Length);
            Length = arr.Length;
        }

        public int this[int index]                  //переопределение индексатора
        {
            get
            {
                if (index > Length || index < 0)
                    throw new IndexOutOfRangeException();
                return _array[index];
            }
            set
            {
                if (index > Length || index < 0)
                    throw new IndexOutOfRangeException();
                _array[index] = value;
            }
        }

        public void Add(int n)                      //добавление числа в конец списка
        {
            if (Length >= _array.Length)
            {
                RizeSize();
            }
            this[Length] = n;
            Length++;
        }

        public void Add(int[] arr)                  //добавление нескольких чисел в конец списка
        {
            Cut();
            if (Length + arr.Length >= _array.Length)
                RizeSize(Length + arr.Length - _array.Length);
            for (int i = 0; i < arr.Length; i++)
            {
                _array[Length + i] = arr[i];
            }
            Length += arr.Length;
        }


        public void AddToOrigin(int n)              //добавление числа в начало списка
        {
            if (Length >= _array.Length)
            {
                RizeSize();
            }
            int[] newArray = new int[_array.Length];
            for (int i = Length - 1; i >= 0; i--)
            {
                newArray[i + 1] = this[i];
            }
            _array = newArray;
            _array[0] = n;
            Length++;
        }

        public void AddToOrigin(int[] arr)          //добавление нескольких чисел в начало списка
        {
            int[] newArray = new int[arr.Length + Length];
            Array.Copy(arr, newArray, arr.Length);
            Array.Copy(_array, 0, newArray, arr.Length, Length);
            _array = newArray;
            Length += arr.Length;
        }

        public void AddToIndex(int index, int n)
        {
            if (index < 0)
                throw new Exception("Index can not be negative");
            if (index >= Length)
                Length = index;
            while (Length >= _array.Length)
            {
                RizeSize();
            }
            int[] newArray = new int[_array.Length];
            Array.Copy(_array, newArray, index);
            for (int i = index; i < Length; i++)
            {
                newArray[i + 1] = _array[i];
            }
            _array = newArray;
            _array[index] = n;
            Length++;
            Cut();
        }

        public void AddToIndex(int index, int[] arr)
        {
            if (index < 0)
                throw new IndexOutOfRangeException("Invalid value of index");
            if (index < Length)
            {
                int[] newArray = new int[arr.Length + Length];
                Array.Copy(_array, newArray, index);                        //копирование до индекса
                Array.Copy(arr, 0, newArray, index, arr.Length);            //копирование массива начиная с индекса
                Array.Copy(_array, index, newArray, arr.Length + index, _array.Length - index);
                _array = newArray;
                Length += arr.Length;
            }
            else
            {
                int[] newArray = new int[index + arr.Length];
                Array.Copy(_array, newArray, _array.Length);
                int i = _array.Length;
                while (i < index)
                    i++;
                Array.Copy(arr, 0, newArray, i, arr.Length);
                _array = newArray;
                Length += arr.Length;
            }
        }

        public void Delete()
        {
            if (Length == 0)
                return;
            Length--;
            if (Length <= _array.Length / 2)
            {
                ReduceSize();
            }
        }

        public void Delete(int n)
        {
            if (n < 0)
                throw new ArgumentOutOfRangeException("Argument can't be negative");
            if (n > Length)
                n = Length;
            if (n > 0)
            {
                Length -= n;
                if (Length <= _array.Length / 2)
                {
                    ReduceSize();
                }
            }
        }

        public void DeleteFromOrigin()
        {
            if (Length == 0)
                throw new Exception("List is empty");
            int[] newArray = new int[_array.Length];
            for (int i = 0; i + 1 < Length; i++)
            {
                newArray[i] = _array[i + 1];
            }
            if (Length <= _array.Length / 2)
            {
                ReduceSize();
            }
            _array = newArray;
            Length--;
        }

        public void DeleteFromOrigin(int n)
        {
            if (Length == 0)
                throw new Exception("List is empty");
            int[] newArray = new int[_array.Length - n];
            Array.Copy(_array, n, newArray, 0, newArray.Length);
            if (Length <= _array.Length / 2)
            {
                ReduceSize();
            }
            _array = newArray;
            Length-=n;
        }

        public void DeleteFromIndex(int index)
        {
            if (index < 0)
                throw new ArgumentOutOfRangeException("Index can not be negative");
            if (index >= Length)
                throw new IndexOutOfRangeException();

            int[] newArray = new int[_array.Length];
            Array.Copy(_array, newArray, index);
            for (int i = index; i + 1 < Length; i++)
            {
                newArray[i] = _array[i + 1];
            }
            _array = newArray;
            Length--;
        }

        public void DeleteFromIndex(int index, int amount)
        {
            if (index < 0)
                throw new ArgumentOutOfRangeException("Index can't be negative");
            if (index >= Length)
                return;
            if (index + amount > Length)
                amount = Length - index;

            int end_of_hole = index + amount;
            int[] newArray = new int[_array.Length];
            Array.Copy(_array, newArray, index);
            Array.Copy(_array, end_of_hole, newArray, index, Length - end_of_hole);
            
            _array = newArray;
            Cut();
            Length -= amount;
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
            throw new ArgumentException("List does not contain this element");
        }

        public void SetElement(int index, int n)
        {
            if (index < 0)
                throw new ArgumentOutOfRangeException("index can't be negative");
            if (index >= Length)
                AddToIndex(index, n);
            else
                this[index] = n;
        }
        public override bool Equals(Object obj)
        {
            ArrayList arrayList = (ArrayList)obj;

            for (int i = 0; i < this.Length || i < arrayList.Length; i++)
            {
                if (this._array[i] != arrayList._array[i])
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
            if (Length == 0)
                throw new Exception("List is empty");
            int max = _array[0];
            for (int i = 1; i < Length; i++)
            {
                max = _array[i] > max ? _array[i] : max;
            }
            return max;
        }

        public int FindMin()
        {
            if (Length == 0)
                throw new Exception("List is empty");
            int min = _array[0];
            for (int i = 1; i < Length; i++)
            {
                min = _array[i] < min ? _array[i] : min;
            }
            return min;
        }

        public int IndexOfMax()
        {
            if (Length == 0)
                throw new Exception("List is empty");
            int i_max = 0;
            for (int i = 1; i < Length; i++)
            {
                i_max = _array[i] > _array[i_max] ? i : i_max;
            }
            return i_max;
        }

        public int IndexOfMin()
        {
            if (Length == 0)
                throw new Exception("List is empty");
            int i_min = 0;
            for (int i = 1; i < Length; i++)
            {
                i_min = _array[i] < _array[i_min] ? i : i_min;
            }
            return i_min;
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
            for (int i = 0; i < Length; i++)
            {
                if (_array[i] == n)
                {
                    DeleteFromIndex(i);
                    return;
                }
            }
        }

        public void DeleteAllElementsWhithValue(int n)
        {
            for (int i = 0; i < Length; i++)
            {
                if (_array[i] == n)
                    DeleteFromIndex(i);
            }
        } 
        
        //public void DeleteNElementsFromOrigin(int n)
        //{
        //    int[] newArray = new int[Length - n];
        //    Array.Copy(_array, n, newArray, 0, Length - n);
        //    Length -= n;
        //}

        //public void DeleteNElementsFromIndex(int index, int n)
        //{
        //    if (index < 0 || index >= Length)
        //        throw new Exception("Invalid value of index");
        //    int[] newArray = new int[Length - n];
        //    Array.Copy(_array, newArray, index);
        //    Array.Copy(_array, index + n, newArray, index, Length - index - n);
        //    Length -= n;
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

        private void ReduceSize(int size = 1)
        {
            int newLength = _array.Length;
            while (newLength > _array.Length - size)
            {
                newLength = (_array.Length == 1) ? (int)(newLength * 0.66d) : 0;
            }
            int[] newArray = new int[newLength];
            if (newLength > 0)
                Array.Copy(_array, newArray, _array.Length);
            _array = newArray;
        }

        private void Cut()
        {
            int[] newArray = new int[Length];
            Array.Copy(_array, newArray, Length);
            _array = newArray;
        }
    }
}
