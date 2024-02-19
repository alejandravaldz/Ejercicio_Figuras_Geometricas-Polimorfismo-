using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_figuras_polimorfismo
{
    internal class Cuadrado: FigurasGeometrica
    {
        public double LadoA { get; set; }
        public double LadoB { get; set; }

        public override double CalcularAreas()
        {

            return LadoA * LadoB;

        }

        public override double CalcularPerimetro()
        {

            return 2 * LadoA * LadoB;

        }
    }
}
}
