namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
 public Iphone(string numero, string modelo, string imei, int memoria) 
            : base(numero, modelo, imei, memoria)
        {
            // Qualquer inicialização específica para Nokia pode ser feita aqui
        }public override void InstalarAplicativo(string nomeApp)
        {
            // Implementa a lógica específica para instalar um aplicativo em um iPhone
            Console.WriteLine($"Instalando aplicativo {nomeApp} na App Store do iPhone...");
        }    }
}
