namespace sistema_de_lanchonete
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            double total = 0;

            do
            {
                Console.WriteLine("\n==== CARDÁPIO DE BEBIDAS ====");
                Console.WriteLine("1. Coca-Cola - R$ 5,00");
                Console.WriteLine("2. Suco de Laranja - R$ 6,00");
                Console.WriteLine("3. Água - R$ 3,00");
                Console.WriteLine("4. Café - R$ 4,00");
                Console.WriteLine("5. Finalizar Pedido");
                Console.WriteLine("===============================");

                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        total += 5.00;
                        Console.WriteLine("Coca-Cola adicionada ao pedido.");
                        break;
                    case 2:
                        total += 6.00;
                        Console.WriteLine("Suco de Laranja adicionado ao pedido.");
                        break;
                    case 3:
                        total += 3.00;
                        Console.WriteLine("Água adicionada ao pedido.");
                        break;
                    case 4:
                        total += 4.00;
                        Console.WriteLine("Café adicionado ao pedido.");
                        break;
                    case 5:
                        Console.WriteLine($"Pedido finalizado. Total a pagar: R$ {total:F2}");
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }

            }while (opcao != 5);

            Console.WriteLine($"valor total do pedido: R$ {total:F2}");
            Console.WriteLine("Obrigado pela preferência!");
        }
    }
}
