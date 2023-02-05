using CalculadoraImc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestXUnit
{
    public class TestClassificarImc
    {
        [Fact]
        public void ClassificarImcResultado() 
        {
            double imc = 28;

            var resultado = Operacoes.ClassificarImc(imc);

            Assert.Equal("Sobrepeso", resultado);
        }

        [Theory]
        [InlineData(28, "Sobrepeso")]
        [InlineData(32, "Obesidade Grau 1")]
        [InlineData(37, "Obesidade Grau 2")]
        public void ClassificarListaValores(double imc, string resultadoEsperado)
        {
            var resutadoImc= Operacoes.ClassificarImc(imc);

            Assert.Equal(resultadoEsperado, resutadoImc);
        }

    }
}
