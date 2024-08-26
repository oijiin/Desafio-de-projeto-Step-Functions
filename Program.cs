using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

// Smartphone smartphone = new Smartphone("123456789123456", "Smartphone X", "987654321987654", 512);

Console.WriteLine("\nSmartphone Nokia:");
Smartphone nokia = new Nokia("", "Nokia 3310", "123456789123456", 128);
nokia.Numero = "21987654321";
nokia.InstalarAplicativo("WhatsApp");
nokia.Ligar();
// nokia.ExibirDetalhes();

Console.WriteLine("\nSmartphone iPhone:");
Iphone iphone = new Iphone("31987654321", "iPhone 13 Pro Max", "987654321987654", 2048);
iphone.InstalarAplicativo("Instagram");
iphone.ReceberLigacao();
iphone.Numero = "33912345678";
// iphone.ExibirDetalhes();
