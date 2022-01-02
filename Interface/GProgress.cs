using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class GProgress : ISeris
    {
        double step;
        double startP;
        double currentP;
        public void setStart(int x)
        {
            startP = x;
            currentP = startP;
        }
        public void setStep(int s)
        {
            step = s;
        }
        public double getNext()
        {
            currentP *= step;
            return currentP;
        }
        public void reset()
        {
            currentP = startP;
        }
    }
}
