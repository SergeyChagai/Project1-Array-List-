using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib
{
    static public class My2DArray
    {
        static public int MinNumber(int[,] tab)
        {
            int min = tab[0, 0];
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    if (tab[i, j] < min)
                        min = tab[i, j];
                }
            }
            return min;
        }

        static public int MaxNumber(int[,] tab)
        {
            int max = tab[0, 0];
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    if (tab[i, j] > max)
                        max = tab[i, j];
                }
            }
            return max;
        }

        static public int[] IndexOfMinNumber(int[,] tab)
        {
            int[] coordinates = new int[2];
            int min_x = 0;
            int min_y = 0;
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    if (tab[i, j] < tab[min_x, min_y])
                    {
                        min_x = i;
                        min_y = j;
                    }
                }
            }
            coordinates[0] = min_x;
            coordinates[1] = min_y;
            return coordinates;
        }

        static public int[] IndexOfMaxNumber(int[,] tab)
        {
            int[] coordinates = new int[2];
            int max_x = 0;
            int max_y = 0;
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    if (tab[i, j] > tab[max_x, max_y])
                    {
                        max_x = i;
                        max_y = j;
                    }
                }
            }
            coordinates[0] = max_x;
            coordinates[1] = max_y;
            return coordinates;
        }

        static public int AmountOfNumbersWhoIsBiggerOfTheirNeighbors(int[,] arr)
        {
            int rep = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    bool left = (j != 0 && arr[i, j] > arr[i, j - 1]) || j == 0;
                    bool right = (j != arr.GetLength(1) - 1 && arr[i, j] > arr[i, j + 1]) || j == arr.GetLength(1) - 1;
                    bool up = (i != 0 && arr[i, j] > arr[i - 1, j]) || i == 0;
                    bool down = (i != arr.GetLength(0) - 1 && arr[i, j] > arr[i + 1, j]) || i == arr.GetLength(0) - 1;
                    if (left && right && up && down)
                        rep++;
                }
            }
            return rep;
        }

        static public int[,] TransposeOfMatix(int[,] arr)
        {
            int x = arr.GetLength(1);
            int y = arr.GetLength(0);
            int[,] arr2 = new int[y, x];

            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                    arr2[i, j] = arr[j, i];
            }
            return arr2;
        }
    }
}
