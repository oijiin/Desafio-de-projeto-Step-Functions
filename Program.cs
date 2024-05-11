using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia:");
Nokia nokia = new Nokia("1234567890", "Modelo X", "IMEI123456", 1000);
nokia.Ligar();
nokia.InstalarAplicativo("WHATSAPP");



Console.WriteLine("Smartphone Iphone:");
Iphone iphone = new Iphone("44444444", "Modelo X5", "444444", 10050);
iphone.Ligar();
iphone.InstalarAplicativo("TELEGRAM");

