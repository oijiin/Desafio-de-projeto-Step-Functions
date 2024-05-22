namespace DesafioPOO.Models
{
    //IMPLEMENTADO
    public class Nokia : Smartphone
    {
        //IMPLEMENTADO
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        { }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Instalando aplicativo em um nokia");
        }
    }
}