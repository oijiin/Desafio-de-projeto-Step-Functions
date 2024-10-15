using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia nokia = new Nokia("Nokia", "Nokia c12", "12345678910", 4);
nokia.Numero = "99999-9999";

Iphone iphone = new Iphone("Iphone", "Iphone X", "10987654321", 128);
iphone.Numero = "91111-1111";

iphone.InstalarAplicativo("Whatsapp");
nokia.InstalarAplicativo("Facebook");