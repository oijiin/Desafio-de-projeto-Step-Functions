using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
System.Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "4987", modelo: "modelo1", imei: 111, memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("whatsapp");

System.Console.WriteLine("\n");

System.Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "5050", modelo: "modelo2", imei: 22, memoria:128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");