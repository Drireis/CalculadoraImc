using CalculadoraImc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCalcularImc
{
    [TestClass]
    public class TestCalculadora
    {
        [TestMethod]
        public void CalcularImc()
        {
            // Arrange - Preparação
            double peso = 100;
            double altura = 1.77;

            // Act - Ação
            var resultado = Operacoes.CalcularImc(peso, altura);

            // Act - Ação
            Assert.AreEqual(31,56, resultado);

        }
    }
}
