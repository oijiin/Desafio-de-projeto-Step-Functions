using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "0987655", modelo: "Modelo 1", imei: "111111111", memoria: 128);
Smartphone.Ligar();
Smartphone.ReceberLigacao();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("Encerrando teste em Nokia.\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "93456785", modelo: "Modelo 2", imei: "22222222", memoria: 64);
Smartphone.Ligar();
Smartphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");

Console.WriteLine("Encerrando teste em Iphone.\n");