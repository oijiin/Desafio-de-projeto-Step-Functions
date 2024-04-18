namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
    
public override void InstalarAplicativo(string nomeApp)
        {
            // Implementa a lógica específica para instalar um aplicativo em um iPhone
            Console.WriteLine($"Instalando aplicativo {nomeApp} na App Store do iPhone...");
        }    }
}
