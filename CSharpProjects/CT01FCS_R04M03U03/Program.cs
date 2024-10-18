// Roteiro 04   - "Trabalhar com os dados variáveis em aplicativos de console C# (Introdução ao C#, Parte 4)"
// Modulo 02    - "Executar operações em matrizes usando métodos auxiliares em C#"
// Unidade 03   - "Exercício – Explorar os métodos Clear() e Resize()" (15min)
// https://learn.microsoft.com/pt-br/training/modules/csharp-arrays-operations/3-exercise-clear-resize

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

#region CT01FCS_R04M03U03


#region Usar métodos de matriz para limpar e redimensionar uma matriz
#region 2.
//string[] pallets = { "B14", "A11", "B12", "A13" };
//Console.WriteLine("");

//Array.Clear(pallets, 0, 2);
//Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
//foreach (var pallet in pallets)
//{
//    Console.WriteLine($"-- {pallet}");
//}
#endregion
#endregion


#region Cadeia de caracteres vazia versus nula
#region Acessar o valor de um elemento que foi limpo
#region 1.
//string[] pallets = { "B14", "A11", "B12", "A13" };
//Console.WriteLine("");

//Console.WriteLine($"Before: {pallets[0]}");
//Array.Clear(pallets, 0, 2);
//Console.WriteLine($"After: {pallets[0]}");

//Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
//foreach (var pallet in pallets)
//{
//    Console.WriteLine($"-- {pallet}");
//}
#endregion
#endregion

#region Chamar um método auxiliar de cadeia de caracteres em um elemento limpo
#region 1.
//string[] pallets = { "B14", "A11", "B12", "A13" };
//Console.WriteLine("");

//Console.WriteLine($"Before: {pallets[0].ToLower()}");
//Array.Clear(pallets, 0, 2);
//Console.WriteLine($"After: {pallets[0].ToLower()}");

//Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
//foreach (var pallet in pallets)
//{
//    Console.WriteLine($"-- {pallet}");
//}
#endregion

//string[] pallets = { "B14", "A11", "B12", "A13" };
//Console.WriteLine("");

//if (pallets[0] != null)
//    Console.WriteLine($"Before: {pallets[0].ToLower()}");
//Array.Clear(pallets, 0, 2);
//if (pallets[0] != null)
//    Console.WriteLine($"After: {pallets[0].ToLower()}");

//Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
//foreach (var pallet in pallets)
//{
//    Console.WriteLine($"-- {pallet}");
//}
#endregion

#region Redimensionar a matriz para adicionar mais elementos
#region 1.
//string[] pallets = { "B14", "A11", "B12", "A13" };
//Console.WriteLine("");

//Array.Clear(pallets, 0, 2);
//Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
//foreach (var pallet in pallets)
//{
//    Console.WriteLine($"-- {pallet}");
//}

//Console.WriteLine("");
//Array.Resize(ref pallets, 6);
//Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

//pallets[4] = "C01";
//pallets[5] = "C02";

//foreach (var pallet in pallets)
//{
//    Console.WriteLine($"-- {pallet}");
//}
#endregion
#endregion

#region Redimensionar a matriz para remover elementos
#region 1.
string[] pallets = { "B14", "A11", "B12", "A13" };
Console.WriteLine("");

Array.Clear(pallets, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 3);
Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
#endregion
#endregion
#endregion

#endregion