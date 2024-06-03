using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complementario32429841.Resources
{
    class NotasAlum
    {
        public List<double> Calificaciones { get; set; }

        public NotasAlum()
        {
            Calificaciones = new List<double>();

        }
        public double CalcularPromedio()
        {
            if (Calificaciones.Count == 0)
                return 0;

            return Calificaciones.Average();
        }
    }
}
