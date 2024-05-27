using DesafioPOO.Models;

Console.WriteLine($"Smarphone Nokia");
Nokia celular1 = new Nokia(numero:"12345667", modelo:"Modelo 1", imei:"111111111", memoria: 64);
celular1.Ligar();
celular1.InstalarAplicativo("Youtube");

Console.WriteLine($"===========================================");

Console.WriteLine($"Smarphone Iphone");
Iphone celular2 = new Iphone(numero:"1456", modelo:"Modelo 2", imei:"00056111", memoria: 128);
celular2.Ligar();
celular2.InstalarAplicativo("Telegram");