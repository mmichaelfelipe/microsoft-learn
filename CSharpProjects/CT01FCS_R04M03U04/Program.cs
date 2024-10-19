// Roteiro 04   - "Trabalhar com os dados variáveis em aplicativos de console C# (Introdução ao C#, Parte 4)"
// Modulo 03    - "Executar operações em matrizes usando métodos auxiliares em C#"
// Unidade 04   - "Exercício – Descobrir Split() e Join()" (10min)
// https://learn.microsoft.com/pt-br/training/modules/csharp-arrays-operations/4-exercise-split-join

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

#region CT01FCS_R04M03U04


#region Métodos de matriz do tipo de dados de cadeia de caracteres
#region Use o ToCharArray() para reverter um string
#region 2.
//string value = "abc123";
//char[] valueArray = value.ToCharArray();
#endregion
#endregion

#region Inverter e, em seguida, combinar a matriz char em uma nova cadeia de caracteres
#region 1.
//string value = "abc123";
//char[] valueArray = value.ToCharArray();
//Array.Reverse(valueArray);
//string result = new string(valueArray);
//Console.WriteLine(result);
#endregion
#endregion

#region Combine todos os caracteres em uma nova cadeia de caracteres com valor separado por vírgula usando Join()
#region 1.
//string value = "abc123";
//char[] valueArray = value.ToCharArray();
//Array.Reverse(valueArray);
////string result = new string(valueArray);
//string result = String.Join(",", valueArray);
//Console.WriteLine(result);
#endregion
#endregion

#region Split() a nova cadeia de caracteres de valor separado por vírgula em uma matriz de cadeias de caracteres
#region 1.
string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
//string result = new string(valueArray);
string result = String.Join(",", valueArray);
Console.WriteLine(result);

string[] items = result.Split(',');
foreach (var item in items)
{
    Console.WriteLine(item);
}
#endregion
#endregion
#endregion

#endregion