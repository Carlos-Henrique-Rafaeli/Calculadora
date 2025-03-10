namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool calculadora = true;

            while (calculadora)
            {
                Console.Clear();
                
                Console.WriteLine("--------------------------");
                Console.WriteLine("Calculadora Tabajara 2025");
                Console.WriteLine("--------------------------");
                Console.WriteLine();

                Console.WriteLine("1 - Somar");
                Console.WriteLine("2 - Subtrair");
                Console.WriteLine("3 - Multiplicar");
                Console.WriteLine("4 - Dividir");
                Console.WriteLine("5 - Tabuada");
                Console.WriteLine("S - Sair");

                Console.WriteLine();
                Console.Write("Escolha uma opção: ");

                string opcao = Console.ReadLine().ToUpper();


                if (opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4" && opcao != "5" && opcao != "S")
                {
                    Console.WriteLine("Opcão Inválida!");
                    Console.ReadLine();
                    continue;
                }
                else if (opcao == "S")
                {
                    calculadora = false;
                    break;
                }
                else if (opcao == "5")
                {
                    Console.Clear();

                    Console.WriteLine("--------------------------");
                    Console.WriteLine("Tabuada");
                    Console.WriteLine("--------------------------");

                    Console.Write("Digite um número: ");

                    int numeroTabuada = Convert.ToInt32(Console.ReadLine());

                    for (int contador = 1; contador <= 10; contador++)
                    {
                        int resultadoTabuada = numeroTabuada * contador;

                        Console.WriteLine($"{numeroTabuada} * {contador} = {resultadoTabuada}");

                    }

                    Console.WriteLine("\nPressione ENTER para voltar!");
                    Console.ReadLine();
                    continue;
                }


                Console.Write("Digite o Primeiro Número: ");
                string primeiroNumeroString = Console.ReadLine();
                decimal primeiroNumero = Convert.ToDecimal(primeiroNumeroString);

                Console.Write("Digite o Segundo Número: ");
                string segundoNumeroString = Console.ReadLine();
                decimal segundoNumero = Convert.ToDecimal(segundoNumeroString);


                decimal resultado = 0;
                bool operacaoValida = true;


                if (opcao == "1")
                {
                    resultado = primeiroNumero + segundoNumero;
                }

                else if (opcao == "2")
                {
                    resultado = primeiroNumero - segundoNumero;
                }

                else if (opcao == "3")
                {
                    resultado = primeiroNumero * segundoNumero;
                }

                else if (opcao == "4")
                {

                    if (segundoNumero != 0)
                    {
                        resultado = primeiroNumero / segundoNumero;
                    }

                    else
                    {
                        Console.WriteLine("Divisão por 0!");
                        operacaoValida = false;
                    }
                }


                if (operacaoValida) 
                {
                    Console.WriteLine("Resultado: " + resultado.ToString("F2"));
                }

                
                Console.Write("\nDeseja fazer outro cálculo? (s/n): ");
                
                string continuar = Console.ReadLine().ToLower();

                if (continuar != "s")
                {
                    calculadora = false;
                }

            }
            
            Console.WriteLine("\nCalculadora Encerrada.");
            Console.WriteLine("Pressione ENTER para sair!");
            Console.ReadLine();
        }
    }
}
