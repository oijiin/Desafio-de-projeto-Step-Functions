namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
    
public override void InstalarAplicativo(string nomeApp)
        {
            // Implementa a lógica específica para instalar um aplicativo em um Nokia
            Console.WriteLine($"Instalando aplicativo {nomeApp} na Play Store do Nokia...");
        }    }
}
