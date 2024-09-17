using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exponencial{
    internal class Calculadora{
        double x, y, r;
        public Calculadora() { }
        public double CalExp(double x) {
            r = Math.Exp(x);
            return r;
        }
    }
}
