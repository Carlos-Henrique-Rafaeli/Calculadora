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
                Console.WriteLine("S - Sair");

                Console.WriteLine();
                Console.Write("Escolha uma opção: ");

                string opcao = Console.ReadLine().ToUpper();

                if (opcao == "S")
                {
                    calculadora = false;
                    break;
                }
                else if (opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4") 
                {
                    Console.WriteLine("Opcão Inválida!");
                    Console.ReadLine();
                    continue;
                }


                Console.Write("Digite o Primeiro Número: ");
                string primeiroNumeroString = Console.ReadLine();
                int primeiroNumero = Convert.ToInt32(primeiroNumeroString);

                Console.Write("Digite o Segundo Número: ");
                string segundoNumeroString = Console.ReadLine();
                int segundoNumero = Convert.ToInt32(segundoNumeroString);


                int resultado = 0;
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
                    Console.WriteLine("Resultado: " + resultado);
                }

                
                Console.Write("Deseja fazer outro cálculo? (s/n): ");
                
                string continuar = Console.ReadLine().ToLower();

                if (continuar != "s")
                {
                    calculadora = false;
                }

            }
            
            Console.WriteLine("Calculadora Encerrada.");
            Console.ReadLine();
        }
    }
}
