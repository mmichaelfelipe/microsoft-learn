// Roteiro 04   - "Trabalhar com os dados variáveis em aplicativos de console C# (Introdução ao C#, Parte 4)"
// Modulo 04    - "Executar operações em matrizes usando métodos auxiliares em C#"
// Unidade 02   - "Exercício – Investigar as noções básicas da formatação de cadeia de caracteres" (20min)
// https://learn.microsoft.com/pt-br/training/modules/csharp-format-strings/2-string-formatting-basics

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

#region CT01FCS_R04M04U02


#region O que é a Formatação Composta?
//string first = "Hello";
//string second = "World";
//string result = string.Format("{0} {1}!", first, second);
//Console.WriteLine(result);

#region 1.
//string first = "Hello";
//string second = "World";
//Console.WriteLine("{1} {0}!", first, second);
//Console.WriteLine("{0} {0} {0}!", first, second);
#endregion
#endregion

#region O que é interpolação de cadeia de caracteres?
#region 1.
//string first = "Hello";
//string second = "World";
//Console.WriteLine($"{first} {second}!");
//Console.WriteLine($"{second} {first}!");
//Console.WriteLine($"{first} {first} {first}!");
#endregion
#endregion

#region Moeda de formatação
//decimal price = 123.45m;
//int discount = 50;
//Console.WriteLine($"Price: {price:C} (Save {discount:C})");
#endregion

#region Formatar números
//decimal measurement = 123456.78912m;
//Console.WriteLine($"Measurement: {measurement:N} units");
//Console.WriteLine($"Measurement: {measurement:N4} units");
#endregion

#region Formatar percentuais
//decimal tax = .36785m;
//Console.WriteLine($"Tax rate: {tax:P2}");
#endregion

#region Combinar abordagens de formatação
decimal price = 67.55m;
decimal salePrice = 59.99m;

string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);

yourDiscount += $"A discount of {((price - salePrice)/price):P2}!"; //inserted
Console.WriteLine(yourDiscount);
#endregion

#endregion