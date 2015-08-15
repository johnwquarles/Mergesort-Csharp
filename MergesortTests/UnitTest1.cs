using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MergeSort;

namespace MergeSortTests
{
    [TestClass]
    public class Merge
    {
        [TestMethod]
        public void TestBaseCaseLeft()
        {
            int[] a = new int[] { 1 };
            int[] b = new int[0];
            CollectionAssert.AreEqual(a, Program.Merge(a, b));
        }

        [TestMethod]
        public void TestBaseCaseRight()
        {
            int[] a = new int[0];
            int[] b = new int[] { 1 };
            CollectionAssert.AreEqual(b, Program.Merge(a, b));
        }

        [TestMethod]
        public void TestSingletons()
        {
            int[] a = new int[] { 2 };
            int[] b = new int[] { 1 };
            int[] expect = new int[] { 1, 2 };
            CollectionAssert.AreEqual(expect, Program.Merge(a, b));
        }

        [TestMethod]
        public void TestKindaComplicated()
        {
            int[] a = new int[] { 2, 7, 19, 22 };
            int[] b = new int[] { 1, 18, 20, 21, 44 };
            int[] expect = new int[] { 1, 2, 7, 18, 19, 20, 21, 22, 44 };
            CollectionAssert.AreEqual(expect, Program.Merge(a, b));
        }

        [TestMethod]
        public void TestAllOnOneSide()
        {
            int[] a = new int[] { 0, 1, 2, 3, 4, 5 };
            int[] b = new int[] { 6, 7, 8 };
            int[] expect = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
            CollectionAssert.AreEqual(expect, Program.Merge(a, b));
        }
    }

    [TestClass]
    public class Mergesort
    {
        [TestMethod]
        public void TestSimpleOdd()
        {
            int[] a = new int[] { 1, 6, 2, 0, 3 };
            int[] expect = new int[] { 0, 1, 2, 3, 6 };
            CollectionAssert.AreEqual(expect, Program.Mergesort(a));
        }

        [TestMethod]
        public void TestSimpleEven()
        {
            int[] a = new int[] { 1, 6, 2, 0, 3, 4 };
            int[] expect = new int[] { 0, 1, 2, 3, 4, 6 };
            CollectionAssert.AreEqual(expect, Program.Mergesort(a));
        }

        [TestMethod]
        public void alreadyInOrder()
        {
            int[] a = new int[] { 0,2,5,7,9 };
            int[] expect = new int[] { 0, 2,5,7,9 };
            CollectionAssert.AreEqual(expect, Program.Mergesort(a));
        }

        [TestMethod]
        public void backwards()
        {
            int[] a = new int[] { 400,300,20,5,2,1 };
            int[] expect = new int[] { 1,2,5,20,300,400 };
            CollectionAssert.AreEqual(expect, Program.Mergesort(a));
        }
    }
}
