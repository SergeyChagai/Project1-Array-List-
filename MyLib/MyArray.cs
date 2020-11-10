using System;

namespace MyLib
{
    public static class MyArray
    {
        static public int MinNumber(int[] numbers)
        {
            int temp = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < temp)
                    temp = numbers[i];
            }
            return temp;
        }

        static public int MaxNumber(int[] numbers)
        {
            int rep = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > rep)
                    rep = numbers[i];
            }
            return rep;
        }

        static public int IndexMin(int[] numbers)
        {
            int rep = 0;
            int temp = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < temp)
                {
                    temp = numbers[i];
                    rep = i;
                }
            }
            return rep;
        }

        static public int IndexMax(int[] numbers)
        {
            int rep = 0;
            int temp = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > temp)
                {
                    temp = numbers[i];
                    rep = i;
                }
            }
            return rep;
        }

        static public int SumOfNumbersWhoHasImpairIndex(int[] arr)
        {
            int rep = 0;
            for (int i = 1; i < arr.Length; i += 2)
                rep += arr[i];
            return rep;
        }

        static public int[] ReverseArray(int[] arr)
        {
            int length = arr.Length;
            for (int i = 0; i < length / 2; i++)
            {
                int temp = arr[i];
                arr[i] = arr[length - i - 1];
                arr[length - i - 1] = temp;
            }
            return arr;
        }

        static public int NumberOfImpairElements(int[] arr)
        {
            int rep = 0;
            int length = arr.Length;
            for (int i = 0; i < length; i++)
            {
                if (arr[i] % 2 != 0)
                    rep++;
            }
            return rep;
        }

        static public int[] HalfSwap(int[] arr)
        {
            int[] rep = new int[arr.Length];
            Array.Copy(arr, rep, arr.Length);
            int length = rep.Length;
            for (int i = 0; i < length / 2; i++)
            {
                int temp = rep[i];
                if (length % 2 == 0)
                {
                    rep[i] = rep[length / 2 + i];
                    rep[length / 2 + i] = temp;
                }
                else
                {
                    rep[i] = rep[length / 2 + i + 1];
                    rep[length / 2 + i + 1] = temp;
                }
            }
            return rep;
        }

        static public int[] SortIncrease(int[] arr)
        {
            int length = arr.Length;
            for (int i = 0; i < length; i++)        //внешний цикл дает указание двигаться вправо, когда предыдущий элемент встал на свое место
            {
                int min = i;                                //в переменную max сохраняем индекс (указание, какой по счету это элемент в массиве) минимального числа, пока что это будет i, то есть число, на котором остановился в данный момент внешний цикл
                for (int j = i; j < length; j++)    //внутренний массив ищет минимальное число из еще неотсортированных чисел (поэтому сначала j = i, т.к. это первое неотсортированное число)
                {
                    if (arr[j] < arr[min])          //если выполняется, что какое-то число больше, чем то, которое сейчас записано как минимальное, записываем индекс этого числа
                        min = j;
                }
                int temp = arr[i];                      //после того, как нашли минимальное число из неотсортированных, меняем местами это минимальное число и то,
                arr[i] = arr[min];                  //что было в начале неотсортированного участка, после чего наш массив становится на 1 элемент более упорядоченным
                arr[min] = temp;
            }
            return arr;
        }

        static public int[] SortDecrease(int[] arr)
        {
            int temp;
            int length = arr.Length;
            //перебор массива вставкой
            for (int i = 1; i < length; i++)
                for (int j = i; j > 0 && arr[j - 1] < arr[j]; j--)
                {
                    temp = arr[j - 1];
                    arr[j - 1] = arr[j];
                    arr[j] = temp;
                }
            return arr;
        }
    }
}
