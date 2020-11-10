using System;

namespace MyLib
{
    public static class MyVariables
    {
        public static int EqualsType1(int a, int b)
        {
            if (b - a == 0)
                throw new Exception("\"b\" can't be equal to \"a\"");
            return ((5 * a - b * b) / (b - a));
        }

        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        public static double Division(int a, int b)
        {
            if (b == 0)
                throw new Exception("Paraneter b can't be equal zero");
            else
            {
                double big_a = a;
                double big_b = b;
                return big_a / big_b;
            }
        }
        
        public static int RemainderOfTheDivision(int a, int b)
        {
            if (b == 0)
                throw new Exception("Paraneter b can't be equal zero");
            else
                return a % b;
        }

        public static double EqualsType2(int a, int b, int c)
        {
            if (a == 0)
                throw new Exception("Parameter \"a\" can't be equal zero");
            else
                return (Division((c - b), a));
        }

        public static string StraightLineEquation(int x1, int y1, int x2, int y2)
        {
            if (x1 == x2 && y1 == y2)
                throw new Exception("Enter the different coordinates");
            if (x1 - x2 == 0)
                return ($"x = {x1}");
            double a = Division((y1 - y2), (x1 - x2));

            double b = y1 - a * x1;
            if (a != 0 && a != 1 && a != -1)
            {
                if (b > 0)
                    return ($"y = {a}x + {b}");
                else if (b == 0)
                    return ($"y = {a}x");
                else
                    return ($"y = {a}x {b}");
            }
            else if (a == 1)
            {
                if (b > 0)
                    return ($"y = x + {b}");
                else if (b == 0)
                    return ($"y = x");
                else
                    return ($"y = x {b}");
            }
            else if (a == -1)
            {
                if (b > 0)
                    return ($"y = -x + {b}");
                else if (b == 0)
                    return ($"y = -x");
                else
                    return ($"y = -x {b}");
            }
            else
                return ($"y = {b}");
        }
        
    }
}