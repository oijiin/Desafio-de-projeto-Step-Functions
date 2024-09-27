using System.ComponentModel;
using DesafioPOO.Models;

namespace DesafioPOO.Models
{
    // Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        // Construtor que passa os parâmetros para o construtor da classe base (Smartphone)
        public Nokia(string numero, string modelo, string imei, int memoria)
        : base(numero, modelo, imei, memoria) 
        {
        }

        // Sobreescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia");
        }
    }
}