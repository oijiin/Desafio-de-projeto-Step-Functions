using DesafioPOO.Models;

// [x] TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smarphone Iphone:");
Smartphone iphone = new Iphone(numero: "555-5678", modelo: "iPhone 13", imei: "987654321098765", memoria: 256);
iphone.Ligar();
iphone.InstalarAplicativo("Netflix");

Console.WriteLine("");

Console.WriteLine("Smarphone Nokia:");
Smartphone nokia = new Nokia(numero: "555-1234", modelo: "Nokia 3310", imei: "123456789012345", memoria: 16);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");