using NUnit.Framework;
using NUnit.Framework.Constraints;
using System;

namespace ArrayList.Tests
{
    public class Tests
    {
        [TestCase(1,1)]
        [TestCase(1,1)]
        [TestCase(1,1)]
        [TestCase(1,1)]
        public void Add(int case_arr, int case_expected_arr)
        {
            ArrayList arr = new ArrayList(ArrayMock(case_arr));
            ArrayList arr2 = new ArrayList(ArrayExpectedMock(case_expected_arr));

            arr.Add(10);
           
            if (arr.Equals(arr2))
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(1, new int[] { 6, 7 }, new int[] { 1, 2, 3, 4, 5, 6, 7 })]
        [TestCase(1, new int[] { }, new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(1, new int[] { 6, 7, 8, 9, 10 }, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 })]
        public void Add(int case_arr, int[] add, int[] expected)
        {
            ArrayList arr = new ArrayList(ArrayMock(case_arr));
            ArrayList arr2 = new ArrayList(expected);

            arr.Add(add);

            if (arr.Equals(arr2))
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(1, new int[] { 10, 1, 2, 3, 4, 5 })]
        [TestCase(2, new int[] { 10, 5, 4, 3, 2, 1 })]
        [TestCase(3, new int[] { 10, 999, 888, 777, 666, 555, 444, 333, 222, 111 })]
        [TestCase(4, new int[] { 10 })]
        public void AddToOrigin(int case_arr, int[] expected)
        {
            ArrayList arr = new ArrayList(ArrayMock(case_arr));
            ArrayList arr2 = new ArrayList(expected);

            arr.AddToOrigin(10);

            if (arr.Equals(arr2))
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 6, 7 }, new int[] { 6, 7, 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 200, 400 }, new int[] { 200, 400, 1, 2, 3 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 3, 8, 9 }, new int[] { 3, 8, 9, 1, 2, 3, 4, 5 })]
        public void AddToOrigin(int[] array, int[] add, int[] expected)
        {
            ArrayList arr = new ArrayList(array);
            ArrayList arr2 = new ArrayList(expected);

            arr.AddToOrigin(add);

            if (arr.Equals(arr2))
                Assert.Pass();
            Assert.Fail();
        }

        [TestCase(1, 0, new int[] { 10, 1, 2, 3, 4, 5 })]
        [TestCase(1, 5, new int[] { 1, 2, 3, 4, 5, 10})]
        [TestCase(1, 8, new int[] { 1, 2, 3, 4, 5, 0, 0, 0, 10 })]
        public void AddToIndex(int case_arr, int index, int[] expected)
        {
            ArrayList arr = new ArrayList(ArrayMock(case_arr));
            ArrayList arr2 = new ArrayList(expected);

            arr.AddToIndex(index, 10);

            if (arr.Equals(arr2))
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(2, new int[] { 6, 7 }, new int[] { 1, 2, 6, 7, 3, 4, 5 })]
        [TestCase(1, new int[] { 200, 400 }, new int[] { 1, 200, 400, 2, 3, 4, 5 })]
        [TestCase(0, new int[] { 3, 8, 9 }, new int[] { 3, 8, 9, 1, 2, 3, 4, 5 })]
        public void AddToIndex(int index, int[] add, int[] expected)
        {
            ArrayList arr1 = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            ArrayList arr2 = new ArrayList(expected);

            arr1.AddToIndex(index, add);

            if (arr1.Equals(arr2))
                Assert.Pass();
            Assert.Fail();
        }

        [TestCase(1, new int[] { 1, 2, 3, 4})]
        [TestCase(2, new int[] { 5, 4, 3, 2})]
        [TestCase(3, new int[] { 999, 888, 777, 666, 555, 444, 333, 222})]
        [TestCase(5, new int[] { })]
        public void Delete(int case_arr, int[] expected)
        {
            ArrayList arr = new ArrayList(ArrayMock(case_arr));
            ArrayList arr2 = new ArrayList(expected);

            arr.Delete();

            if (arr.Equals(arr2))
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(1, 2, new int[] { 1, 2, 3})]
        [TestCase(2, 0, new int[] { 5, 4, 3, 2, 1 })]
        [TestCase(3, 9, new int[] {  })]
        public void Delete(int case_arr, int amount, int[] expected)
        {
            ArrayList arr = new ArrayList(ArrayMock(case_arr));
            ArrayList arr2 = new ArrayList(expected);

            arr.Delete(amount);

            if (arr.Equals(arr2))
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(1, new int[] { 2, 3, 4, 5 })]
        [TestCase(2, new int[] { 4, 3, 2, 1 })]
        [TestCase(3, new int[] { 888, 777, 666, 555, 444, 333, 222, 111 })]
        [TestCase(5, new int[] { })]
        public void DeleteFromOrigin(int case_arr, int[] expected)
        {
            ArrayList arr = new ArrayList(ArrayMock(case_arr));
            ArrayList arr2 = new ArrayList(expected);

            arr.DeleteFromOrigin();

            if (arr.Equals(arr2))
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(1, 2, new int[] { 3, 4, 5 })]
        [TestCase(2, 0, new int[] { 5, 4, 3, 2, 1 })]
        [TestCase(3, 9, new int[] { })]
        public void DeleteFromOrigin(int case_arr, int amount, int[] expected)
        {
            ArrayList arr = new ArrayList(ArrayMock(case_arr));
            ArrayList arr2 = new ArrayList(expected);

            arr.DeleteFromOrigin(amount);

            if (arr.Equals(arr2))
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(1, 2, new int[] { 1, 2, 4, 5 })]
        [TestCase(1, 0, new int[] { 2, 3, 4, 5 })]
        [TestCase(1, 4, new int[] { 1, 2, 3, 4 })]
        [TestCase(5, 0, new int[] { })]
        public void DeleteFromIndex(int case_arr, int index, int[] expected)
        {
            ArrayList arr = new ArrayList(ArrayMock(case_arr));
            ArrayList arr2 = new ArrayList(expected);

            arr.DeleteFromIndex(index);

            if (arr.Equals(arr2))
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(1, 2, 2, new int[] { 1, 2, 5 })]
        [TestCase(1, 0, 0, new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(1, 4, 1, new int[] { 1, 2, 3, 4 })]
        [TestCase(5, 0, 1, new int[] { })]
        public void DeleteFromIndex(int case_arr, int index, int amount, int[] expected)
        {
            ArrayList arr = new ArrayList(ArrayMock(case_arr));
            ArrayList arr2 = new ArrayList(expected);

            arr.DeleteFromIndex(index, amount);

            if (arr.Equals(arr2))
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(0, 6)]
        [TestCase(-1, 1)]
        [TestCase(10000, 1)]
        public void DeleteFromIndexNegative(int index, int amount)
        {
            ArrayList arr = new ArrayList(ArrayMock(1));

            try { arr.DeleteFromIndex(index, amount); }
            catch { Assert.Pass(); }
            Assert.Fail();
        }

        [Test]
        public void Test6()
        {
            ArrayList arr = new ArrayList();

            arr.Add(3);
            arr.AddToOrigin(1);
            arr.AddToIndex(1, 2);
            arr.DeleteFromIndex(1);

            if (arr.Length == 2)
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void Test7()
        {
            ArrayList arr = new ArrayList();

            arr.Add(3);
            arr.AddToOrigin(1);
            arr.AddToIndex(1, 2);
            arr.DeleteFromIndex(1);

            if (arr.AccessToIndex(1) == 3)
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void Test8()
        {
            ArrayList arr = new ArrayList();

            arr.Add(3);
            arr.AddToOrigin(1);
            arr.AddToIndex(1, 2);
            arr.DeleteFromIndex(1);

            if (arr.IndexOfElement(3) == 1)
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void Test9()
        {
            ArrayList arr = new ArrayList();
            ArrayList arr2 = new ArrayList();

            arr.Add(3);
            arr.AddToOrigin(1);
            arr.AddToIndex(1, 2);
            arr.SetElement(1, 4);

            arr2.Add(1);
            arr2.Add(4);
            arr2.Add(3);
            if (arr.Equals(arr2))
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void Test10()
        {
            ArrayList arr = new ArrayList();
            ArrayList arr2 = new ArrayList();

            arr.Add(1);
            arr.Add(2);
            arr.Add(3);
            arr.Add(4);
            arr.Add(5);
            arr.Reverse();

            arr2.Add(5);
            arr2.Add(4);
            arr2.Add(3);
            arr2.Add(2);
            arr2.Add(1);
            if (arr.Equals(arr2))
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void Test11()
        {
            ArrayList arr = new ArrayList();

            arr.Add(1);
            arr.Add(2);
            arr.Add(3);
            arr.Add(4);
            arr.Add(5);
            
            if (arr.FindMax() == 5)
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void Test12()
        {
            ArrayList arr = new ArrayList();

            arr.Add(1);
            arr.Add(2);
            arr.Add(3);
            arr.Add(4);
            arr.Add(5);

            if (arr.FindMin() == 1)
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void Test13()
        {
            ArrayList arr = new ArrayList();

            arr.Add(1);
            arr.Add(2);
            arr.Add(3);
            arr.Add(4);
            arr.Add(5);

            if (arr.IndexOfMax() == 4)
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void Test14()
        {
            ArrayList arr = new ArrayList();

            arr.Add(1);
            arr.Add(2);
            arr.Add(3);
            arr.Add(4);
            arr.Add(5);

            if (arr.IndexOfMin() == 0)
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void Test15()
        {
            ArrayList arr = new ArrayList();
            ArrayList arr2 = new ArrayList();

            arr.Add(5);
            arr.Add(2);
            arr.Add(3);
            arr.Add(1);
            arr.Add(4);
            arr.SortIncrease();

            arr2.Add(1);
            arr2.Add(2);
            arr2.Add(3);
            arr2.Add(4);
            arr2.Add(5);
            if (arr.Equals(arr2))
                Assert.Pass();
            Assert.Fail();
        }

        [Test]
        public void Test16()
        {
            ArrayList arr = new ArrayList();
            ArrayList arr2 = new ArrayList();

            arr.Add(5);
            arr.Add(2);
            arr.Add(3);
            arr.Add(1);
            arr.Add(4);
            arr.SortDecrease();

            arr2.Add(5);
            arr2.Add(4);
            arr2.Add(3);
            arr2.Add(2);
            arr2.Add(1);
            if (arr.Equals(arr2))
                Assert.Pass();
            Assert.Fail();
        }

        [Test]
        public void Test17()
        {
            ArrayList arr = new ArrayList();
            ArrayList arr2 = new ArrayList();

            arr.Add(5);
            arr.Add(2);
            arr.Add(3);
            arr.Add(1);
            arr.Add(4);
            arr.DeleteFirstElementWhithValue(1);

            arr2.Add(5);
            arr2.Add(2);
            arr2.Add(3);
            arr2.Add(4);
            if (arr.Equals(arr2))
                Assert.Pass();
            Assert.Fail();
        }

        [Test]
        public void Test18()
        {
            ArrayList arr = new ArrayList();
            ArrayList arr2 = new ArrayList();

            arr.Add(5);
            arr.Add(2);
            arr.Add(5);
            arr.Add(1);
            arr.Add(5);
            arr.DeleteAllElementsWhitsValue(5);

            arr2.Add(2);
            arr2.Add(1);
            if (arr.Equals(arr2))
                Assert.Pass();
            Assert.Fail();
        }

        [Test]
        public void Test19()
        {
            ArrayList arr = new ArrayList();
            ArrayList arr2 = new ArrayList();

            int[] adding_arr = new int[] { 3, 4 };
            arr.Add(1);
            arr.Add(2);
            arr.Add(adding_arr);

            arr2.Add(1);
            arr2.Add(2);
            arr2.Add(3);
            arr2.Add(4);
            if (arr.Equals(arr2))
                Assert.Pass();
            Assert.Fail();
        }

        [Test]
        public void Test20()
        {
            ArrayList arr = new ArrayList();
            ArrayList arr2 = new ArrayList();

            int[] adding_arr = new int[] { 3, 4 };
            arr.Add(1);
            arr.Add(2);
            arr.AddToOrigin(adding_arr);

            arr2.Add(3);
            arr2.Add(4);
            arr2.Add(1);
            arr2.Add(2);
            if (arr.Equals(arr2))
                Assert.Pass();
            Assert.Fail();
        }

        

        

        private int[] ArrayMock(int i)
        {
            int[] arr;

            switch(i)
            {
                case 1:
                    arr = new int[] { 1, 2, 3, 4, 5 };
                    return arr;
                case 2:
                    arr = new int[] { 5, 4, 3, 2, 1 };
                    return arr;
                case 3:
                    arr = new int[] { 999, 888, 777, 666, 555, 444, 333, 222, 111 };
                    return arr;
                case 4:
                    arr = new int[] { };
                    return arr;
                case 5:
                    arr = new int[] { 1 };
                    return arr;
                default:
                    throw new Exception("Invalid value of parameter");
            }
        }

        private int[] ArrayExpectedMock(int i)
        {
            int[] arr;

            switch (i)
            {
                case 1:
                    arr = new int[] { 1, 2, 3, 4, 5, 10 };
                    return arr;
                case 2:
                    arr = new int[] { 5, 4, 3, 2, 1, 10};
                    return arr;
                case 3:
                    arr = new int[] { 999, 888, 777, 666, 555, 444, 333, 222, 111, 10 };
                    return arr;
                case 4:
                    arr = new int[] { 10 };
                    return arr;
                default:
                    throw new Exception("Invalid value of parameter");
            }
        }
    }
}