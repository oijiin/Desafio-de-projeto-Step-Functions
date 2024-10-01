using DesafioPOO.Models;

Nokia nokia1 = new Nokia(numero: "1231", modelo: "3", imei: "12232131243", memoria: 64);
nokia1.Ligar();
nokia1.InstalarAplicativo("Instagram");


Iphone apple1 = new Iphone(numero: "12", modelo: "17", imei: "111111111", memoria: 256);
apple1.Ligar();
apple1.InstalarAplicativo("Gmail");
apple1.ReceberLigacao("Lucas");