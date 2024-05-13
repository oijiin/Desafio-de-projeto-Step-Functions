using DesafioPOO.Models;

Console.WriteLine("Iphone:");
Iphone iphone = new Iphone(numero: "40028922", modelo: "Iphone XR", iMei: "000000000", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("iTunes");

Console.WriteLine("----------------------");

Console.WriteLine("Nokia:");
Nokia nokia = new Nokia(numero: "080007777", modelo: "Nokia Tijolão", iMei: "111111111", memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("Deezer");