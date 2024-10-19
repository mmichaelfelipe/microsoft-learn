// Roteiro 04   - "Trabalhar com os dados variáveis em aplicativos de console C# (Introdução ao C#, Parte 4)"
// Modulo 05    - "Modificar o conteúdo de cadeias de caracteres usando métodos internos de tipo de dados em C#"
// Unidade 04   - "Exercício – Usar os métodos Remove() e Replace()" (08min)
// https://learn.microsoft.com/pt-br/training/modules/csharp-modify-content/4-exercise-remove-replace

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

#region CT01FCS_R04M05U04

#region Usar o método (Remove)
#region Remover caracteres em locais específicos de uma cadeia de caracteres
#region 2.
string data = "12345John Smith          5000  3  ";
string updateData = data.Remove(5, 20);
Console.WriteLine(data);
Console.WriteLine(updateData);
#endregion
#endregion
#endregion

#region Usar o método Replace()
#region Remover caracteres, independentemente de onde eles aparecem em uma cadeia de caracteres
#region 1.
string message = "This--is--ex-amp-le--da-ta";
message = message.Replace("--", " ");
message = message.Replace("-", "");

//message = message
//    .Replace("--", " ")
//    .Replace("-", "");

Console.WriteLine(message);
#endregion
#endregion
#endregion

#endregion