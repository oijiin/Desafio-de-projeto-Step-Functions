using DesafioPOO.Models;

Smartphone nokia = new Nokia("(61) 99887-6543", "5120", "123123187139817918273", 32_000);
Smartphone iPhone = new Iphone("(11) 99887-6543", "iPhone 15 Pro-Max", "987612398172398712398712312", 32_000_000);

Console.WriteLine("=================== Nokia ===================");

nokia.InstalarAplicativo("snake");
nokia.Ligar();
nokia.ReceberLigacao();

Console.WriteLine("=================== iPhone ===================");

iPhone.InstalarAplicativo("WhatsApp");
iPhone.Ligar();
iPhone.ReceberLigacao();