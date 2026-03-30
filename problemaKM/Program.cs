using AdapterNovoExemplo;

public class Program
{
    static void Main()
    {
        SensorMilhas sendorMilhas = new SensorMilhas(100);

        
        ISensorDistancia milhasAdapter = new MilhasAdapter(sendorMilhas);

        Console.WriteLine(milhasAdapter.obterKM()) ;
    }
}