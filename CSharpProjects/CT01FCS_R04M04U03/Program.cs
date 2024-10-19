// Roteiro 04   - "Trabalhar com os dados variáveis em aplicativos de console C# (Introdução ao C#, Parte 4)"
// Modulo 04    - "Executar operações em matrizes usando métodos auxiliares em C#"
// Unidade 03   - "Exercício – Explorar a interpolação de cadeia de caracteres" (08min)
// https://learn.microsoft.com/pt-br/training/modules/csharp-format-strings/3-exercise-string-interpolation

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

#region CT01FCS_R04M04U03


#region Exibir o número da fatura usando interpolação de cadeia de caracteres
#region 2.
//int invoiceNumber = 1201;
//decimal productShares = 25.4568m;
//decimal subtotal = 2700.00m;
//decimal taxPercentage = .15825m;
//decimal total = 3185.19m;

//Console.WriteLine($"Invoice Number: {invoiceNumber}");
#endregion
#endregion

#region Exibir as ações de produto com precisão de um milésimo (0,001)
#region 1.
//int invoiceNumber = 1201;
//decimal productShares = 25.4568m;
//decimal subtotal = 2700.00m;
//decimal taxPercentage = .15825m;
//decimal total = 3185.19m;

//Console.WriteLine($"Invoice Number: {invoiceNumber}");
//Console.WriteLine($"\tShares: {productShares:N3} Product");
#endregion
#endregion

#region Exibir o subtotal que você vai cobrar do cliente, formatado como moeda
#region 1.
//int invoiceNumber = 1201;
//decimal productShares = 25.4568m;
//decimal subtotal = 2700.00m;
//decimal taxPercentage = .15825m;
//decimal total = 3185.19m;

//Console.WriteLine($"Invoice Number: {invoiceNumber}");
//Console.WriteLine($"\tShares: {productShares:N3} Product");
//Console.WriteLine($"\t\tSubtotal: {subtotal:C}");
#endregion
#endregion

#region Exibir o imposto cobrado na venda, formatado como percentual
#region 1.
//int invoiceNumber = 1201;
//decimal productShares = 25.4568m;
//decimal subtotal = 2700.00m;
//decimal taxPercentage = .15825m;
//decimal total = 3185.19m;

//Console.WriteLine($"Invoice Number: {invoiceNumber}");
//Console.WriteLine($"\tShares: {productShares:N3} Product");
//Console.WriteLine($"\t\tSubtotal: {subtotal:C}");
//Console.WriteLine($"\t\t\tTax: {taxPercentage:P2}");
#endregion
#endregion

#region Finalizar o recibo com o valor total devido, formatado como moeda
#region 1.
int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subtotal = 2700.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");
Console.WriteLine($"\tShares: {productShares:N3} Product");
Console.WriteLine($"\t\tSubtotal: {subtotal:C}");
Console.WriteLine($"\t\t\tTax: {taxPercentage:P2}");
Console.WriteLine($"\t\tTotal Billed: {total:C}");
#endregion
#endregion


#endregion