using DesafioPOO.Models;

// Testando a classe Nokia
        Nokia nokia = new Nokia("123456789", "Nokia 3310", "111111111111111", 64);
        Console.WriteLine("=== Testando Nokia ===");
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");

        Console.WriteLine();

// Testando a classe Iphone
        Iphone iphone = new Iphone("987654321", "iPhone 13", "222222222222222", 128);
        Console.WriteLine("=== Testando iPhone ===");
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");