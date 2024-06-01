namespace DesafioPOO.Models
{
    public class SmartphoneIphone : Smartphone
    {
        public SmartphoneIphone (string numero, string modelo, int imei, string memoria)
            : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp}.");
        }
    }
   // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
   {
        public Iphone (string numero, string modelo, int imei, string memoria)
            : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia.");
        }
    }
}