// Roteiro 04   - "Trabalhar com os dados variáveis em aplicativos de console C# (Introdução ao C#, Parte 4)"
// Modulo 01    - "Escolher o tipo de dados correto em seu código C#"
// Unidade 03   - "Exercício – Descobrir tipos integrais" (10min)
// https://learn.microsoft.com/pt-br/training/modules/csharp-choose-data-type/3-exercise-integral-types

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

#region CT01FCS_R04M01U03



#region Usar as propriedades MinValue e MaxValue para cada tipo integral com sinal
Console.WriteLine("Signed integral types");

Console.WriteLine($"sbyte   : {sbyte.MinValue} to {sbyte.MaxValue}");
Console.WriteLine($"short   : {short.MinValue} to {short.MaxValue}");
Console.WriteLine($"int     : {int.MinValue} to {int.MaxValue}");
Console.WriteLine($"long    : {long.MinValue} to  {long.MaxValue}");
#endregion


#region Tipos integrais sem sinal
#region Usar as propriedades MinValue e MaxValue para cada tipo integral sem sinal
Console.WriteLine();
Console.WriteLine("Unsigned integral types");

Console.WriteLine($"byte    : {byte.MinValue} to {byte.MaxValue}");
Console.WriteLine($"ushort  : {ushort.MinValue} to {ushort.MaxValue}");
Console.WriteLine($"uint    : {uint.MinValue} to {uint.MaxValue}");
Console.WriteLine($"ulong   : {ulong.MinValue} to  {ulong.MaxValue}");
#endregion
#endregion



#endregion