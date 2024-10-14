using System.Net;
using DesafioPOO.Models;

Console.WriteLine("Teste Nokia:");
Smartphone nokia = new Nokia(numero: "11111111111", modelo: "Modelo X", imei: "102030", memoria: 512);
nokia.Ligar();
nokia.InstalarAplicativo("Pokemon GO");
nokia.ReceberLigacao();

Console.WriteLine("\n");

Console.WriteLine("Teste Iphone:");
Smartphone iphone = new Iphone(numero: "11222222222", modelo: "Modelo Y", imei: "304050", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Github");
nokia.ReceberLigacao();
