using DesafioPOO.Models;

Console.WriteLine("******Testes Smartphone Nokia******\n");
Nokia nokia = new("71 98764-5802", "A10", "65as65a6s565s", 256);
Nokia nokia2 = new("71 99707-3662", "G10", "95655ASDASASD", 128);
nokia.InstalarAplicativo("IFood");
Console.WriteLine("\n Informações do(s) aparelho(s): \n");
Console.WriteLine($"Número(s): {nokia.Numero} | {nokia2.Numero}\n");

Console.WriteLine($"Testando ligação do aparelho {nokia.Numero}");
nokia.Ligar();
Console.WriteLine($"Testando recebendo uma ligação no aparelho {nokia.Numero}");
nokia.ReceberLigacao();

Console.WriteLine("\n******Testes Smartphone Iphone******\n");
Iphone iphone = new("71 98522-5859", "C30", "GDFD656565", 512);
iphone.InstalarAplicativo("Uber");
Console.WriteLine("\n Informações do aparelho: \n");
Console.WriteLine($"Número(s): {iphone.Numero} \n");

Console.WriteLine($"Testando ligação do aparelho {iphone.Numero}");
iphone.Ligar();
Console.WriteLine($"Testando recebendo uma ligação no aparelho {nokia.Numero}");
iphone.ReceberLigacao();
