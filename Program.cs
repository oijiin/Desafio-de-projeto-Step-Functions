using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
namespace DesafioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Nokia nokia = new Nokia("123456789", "Nokia 3310", "123456789", 16);
            Console.WriteLine($"{nokia.Numero}, {nokia.Modelo}, {nokia.IMEI}, {nokia.Memoria}");
            //nokia.Ligar();
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("WhatsApp");

            Iphone iphone = new Iphone("987654321", "Iphone 12", "987654321", 128);
            Console.WriteLine($"{iphone.Numero}, {iphone.Modelo}, {iphone.IMEI}, {iphone.Memoria}");
            iphone.Ligar();
            //.ReceberLigacao();
            iphone.InstalarAplicativo("Instagram");
        }
    }
}