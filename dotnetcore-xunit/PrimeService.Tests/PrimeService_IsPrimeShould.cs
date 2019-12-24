using Xunit;
using Prime.Services;
using System.Collections.Generic;
//.NET Core

namespace Prime.UnitTests.Services
{
    public class PrimeService_IsPrimeShould
    {
        private readonly PrimeService _primeService;

        public PrimeService_IsPrimeShould()
        {
            _primeService = new PrimeService();
        }

        // [Theory]
        // [InlineData(-1)]
        // [InlineData(0)]
        // [InlineData(1)]
        // public void IsPrime_InputIs1_ReturnFalse(int value)
        // {
        //     var result = _primeService.IsPrime(value);
            
        //     Assert.False(result, $"{value} should not be prime");
            
        // }

        // [Theory]
        // [InlineData(2)]
        // public void IsPrime_InputIs2_ReturnTrue(int value)
        // {
        //     var result = _primeService.IsPrime(value);

        //     Assert.True(result, $"{value} should be prime");
        // }

        // [Fact]
        // public void IsListContainsOne()
        // {
        //     var expected = new List<int>();
        //     expected.Add(1);
        //     var result = _primeService.ListOfNumbers();

        //     Assert.Equal(expected, result);
            
        // }

        // [Fact]
        // public void IsListEmpty()
        // {
        //     var expected2 = new List<int>();
        //     var result2 = _primeService.ListOfNumbers();

        //     Assert.Equal(expected2, result2);
        // }

        private List<int> list = new List<int>();
        [Fact]
        public void testOne(){
            list.Add(1);
            Assert.Equal(1, list.Count);

        }
        [Fact]
        public void testTwo(){
            Assert.Equal(0, list.Count);

        }
        
    }
}