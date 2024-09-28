namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria) 
        {
            
        }
    
    // TODO: Herdar da classe "Smartphone"
    public override void InstalarAplicativo(string nome)
    {
        Console.WriteLine($"Instalando {nome} no Iphone.");
        // TODO: Sobrescrever o método "InstalarAplicativo"
    }
}

}