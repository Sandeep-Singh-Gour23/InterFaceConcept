using System;

namespace InterFaceConcept
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMath math = new Math();
            math.add(15, 25);
            math.subtract(20, 5);
            math.multiply(20, 5);
            math.divide(21, 5);

            // Created object of SimpleInterest Class and passes Interface IMath reference as an argument in Constructor.
            ICalculator cal;
            cal = new SimpleInterest(math);
            cal.interest(1000, 3, 10);

            // Created object of CompoundInterest Class and passes Interface IMath reference as an argument in Constructor.
            cal = new CompoundInterest(math);
            cal.interest(1000, 3, 10);
        }
    }
}
