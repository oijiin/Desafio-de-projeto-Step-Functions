using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia nokia = new Nokia(numero:"+55 7198825-5530",modelo:"G21",imei:"15151525",memoria:64); 
Console.WriteLine($"Smartfone Nokia:G21");
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Iphone iphone = new Iphone(numero:"+55 7198825-5530",modelo:"Iphone 11",imei:"30303050",memoria:256); 
Console.WriteLine($"Smartfone Iphone:11");
iphone.Ligar();
iphone.InstalarAplicativo("Uber");