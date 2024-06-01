using System.Globalization;

namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"

        public Iphone(string numero, string modelo, string imei)
            : base(numero, modelo, imei)
        {

        }
        public override void InstalarAplicativo(string nomeApp)
        {
            listaDeAplicativos.Add(nomeApp);
        }

        public override void InstalarMemoria(int memoria)
        {
            Memoria = memoria;
        }

        public override void ExibirRecursos()
        {
            Console.WriteLine($"Celular: {typeof(Iphone).Name}");
            Console.WriteLine($"Modelo: {Modelo}, numero: {Numero}, IMEI: {IMEI} ");
            Console.WriteLine($"Memória instalada: {Memoria}");
            
            Console.WriteLine($"Aplicatio(s) instalado(s): ");

            foreach(var aplicativo in listaDeAplicativos)
               Console.WriteLine($"  - {aplicativo}; ");
        }
    }

}