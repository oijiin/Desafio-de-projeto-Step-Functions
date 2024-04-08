using DesafioPOO.Models;

Smartphone nokia = new Nokia("554856327", "Nokia 2 plus", "1256488546512198", 128);
Smartphone iphone = new Iphone("669851877", "Apple Ultra+", "4891651618975", 512);

Console.WriteLine("Celular Android");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Youtube");

Console.WriteLine("\n");

Console.WriteLine("Celular IOS");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Safari");