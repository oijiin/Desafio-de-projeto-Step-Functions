using DesafioPOO.Models;

public class Program
{
    public static void Main(string[] args)
    {
        // Criando um objeto do tipo Nokia
        Nokia nokia = new Nokia("123456789", "Nokia 3310", "123456789IMEI", 64);
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");

        // Criando um objeto do tipo Iphone
        Iphone iphone = new Iphone("987654321", "iPhone X", "987654321IMEI", 128);
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}
// TODO: Realizar os testes com as classes Nokia e Iphone