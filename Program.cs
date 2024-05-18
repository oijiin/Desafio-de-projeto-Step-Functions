using System;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "98654321", modelo: "G60", imei: "111111111", memoria: 64);

nokia.Ligar();
nokia.InstalarAplicativo("YouTube");


Console.WriteLine("\n");


Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "98732160", modelo: "14", imei: "222222222", memoria: 128);

iphone.ReceberLigacao();
iphone.InstalarAplicativo("Clash Royale");