namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone:Smartphone
    {
        public Iphone(string numero):base(numero)
        {
            Numero = "123123123";
            Modelo = "Iphone";
            IMEI = "123456789";
            Memoria = 64;

            numero = Numero;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}