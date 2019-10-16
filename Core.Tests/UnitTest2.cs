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
            _registro.RegistrarCont("Sanchez", "Angela", "Angela.sanchez@gmail.com", "Cr 1 este 43 B 28 sur", "Bogota", "0");
        }
    }
}
