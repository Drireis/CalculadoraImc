using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraImc
{
    public static class Operacoes
    {
        public static double CalcularImc(double peso, double altura)
        {
            return Math.Round((peso / (altura * altura)), 2);
        }
        public static string ClassificarImc(double imc)
        {
            if (imc < 18.5)
            {
                return "Abaixo do peso";
            }
            else if (imc >= 18.5 && imc <= 25)
            {
                return "Peso normal";
            }
            else if (imc > 25 && imc <=30)
            {
                return "Sobrepeso";
            }
            else if (imc >30 && imc <= 35)
            {
                return "Obesidade Grau 1";
            }
            else if (imc > 35 && imc <= 40)
            {
                return "Obesidade Grau 2";
            }
            else
            {
                return "Obesidade Grau 3";    
            }

        }
    }
}
