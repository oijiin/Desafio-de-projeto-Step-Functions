using DesafioPOO.Models;

var nokia = new Nokia("21959351922", "Nokia 110", "928382983309876", 64);
var iphone = new Iphone("21959351921", "Iphone 15 Pro", "123456789101112", 512);

nokia.InstalarAplicativo("Whatsapp");
iphone.InstalarAplicativo("Facebook app");

Console.WriteLine($"Aparelho Nokia modelo: {nokia.Modelo}, Número: {nokia.Numero}, IMEI: {nokia.IMEI}, Memória: {nokia.Memoria}");
Console.WriteLine($"Aparelho Iphone modelo: {iphone.Modelo}, Número: {iphone.Numero}, IMEI: {iphone.IMEI}, Memória: {iphone.Memoria}");
