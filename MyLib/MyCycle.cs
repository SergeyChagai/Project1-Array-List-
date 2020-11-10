using System;

namespace MyLib
{
    public static class MyCycle
    {
        public static double Degree(int num, int pow)
        {
            double degree = 1;
            if (pow >= 0)
            {
                for (int i = 0; i < pow; i++)
                    degree = degree * num;
                return degree;
            }
            else
                throw new Exception("Parameter \"pow\" should be positive or equal to zero");
        }

        public static int[] NumWhoDivide(int num, int rightboarder)
        {
            int[] rep = new int[rightboarder / num];
            int j = 0;
            for(int i = num; i <= rightboarder; i+=num)
            {
                if (i % num == 0)
                    rep[j] = i;
                j++;
            }
            return rep;
        }
        public static int AmountOfNumSquareLessThan(int a)
        {
            if (a <= 0)
                throw new Exception("Paraneter should be positive");
            int s = 0;

            while (s * s < a)
                s++;
            return s - 1;
        }
        public static int BiggerDividerOf(int a)
        {
            if (a == 0)
                throw new Exception("Parameter can't be equal to zero");
            int rep = 1;
            bool flag = (a < 0) ? true : false;
            if (flag)
                a *= -1;

            for (int i = 1; i <= a / 2; i++)
            {
                if (a % i == 0)
                    rep = i;
            }
            if (flag)
                return rep * -1;
            else
                return rep;
        }

        public static int SumOfDivisibleNum(int div, int left, int right)
        {
            int rep = 0;

            if (left > right)
                MyVariables.Swap(ref left, ref right);

            while (left <= right)
            {
                if (left % div == 0)
                {
                    rep += left;
                    //Console.Write(left + " ");               чтобы вывести промежуточные значения
                }
                left++;
            }
            return rep;
        }
        public static int NumOfFibonacci(int n)
        {
            if (n <= 0)
                throw new Exception("Parameter should be positive");
            int f = 1;
            int f_n_1 = 1;                                          //это для записи предыдущего числа

            for (int i = 3; i <= n; i++)
            {
                int buf = f;
                f += f_n_1;
                f_n_1 = buf;
            }

            return f;
        }
        public static int GreatestCommonFactor(int a, int b)
        {

            if (a < b)
            {
                int buf = a;
                a = b;
                b = buf;
            }

            while (b != 1)
            {
                if (a % b == 0)
                    return b;
                a = a % b;
                MyVariables.Swap(ref a, ref b);
            }

            return b;
        }
        public static double CubicRoot(double n)
        {
            bool flag = false;
            if (n < 0)
            {
                flag = true;
                n *= -1;
            }
            double rightBoarder = n;
            double leftBoarder = 0;
            double midPoint = 0;

            while (rightBoarder - leftBoarder >= 0.000001)
            {
                midPoint = (leftBoarder + rightBoarder) / 2;

                if (midPoint * midPoint * midPoint == n)
                    break;
                if (midPoint * midPoint * midPoint > n)
                {
                    rightBoarder = midPoint;
                }
                else
                {
                    leftBoarder = midPoint;
                }
            }
            if (flag)
                return midPoint * -1;
            else
                return midPoint;
        }
        public static int ImpairDigits(int a)
        {
            int rep = 0;

            while (a % 10 != 0)
            {
                if ((a % 10) % 2 != 0)
                    rep++;
                a /= 10;
            }
            return rep;
        }
        public static int ReverseNum(int a)
        {
            int b = 0;

            if (a < 0)
                a *= -1;

            while (a != 0)
            {
                b = (b * 10) + (a % 10);
                a /= 10;
            }
            return b;
        }

        public static int PairImpair(int a, int n)      //a - левая граница диапазона, n - правая
        {
            int x = 0;

            if (a > n)
            {
                int temp = a;
                a = n;
                n = temp;
            }
            
            for (int i = a; i <= n; i++)
            {
                int sum_p = 0;
                int sum_imp = 0;
                int buf = i;

                while (buf != 0)
                {
                    if ((buf % 10) != 0 && (buf % 10) % 2 == 0)
                        sum_p += buf % 10;
                    else if ((buf % 10) != 0 && (buf % 10) % 2 != 0)
                        sum_imp += buf % 10;
                    buf /= 10;
                }
                if (sum_p < 0)
                    sum_p *= -1;
                if (sum_imp < 0)
                    sum_imp *= -1;
                if (sum_p > sum_imp)
                    x++;
            }
            return x;
        }
        public static bool SameDigits(int a, int b)
        {
            bool rep = false;

            if (a < 0)
                a *= -1;
            if (b < 0)
                b *= -1;
            int temp = b;
            while (a != 0)
            {
                while (b != 0)
                {
                    if (a % 10 == b % 10)
                    {
                        rep = true;
                        break;
                    }
                    b /= 10;
                }
                b = temp;
                a /= 10;
            }
            return rep;
        }
    }
}
