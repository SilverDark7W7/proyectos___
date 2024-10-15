using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace arduino_conexion
{
    class CX_CY
    {
        public double angulo { get; private set; }

        public double R { get; private set; }


        public CX_CY(string x, string y)
        {
            
            double a= double.Parse(x);
            double b = double.Parse(y);
            double resux = Math.Pow(2, a);
            double resuy = Math.Pow(2, b);
            double result = resux + resuy;
            double resultante;
            resultante = Math.Sqrt(result);
            double tan1;
            tan1 = Math.Tanh(b / a);
            R = resultante;
            angulo = tan1;

        }



    }
}
