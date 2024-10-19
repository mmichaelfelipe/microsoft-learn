// Roteiro 04   - "Trabalhar com os dados variáveis em aplicativos de console C# (Introdução ao C#, Parte 4)"
// Modulo 04    - "Executar operações em matrizes usando métodos auxiliares em C#"
// Unidade 04   - "Exercício – Descobrir o preenchimento e alinhamento" (12min)
// https://learn.microsoft.com/pt-br/training/modules/csharp-format-strings/4-exercise-string-methods-padding

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

#region CT01FCS_R04M04U04

//string first = "Hello";
//string second = "World";
//string result = string.Format("{0} {1}!", first, second);
//Console.WriteLine(result);

#region Formatar cadeias de caracteres adicionando um espaço em branco antes ou depois
#region 2.
//string input = "Pad this";
//Console.WriteLine(input.PadLeft(12));
#endregion

#region 6.
//string input = "Pad this";
//Console.WriteLine(input.PadLeft(12));
//Console.WriteLine(input.PadRight(12));
#endregion
#endregion

#region O que é um método sobrecarregado?
#region 2.
//string input = "Pad this";
//Console.WriteLine(input.PadLeft(12, '-'));
//Console.WriteLine(input.PadRight(12, '-'));
#endregion
#endregion

#region Como trabalhar com cadeias de caracteres preenchidas
#region Adicionar a ID de Pagamento à saída
#region 2.
//string paymentId = "769C";

//var formattedLine = paymentId.PadRight(6);

//Console.WriteLine(formattedLine);
#endregion
#endregion

#region Adicionar o nome do favorecido à saída
#region 1.
//string paymentId = "769C";
//string payeeName = "Mr. Stephen Ortega";

//var formattedLine = paymentId.PadRight(6);
//formattedLine += payeeName.PadRight(24);

//Console.WriteLine(formattedLine);
#endregion
#endregion

#region Adicionar o valor do pagamento à saída
#region 1.
//string paymentId = "769C";
//string payeeName = "Mr. Stephen Ortega";
//string paymentAmount = "$5,000.00";

//var formattedLine = paymentId.PadRight(6);
//formattedLine += payeeName.PadRight(24);
//formattedLine += paymentAmount.PadLeft(10);

//Console.WriteLine(formattedLine);
#endregion
#endregion

#region Adicionar uma linha de números acima da saída para confirmar mais facilmente o resultado
#region 1.
string paymentId = "769C";
string payeeName = "Mr. Stephen Ortega";
string paymentAmount = "$5,000.00";

var formattedLine = paymentId.PadRight(6);
formattedLine += payeeName.PadRight(24);
formattedLine += paymentAmount.PadLeft(10);

Console.WriteLine("1234567890123456789012345678901234567890");
Console.WriteLine(formattedLine);
#endregion
#endregion
#endregion

#endregion