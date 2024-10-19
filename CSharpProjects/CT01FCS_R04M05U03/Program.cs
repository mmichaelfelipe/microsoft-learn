// Roteiro 04   - "Trabalhar com os dados variáveis em aplicativos de console C# (Introdução ao C#, Parte 4)"
// Modulo 05    - "Modificar o conteúdo de cadeias de caracteres usando métodos internos de tipo de dados em C#"
// Unidade 03   - "Exercício – Usar os métodos auxiliares IndexOf() e LastIndexOf() da cadeia de caracteres" (25min)
// https://learn.microsoft.com/pt-br/training/modules/csharp-modify-content/3-exercise-lastindexof-indexof

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

#region CT01FCS_R04M05U03


#region IndexOf() e LastIndexOf()
#region 2.
//string message = "hello there!";

//int first_h = message.IndexOf('h');
//int last_h = message.LastIndexOf('h');

//Console.WriteLine($"For the message: '{message}', the first 'h' is at position {first_h} and the last 'h' is at position {last_h}");
#endregion
#endregion

#region Recuperar a última ocorrência de uma subcadeia de caracteres
#region 2.
//string message = "(What if) I am (only interested) in the last (set of parentheses)?";
//int openingPosition = message.LastIndexOf('(');

//openingPosition += 1;
//int closingPosition = message.LastIndexOf(')');
//int length = closingPosition - openingPosition;
//Console.WriteLine(message.Substring(openingPosition, length));
#endregion
#endregion

#region Recuperar todas as instâncias de subcadeias de caracteres dentro de parênteses
#region 1.
//string message = "(What if) I am (only interested) in the last (set of parentheses)?";
//while (true)
//{
//    int openingPosition = message.IndexOf('(');
//    if (openingPosition == -1) break;

//    openingPosition += 1;
//    int closingPosition = message.IndexOf(')');
//    int length = closingPosition - openingPosition;
//    Console.WriteLine(message.Substring(openingPosition, length));

//    // Note the overload of the Substring to return only the remaining
//    // unprocessed message:
//    message = message.Substring(closingPosition + 1);
//}
#endregion
#endregion

#region Trabalhar com diferentes tipos de conjuntos de símbolos
#region 1.
//string message = "Help (find) the {opening symbols}";
//Console.WriteLine($"Searching THIS Message: {message}");
//char[] openSymbols = { '[', '{', '(' };
//int startPosition = 5;
//int openingPosition = message.IndexOfAny(openSymbols);
//Console.WriteLine($"Found WHITHOUT using startPosition: {message.Substring(openingPosition)}");

//openingPosition = message.IndexOfAny(openSymbols, startPosition);
//Console.WriteLine($"Found WITH using startPosition {startPosition}: {message.Substring(openingPosition)}");
#endregion

#region 4.
string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

// The IndexOfAny() helper method requires a char array of characters. 
// You want to look for:
char[] openSymbols = { '[', '{', '(' };

// You'll use a slightly different technique for iterating through 
// the characters in the string. This time, use the closing 
// position of the previous iteration as the starting index for the 
// next open symbol. So, you need to initialize the closingPosition 
// variable to zero:

int closingPosition = 0;

while (true)
{
    int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

    if (openingPosition == -1) break;

    string currentSymbol = message.Substring(openingPosition, 1);

    // Now find the matching closing symbol
    char matchingSymbol = ' ';
    switch (currentSymbol)
    {
        case "[":
            matchingSymbol = ']';
            break;
        case "{":
            matchingSymbol = '}';
            break;
        case "(":
            matchingSymbol = ')';
            break;
    }
    
    // Copilot sugestion
    //char matchingSymbol = currentSymbol switch
    //{
    //    "(" => ')',
    //    "[" => ']',
    //    "{" => '}',
    //    _ => throw new InvalidOperationException("Invalid symbol found")
    //};

    // To find the closingPosition, use an overload of the IndexOf method to specify 
    // that the search for the matchingSymbol should start at the openingPosition in the string. 
    openingPosition += 1;
    closingPosition = message.IndexOf(matchingSymbol, openingPosition);

    // Finally, use the techniques you've already learned to display the sub-string:
    int length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));
}
#endregion
#endregion

#endregion