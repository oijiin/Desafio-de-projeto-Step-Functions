using DesafioPOO.Models;

// TODO: Realizei os testes com as classes Nokia e Iphone
public class Program
{
    public static void Main(string[] args)
    {
        // Criei um objeto do tipo Nokia
        Nokia nokia = new Nokia("56789", "Nokia 3310", "123456789IMEI", 64);
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");

        // Criei um objeto do tipo Iphone
        Iphone iphone = new Iphone("654321", "iPhone X", "987654321IMEI", 128);
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Telegram");
    }
}