using DesafioPOO.Models;

Iphone i1 = new Iphone(numero: "97132647", modelo: "Iphone 7", imei: "Não sei o que é IMEI", memoria: 64);

Nokia n1 = new Nokia(numero: "2345", modelo: "Nokia do bom", imei: "continuo sem saber", memoria: 128);

Console.WriteLine("Informações iPhone:");
Console.WriteLine($"Número: {i1.Numero}");
i1.Ligar();
i1.ReceberLigacao();
i1.InstalarAplicativo("Youtube");

Console.WriteLine("\n");

Console.WriteLine("Informações Nokia:");
Console.WriteLine($"Número: {n1.Numero}");
n1.Ligar();
n1.ReceberLigacao();
n1.InstalarAplicativo("Sofascore");


// Implementado