using System.Runtime.CompilerServices;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia("123456789", "X30", "1111111111", 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone("4987", "Iphone 15", "2222222222", 128);
nokia.Ligar();
nokia.InstalarAplicativo("Telegram");