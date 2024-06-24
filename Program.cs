﻿using DesafioPOO.Models;
using System;
namespace DesafioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Nokia nokia = new Nokia("123456789", "Nokia 3310", "123456789", 16);
            nokia.Ligar();
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("WhatsApp");

            Iphone iphone = new Iphone("987654321", "Iphone 12", "987654321", 128);
            iphone.Ligar();
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Instagram");
        }
    }
}