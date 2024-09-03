using DesafioPOO.Models;

Console.WriteLine("Nokia:");
Smartphone nokia = new Nokia(numero: "11111111", modelo: "222222222", imei: "3333333", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("Iphone:");
Smartphone iphone = new Iphone(numero: "444444444", modelo: "555555555", imei: "6666666666", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Pinterest");