using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Smartphone nokia = new Nokia("(11) 9 8765-4321", "Nokia 5.4 Nk025", "357986028976543", 32);

Console.WriteLine("Testando o Nokia");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Threema");

Smartphone iphone = new Iphone("(19) 9 8458-3391", "Iphone 16 Pro-Max", "867530987654321", 512);

Console.WriteLine("Testando o Iphone");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");



