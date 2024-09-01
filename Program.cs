using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Nokia:");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "1", memoria:64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Iphone:");
Smartphone ifone= new Iphone(numero: "4987", modelo: "Modelo 2", imei: "2", memoria:128);
ifone.ReceberLigacao();
ifone.InstalarAplicativo("Telegram");