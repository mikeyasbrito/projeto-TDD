using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class CalculadoraImp
    {
        public int Sum(int val1, int val2)
        {
            return val1 + val2;
        }

        public int Sub(int val1, int val2)
        {
            return val1 - val2;
        }

        public int Mult(int val1, int val2)
        {
            return val1 * val2;
        }

        public int Div(int val1, int val2)
        {
            return val1 / val2;
        }
    }
}