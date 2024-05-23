using DesafioPOO.Models;

Console.WriteLine("Iniciando os testes com o smartphone Nokia");
var nokia = new Nokia("1234", "Tijolao", "4A2S288454SX", 256);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Microsoft Teams");
Console.WriteLine("Testes com o smartphone Nokia finalizados com sucesso!");

Console.WriteLine("\n\n\n");

Console.WriteLine("Iniciando os testes com o smartphone iPhone");
var iPhone = new Nokia("1985", "2", "32S9XQLLA59SB", 128);
iPhone.Ligar();
iPhone.ReceberLigacao();
iPhone.InstalarAplicativo("Mapas");
Console.WriteLine("Testes com o smartphone iPhone finalizados com sucesso!");