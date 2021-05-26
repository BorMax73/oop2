using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2_LW3_A2
{
    class Moduler
    {
        public double Operation(double op1, double op2, string op)
        {
            double result = 0;
            switch (op)
            {
                case "+":
                    result = op1 + op2;
                    break;
                case "-":
                    result = op1 - op2;
                    break;
                case "/":
                    if (op2 != 0) result = op1 / op2;
                    break;
                case "*":
                    result = op1 * op2;
                    break;
                default:
                    break;
            }
            return result;
        }
    }
}
