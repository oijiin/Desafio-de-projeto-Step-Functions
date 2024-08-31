using DesafioPOO.Models;

Console.WriteLine("Nokia Test");
Smartphone nokia = new Nokia("19997737436","Nokia 8000", "654651651561001", 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("iPhone Test");
Smartphone iphone = new Iphone("19998852083","iPhone 14", "984946942568720", 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");

