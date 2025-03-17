namespace Calculadora.ConsoleApp;

public static class Calculadora
{

    static string[] operacoesRealizadas = new string[10];
    static int indiceHistorico = 0;

    public static decimal Somar(decimal primeiroNumero, decimal segundoNumero)
    {
        decimal resultado = primeiroNumero + segundoNumero;

        VerificarHistorico();

        operacoesRealizadas[indiceHistorico] = $"{primeiroNumero} + {segundoNumero} = {resultado.ToString("F2")}";

        indiceHistorico++;

        return resultado;
    }

    public static decimal Subtrair(decimal primeiroNumero, decimal segundoNumero)
    {
        decimal resultado = primeiroNumero - segundoNumero;

        VerificarHistorico();

        operacoesRealizadas[indiceHistorico] = $"{primeiroNumero} - {segundoNumero} = {resultado.ToString("F2")}";

        indiceHistorico++;

        return resultado;
    }

    public static decimal Multiplicar(decimal primeiroNumero, decimal segundoNumero)
    {
        decimal resultado = primeiroNumero * segundoNumero;

        VerificarHistorico();

        operacoesRealizadas[indiceHistorico] = $"{primeiroNumero} * {segundoNumero} = {resultado.ToString("F2")}";

        indiceHistorico++;

        return resultado;
    }

    public static decimal Dividir(decimal primeiroNumero, decimal segundoNumero)
    {
        decimal resultado = primeiroNumero / segundoNumero;

        VerificarHistorico();

        operacoesRealizadas[indiceHistorico] = $"{primeiroNumero} / {segundoNumero} = {resultado.ToString("F2")}";

        indiceHistorico++;

        return resultado;
    }


    public static string[] GerarTabuada(int numeroTabuada)
    {
        string[] linhasTabuada = new string[10];

        for (int contador = 1; contador <= 10; contador++)
        {
            int resultadoTabuada = numeroTabuada * contador;

            linhasTabuada[contador - 1] = $"{numeroTabuada} * {contador} = {resultadoTabuada}";
        }

        return linhasTabuada;
    }


    static void VerificarHistorico()
    {
        if (indiceHistorico >= operacoesRealizadas.Length)
            indiceHistorico = 0;
    }

    public static string[] ObterHistoricoDeOperacoes()
    {
        return operacoesRealizadas;
    }
}
