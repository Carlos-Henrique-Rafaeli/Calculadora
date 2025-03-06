namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("Calculadora Tabajara 2025");
            Console.WriteLine("--------------------------");
            Console.WriteLine("");

            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("S - Sair");

            Console.WriteLine("");
            Console.Write("Escolha uma opção: ");

            string opcao = Console.ReadLine().ToUpper();

            if (opcao == "S")
            {
                return;
            }
            
            Console.Write("Digite o Primeiro Número: ");
            string primeiroNumeroString = Console.ReadLine();

            int primeiroNumero = Convert.ToInt32(primeiroNumeroString);

            Console.Write("Digite o Segundo Número: ");
            string segundoNumeroString = Console.ReadLine();
            int segundoNumero = Convert.ToInt32(segundoNumeroString);

            int resultado = 0;


            if (opcao == "1") {
                resultado = primeiroNumero + segundoNumero;
            }
            else {
                resultado = primeiroNumero - segundoNumero;
            }


            Console.WriteLine("Resultado: " + resultado);

            Console.ReadLine();
        }
    }
}
