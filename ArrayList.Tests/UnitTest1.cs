using NUnit.Framework;

namespace ArrayList.Tests
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            ArrayList arr = new ArrayList();
            ArrayList arr2 = new ArrayList();

            arr.Add(3);
            arr.AddToOrigin(1);
            arr.AddToOrigin(2);

            arr2.Add(2);
            arr2.Add(1);
            arr2.Add(3);
            if (arr.Equals(arr2))
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void Test2()
        {
            ArrayList arr = new ArrayList();
            ArrayList arr2 = new ArrayList();

            arr.Add(3);
            arr.AddToOrigin(1);
            arr.AddToIndex(1, 2);

            arr2.Add(1);
            arr2.Add(2);
            arr2.Add(3);
            if (arr.Equals(arr2))
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void Test3()
        {
            ArrayList arr = new ArrayList();
            ArrayList arr2 = new ArrayList();

            arr.Add(3);
            arr.AddToOrigin(1);
            arr.Delete();

            arr2.Add(1);
            if (arr.Equals(arr2))
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void Test4()
        {
            ArrayList arr = new ArrayList();
            ArrayList arr2 = new ArrayList();

            arr.Add(3);
            arr.AddToOrigin(1);
            arr.DeleteFromOrigin();

            arr2.Add(3);
            if (arr.Equals(arr2))
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void Test5()
        {
            ArrayList arr = new ArrayList();
            ArrayList arr2 = new ArrayList();

            arr.Add(3);
            arr.AddToOrigin(1);
            arr.AddToIndex(1, 2);
            arr.DeleteFromIndex(1);

            arr2.Add(1);
            arr2.Add(3);
            if (arr.Equals(arr2))
            {
                Assert.Pass();
            }
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
            arr.ChangeElement(1, 4);

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
            arr.AddArray(adding_arr);

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
            arr.AddArrayToOrigin(adding_arr);

            arr2.Add(3);
            arr2.Add(4);
            arr2.Add(1);
            arr2.Add(2);
            if (arr.Equals(arr2))
                Assert.Pass();
            Assert.Fail();
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 6, 7 }, new int[] { 6, 7, 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { 1, 2, 3}, new int[] { 200, 400}, new int[] { 200, 400, 1, 2, 3 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 3, 8, 9 }, new int[] { 3, 8, 9, 1, 2, 3, 4, 5 })]
        public void AddArrayToOrigin(int[] array, int[] add, int[] expected)
        {
            ArrayList arr = new ArrayList(array);
            ArrayList arr2 = new ArrayList(expected);

            arr.AddArrayToOrigin(add);

            if (arr.Equals(arr2))
                Assert.Pass();
            Assert.Fail();
        }

        [TestCase(2, new int[] { 6, 7 }, new int[] {  1, 2, 6, 7, 3, 4, 5 })]
        [TestCase(1, new int[] { 200, 400 }, new int[] {  1, 200, 400, 2, 3, 4, 5 })]
        [TestCase(0, new int[] { 3, 8, 9 }, new int[] { 3, 8, 9, 1, 2, 3, 4, 5 })]
        public void AddArrayToIndex(int index, int[] add, int[] expected)
        {
            ArrayList arr1 = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            ArrayList arr2 = new ArrayList(expected);

            arr1.AddArrayToIndex(index, add);

            if (arr1.Equals(arr2))
                Assert.Pass();
            Assert.Fail();
        }


    }
}