// Roteiro 05   - "Criar métodos em aplicativos de console C# (Introdução ao C#, Parte 5)"
// Modulo 03    - "Criar métodos C# que retornem valores"
// Unidade 04   - "Exercício – Retornar cadeias de caracteres de métodos" (05min)
// https://learn.microsoft.com/pt-br/training/modules/create-c-sharp-methods-return-values/4-exercise-create-methods-return-strings

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

#region CT01FCS_R01M03U04


#region Criar um método que retorna uma cadeia de caracteres
#region 2., 3.
//string ReverseWord(string word)
//{
//    string result = "";
//    for (int i = word.Length - 1; i >= 0; i--)
//    {
//        result += word[i];
//    }
//    return result;
//}
#endregion
#endregion

#region Testar seu código
#region 1.
//string input = "snake";

//Console.WriteLine(input);
//Console.WriteLine(ReverseWord(input));

//string ReverseWord(string word)
//{
//    string result = "";
//    for (int i = word.Length - 1; i >= 0; i--)
//    {
//        result += word[i];
//    }
//    return result;
//}
#endregion
#endregion

#region Criar um método para inverter as palavras na frase
#region 1., 2., 3., 4., 5.
string input = "there are snakes at the zoo";

Console.WriteLine(input);
Console.WriteLine(ReverseSentence(input));

string ReverseWord(string word)
{
    string result = "";
    for (int i = word.Length - 1; i >= 0; i--)
    {
        result += word[i];
    }
    return result;
}

string ReverseSentence(string input)
{
    string result = "";
    string[] words = input.Split(" ");

    foreach (string word in words)
    {
        result += ReverseWord(word) + " ";
    }

    return result.Trim();
}
#endregion
#endregion

#region
#endregion

#endregion