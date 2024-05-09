using DesafioPOO.Models;

class Program
{
    private const string NokiaNumero = "123456789";
    private const string NokiaModelo = "Nokia 1100";
    private const string NokiaIMEI = "IMEI123456789";
    private const int NokiaMemoria = 64;

    private const string IphoneNumero = "987654321";
    private const string IphoneModelo = "iPhone X";
    private const string IphoneIMEI = "IMEI987654321";
    private const int IphoneMemoria = 256;

    private const string AppNokia = "WhatsApp";
    private const string AppIphone = "Instagram";

    static void Main(string[] args)
    {
        Nokia nokia = new Nokia(NokiaNumero, NokiaModelo, NokiaIMEI, NokiaMemoria);
        Iphone iphone = new Iphone(IphoneNumero, IphoneModelo, IphoneIMEI, IphoneMemoria);

        LigarEInstalarApp(nokia, AppNokia);
        LigarEInstalarApp(iphone, AppIphone);
    }

    private static void LigarEInstalarApp(Smartphone smartphone, string app)
    {
        smartphone.Ligar();
        smartphone.InstalarAplicativo(app);
    }
}
