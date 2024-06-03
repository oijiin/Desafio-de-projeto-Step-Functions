namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public sealed class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }

        public override void InstalarAplicativo(string nome)
        {
            Console.WriteLine("Instalando aplicativo: " + nome);
        }
    }
}