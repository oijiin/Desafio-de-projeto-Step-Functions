namespace DesafioPOO.Models
{
    // IMPLEMENTADO
    public class Iphone : Smartphone
    {
        // Implementando o Construtor Padrão a partir da Herança
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }

        // IMPLEMENTADO
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no IPhone");
        }
    }
}