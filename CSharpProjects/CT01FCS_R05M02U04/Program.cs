// Roteiro 05   - "Criar métodos em aplicativos de console C# (Introdução ao C#, Parte 5)"
// Modulo 02    - "Criar métodos C# com parâmetros"
// Unidade 04   - "Exercício – Usar parâmetros de tipo de referência e de valor" (05min)
// https://learn.microsoft.com/pt-br/training/modules/create-c-sharp-methods-parameters/4-exercise-use-value-reference-type-parameters

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

#region CT01FCS_R01M02U04

/*
 * Em C#, as variáveis podem ser categorizadas em dois tipos principais: tipos de valor e tipos de referência. 
 * Esses tipos descrevem como as variáveis armazenam seus valores.
 * 
 * Tipos de valor como int, bool, float, double e char contêm valores diretamente. 
 * Tipos de referência, como string, array e objetos (como instâncias de Random) não armazenam seus valores diretamente. 
 * Em vez disso, os tipos de referência armazenam um endereço onde seu valor está sendo armazenado.
*/

#region Parâmetros passados por valor e passados por referência
/*
 * Quando um argumento é passado para um método, as variáveis de tipo de valor têm seus valores copiados para o método. 
 * Cada variável tem a própria cópia do valor, portanto, a variável original não é modificada.
 * 
 * Com tipos de referência, o endereço do valor é passado para o método. 
 * A variável fornecida ao método faz referência ao valor naquele endereço, 
 * portanto, as operações nessa variável afetam o valor referenciado pela outra.
*/
#endregion

#region Testar passagem por valor
#region 2.
//int a = 3;
//int b = 4;
//int c = 0;

//Multiply(a, b, c);
//Console.WriteLine($"global statement: {a} x {b} = {c}");

//void Multiply(int a, int b, int c)
//{
//    c = a * b;
//    Console.WriteLine($"inside Multiply method: {a} x {b} = {c}");
//}
#endregion
#endregion

#region Teste aprovado por referência
#region 2.
//int[] array = {1, 2, 3, 4, 5};

//PrintArray(array);
//Clear(array);
//PrintArray(array);

//void PrintArray(int[] array)
//{ 
//    foreach (int a in array)
//    {
//        Console.Write($"{a} ");
//    }
//    Console.WriteLine();
//}

//void Clear(int[] array)
//{
//    for (int i = 0; i < array.Length; i++)
//    {
//        array[i] = 0;
//    }
//}
#endregion
#endregion

#region Testar com cadeia de caracteres
#region 2.
//string status = "Healthy";

//Console.WriteLine($"Start: {status}");
//SetHealthy(status, false);
//Console.WriteLine($"End: {status}");

//void SetHealthy(string status, bool isHealthy)
//{
//    status = (isHealthy ? "Healthy" : "Unhealthy");
//    Console.WriteLine($"Middle {status}");
//}
#endregion

#region 4.
string status = "Healthy";

Console.WriteLine($"Start: {status}");
SetHealthy(false);
Console.WriteLine($"End: {status}");

void SetHealthy(bool isHealthy)
{
    status = (isHealthy ? "Healthy" : "Unhealthy");
    Console.WriteLine($"Middle {status}");
}
#endregion
#endregion

#endregion