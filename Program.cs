using DesafioPOO.Models;

Smartphone nokia = new Nokia("123456", "Modelo 1", "1111111111", 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Smartphone iphone = new Iphone("654321", "Modelo 2", "222222222", 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
