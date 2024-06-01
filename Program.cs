using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

var iphone = new Iphone("11975669987", "12", "2234324324aassookncbvgg");
var nokia = new Nokia("11988456777","TDX","28340382893nvbcc");

iphone.InstalarAplicativo("Tinder");
iphone.InstalarAplicativo("Banco Nubank");
iphone.InstalarAplicativo("Waze");
iphone.InstalarAplicativo("Google Maps");
iphone.InstalarAplicativo("Uber");
iphone.InstalarMemoria(6);

iphone.ExibirRecursos();
iphone.Ligar();
iphone.ReceberLigacao();

Console.WriteLine("-----------------------------------");

nokia.InstalarAplicativo("Happn");
nokia.InstalarAplicativo("Banco Bradesco");
nokia.InstalarAplicativo("Waze");
nokia.InstalarAplicativo("Zé Delivery");
nokia.InstalarAplicativo("Mototaxi");
nokia.InstalarMemoria(6);

nokia.ExibirRecursos();
nokia.Ligar();
nokia.ReceberLigacao();

Console.ReadLine();

