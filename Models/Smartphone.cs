namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string _modelo;
        private string _iMEI;
        private int _memoria;
        public Smartphone(string numero, string modelo, string iMei, int memoria)
        {
            Numero = numero;
            _modelo = modelo;
            _iMEI = iMei;
            _memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}