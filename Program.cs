

class Program
{
    static void Main()
    {
    // TODO: Realizar os testes com as classes Nokia e Iphone
        Console.WriteLine("Smatphone Nokia");
        Nokia nokia = new Nokia("123456789", "Lumia 950", "123456789012345", 64);
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("Alura");

        Console.WriteLine("/n");

        Console.WriteLine("Smatphone iPhone");
        Iphone iphone = new Iphone("987654321", "13", "987654321098765", 128);
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Dio");
    }
}