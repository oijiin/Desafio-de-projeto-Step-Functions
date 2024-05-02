using DesafioPOO.Models;

Console.Clear();
Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "010101", memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("Youtube");
nokia.ReceberLigacao();

Console.WriteLine("\nSmartphone iPhone: ");
Smartphone iphone = new Iphone(numero: "654321", modelo: "Modelo 2", imei: "260385", memoria: 64);
iphone.Ligar();
iphone.InstalarAplicativo("Discord");
iphone.ReceberLigacao();