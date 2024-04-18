namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
     public Nokia(string numero, string modelo, string imei, int memoria) 
            : base(numero, modelo, imei, memoria)
        {
            // Qualquer inicialização específica para Nokia pode ser feita aqui
        }
public override void InstalarAplicativo(string nomeApp)
        {
            // Implementa a lógica específica para instalar um aplicativo em um Nokia
            Console.WriteLine($"Instalando aplicativo {nomeApp} na Play Store do Nokia...");
        }    }
}
