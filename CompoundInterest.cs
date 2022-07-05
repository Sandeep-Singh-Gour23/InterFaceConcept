using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFaceConcept
{
    public class CompoundInterest : ICalculator
    {
        public CompoundInterest(IMath math)
        {
            Console.WriteLine(" ");
            Console.WriteLine("......I'm in Constructor of CI......");
            math.add(55, 4);
            math.subtract(55, 15);
            math.multiply(55, 2);
            math.divide(55, 15);
        }
        public void interest(int principal, int time, int rate)
        {
            int CI = principal * (1 + rate / 100) ^ time - principal;
            Console.WriteLine("Compound Interest : " + CI);
        }
    }
}
