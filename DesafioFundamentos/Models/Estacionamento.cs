namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            string placa = "";

            do
            {
                Console.WriteLine("Digite a placa do veículo para estacionar:");
                placa = Console.ReadLine();
            } while(placa == "");
            

            veiculos.Add(placa);

            Console.WriteLine($"\nVeículo da placa {placa} adicionado com sucesso\n");

        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("\nDigite a quantidade de horas que o veículo permaneceu estacionado:");

                int.TryParse(Console.ReadLine(), out int horas);
                decimal valorTotal = precoInicial + precoPorHora * horas; 

                veiculos.Remove(placa);

                Console.WriteLine($"\nO veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}\n");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                
                foreach (string item in veiculos)
                {
                    Console.WriteLine(item);
                }

            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
