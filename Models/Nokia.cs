namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia:Smartphone  
    {

        public Nokia(string numero):base(numero)
        {
            Numero = "123123123";
            Modelo = "Nokia";
            IMEI = "123456789";
            Memoria = 32;

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