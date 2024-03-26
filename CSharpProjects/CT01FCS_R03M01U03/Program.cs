// Roteiro 03   - "Adicionar lógica a aplicativos de console C# (Introdução ao C#, Parte 3)"
// Modulo 01    - "Avaliar expressões boolianas para tomar decisões em C#"
// Unidade 03   - "Exercício – Implementar o operador condicional" (07min)
// https://learn.microsoft.com/pt-br/training/modules/csharp-evaluate-boolean-expressions/3-exercise-conditional-operator


// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

#region CT01FCS_R03M01U03



#region O que é o operador condicional?
/* O operador condicional também é comumente chamado de "operador (condicional) ternário."
 * Representado da forma        ? :
 * <evaluate this condition> ? <if condition is true, return this value> : <if condition is false, return this value>
 */
#region temp exercicio
//int valorCompra1 = 999;
//int valorCompra2 = 1001;

//int valorDescontoCompra1 = (valorCompra1 >= 1000 ? 100 : 50);
//int valorDescontoCompra2 = (valorCompra2 >= 1000 ? 100 : 50);

//Console.WriteLine($"O valor de desconto da compra 1 foi {valorDescontoCompra1}");
//Console.WriteLine($"O valor de desconto da compra 2 foi {valorDescontoCompra2}");
#endregion

#region Adicionar código que usa um operador condicional
//int saleAmount = 1001;
//int discount = saleAmount > 1000 ? 100 : 50;
//Console.WriteLine($"Discount: {discount}");
#endregion

#region Usar o operador condicional embutido
int saleAmount = 1001;
//int discount = saleAmount > 1000 ? 100 : 50;
Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");
#endregion

#endregion



#endregion