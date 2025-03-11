# Calculadora Tabajara 2025

![](https://i.imgur.com/xMCmm40.gif)

## Introdução

Calculadora simples que permite fazer as 4 operações básicas, calcular a tabuada e mostrar o histórico de operações.

## Funcionalidades

- **Operações Básicas**: Pode fazer somas, subtrações, divisões e multiplicações.
- **Suporte a Decimais**: Pode ser utilizada com números decimais.
- **Tratamento de Divisão por Zero**: Detecção de divisão por zero.
- **Tabuada**: Ela calcula a tabuada de um número de 1 a 10.
- **Histórico de Operações**: A calculadora armazena suas últimas operações matemáticas.

## Como utilizar

1. Clone o repositório ou baixe o código fonte.
2. Abra o terminal ou o prompt de comando e navegue até a pasta raiz
3. Utilize o comando abaixo para restaurar as dependências do projeto.

```
dotnet restore
```

4. Em seguida, compile a solução utilizando o comando:
   
```
dotnet build --configuration Release
```

5. Para executar o projeto compilando em tempo real
   
```
dotnet run --project Calculadora.ConsoleApp
```

6. Para executar o arquivo compilado, navegue até a pasta `./Calculadora.ConsoleApp/bin/Release/net8.0/` e execute o arquivo:
   
```
Calculdora.ConsoleApp.exe
```

## Requisitos

- .NET SDK (recomendado .NET 8.0 ou superior) para compilação e execução do projeto.