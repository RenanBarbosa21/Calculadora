using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treino01_C_
{
    internal class Calculator
    {
       //metodo publico para calcular de acordo os com os parametros listados.
        public int Calculate(String op, int value1,int value2) {

            if (op == "+") 
            {
                return value1 + value2;
            }
            if (op == "_") 
            {
                return value1 - value2 ;
            }
            if (op == "*") 
            {
                return value1 * value2;
            }
            if (op == "/") 
            {
                return value1 / value2;
            }
            return 0;
        }
    }
}