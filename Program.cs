using DesafioPOO.Models;

//Realizando os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone nokia:");
Nokia n = new Nokia("61912345678", "modelo 1", "1111111", 128);
n.Ligar();
n.InstalarAplicativo("Roblox");

Console.WriteLine("Smartphone Iphone:");
Iphone i = new Iphone("61987654321", "modelo 2", "2222222", 64);
i.ReceberLigacao();
i.InstalarAplicativo("Whatsapp");