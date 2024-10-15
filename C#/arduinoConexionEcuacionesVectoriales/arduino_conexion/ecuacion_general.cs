using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace arduino_conexion
{
    class ecuacion_generales
    {
        public double Magnitud { get; private set; }
        public double Direccion { get; private set; }
        public int ResultadoX_Entero { get; private set; }
        public double ResultadoX_Decimales { get; private set; }
        public int ResultadoY_Entero { get; private set; }
        public double ResultadoY_Decimales { get; private set; }
        public bool EsOperacionValida { get; private set; }

        public ecuacion_generales(string ecuacion)
        {
            Regex regex = new Regex(@"v=(\d+(\.\d+)?)m,(\d+(\.\d+)?)grados");

            Match match = regex.Match(ecuacion);

            if (match.Success)
            {
                double magnitud = double.Parse(match.Groups[1].Value);
                double direccion = double.Parse(match.Groups[3].Value);

                Magnitud = magnitud;
                Direccion = direccion;

                double resultadoX = magnitud * Math.Cos(Math.PI * direccion / 180);
                double resultadoY = magnitud * Math.Sin(Math.PI * direccion / 180);

                ResultadoX_Entero = (int)resultadoX;
                ResultadoX_Decimales = resultadoX ;
                ResultadoY_Entero = (int)resultadoY;
                ResultadoY_Decimales = resultadoY ;

                EsOperacionValida = true;
            }
            else
            {
                EsOperacionValida = false;
            }
        }


    }
}
