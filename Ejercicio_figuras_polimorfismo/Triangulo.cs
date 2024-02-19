using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_figuras_polimorfismo
{
    internal class Triangulo : FigurasGeometrica
    {
        public double LadoA { get; set; }
        public double LadoB { get; set; }

        public double LadoC { get; set; }


        public override double CalcularAreas()
        {


            return (LadoA + LadoB) / 2;

        }

        public override double CalcularPerimetro()
        {
            return LadoA * LadoB;

        }
    }
}

