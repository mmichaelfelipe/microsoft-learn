// Roteiro 04   - "Trabalhar com os dados variáveis em aplicativos de console C# (Introdução ao C#, Parte 4)"
// Modulo 01    - "Escolher o tipo de dados correto em seu código C#"
// Unidade 04   - "Exercício – Descobrir tipos de ponto flutuante" (08min)
// https://learn.microsoft.com/pt-br/training/modules/csharp-choose-data-type/4-exercise-floating-point-types

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

#region CT01FCS_R04M01U04



#region Avaliar tipos de ponto flutuante
#region Usar as propriedades MinValue e MaxValue para tipo de float com sinal
Console.WriteLine();
Console.WriteLine("Floating point types:");
Console.WriteLine($"float   : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
Console.WriteLine($"double  : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
Console.WriteLine($"decimal : {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");
#endregion

#region Decifrar valores grandes de ponto flutuante
/*  Como os tipos de ponto flutuante podem conter números grandes com precisão,
    os valores podem ser representados usando a "notação E",
    que é uma forma de notação científica que significa "vezes dez elevado à potência de". 
    Assim, um valor como 5E+2 seria o valor 500, pois é equivalente a 5 * 10^2 ou 5 x 102.

    Exemplo:
    Escrever o número “3,4028235E+38” sem usar a notação E resultaria em um número extremamente longo, 
    com 38 zeros após o número 34028235. Isso seria algo como:
    340282350000000000000000000000000000000
*/
#endregion
#endregion



#endregion