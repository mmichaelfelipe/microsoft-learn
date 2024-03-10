// Roteiro 02   - "Criar e executar aplicativos de console C# simples (Introdução ao C#, Parte 2)"
// Modulo 05    - "Criar código legível com convenções, espaço em branco e comentários em C#"
// Unidade 05   - "Exercício – Concluir uma atividade de desafio em que é preciso melhorar a legibilidade de um código" (07min)
// https://learn.microsoft.com/pt-br/training/modules/csharp-readable-code/5-challenge

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

#region CT01FCS_R02M05U5



    #region Desafio de código – Aplicar as diretrizes de estilo para melhorar a legibilidade
        
        
        #region 2.
/*
string str = "The quick brown fox jumps over the lazy dog.";
// convert the message into a char array
char[] charMessage = str.ToCharArray();
// Reverse the chars
Array.Reverse(charMessage);
int x = 0;
// count the o's
foreach (char i in charMessage) { if (i == 'o') { x++; } }
// convert it back to a string
string new_message = new String(charMessage);
// print it out
Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {x} times.");
*/
        #endregion


        #region 3.
/*
    [Trecho de mensagem da aula]
    A finalidade de alto nível desse código é inverter uma cadeia de caracteres 
    e contar o número de vezes que um caractere específico é exibido.
*/

string originalMessage = "The quick brown fox jumps over the lazy dog.";
char[] reverseMessageArray = originalMessage.ToCharArray();
Array.Reverse(reverseMessageArray);

int occurrences = 0;
foreach (char i in reverseMessageArray) 
{ 
    if (i == 'o') 
        occurrences++; 
}

string reverseMessage = new String(reverseMessageArray);
Console.WriteLine(reverseMessage);
Console.WriteLine($"'o' appears {occurrences} times.");

        #endregion


    #endregion



#endregion