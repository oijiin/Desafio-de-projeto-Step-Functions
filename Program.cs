using DesafioPOO.Models;

Smartphone nokia = new Nokia(
    numero:"555892001",
    modelo:"c20",
    imei:"123456789123456",
    memoria: 32
);

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Teams");

Console.WriteLine("------------------------------------");

Smartphone iphone = new Iphone(
    numero: "555998012",
    modelo:"10",
    imei:"987654321987656",
    memoria:16
);

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Icloud");