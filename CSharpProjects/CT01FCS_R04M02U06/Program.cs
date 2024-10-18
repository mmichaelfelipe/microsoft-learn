// Roteiro 04   - "Trabalhar com os dados variáveis em aplicativos de console C# (Introdução ao C#, Parte 4)"
// Modulo 02    - "Converter tipos de dados usando técnicas de conversão cast em C#"
// Unidade 06   - "Exercício – Concluir o desafio de imprimir na tela operações matemáticas como tipos de número específicos" (06min)
// https://learn.microsoft.com/pt-br/training/modules/csharp-convert-cast/6-challenge-2

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System.Globalization;
CultureInfo.CurrentCulture = new CultureInfo("en-US");

#region CT01FCS_R04M02U06


#region 2.
int value1 = 11;
decimal value2 = 6.2m;
float value3 = 4.3f;

// Your code here to set result1
// Hint: You need to round the result to nearest integer (don't just truncate)
int result1 = Convert.ToInt32(value1 / value2);
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// Your code here to set result2
decimal result2 = value2 / (decimal)value3;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// Your code here to set result3
float result3 = value3 / value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");
#endregion

#region 3. Substitua os comentários de código do código inicial pelo seu próprio código para resolver o desafio:
/*
- Solucionar para result1: dividir value1 por value2, exibir o resultado como int
- Solucionar para result2: dividir value2 por value3, exibir o resultado como decimal
- Solucionar para result3: dividir value3 por value1, exibir o resultado como float

Resolva o desafio de modo que a sua saída seja semelhante a:
    Divide value1 by value2, display the result as an int: 2
    Divide value2 by value3, display the result as a decimal: 1.4418604651162790697674418605
    Divide value3 by value1, display the result as a float: 0.3909091
*/
#endregion
#endregion