using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace John_Tran_Calculator
{
    public class Subtractor : BaseOperation
    {
        public Subtractor()
        {
            OperationName = "Subtraction";
        }

        public override double Calculate(double num1, double num2)
        {
            return num1 - num2;
        }
    }
}
