using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Teste no Nokia");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "9876", memoria: 128);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("..............");

Console.WriteLine("Teste no Iphone");
Smartphone iphone = new Iphone(numero: "1357", modelo: "modelo 3", imei: "1234", memoria: 32);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Youtube");