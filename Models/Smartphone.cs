namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo;
        private string Mei;
        private int Memoria;
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama

        public Smartphone(string numero, string modelo, string mei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Mei = mei;
            Memoria = memoria;
            // TODO: Passar os parâmetros do construtor para as propriedades
        }

        protected Smartphone(string numero)
        {
            Numero = numero;
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