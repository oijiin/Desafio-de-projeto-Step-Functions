using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Testando a classe Nokia");
Nokia nokia = new Nokia("123456789", "Nokia 3310", "123456789", 512);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\nTestando a classe Iphone");

Iphone iphone = new Iphone("987654321", "Iphone 12", "987654321", 1024);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");
