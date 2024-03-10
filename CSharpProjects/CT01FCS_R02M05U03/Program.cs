// Roteiro 02   - "Criar e executar aplicativos de console C# simples (Introdução ao C#, Parte 2)"
// Modulo 05    - "Criar código legível com convenções, espaço em branco e comentários em C#"
// Unidade 03   - "Exercício – Criar comentários de código eficazes" (13min)
// https://learn.microsoft.com/pt-br/training/modules/csharp-readable-code/3-exercise-comment-code

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

#region CT01FCS_R02M05U3



    #region O que é um comentário de código?
// This is a code comment!
    #endregion


    #region  Criar e usar comentários de código


        #region 8. 
/*
string firstName = "Bob";
int widgetsPurchased = 7;
Console.WriteLine($"{firstName} purchased {widgetsPurchased} widgets.");
*/
        #endregion


        #region  9.
/*
Random random = new Random();
string[] orderIDs = new string[5];
// Loop through each blank orderID
for (int i = 0; i < orderIDs.Length; i++) 
{
    //Get a random value that equates to ASCII letters A through E
    int prefixValue = random.Next(65, 70);
    // Convert the random value into a char, then a string
    string prefix = Convert.ToChar(prefixValue).ToString();
    // Create a ramdom number, pad with zeroes
    string suffix = random.Next(1, 1000).ToString("000");
    // Combine the prefix and suffix together, then assign to current OrderID
    orderIDs[i] = prefix + suffix;
}
// Print out each orderID
foreach (var orderID in orderIDs) 
{
    Console.WriteLine(orderID);
}
*/
        #endregion


        #region 12.
/*
Random random = new Random();
string[] orderIDs = new string[5];

for (int i = 0; i < orderIDs.Length; i++) 
{
    int prefixValue = random.Next(65, 70);
    string prefix = Convert.ToChar(prefixValue).ToString();
    string suffix = random.Next(1, 1000).ToString("000");
    orderIDs[i] = prefix + suffix;
}


foreach (var orderID in orderIDs) 
{
    Console.WriteLine(orderID);
}
*/
        #endregion


        #region 13.
/*
    The following code creates five random OrderIDs
    to test the fraud detection process. OrderIDs
    consist of a letter from A to E, and a three
    digit number. Ex. A123.
*/
Random random = new Random();
string[] orderIDs = new string[5];

for (int i = 0; i < orderIDs.Length; i++) 
{
    int prefixValue = random.Next(65, 70);
    string prefix = Convert.ToChar(prefixValue).ToString();
    string suffix = random.Next(1, 1000).ToString("000");
    orderIDs[i] = prefix + suffix;
}


foreach (var orderID in orderIDs) 
{
    Console.WriteLine(orderID);
}
        #endregion


    #endregion



#endregion