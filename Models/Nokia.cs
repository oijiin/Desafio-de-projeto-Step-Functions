namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public Nokia(string nome, string modelo, string imei, int memoria):base(nome, modelo, imei, memoria)
         {}
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo no dispositivo {nomeApp} no dispositivo Nokia");
        }
    }
}