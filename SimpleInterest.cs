using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFaceConcept
{
    public class SimpleInterest : ICalculator
    {
        public SimpleInterest(IMath math)
        {
            Console.WriteLine("......I'm in Constructor of SI......");
            math.add(55, 45);
            math.subtract(55, 5);
            math.multiply(55, 5);
            math.divide(55, 5);
        }
        public void interest(int principal, int time, int rate)
        {
            int SI = (principal * rate * time) / 100;
            Console.WriteLine("Simple Interest : " +SI);      
        }

    }
}
