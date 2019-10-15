using System;
using Xunit;

namespace Core.Tests
{
    public class UnitTest1
    {
        private readonly Contact _primeService;

        public UnitTest1()
        {
            _primeService = new Contact();
        }
                                 
        [Fact]
        public void Test1()
        {
            var result = _primeService.IsPrime(1);
            Assert.False(result, "1 should not be prime");

        }
    }
}
