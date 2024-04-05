// Roteiro 03   - "Adicionar lógica a aplicativos de console C# (Introdução ao C#, Parte 3)"
// Modulo 04    - "Iterar por meio de um bloco de código usando a instrução for em C#"
// Unidade 03   - "Exercício – Concluir uma atividade de desafio usando instruções for e if" (09min)
// https://learn.microsoft.com/pt-br/training/modules/csharp-for/3-challenge

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

#region CT01FCS_R03M04U03


#region Desafio FizzBuzz
/* O FizzBuzz é um conhecido desafio de codificação e uma pergunta de 
 * entrevista. Ele exercita sua compreensão da declaração for, 
 * da declaração if, do operador restante % e do comando da lógica básica.
 */
#region Desafio de código – implementar as regras do desafio FizzBuzz
/* Aqui estão as regras do FizzBuzz que você precisa implementar em seu projeto de código:
 * 
    - Valores de saída de 1 a 100, um número por linha, dentro do bloco de código de uma instrução de iteração.
    - Quando o valor atual é divisível por 3, imprima o termo Fizz ao lado do número.
    - Quando o valor atual é divisível por 5, imprima o termo Buzz ao lado do número.
    - Quando o valor atual é divisível tanto por 3 quanto por 5, imprima o termo FizzBuzz ao lado do número.
 */
#endregion

#region Minha versão do desafio
const string fizz = "Fizz";
const string buzz = "Buzz";
const string fizzBuzz = "FizzBuzz";

for (int i = 1; i <= 100; i++)
{
    if ((i % 3 == 0) && (i % 5 == 0))
        Console.WriteLine($"{i} - {fizzBuzz}");
    else if (i % 3 == 0)
        Console.WriteLine($"{i} - {fizz}");
    else if (i % 5 == 0)
        Console.WriteLine($"{i} - {buzz}");
    else
        Console.WriteLine(i);
}
#endregion

#region Resposta oficial
//for (int i = 1; i < 101; i++)
//{
//    if ((i % 3 == 0) && (i % 5 == 0))
//        Console.WriteLine($"{i} - FizzBuzz");
//    else if (i % 3 == 0)
//        Console.WriteLine($"{i} - Fizz");
//    else if (i % 5 == 0)
//        Console.WriteLine($"{i} - Buzz");
//    else
//        Console.WriteLine($"{i}");
//}
#endregion
#endregion



#endregion