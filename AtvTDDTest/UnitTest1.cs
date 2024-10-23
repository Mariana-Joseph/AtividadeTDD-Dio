using System;
using Xunit;
using AtvTDD;

namespace AtvTDDTest
{
    public class UnitTest1
    {
        [Fact]
        public void Somar1Com2Retorna3()
        {
            //Arrange
            int num1 = 1;
            int num2 = 2;
            //Act
            Calculadora calc = new Calculadora();
            var resultado = calc.Somar(num1, num2);
            //Assert
            Assert.Equal(3, resultado);

        }
    }
}
