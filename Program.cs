using DesafioPOO.Models;

Nokia meuNokia = new Nokia("001-987654321", "Nokia 2024", "98374523947", 32);
Console.WriteLine($"Número do Nokia: {meuNokia.Numero}");
meuNokia.Ligar();
meuNokia.ReceberLigacao();
meuNokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("------------------------");

Iphone meuIphone = new Iphone("001-123456789", "IPhone 16 Pro", "293939244", 128);
Console.WriteLine($"Número do IPhone: {meuIphone.Numero}");
meuIphone.Ligar();
meuIphone.ReceberLigacao();
meuIphone.InstalarAplicativo("Instagram");