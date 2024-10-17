namespace DesafioPOO.Models
using System;

namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string marca, int armazenamento)
            : base(numero, modelo, marca, armazenamento) // Chama o construtor da classe pai
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia...");
            // Implementação específica para Nokia
        }
    }
}
