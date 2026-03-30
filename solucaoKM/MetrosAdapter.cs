using AdapterNovoExemplo;

namespace solucaoKM
{

    public class MetrosAdapter : ISensorDistancia
    {
        private SensorMetros adapter { get; set; }

        public MetrosAdapter(SensorMetros sensor)
        {
            adapter = sensor;
        }

        public double obterKM()
        {
            double km = adapter.obterMetros() * 1000;
            return km;
        }
    }
}

