// Roteiro 04   - "Trabalhar com os dados variáveis em aplicativos de console C# (Introdução ao C#, Parte 4)"
// Modulo 05    - "Modificar o conteúdo de cadeias de caracteres usando métodos internos de tipo de dados em C#"
// Unidade 02   - "Exercício – Use os métodos auxiliares IndexOf() e Substring() da cadeia de caracteres" (25min)
// https://learn.microsoft.com/pt-br/training/modules/csharp-modify-content/2-exercise-indexof-substring

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

#region CT01FCS_R04M05U02


#region Escreva um código para encontrar pares de parênteses inseridas em uma cadeia de caracteres
#region 2.
//string message = "Find what is (inside the parentheses)";

//int openingPosition = message.IndexOf('(');
//int closingPosition = message.IndexOf(')');

//Console.WriteLine(openingPosition);
//Console.WriteLine(closingPosition);
#endregion
#endregion

#region Adicione o código para recuperar o valor entre parênteses
#region 1.
//string message = "Find what is (inside the parentheses)";

//int openingPosition = message.IndexOf('(');
//int closingPosition = message.IndexOf(')');

////Console.WriteLine(openingPosition);
////Console.WriteLine(closingPosition);

//int length = closingPosition - openingPosition;
//Console.WriteLine(message.Substring(openingPosition, length));
#endregion
#endregion

#region Modificar a posição inicial da subcadeia de caracteres
#region 1.
//string message = "Find what is (inside the parentheses)";

//int openingPosition = message.IndexOf('(');
//int closingPosition = message.IndexOf(')');

//openingPosition += 1;

//int length = closingPosition - openingPosition;
//Console.WriteLine(message.Substring(openingPosition, length));
#endregion

#region 4.
//string message = "What is the value <span>between the tags</span>?";

//int openingPosition = message.IndexOf("<span>");
//int closingPosition = message.IndexOf("</span>");

//openingPosition += 6;
//int length = closingPosition - openingPosition;
//Console.WriteLine(message.Substring(openingPosition, length));
#endregion
#endregion

#region Evitar valores mágicos
#region 2.
string message = "What is the value <span>between the tags</span>?";

const string openSpan = "<span>";
const string closeSpan = "</span>";

int openingPosition = message.IndexOf(openSpan);
int closingPosition = message.IndexOf(closeSpan);

openingPosition += openSpan.Length;
int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));
#endregion
#endregion

#endregion