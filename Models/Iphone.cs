namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) :
            base(numero, modelo, imei, memoria)
        {
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console
                .WriteLine($"1 - Abrir App Store e baixar {nomeApp} 2 - Voltar para Área de Trabalho");
            string switch_on = Console.ReadLine();
            switch (switch_on)
            {
                case "1":
                    Console.WriteLine($"Baixando app {nomeApp}");
                    break;
                case "2":
                    Console.WriteLine("Voltando para Área de Trabalho");
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }
    }
}
