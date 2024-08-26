namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        private string _modelo;
        private string _iMEI;
        private int _memoria;

        public Smartphone(string numero, string modelo, string iMEI, int memoria)
        {
            Numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades
            _modelo = modelo;
            _iMEI = iMEI;
            _memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...\t");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...\t");
        }

        public abstract void InstalarAplicativo(string nomeApp);

        /*
        public void ExibirDetalhes()
        {
            Console.WriteLine("Detalhes do Smartphone:");
            Console.WriteLine($"\tNúmero: {Numero}");
            Console.WriteLine($"\tModelo: {_modelo}");
            Console.WriteLine($"\tIMEI: {_iMEI}");
            Console.WriteLine($"\tMemória: {_memoria} MB");
        }
        */
    }
}