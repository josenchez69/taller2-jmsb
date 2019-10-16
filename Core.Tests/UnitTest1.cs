using System;
using Xunit;

namespace Core.Tests
{
    public class UnitTest1
    {
        private readonly Contact _contact;

        public UnitTest1()
        {
            _contact = new Contact();
        }
                                 
        [Fact]
        public void Test1()
        {
            var result = _contact.RegistrarContacto("a", "b");
            Assert.False(result);
        }

        [Fact]
        public void Test2()
        {
            var result = _contact.RegistrarContacto("user", "1234");
            Assert.True(result);
        }
    }
}
