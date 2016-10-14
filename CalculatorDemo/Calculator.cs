using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorDemo
{
    public class Calculator
    {
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Mul(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Divid(int num1, int num2)
        {
            if (IsNagtive(num1) || IsNagtive(num2))
            {
                throw new Exception("number cannnot be nagtive!");
            }
            return num1 / num2;
        }

        private bool IsNagtive(int num2)
        {
            if (num2<0)
            {
                return true;
            }
            return false;
        }
    }
}
