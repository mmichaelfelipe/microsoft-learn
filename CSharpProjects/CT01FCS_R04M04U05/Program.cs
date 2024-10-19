// Roteiro 04   - "Trabalhar com os dados variáveis em aplicativos de console C# (Introdução ao C#, Parte 4)"
// Modulo 04    - "Executar operações em matrizes usando métodos auxiliares em C#"
// Unidade 05   - "Exercício – Concluir um desafio em que é preciso aplicar a interpolação de cadeias de caracteres a uma carta-modelo" (10min)
// https://learn.microsoft.com/pt-br/training/modules/csharp-format-strings/5-challenge

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

#region CT01FCS_R04M04U05

#region 2.
string customerName = "Mr. Barros";

string currentProduct = "MagicYield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

// Your logic here
string message = $"Dear {customerName},\n" +
    $"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n\n" +
    $"Currently, you own {currentShares:N} shares at a return of {currentReturn:P}.\n\n" +
    $"Our new product, {newProduct} offers a return of {newReturn:P}.  Given your current volume, your potential profit would be {newProfit:C}.\n\n";
Console.WriteLine(message);

Console.WriteLine("Here's a quick comparison:\n");

// Your logic here
string comparisonMessage =
    $"{currentProduct}".PadRight(20) +
    $"{currentReturn:P}".PadRight(9) +
    $"{currentProfit:C}\n" +
    $"{newProduct}".PadRight(20) +
    $"{newReturn:P}".PadRight(9) +
    $"{newProfit:C}";

Console.WriteLine(comparisonMessage);
#endregion

#endregion