using System;

namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string marca, int armazenamento)
            : base(numero, modelo, marca, armazenamento) // Chama o construtor da classe pai
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no iPhone...");
            // Implementação específica para iPhone
        }
    }
}
