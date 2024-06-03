using DesafioPOO.Models;

Nokia nokia = new Nokia("111", "1973", "7asgda7g", 49);
Iphone iphone = new Iphone("222", "7S", "asd2g2782", 27);

nokia.InstalarAplicativo("WhatsApp");
nokia.ReceberLigacao();
nokia.Ligar();

iphone.InstalarAplicativo("WhatsApp");
iphone.ReceberLigacao();
iphone.Ligar();