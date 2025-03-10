namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool calculadora = true;

            string[] opcoesValidas = { "1", "2", "3", "4", "5", "6", "S" };

            //List<string> historico = new List<string>();

            string[] operacoesRealizadas = new string[10];
            int indiceHistorico = 0;

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
                Console.WriteLine("6 - Hístórico");
                Console.WriteLine("S - Sair");

                Console.Write("\nEscolha uma opção: ");

                string opcao = Console.ReadLine().ToUpper();


                if (!opcoesValidas.Contains(opcao))
                {
                    Console.WriteLine("\nOpcão Inválida!");
                    Console.WriteLine("\nPressione ENTER para voltar!");
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

                    Console.Write("\nDigite um número: ");

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
                else if (opcao == "6")
                { 
                    Console.Clear();
                    Console.WriteLine("--------------------------");
                    Console.WriteLine("Histórico");
                    Console.WriteLine("--------------------------");
                    foreach (var hist in operacoesRealizadas)
                    {
                        if (!string.IsNullOrEmpty(hist))
                            Console.WriteLine(hist);
                    }

                    Console.WriteLine("\nPressione ENTER para voltar!");
                    Console.ReadLine();
                    continue;
                }


                Console.Write("\nDigite o Primeiro Número: ");
                string primeiroNumeroString = Console.ReadLine();
                decimal primeiroNumero = Convert.ToDecimal(primeiroNumeroString);

                Console.Write("\nDigite o Segundo Número: ");
                string segundoNumeroString = Console.ReadLine();
                decimal segundoNumero = Convert.ToDecimal(segundoNumeroString);


                decimal resultado = 0;
                bool operacaoValida = true;

                if (indiceHistorico >= operacoesRealizadas.Length)
                    indiceHistorico = 0;

                if (opcao == "1")
                {
                    resultado = primeiroNumero + segundoNumero;
                    operacoesRealizadas[indiceHistorico] = $"{primeiroNumero} + {segundoNumero} = {resultado}";
                    indiceHistorico++;
                    //historico.Add($"{primeiroNumero} + {segundoNumero} = {resultado}");
                }

                else if (opcao == "2")
                {
                    resultado = primeiroNumero - segundoNumero;
                    operacoesRealizadas[indiceHistorico] = $"{primeiroNumero} - {segundoNumero} = {resultado}";
                    indiceHistorico++;
                    //historico.Add($"{primeiroNumero} - {segundoNumero} = {resultado}");
                }

                else if (opcao == "3")
                {
                    resultado = primeiroNumero * segundoNumero;
                    operacoesRealizadas[indiceHistorico] = $"{primeiroNumero} * {segundoNumero} = {resultado}";
                    indiceHistorico++;
                    //historico.Add($"{primeiroNumero} * {segundoNumero} = {resultado}");
                }

                else if (opcao == "4")
                {

                    if (segundoNumero != 0)
                    {
                        resultado = primeiroNumero / segundoNumero;
                        operacoesRealizadas[indiceHistorico] = $"{primeiroNumero} / {segundoNumero} = {resultado}";
                        indiceHistorico++;

                        //historico.Add($"{primeiroNumero} / {segundoNumero} = {resultado}");
                    }

                    else
                    {
                        Console.WriteLine("Divisão por 0!");
                        operacaoValida = false;
                    }
                }


                if (operacaoValida) 
                {
                    Console.WriteLine("\nResultado: " + resultado.ToString("F2"));
                }

                
                Console.Write("\nDeseja fazer outro cálculo? (S/N): ");
                
                string continuar = Console.ReadLine().ToUpper();

                if (continuar != "S")
                {
                    calculadora = false;
                }

            }
            
            Console.WriteLine("\nCalculadora Encerrada.");
            Console.WriteLine("\nPressione ENTER para sair!");
            Console.ReadLine();
        }
    }
}
