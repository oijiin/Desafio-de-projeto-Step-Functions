namespace DesafioPOO.Models
{
    public abstract class Smartphone : NotifyPropertyChangedBase
    {
        private string _numero;
        public string Numero
        {
            get => _numero;
            set => SetField(ref _numero, value);
        }

        private string _modelo;
        public string Modelo
        {
            get => _modelo;
            set => SetField(ref _modelo, value);
        }

        private string _imei;
        public string IMEI
        {
            get => _imei;
            set => SetField(ref _imei, value);
        }

        private int _memoria;
        public int Memoria
        {
            get => _memoria;
            set => SetField(ref _memoria, value);
        }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar() => Console.WriteLine("Ligando...");

        public void ReceberLigacao() => Console.WriteLine("Recebendo ligação...");

        public abstract void InstalarAplicativo(string nomeApp);
    }
}
