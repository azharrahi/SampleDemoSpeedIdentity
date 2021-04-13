using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Tests
{
    [TestClass()]
    public class BucketTests
    {
        Bucket bucket = null;
        [TestInitialize]
        public void Initialize()
        {
            bucket = new Bucket();
        }

        [DataTestMethod]
        [DataRow(new int[] { 6, 1, 4, 21, 12, 43, 16 }, new int[] { 43, 21, 16, 12, 6, 4, 1 })]
        [DataRow(new int[] { 6, 1, 4, 21, 12, 43, 16 }, new int[] { 43, 21, 16, 12, 6, 4, 1 })]
        [DataRow(new int[] { 5, 3, 1, 33, 29, 45, 46 }, new int[] { 46, 45, 33, 29, 5, 3, 1 })]
        [DataRow(new int[] { 16, 13, 43, 31, 22, 33, 6 }, new int[] { 43, 33, 31, 22, 16, 13, 6})]
        [TestMethod()]
        public void Sort_Numbers_By_Desc(int[] Array, int[] comparedArray)
        {
            var SortedArray = bucket.SortByDesc(Array.ToList());

            Assert.AreEqual<int>(Array.Length, SortedArray.Count);

            //RawArray = new List<int> { 1, 4, 6, 12, 16, 21, 43 };
            for (int i = 0; i < SortedArray.Count; i++)
            {
                Assert.AreEqual<int>(comparedArray[i], SortedArray[i]);
            }
        }

        [DataTestMethod]
        [DataRow(new int[] { 6, 1, 4, 21, 12, 43, 16 }, new int[] { 1, 4, 6, 12, 16, 21, 43 })]
        [DataRow(new int[] { 5, 3, 1, 33, 29, 45, 46 }, new int[] { 1, 3, 5, 29, 33, 45, 46 })]
        [DataRow(new int[] { 16, 13, 43, 31, 22, 33, 6 }, new int[] { 6, 13, 16, 22, 31, 33, 43 })]
        [TestMethod()]
        public void Sort_Numbers_By_Asc(int[] Array, int[] comparedArray)
        {
            var SortedArray = bucket.Sort(Array.ToList());

            Assert.AreEqual<int>(Array.Length, SortedArray.Count);

            //RawArray = new List<int> { 1, 4, 6, 12, 16, 21, 43 };
            for (int i = 0; i < SortedArray.Count; i++)
            {
                Assert.AreEqual<int>(comparedArray[i], SortedArray[i]);
            }
        }
    }
}