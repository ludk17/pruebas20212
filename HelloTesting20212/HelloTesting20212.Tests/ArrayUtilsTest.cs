using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloTesting20212.Tests
{
    public class ArrayUtilsTest
    {
        [Test]
        public void SumaParesCaso01()
        {
            var au = new ArrayUtils();
            var result = au.SumaPares(new int[] { 1,2,2,3,4,6 });

            Assert.AreEqual(14, result);
        }

        [Test]
        public void SumaParesCaso02()
        {
            var au = new ArrayUtils();
            var result = au.SumaPares(new int[] { 1, 3 });

            Assert.AreEqual(0, result);
        }

        [Test]
        public void SumaParesCaso03()
        {
            var au = new ArrayUtils();
            var result = au.SumaPares(new int[] {1, -2, 2, -4 });

            Assert.AreEqual(-4, result);
        }

        [Test]
        public void SumaParesCaso04()
        {
            var au = new ArrayUtils();
            var result = au.SumaPares(new int[] {2,1,1,1,1,1,1 });

            Assert.AreEqual(2, result);
        }
    }
}
