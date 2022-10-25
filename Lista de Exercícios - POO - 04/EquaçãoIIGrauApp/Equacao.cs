using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquaçãoIIGrauApp
{
    class Equacao
    {
        private double a, b, c;
        public void SetABC(double a, double b, double c)
        {
            if (a != 0)
            {
                this.a = a; 
                this.b = b; 
                this.c = c;
            }
        }
        public void GetABC(out double a, out double b, out double c)
        {
            a = this.a;
            b = this.b;
            c = this.c;
        }
        public bool RaizesReais()
        {
            if (Delta() < 0) return false;
            return true;
        }
        public double Delta()
        {
            return b * b -4 * a * c;
        }
        public bool X1(out double x)
        {
           x = (-b + Math.Sqrt(Delta())) / 2 * a;
           return true;
        }
        public bool X2(out double x)
        {
            x = (-b - Math.Sqrt(Delta())) / 2 * a;
            return true;
        }
    }
}