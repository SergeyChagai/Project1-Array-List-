using System;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace MyLib
{
    public static class MyBranching
    {
        public static int Condition1(int a, int b)
        {
            if (a > b)
                return (a + b);
            else if (a == b)
                return (a * b);
            else
                return (a - b);
        }

        public static string Quarters(int x, int y)
        {
            bool left = y == 0 && x < 0;
            bool right = y == 0 && x > 0;
            bool up = y > 0 && x == 0;
            bool down = y < 0 && x == 0;
            if (x > 0 && y > 0)
                return ("Точка в первой четверти (верхний правый угол)");
            else if (x < 0 && y > 0)
                return ("Точка во второй четверти (верхний левый угол)");
            else if (x < 0 && y < 0)
                return ("Точка в третьей четверти (нижний левый угол)");
            else if (x > 0 && y < 0)
                return ("Точка в четвертой четверти (нижний правый угол)");
            else if (left)
                return ("Точка на оси абсцисс слева");
            else if (right)
                return ("Точка на оси абсцисс справа");
            else if (up)
                return ("Точка на оси ординат сверху");
            else if (down)
                return ("Точка на оси ординат снизу");
            else
                return ("Точка в начале координат");
        }

        public static int[] Increase(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int min = i;
                for (int j = i; j < arr.Length; j++)
                    if (arr[j] < arr[min])
                        min = j;
                MyVariables.Swap(ref arr[i], ref arr[min]);
            }
            return arr;
        }

        public static double Sqrt(double a)
        {
            double s = 1;
            double i = 1;

            if (a < 0)
                throw new Exception("Parameter can't be negative");
            if (a == 0)
                return 0;
            while (s <= a && i > 0.0000000001)
            {
                if (s * s == a)
                    return s;
                else if ((s - 1 + i) * (s - 1 + i) == a)
                    return ((s - 1 + i));
                else if (s * s < a)
                    s += i;
                else if (s * s > a)
                {
                    s = s - i + i / 10;
                    i /= 10;
                }
                else if ((s + i) * (s + i) < a)
                {
                    s = s - 1 + i;
                    continue;
                }
                else if ((s - 1 + i) * (s - 1 + i) > a)
                {
                    i /= 10;
                    continue;
                }

            }
            return s;
            }

        public static string CallingNumber(int a)
        {
            string num = "";
            if (a / 10 < 1 || a / 10 > 9)
                throw new Exception("Two-digit only");
            if (a / 10 == 1 && a % 10 == 0)
                num += "десять";
            if (a / 10 == 2)
                num += ("два");
            if (a / 10 == 3 || (a / 10 == 1 && a % 10 == 3))
                num += ("три");
            if (a / 10 == 4)
                num += ("сорок ");
            if (a / 10 == 5 || (a / 10 == 1 && a % 10 == 5))
                num += ("пят");
            if (a / 10 == 6 || (a / 10 == 1 && a % 10 == 6))
                num += ("шест");
            if (a / 10 == 7 || (a / 10 == 1 && a % 10 == 7))
                num += ("сем");
            if (a / 10 == 8 || (a / 10 == 1 && a % 10 == 8))
                num += ("восем");
            if (a / 10 == 9)
                num += ("девяносто ");
            if (a / 10 != 1 && a / 10 < 4)
                num += ("дцать ");
            if (a / 10 >= 5 && a / 10 <= 8)
                num += ("ьдесят ");
            if (a / 10 == 1 && a % 10 == 1)
                num += ("один");
            if (a / 10 == 1 && a % 10 == 2)
                num += ("две");
            if (a / 10 == 1 && a % 10 == 4)
                num += ("четыр");
            if (a / 10 == 1 && a % 10 == 9)
                num += ("девят");
            if (a / 10 == 1 && a % 10 != 0)
                num += ("надцать\n");
            else
            {
                if (a % 10 == 1)
                    num += ("один");
                if (a % 10 == 2)
                    num += ("два");
                if (a % 10 == 3)
                    num += ("три");
                if (a % 10 == 4)
                    num += ("четыре");
                if (a % 10 == 5)
                    num += ("пять");
                if (a % 10 == 6)
                    num += ("шесть");
                if (a % 10 == 7)
                    num += ("семь");
                if (a % 10 == 8)
                    num += ("восемь");
                if (a % 10 == 9)
                    num += ("девять");
                num += "\n";
            }

            return num;
        }
    }
}
