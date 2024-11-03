using DesafioPOO.Models;

        solucao
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "4987", modelo: "Modelo 2", imei: "222222222", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");

// TODO: Realizar os testes com as classes Nokia e Iphone
        main
        
class Program
{
    static void Main(string[] args)
    {
        // Criando um objeto Nokia
        Nokia nokia = new Nokia();
        nokia.Numero = "123456789";
        nokia.Modelo = "Nokia 3310";
        nokia.InstalarAplicativo("Snake");

        // Criando um objeto iPhone
        Iphone iphone = new Iphone();
        iphone.Numero = "987654321";
        iphone.Modelo = "iPhone 14 Pro";
        iphone.InstalarAplicativo("Instagram");
    }
}