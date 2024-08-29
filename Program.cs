using DesafioPOO.Models;

Console.OutputEncoding = System.Text.Encoding.UTF8;

var nokia = new Nokia("11911111111", $"{nameof(Nokia)} Lumia", "9999", 1);
nokia.InstalarAplicativo("Whatsapp");

var iphone = new Iphone("11922222222", $"{nameof(Iphone)} 15", "8888", 2);
iphone.InstalarAplicativo("Facebook");

Console.WriteLine($"Celular número {nokia.Numero} está efetuando uma ligação.");
nokia.Ligar();
Console.WriteLine($"Celular número {iphone.Numero} está recebendo uma ligação.");
iphone.ReceberLigacao();

// var sm = new Smartphone("11933333333", "NaoPode", "7777", 3);
//Severity	Code	Description	Project	File	Line	Suppression State
//Error CS0144	Cannot create an instance of the abstract type or interface 'Smartphone'	


Console.ReadKey();
