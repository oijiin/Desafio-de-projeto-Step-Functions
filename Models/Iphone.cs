namespace DesafioPOO.Models
{
    // Herdando da classe "Smartphone"
    public class Iphone : Smartphone
    {
        // Construtor que passa os parâmetros para o construtor da classe base (Smartphone)
        public Iphone(string numero, string modelo, string imei, int memoria) 
            : base(numero, modelo, imei, memoria)
        {
        }

        // Sobrescrevendo o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no iPhone");
        }
    }
}
