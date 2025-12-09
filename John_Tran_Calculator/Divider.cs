using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace John_Tran_Calculator
{
    public class Divider : BaseOperation
    {
        public Divider()
        {
            OperationName = "Division";
        }

        public override double Calculate(double num1, double num2)
        {
            // Prevent crashing if dividing by zero
            if (num2 == 0)
            {
                // Throw an exception to indicate division by zero error
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return num1 / num2;
        }
    }
}
