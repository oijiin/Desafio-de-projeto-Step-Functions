using DesafioPOO.Models;


// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone nokia1");
Smartphone nokia1 = new Nokia(numero :"123456789" ,modelo : " modelo 1" ,memoria:"250" ,iMEI: "011");
Console.WriteLine("");
nokia1.Ligar();
nokia1.InstalarAplicativo("facebook");
        

Console.WriteLine("\n");


Console.WriteLine("Smartphone iphone1");
Smartphone iphone1 = new Iphone(numero :"123456789" ,modelo : " modelo 1" ,memoria:"250" ,iMEI: "011");
Console.WriteLine("");
iphone1.ReceberLigacao();
iphone1.InstalarAplicativo("telegram");
