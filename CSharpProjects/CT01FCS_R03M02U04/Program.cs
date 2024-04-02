// Roteiro 03   - "Adicionar lógica a aplicativos de console C# (Introdução ao C#, Parte 3)"
// Modulo 02    - "Controlar o escopo da variável e a lógica usando blocos de código em C#"
// Unidade 04   - "Exercício – Concluir uma atividade de desafio usando o escopo variável" (06min)
// https://learn.microsoft.com/pt-br/training/modules/csharp-code-blocks/4-exercise-challenge-variable-scope


// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

#region CT01FCS_R03M02U04



#region Desafio de código: atualizar um código problemático no editor de código
#region 2.
//int[] numbers = { 4, 8, 15, 16, 23, 42 };

//foreach (int number in numbers)
//{
//    int total;

//    total += number;

//    if (number == 42)
//    {
//        bool found = true;

//    }

//}

//if (found)
//{
//    Console.WriteLine("Set contains 42");

//}

//Console.WriteLine($"Total: {total}");
#endregion
#region Minha versão de resposta para o desafio
int[] numbers = { 4, 8, 15, 16, 23, 42 };
int total = 0;
bool found = false;

foreach (int number in numbers)
{
    total += number;
    if (number == 42)
        found = true;
}

if (found)
    Console.WriteLine("Set contains 42");

Console.WriteLine($"Total: {total}");
#endregion
#region Resposta oficial
//int[] numbers = { 4, 8, 15, 16, 23, 42 };
//int total = 0;
//bool found = false;

//foreach (int number in numbers)
//{
//    total += number;
//    if (number == 42)
//        found = true;
//}

//if (found)
//    Console.WriteLine("Set contains 42");

//Console.WriteLine($"Total: {total}");
#endregion
#endregion



#endregion