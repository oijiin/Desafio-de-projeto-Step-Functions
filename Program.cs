using DesafioPOO.Models;

Smartphone iphone = new Iphone("123-4567", "iPhone 15", "2345678-Biscoito", 128);
Smartphone nokia = new Nokia("789-1111", "Nokia 1100", "2345678-Biscoito", 16);

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Telegram");