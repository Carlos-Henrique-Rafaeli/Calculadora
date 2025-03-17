namespace Calculadora.ConsoleApp;

internal class Program
{
    static string[] opcoesValidas = { "1", "2", "3", "4", "5", "6", "S" };

    static void Main(string[] args)
    {
        while (true)
        {
            string opcao = ExibirMenu();

            if (!opcoesValidas.Contains(opcao))
            {
                Console.WriteLine("Opcão Inválida!\nPressione ENTER para voltar!");
                Console.ReadLine();
                continue;
            }

            if (OpcaoSairFoiEscolhida(opcao))
                break;

            else if (OpcaoTabuadaFoiEscolhida(opcao))
                ExibirTabuada();

            else if (OpcaoHistoricoFoiEscolhida(opcao))
                ExibirHistorico();

            else
                ExibirResultado(RealizarCalculo(opcao));
        }

    }

    static string ExibirMenu()
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

        string opcao = Console.ReadLine()!.ToUpper();

        return opcao;
    }

    static bool OpcaoSairFoiEscolhida(string opcao)
    {
        bool opcaoSairFoiEscolhida = opcao == "S";
       
        return opcaoSairFoiEscolhida;
    }
    
    static bool OpcaoTabuadaFoiEscolhida(string opcao)
    {
        bool opcaoTabuadaFoiEscolhida = opcao == "5";
       
        return opcaoTabuadaFoiEscolhida;
    } 
    
    static bool OpcaoHistoricoFoiEscolhida(string opcao)
    {
        bool opcaoHistoricoFoiEscolhida = opcao == "6";
       
        return opcaoHistoricoFoiEscolhida;
    } 

    static void ExibirTabuada()
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
    }
    
    static void ExibirHistorico()
    {
        Console.Clear();
        Console.WriteLine("--------------------------");
        Console.WriteLine("Histórico de Operações");
        Console.WriteLine("--------------------------");

        string[] historicoOperacoes = Calculadora.ObterHistoricoDeOperacoes();

        foreach (var hist in historicoOperacoes)
        {
            if (!string.IsNullOrEmpty(hist))
                Console.WriteLine(hist);
        }

        Console.WriteLine("\nPressione ENTER para voltar!");
        Console.ReadLine();
    }
    
    static void ExibirResultado(decimal resultado)
    {
        Console.WriteLine("\n--------------------------");
        Console.WriteLine("Resultado: " + resultado.ToString("F2"));
        Console.WriteLine("--------------------------");
        
        Console.WriteLine("\nPressione ENTER para voltar!");
        Console.ReadLine();
    }

    static decimal RealizarCalculo(string operacao)
    {
        Console.Write("\nDigite o Primeiro Número: ");
        string primeiroNumeroString = Console.ReadLine()!;
        
        while (VerificarStringNumero(primeiroNumeroString))
        {
            Console.WriteLine("Número inválido!");
            Console.Write("Digite o primeiro número novamente: ");
            primeiroNumeroString = Console.ReadLine()!;
        }

        decimal primeiroNumero = Convert.ToDecimal(primeiroNumeroString);

        Console.Write("\nDigite o Segundo Número: ");
        string segundoNumeroString = Console.ReadLine()!;

        while (VerificarStringNumero(segundoNumeroString))
        {
            Console.WriteLine("Número inválido!");
            Console.Write("Digite o segundo número novamente: ");
            segundoNumeroString = Console.ReadLine()!;
        }
        
        decimal segundoNumero = Convert.ToDecimal(segundoNumeroString);

        decimal resultado = 0;

        if (operacao == "1")
            resultado = Calculadora.Somar(primeiroNumero, segundoNumero);

        else if (operacao == "2")
            resultado = Calculadora.Subtrair(primeiroNumero, segundoNumero);

        else if (operacao == "3")
            resultado = Calculadora.Multiplicar(primeiroNumero, segundoNumero);

        else if (operacao == "4")
        {

            while (segundoNumero == 0)
            {
                Console.WriteLine("Divisão por 0!");
                Console.Write("Digite o segundo número novamente: ");

                segundoNumeroString = Console.ReadLine()!;

                if (VerificarStringNumero(segundoNumeroString))
                    continue;

                segundoNumero = Convert.ToDecimal(segundoNumeroString);
            }             

            resultado = Calculadora.Dividir(primeiroNumero, segundoNumero);
            
        }
                
        return resultado;
    }

    static bool VerificarStringNumero(string x)
    {
        bool verificacao = String.IsNullOrEmpty(x) || !decimal.TryParse(x, out _);

        return verificacao;
    }
}
