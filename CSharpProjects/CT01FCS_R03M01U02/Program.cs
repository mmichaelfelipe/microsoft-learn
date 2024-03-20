// Roteiro 03   - "Adicionar lógica a aplicativos de console C# (Introdução ao C#, Parte 3)"
// Modulo 01    - "Avaliar expressões boolianas para tomar decisões em C#"
// Unidade 02   - "Exercício – Avaliar uma expressão" (11min)
// https://learn.microsoft.com/pt-br/training/modules/csharp-evaluate-boolean-expressions/2-exercise-boolean-expressions


// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

#region CT01FCS_R03M01U02



#region Avaliando igualdade e desigualdade

#region Use o operador de igualdade
//Console.WriteLine("a" == "a");
//Console.WriteLine("a" == "A");
//Console.WriteLine(1 == 2);

//string myValue = "a";
//Console.WriteLine(myValue == "a");
#endregion

#region Aprimore a verificação de igualdade de cadeira de caracteres usando métodos auxiliares internos da cadeia de caracteres
//string value1 = " a";
//string value2 = "A ";
//Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());
#endregion

#region Use o operador de desigualdade
//Console.WriteLine("a" != "a");
//Console.WriteLine("a" != "A");
//Console.WriteLine(1 != 2);

//string myValue = "a";
//Console.WriteLine(myValue != "a");
#endregion

#endregion



#region Avaliar comparações
/* Os operadores de comparação são:
 * >        Maior que
 * <        Menor que
 * >=       Maior que ou igual a
 * <=       Menor que ou igual a
 */

#region Use os operadores de comparação
//Console.WriteLine(1 > 2);
//Console.WriteLine(1 < 2);
//Console.WriteLine(1 >= 1);
//Console.WriteLine(1 <= 1);
#endregion

#endregion



#region Métodos que retornam um valor booliano

#region Usar um método que retorna um booliano
//string pangram = "The quick brown fox jumps over the lazy dog.";
//Console.WriteLine(pangram.Contains("fox"));
//Console.WriteLine(pangram.Contains("cow"));
#endregion

#endregion



#region O que é a negação lógica?
/* Operador de negação unário "!", também chamado de "operador not".
 */

#region Use o operador de negação lógica
string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(!pangram.Contains("fox"));
Console.WriteLine(!pangram.Contains("cow"));
#endregion

#region Operador de desigualdade versus negação lógica
/* O os exemplos abaixo produzem o mesmo resultado
 *   x != y
 *   !(x == y)
 */

int a = 7;
int b = 6;
Console.WriteLine(a != b); // output: True
string s1 = "Hello";
string s2 = "Hello";
Console.WriteLine(s1 != s2); // output: False
#endregion

#endregion



#endregion