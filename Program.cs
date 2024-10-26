using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone NoKia:");
Smartphone nokia = new Nokia("123456", "Modelo1", "11111111", 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone("123456", "Modelo2", "22222222", 128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");