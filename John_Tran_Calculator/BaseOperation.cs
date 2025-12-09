using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace John_Tran_Calculator
{
    public abstract class BaseOperation : IOperation
    {
        // Initialize operation name property with getter and setter
        public string OperationName { get; set; }

        // Abstract method for the child classes to handle the math
        public abstract double Calculate(double num1, double num2);
    }
}
