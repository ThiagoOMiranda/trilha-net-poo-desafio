namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria)
                    : base(numero, modelo, imei, memoria)
        {

        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("____________________\n");
            Console.WriteLine($"Android OS:\nMemoria disponível: {this.Memoria}Gb \n" +
                                $"Instalando o aplicativo {nomeApp} no Nokia {this.Modelo}...\n" +
                                $"\n{nomeApp} instalado com sucesso!");
        }
    }
}
