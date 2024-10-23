using System;
using Xunit;
using AtvTDD;

namespace AtvTDDTest
{
    public class UnitTest1
    {
        public Calculadora construitClasse()
        {
            string data = "23/10/2024";
            Calculadora calc = new Calculadora(data);

            return calc;
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(20, 1, 21)]
        public void TesteSomar(int num1, int num2, int resultado)
        {
            //Arrange
            //Act
            Calculadora calc = construitClasse();
            var resultadoTeste = calc.Somar(num1, num2);
            //Assert
            Assert.Equal(resultado, resultadoTeste);

        }
        [Theory]
        [InlineData(1, 2, -1)]
        [InlineData(20,1, 19)]
        public void TesteSubtrair(int num1, int num2, int resultado)
        {
            //Arrange
            //Act
            Calculadora calc = construitClasse();
            var resultadoTeste = calc.Subtrair(num1, num2);
            //Assert
            Assert.Equal(resultado, resultadoTeste);

        }
        [Theory]
        [InlineData(1, 2, 2)]
        public void TesteMultiplicar(int num1, int num2, int resultado)
        {
            //Arrange
            //Act
            Calculadora calc = construitClasse();
            var resultadoTeste = calc.Multiplicar(num1, num2);
            //Assert
            Assert.Equal(resultado, resultadoTeste);

        }
        [Theory]
        [InlineData(2, 2, 1)]
        [InlineData(6, 2, 3)]
        public void TesteDividir(int num1, int num2, int resultado)
        {
            //Arrange
            //Act
            Calculadora calc = construitClasse());
            var resultadoTeste = calc.Dividir(num1, num2);
            //Assert
            Assert.Equal(resultado, resultadoTeste);
        }

        [Fact]
        public void TestarDivisaoPor0()
        {
            Calculadora calc = construitClasse();
            Assert.Throws<DivideByZeroException>(() => calc.Dividir(3, 0));

        }

        [Fact]
        public void TestarHistorico()
        {
            Calculadora calc = construitClasse();

            calc.Somar(1, 2);
            calc.Somar(2, 3);
            calc.Somar(3, 4);
            calc.Somar(4, 5);

            var lista = calc.historico();

            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);

        }
    }
}