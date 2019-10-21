using System;
using Xunit;

namespace Core.Tests
{
    public class UnitTest2
    {
        private readonly Registrar _registro;

        public UnitTest2()
        {
            _registro = new Registrar();
        }

        [Fact]
        public void Test1()
        {
            var result = _registro.RegistrarCont("Sanchez", "Angela", "Angela.sanchez@gmail.com", "Cr 1 este 43 B 28 sur", "Bogota", "0");
            Assert.False(result);
        }

        [Fact]
        public void Test2()
        {
            var result = _registro.RegistrarCont("Sanchez", "Angela", "Angela.sanchez@gmail.com", "Cr 1 este 43 B 28 sur", "Bogota", "3133810843");
            Assert.True(result);
        }
    }
}
