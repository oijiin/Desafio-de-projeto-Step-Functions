using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "1425", modelo: "Nk0152.4", imei: "1111111111", memoria: 64 );
nokia.Ligar();
nokia.InstalarAplicativo("Facebook");

Console.WriteLine("\n");

Console.WriteLine("Smartphone IPhone: ");
Smartphone iphone = new Iphone(numero: "2914", modelo: "Max Pro", imei: "2222222222", memoria: 256 );
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");

// IMPLEMENTADO