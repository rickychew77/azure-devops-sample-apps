using NUnit.Framework;
using Prime.Services;
using System.Collections.Generic;


//.NET Core

namespace Prime.UnitTests.Services
{
    [TestFixture]
    public class PrimeService_IsPrimeShould
    {
        // [Test]
        // public void IsPrime_InputIs1_ReturnFalse()
        // {
        //     PrimeService primeService = CreatePrimeService();
        //     var result = primeService.IsPrime(1);

        //     Assert.IsFalse(result, "1 should not be prime");
        // }
        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(1)]
        public void IsPrime_ValuesLessThan2_ReturnFalse(int value)
        {
            PrimeService _primeService = CreatePrimeService();
            var result = _primeService.IsPrime(value);

            Assert.IsFalse(result, $"{value} should not be prime");
        }
        
        // private List<int> list = new List<int>();
        // [Test]
        // public void testOne(){
        //     list.Add(1);
        //     Assert.AreEqual(1, list.Count);

        // }
        // [Test]
        // public void testTwo(){
        //     Assert.AreEqual(0, list.Count);
        // }

        private PrimeService CreatePrimeService()
        {
             return new PrimeService();
        }
    }
}