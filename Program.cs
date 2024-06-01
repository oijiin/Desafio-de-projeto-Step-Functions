using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Smatphone Nokia");
        Smartphone nokia = new SmartphoneNokia ("123456789", "Galaxy S21", 1212121328, "128 GB");
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");
    
        Console.WriteLine("\n");

        Console.WriteLine("Smartphone Iphone");
        Smartphone iphone = new SmartphoneIphone ("123456789", "Galaxy S21", 1280654548, "248 GB");
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Waze");
    }





}

    