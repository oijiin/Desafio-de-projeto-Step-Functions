using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        // Teste com Nokia
        Smartphone nokia = new Nokia("123456789", "Nokia Modelo", "111111111111", 64);
        nokia.Ligar();
        nokia.InstalarAplicativo("WhatsApp");

        // Teste com Iphone
        Smartphone iphone = new Iphone("987654321", "iPhone Modelo", "222222222222", 128);
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}
