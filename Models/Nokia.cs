namespace DesafioPOO.Models
{
    public class SmartphoneNokia : Smartphone
    {
        public SmartphoneNokia (string numero, string modelo, int imei, string memoria)
            : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp}.");
        }
    }
   // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
   {
        public Nokia (string numero, string modelo, int imei, string memoria)
            : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia.");
        }
    }
}