using CalculadoraImc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCalcularImc
{
    [TestClass]
    public class TestClassificarImc
    {
        [TestMethod]
        public void ClassificarImc() 
        {
            // Arrange - Preparação
            double imc = 28;

            // Act - Ação
            var classificarImc = Operacoes.ClassificarImc(imc);

            // Assert - Verificação
            Assert.AreEqual("Sobrepeso", classificarImc);
        }
    }
}
