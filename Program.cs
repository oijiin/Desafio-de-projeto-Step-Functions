using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
System.Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "12345678", modelo: "Modelo 1", imei: "1111111111", memoria: 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo(" Facebook ");

Console.WriteLine("\n");

System.Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 2", imei: "2222222222", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo(" Telegram ");