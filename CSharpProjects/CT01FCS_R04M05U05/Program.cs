// Roteiro 04   - "Trabalhar com os dados variáveis em aplicativos de console C# (Introdução ao C#, Parte 4)"
// Modulo 05    - "Modificar o conteúdo de cadeias de caracteres usando métodos internos de tipo de dados em C#"
// Unidade 05   - "Exercício: conclua um desafio para extrair, substituir e remover os dados de uma cadeia de caracteres de entrada" (10min)
// https://learn.microsoft.com/pt-br/training/modules/csharp-modify-content/5-exercise-challenge-extract-replace-remove-data

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

#region CT01FCS_R04M05U05


#region Extrair, substituir e remover dados de uma cadeia de caracteres de entrada
#region 2.
const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = string.Empty;
string output = string.Empty;

// Your work here
const string startTagSpan = "<span>";
const string endTagSpan = "</span>";
var quantityStartPosition = input.IndexOf(startTagSpan) + startTagSpan.Length;
var quantityEndPosition = input.IndexOf(endTagSpan);
quantity = input.Substring(quantityStartPosition, quantityEndPosition - quantityStartPosition);
quantity = $"Quantity: {quantity}";

const string startTagDiv = "<div>";
const string endTagDiv = "</div>";
var outputStartPosition = input.IndexOf(startTagDiv) + startTagDiv.Length;
var outputEndPosition = input.IndexOf(endTagDiv);
output = input.Substring(outputStartPosition, outputEndPosition - outputStartPosition);
output = output.Replace("&trade;", "&reg;");
output = $"Output: {output}";


Console.WriteLine(quantity);
Console.WriteLine(output);
#endregion
#endregion

#endregion