using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2_LW3_A2
{
    class Presenter
    {
        Moduler moduler = new Moduler();
        public string Start(string expression)
        {
            char[] delimiterChars = {'+', '-', '/', '*'};
            string[] nums = expression.Split(delimiterChars);
            string op = null;
            double op1 = 0;
            double op2 = 0;

            for (int i = 0; i < 4; i++)
            {
                if (expression.Contains(delimiterChars[i]) == true) op = Convert.ToString(delimiterChars[i]);
            }

            op1 = Convert.ToDouble(nums[0]);
            op2 = Convert.ToDouble(nums[1]);
            return Convert.ToString(moduler.Operation(op1, op2, op));
        }
    }
}
