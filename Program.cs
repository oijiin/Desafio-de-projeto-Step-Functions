using DesafioPOO.Models;
using System;
namespace DesafioPOO{
    class Program{
        static void Main(string[] args){
            Nokia nokia = new Nokia("61982754612", "Nokia 3310", "123456789", 1000);
            nokia.Ligar();
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("WhatsApp!");

            Iphone iphone = new Iphone("987654321", "iPhone 12", "987654321", 1000);
            iphone.Ligar();
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Telegram!");
        }
    }
}