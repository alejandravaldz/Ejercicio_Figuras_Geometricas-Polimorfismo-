using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_figuras_polimorfismo
{
    internal class Circulo: FigurasGeometrica
    {
        public double Radio { get; set; }



        public override double CalcularAreas()
        {

            return 3.14 * Radio * 2;

        }

        public override double CalcularPerimetro()
        {

            return 2 * 3.14 * Radio;

        }

    }
}
}
