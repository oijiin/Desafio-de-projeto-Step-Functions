namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        //Desafio Concluído
        public Iphone (string numero, string modelo, string imei, int memoria) : base (numero, modelo, imei, memoria)
        {
            
        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"iPhone instalando {nomeApp}...");
        }
    }
}