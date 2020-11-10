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
    }
}