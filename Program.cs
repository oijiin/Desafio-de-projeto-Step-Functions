using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Configurando o Nokia");
Nokia nk = new Nokia(numero: "101010101", modelo: "nk2035", imei: "654321", memoria: 128);
nk.Ligar();
nk.InstalarAplicativo("WhatsApp");
nk.ReceberLigacao();

Console.WriteLine("\n");

Console.WriteLine("Configurando o Iphone");
Iphone ipho = new Iphone(numero: "010101010", modelo: "Ipho8426", imei: "584351", memoria: 128);
ipho.Ligar();
ipho.InstalarAplicativo("Telegram");
ipho.ReceberLigacao();
