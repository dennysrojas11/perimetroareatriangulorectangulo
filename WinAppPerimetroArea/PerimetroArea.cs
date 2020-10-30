using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppPerimetroArea
{
    class PerimetroArea
    {
        double b, h, r1, r2, c;

        public PerimetroArea(double B, double H)
        {
            this.b = B;
            this.h = H;
        }

        public double calcularperimetro() {
            c = Math.Sqrt(Math.Pow(h,2)-Math.Pow(b,2));
            r1 = b + h + c;
            r1 = Math.Round(r1, 2);
            return r1;
        }

        public double calculararea()
        {
            r2 = (b * c) / 2;
            r2 = Math.Round(r2, 2);
            return r2;
        }
    }
}
