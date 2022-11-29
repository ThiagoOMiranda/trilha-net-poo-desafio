namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria)
                    : base(numero, modelo, imei, memoria)
        {

        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("____________________\n");
            Console.WriteLine($"Apple IOS:\nMemoria disponível: {this.Memoria}Gb \n" +
                                $"Instalando o aplicativo {nomeApp} no Iphone {this.Modelo}...\n" +
                                $"\n{nomeApp} instalado com sucesso!");
        }
    }
}