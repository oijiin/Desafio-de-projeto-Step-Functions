using DesafioPOO.Models;

// Implementado
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "(44)99222-2333", modelo: "Nokia C01", imei: "123456789", memoria: 516);
nokia.Ligar();
nokia.InstalarAplicativo("dio");
nokia.ReceberLigacao();
Console.WriteLine("Informações do seu smarthphone Nokia.\n");
Console.WriteLine("Seu número: "+nokia.Numero+"\n");

Console.WriteLine("Desligando smarthphone Nokia.\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "(44)99111-1234", modelo: "Iphone 15", imei: "123456789", memoria: 1024);
iphone.Ligar();
iphone.InstalarAplicativo("dio");
iphone.ReceberLigacao();
Console.WriteLine("Informações do seu smarthphone Iphone.\n");
Console.WriteLine("Seu número: " + iphone.Numero + "\n");

Console.WriteLine("Desligando smarthphone Iphone.\n");