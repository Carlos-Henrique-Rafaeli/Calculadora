# Calculadora Tabajara 2025

![](https://i.imgur.com/xMCmm40.gif)

## Introdu��o

Calculadora simples que permite fazer as 4 opera��es b�sicas, calcular a tabuada e mostrar o hist�rico de opera��es.

## Funcionalidades

- **Opera��es B�sicas**: Pode fazer somas, subtra��es, divis�es e multiplica��es.
- **Suporte a Decimais**: Pode ser utilizada com n�meros decimais.
- **Tratamento de Divis�o por Zero**: Detec��o de divis�o por zero.
- **Tabuada**: Ela calcula a tabuada de um n�mero de 1 a 10.
- **Hist�rico de Opera��es**: A calculadora armazena suas �ltimas opera��es matem�ticas.

## Como utilizar

1. Clone o reposit�rio ou baixe o c�digo fonte.
2. Abra o terminal ou o prompt de comando e navegue at� a pasta raiz
3. Utilize o comando abaixo para restaurar as depend�ncias do projeto.

```
dotnet restore
```

4. Em seguida, compile a solu��o utilizando o comando:
   
```
dotnet build --configuration Release
```

5. Para executar o projeto compilando em tempo real
   
```
dotnet run --project Calculadora.ConsoleApp
```

6. Para executar o arquivo compilado, navegue at� a pasta `./Calculadora.ConsoleApp/bin/Release/net8.0/` e execute o arquivo:
   
```
Calculdora.ConsoleApp.exe
```

## Requisitos

- .NET SDK (recomendado .NET 8.0 ou superior) para compila��o e execu��o do projeto.