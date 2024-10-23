// Roteiro 05   - "Criar métodos em aplicativos de console C# (Introdução ao C#, Parte 5)"
// Modulo 03    - "Criar métodos C# que retornem valores"
// Unidade 05   - "Exercício – Retornar boolianos de métodos" (05min)
// https://learn.microsoft.com/pt-br/training/modules/create-c-sharp-methods-return-values/5-exercise-create-methods-return-booleans

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

#region CT01FCS_R01M03U05


#region Criar um método que retorna um booliano
#region 2., 3., 5.
string[] words = { "racecar", "talented", "deified", "tent", "tenet" };

Console.WriteLine("Is it a palindrome?");
foreach (string word in words)
{
    Console.WriteLine($"{word}: {IsPalindrome(word)}");
}

bool IsPalindrome(string word)
{
    int start = 0;
    int end = word.Length - 1;

    while (start < end)
    {
        if (word[start] != word[end])
        {
            return false;
        }
        start++;
        end--;
    }

    return true;
}
#endregion
#endregion

#endregion