using CalculadoraImc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestXUnit
{
    public class TestCalcularImc
    {
        [Fact]
        public void ResultadoImc()
        { 
            // Arrrange Preparação
            double peso = 100;
            double altura = 1.77;

            // Act - Ação
            var retultadoimc = Operacoes.CalcularImc(peso, altura);

            Assert.Equal(31.92, retultadoimc);
        }
        [Theory]
        [InlineData(80, 1.79, 24.97)]
        [InlineData(100, 1.79, 31.21)]
        public void CalcularImcLista(double peso, double altura, double resultadoEsperado)
        {
            var resultadoImc = Operacoes.CalcularImc(peso, altura);

            Assert.Equal(resultadoEsperado, resultadoImc);
        }

    }
}
