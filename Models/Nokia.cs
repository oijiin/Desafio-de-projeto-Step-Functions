namespace DesafioPOO.Models{
    public class Nokia : Smartphone{
        public override void InstalarAplicativo(string nomeApp){
            Console.WriteLine("Instalando o aplicativo " + nomeApp + " no Nokia");
        }
    }
}