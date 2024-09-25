using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "989890909", imei: 12349876, modelo: "Lumia 1920", memoria: "64gb");
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone");
Smartphone iphone = new Iphone(numero: "12543789", imei: 98764321, modelo: "iPhone 15", memoria: "128gb");
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");


// TODO: Realizar os testes com as classes Nokia e Iphone