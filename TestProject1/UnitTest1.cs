using NUnit.Framework;
using System.Collections.Generic;

namespace ogo
{
    public class Tests
    {
        Main sund;

        [SetUp]
        public void Setup()
        {
            sund = new Main();
        }

        [Test]
        public void TestList()
        {
            string[] chisla = { "3", "5", "7", "11", "17", "19"};
            string znach = null;
            int n = 10; sund.Init(n);
            znach = sund.Sundarammmm(n);
            var expected = chisla; Assert.AreEqual(expected, chisla);

        }
        
        [Test]
        public void Teststring()
        {
            string[] chisla = { "3", "5", "7", "11", "17", "19"};
            string znach = null;
            int n = 15; sund.Init(n);
            znach = sund.Sundarammmm(n);
            var expected = chisla; Assert.AreEqual(expected, chisla);

        }
        
        [Test]
        public void TestListMinus()
        {
            int n = -925; n = sund.Init(n);
            var actual = sund.Sundarammmm(n); string[] expected = null; Assert.AreEqual(expected, actual);
        }
        
        
        [Test]

        public void TestListLargeNumber()
        {
            int n = 23985; n = sund.Init(n);
            var actual = sund.Sundarammmm(n); string expected = null; Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestStringNull()
        {
            List<int> simpleNumbers = null;
            var actual = sund.ToStr(simpleNumbers); string expected = null; Assert.AreEqual(expected, actual);
        }
        
    }
}
