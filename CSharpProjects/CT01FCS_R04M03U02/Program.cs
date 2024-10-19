// Roteiro 04   - "Trabalhar com os dados variáveis em aplicativos de console C# (Introdução ao C#, Parte 4)"
// Modulo 03    - "Executar operações em matrizes usando métodos auxiliares em C#"
// Unidade 02   - "Exercício – Conhecer as funções Sort() e Reverse()" (10min)
// https://learn.microsoft.com/pt-br/training/modules/csharp-arrays-operations/2-exercise-sort-reverse

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

#region CT01FCS_R04M03U02


#region Criar uma matriz de paletes, depois classificá-los
#region 2.
//string[] pallets = { "B14", "A11", "B12", "A13" };

//Console.WriteLine("Sorted...");
//Array.Sort(pallets);
//foreach (var pallet in pallets)
//{
//    Console.WriteLine($"-- {pallet}");
//}
#endregion
#endregion


#region Inverter a ordem dos paletes
#region 1.
string[] pallets = { "B14", "A11", "B12", "A13" };

Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Console.WriteLine("Reversed...");
Array.Reverse(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
#endregion
#endregion

#endregion