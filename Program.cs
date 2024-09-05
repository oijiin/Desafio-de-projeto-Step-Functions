using DesafioPOO.Models;

//Desafio Concluído


Console.WriteLine("Iphone Mobile");
Smartphone iphone = new Iphone(numero: "+244 943 788 485", modelo: "8 Plus", imei: "251233137863183", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Netflix");



Console.WriteLine("\nNokia Mobile");
Smartphone nokia = new Nokia(numero: "+244 933 212 121", modelo: "Lumia", imei: "899009348712391", memoria: 16);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");
