using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetic_Operation
{
    public class Arithmetic
    {
        public int Sum(int x, int y)
        {
            return x + y;
        }
        public int Subtract(int x, int y) 
        {
            return x - y;
        }
        public int Divide(int x, int y) 
        {
            return x / y;
        }
        public int Multiply(int x, int y) 
        {
            return x * y;
        }
        public int ModuloDivision(int x, int y) 
        {
            return x % y;
        }

        public string CheckEvenOdd(int x)
        {
            if (x % 2 == 0)
            {
                return "It is even";
            }
            else
            {
                return "It is odd";
            }
        }
    }  
}


