namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private decimal lucroTotalDia = 0;
        private List<string> veiculos = new List<string>();

        // Construtor da classe Estacionamento
        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // IMPLEMENTADO!!!
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine($"O veículo com a placa {placa} já está cadastrado!\n" +
                    $" Por favor, cadastre uma placa diferente.");
            }
            else
            {
                veiculos.Add(placa);
            }

        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // IMPLEMENTADO!!!
            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // IMPLEMENTADO!!!
                int horas = Convert.ToInt32(Console.ReadLine());
                decimal valorTotal = precoInicial + precoPorHora * horas;
                lucroTotalDia += valorTotal;

                // IMPLEMENTADO!!!
                veiculos.Remove(placa);

                // Adicionei a impressão dos números decimais no valorTotal
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal.ToString("0.00")}");
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

                // IMPLEMENTADO!!!
                foreach (String veiculo in veiculos)
                {
                    Console.WriteLine($"{veiculo}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }

        // Para me desafiar, adicionei um método a mais, para listar o lucro total obtido
        public void LucroTotalDia()
        {
            Console.WriteLine($"O Lucro total do dia foi: R$ {lucroTotalDia.ToString("0.00")}");
        }
    }
}
