using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7_AntoniaCarrizo
{
    public class Operations
    {
        public Operations()
        {

        }
        public decimal Sum(decimal a, decimal b)
        {
            decimal result = a + b;
            return result;
        }
        public decimal Subtract(decimal a, decimal b)
        {
            decimal result = a - b;
            return result;
        }
        public decimal Multiplication(decimal a, decimal b)
        {
            decimal result = a * b;
            return result;
        }
        public decimal Division(decimal a, decimal b)
        {
            decimal result = a / b;
            return result;
        }
    }
}
