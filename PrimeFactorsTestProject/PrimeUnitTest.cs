using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace PrimeFactorsTestProject
{
    [TestClass]
    public class PrimeUnitTest
    {
        [TestMethod]
        public void OneHasEmptyList()
        {
            CollectionAssert.AreEqual(new List<int>(), PrimeFactors.PrimeFactors.ComputeFactors(1));
        }
        [TestMethod]
        public void TwoHasOnlyItself()
        {
            CollectionAssert.AreEqual(new List<int>() { 2 }, PrimeFactors.PrimeFactors.ComputeFactors(2));
        }

        [TestMethod]
        public void ThreeHasOnlyItSelf()
        {
            CollectionAssert.AreEqual(new List<int>() { 3 }, PrimeFactors.PrimeFactors.ComputeFactors(3));
        }

        [TestMethod]
        public void FourHasTwoTimesTwo()
        {
            CollectionAssert.AreEqual(new List<int>() { 2, 2 }, PrimeFactors.PrimeFactors.ComputeFactors(4));
        }

        [TestMethod]
        public void FiveHasOnlyItself()
        {
            CollectionAssert.AreEqual(new List<int>() { 5 }, PrimeFactors.PrimeFactors.ComputeFactors(5));
        }
        
        [TestMethod]
        public void SixHasThreeAndTwo()
        {
            CollectionAssert.AreEqual(new List<int>() { 2,3 }, PrimeFactors.PrimeFactors.ComputeFactors(6));
        } 
        [TestMethod]
        public void SevenHasOnlyItSelf()
        {
            CollectionAssert.AreEqual(new List<int>() { 7 }, PrimeFactors.PrimeFactors.ComputeFactors(7));
        }
        [TestMethod]
        public void EightHasThreeTimesTwo()
        {
            CollectionAssert.AreEqual(new List<int>() { 2, 2, 2 }, PrimeFactors.PrimeFactors.ComputeFactors(8));
        }
        [TestMethod]
        public void NineHasTwoTimesThree()
        {
            CollectionAssert.AreEqual(new List<int>() { 3, 3 }, PrimeFactors.PrimeFactors.ComputeFactors(9));
        }

        [TestMethod]
        public void TwnetyFiveHasTwoTimesFive()
        {
            CollectionAssert.AreEqual(new List<int>() { 5, 5 }, PrimeFactors.PrimeFactors.ComputeFactors(25));
        }

        [TestMethod]
        public void _56HasThreeTime2AndSeven()
        {
            CollectionAssert.AreEqual(new List<int>() { 2, 2, 2, 7 }, PrimeFactors.PrimeFactors.ComputeFactors(56));
        }
    }
}
