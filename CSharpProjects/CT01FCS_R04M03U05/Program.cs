// Roteiro 04   - "Trabalhar com os dados variáveis em aplicativos de console C# (Introdução ao C#, Parte 4)"
// Modulo 03    - "Executar operações em matrizes usando métodos auxiliares em C#"
// Unidade 05   - "Exercício – Conclua um desafio para inverter palavras em uma frase" (10min)
// https://learn.microsoft.com/pt-br/training/modules/csharp-arrays-operations/5-challenge-1

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

#region CT01FCS_R04M03U05


#region Escrever código para inverter cada palavra de uma mensagem
#region 2.
//string pangram = "The quick brown fox jumps over the lazy dog";
#endregion

#region 3.Escreva o código necessário para inverter as letras de cada palavra no lugar e exibir o resultado.
/*
Em outras palavras, não basta inverter todas as letras na variável pangram. 
Em vez disso, você precisará inverter apenas as letras de cada palavra, 
mas imprimir a palavra invertida em sua posição original na mensagem.

Seu código deverá produzir a seguinte saída:

Output
ehT kciuq nworb xof spmuj revo eht yzal god
*/

string pangram = "The quick brown fox jumps over the lazy dog";
string pangramInvertido = string.Empty;

string[] palavras = pangram.Split(' ');
List<string> palavrasInvertidas = new List<string>();
char[] letrasPalavra;

foreach (var palavra in palavras)
{
    letrasPalavra = palavra.ToCharArray();
    Array.Reverse(letrasPalavra);
    string palavraInvertida = new string(letrasPalavra);
    palavrasInvertidas.Add(palavraInvertida);
    pangramInvertido = string.Join(" ", palavrasInvertidas);
}

Console.WriteLine(pangram);
Console.WriteLine(pangramInvertido);

#endregion

#region resultado sugerido (Unidade 06)
//string pangram = "The quick brown fox jumps over the lazy dog";

//// Step 1
//string[] message = pangram.Split(' ');

////Step 2
//string[] newMessage = new string[message.Length];

//// Step 3
//for (int i = 0; i < message.Length; i++)
//{
//    char[] letters = message[i].ToCharArray();
//    Array.Reverse(letters);
//    newMessage[i] = new string(letters);
//}

////Step 4
//string result = String.Join(" ", newMessage);
//Console.WriteLine(result);
#endregion
#endregion
#endregion