using DesafioPOO.Models;

Smartphone nokia = new Nokia(numero: "12345678", modelo: "C21 Plus", imei: "0000", memoria: 126);
Console.WriteLine("Nokia:");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Instagram");

Smartphone iphone = new Iphone(numero: "12345678", modelo: "15 Pro Max", imei: "111111", memoria: 256);
Console.WriteLine("Iphone:");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Tiktok");