namespace DesafioPOO.Models
{

    
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string nomeModelo, string imei, int memoria) : base(numero, nomeModelo, imei, memoria)
        {}
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo - {nomeApp} - no Iphone");
        }
    }
}