using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia:");
var nokia = new Nokia("1234", "Nokia 3310", "123456", 32);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("-------------------------------------------------");

Console.WriteLine("Smartphone Iphone:");
var iphone = new Iphone("1234", "Iphone 13", "123456", 32);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");