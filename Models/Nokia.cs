using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
namespace DesafioPOO.Models
{


public class Nokia : Smartphone
{
    // TODO: Herdar da classe "Smartphone"
    public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
    {
    }    
       public override void InstalarAplicativo(string nome)
       {
        Console.WriteLine($"Instalando {nome} no Nokia.");
       }
        // TODO: Sobrescrever o método "InstalarAplicativo"
    }
}