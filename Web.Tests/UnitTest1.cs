using System;
using Web.Controllers;
using Web.Models;
using Xunit;

namespace Web.Tests
{
    public class UnitTest1
    {
        private readonly RegisterController _Contacto;

        public UnitTest1()
        {
            _Contacto = new RegisterController();
        }

        [Fact]
        public void Test1()
        {
            var result = _Contacto.Login();
        }
    }
}
