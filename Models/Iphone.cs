namespace DesafioPOO.Models
{
    //Herda da classe "Smartphone"
    public class Iphone : Smartphone
    {

        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
        Console.WriteLine($"instalando o aplicativo {nomeApp} no Iphone...");
        }
    }
}