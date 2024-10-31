﻿using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", IMEI: "111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "4987", modelo: "Modelo 2", iMEI: "222222222", memoria: 64);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");