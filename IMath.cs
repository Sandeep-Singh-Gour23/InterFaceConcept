using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFaceConcept
{
    public interface IMath
    {
        void add(int x, int y);
        void subtract(int x, int y);
        void multiply(int x, int y);
        void divide(double x, double y);

    }
}
