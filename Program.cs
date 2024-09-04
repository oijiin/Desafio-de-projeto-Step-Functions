using DesafioPOO.Models;

Smartphone nokia = new Nokia(numero: "123456789", modelo: "3310", imei: "123456789", memoria: 16);
Smartphone iphone = new Iphone(numero: "987654321", modelo: "12", imei: "987654321", memoria: 128);

System.Console.WriteLine("Nokia:");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Snake");

System.Console.WriteLine("\nIphone:");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");

