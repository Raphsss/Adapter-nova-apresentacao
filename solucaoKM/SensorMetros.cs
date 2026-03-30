using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solucaoKM
{
    public class SensorMetros
    {
        private double _distancia { get; set; }

        public SensorMetros(double distancia)
        {
            _distancia = distancia;
        }

        public double obterMetros()
        {
            return _distancia;
        }
    }
}
