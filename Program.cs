using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Nokia nokia = new Nokia("12345678", "NK001", "123321", 128);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Iphone iphone = new Iphone("87654321", "PRO-MAX14", "321123", 512);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");