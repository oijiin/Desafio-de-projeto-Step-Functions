using DesafioPOO.Models;

Smartphone iphone = new Iphone("12345", "Modelo 1", "IMEI12345", 128);
Smartphone nokia = new Iphone("54321", "Modelo 2", "IMEI54321", 64);

Console.WriteLine("Testando o Iphone: ");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");

Console.WriteLine();

Console.WriteLine("Testando Nokia: ");
nokia.Ligar();  
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.ReadLine();