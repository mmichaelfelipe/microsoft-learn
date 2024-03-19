// Roteiro 02   - "Criar e executar aplicativos de console C# simples (Introdução ao C#, Parte 2)"
// Modulo 05    - "Criar código legível com convenções, espaço em branco e comentários em C#"
// Unidade 06   - "Examine a solução para aprimorar a atividade de desafio de legibilidade de código" (04min)
// https://learn.microsoft.com/pt-br/training/modules/csharp-readable-code/6-solution

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

#region CT01FCS_R02M05U05



    #region Examine a solução para aprimorar a atividade de desafio de legibilidade de código
/*
    This code reverses a message, counts the number of times
    a particular character appears, then prints the result
    to the console window.
*/

string originalMessage = "The quick brown fox jumps over the lazy dog.";

char[] message = originalMessage.ToCharArray();
Array.Reverse(message);

int letterCount = 0;

foreach (char letter in message)
{
    if (letter == 'o')
    {
        letterCount++;
    }
}

string newMessage = new string(message);

Console.WriteLine();
Console.WriteLine($"'o' appears {letterCount} times");
    #endregion



#endregion