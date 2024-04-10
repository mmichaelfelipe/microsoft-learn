// Roteiro 03   - "Adicionar lógica a aplicativos de console C# (Introdução ao C#, Parte 3)"
// Modulo 05    - "Adicione lógica de loop a seu código usando as instruções "do-while" e "while" em C#"
// Unidade 05   - "Exercício – Concluir uma atividade de desafio em que é preciso diferenciar entre instruções de iteração do e while" (14min)
// https://learn.microsoft.com/pt-br/training/modules/csharp-do-while/5-exercise-challenge-differentiate-while-do-statements

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

#region CT01FCS_R03M05U05



#region Gerencie a entrada do usuário durante esse desafio
#region 1.
//string? readResult;
//Console.WriteLine("Enter a string:");
//do
//{
//    readResult = Console.ReadLine();
//} while (readResult == null);
#endregion

#region 2.
//string? readResult;
//bool validEntry = false;
//Console.WriteLine("Enter a string containing at least three characters:");
//do
//{
//    readResult = Console.ReadLine();
//    if (readResult != null)
//    {
//        if (readResult.Length >= 3)
//        {
//            validEntry = true;
//        }
//        else
//        {
//            Console.WriteLine("Your input is invalid, please try again.");
//        }
//    }
//} while (validEntry == false);
#endregion

#region 3. Usando TryParse (int)
//string? readResult = Console.ReadLine();

//// capture user input in a string variable named readResult

//int numericValue;
//bool validNumber = false;

//validNumber = int.TryParse(readResult, out numericValue);

//Console.WriteLine(numericValue);
#endregion
#endregion


#region Projeto de código 1 - escrever o código que valida a entrada de inteiro
/* Veja as seguintes condições que seu primeiro projeto de codificação deve implementar:
    - A solução deve incluir uma iteração do-while ou while.
    - Antes do bloco de iteração: a solução deve usar uma instrução Console.WriteLine() para solicitar ao usuário um valor inteiro entre 5 e 10.
    - Dentro do bloco de iteração:
        - A solução deve usar uma instrução Console.ReadLine() para obter uma entrada do usuário.
        - A solução deve garantir que a entrada seja uma representação válida de um inteiro.
        - Se o valor inteiro não estiver entre 5 e 10, o código deverá usar uma instrução Console.WriteLine() para solicitar ao usuário um valor inteiro entre 5 e 10.
        - A solução deve garantir que o valor inteiro esteja entre 5 e 10 antes de sair da iteração.
    - Abaixo (depois) do bloco de código de iteração: a solução deve usar uma instrução Console.WriteLine() para informar ao usuário que o valor de entrada foi aceito.

    No exemplo descrito acima, a saída do console deve ser semelhante à seguinte:
        - Enter an integer value between 5 and 10
        - two
        - Sorry, you entered an invalid number, please try again
        - 2
        - You entered 2. Please enter a number between 5 and 10.
        - 7
        - Your input value (7) has been accepted.  
 */

#region Minhar resposta para o desafio (Projeto de código 1)
Console.WriteLine("Enter an integer value between 5 and 10");
int userInputNumber;

do
{
    string? userInput = Console.ReadLine();

    if (!int.TryParse(userInput, out userInputNumber))
    {
        Console.WriteLine("Sorry, you entered a invalid number, please try again.");
        continue;
    }
    if (userInputNumber is < 5 or > 10)
    {
        Console.WriteLine($"You entered {userInputNumber}. Please enter a number between 5 and 10.");
        continue;
    }

    break;
} while (true);

Console.WriteLine($"Your input value ({userInputNumber})");
#endregion

#region Resposta oficial
//string? readResult;
//string valueEntered = "";
//int numValue = 0;
//bool validNumber = false;

//Console.WriteLine("Enter an integer value between 5 and 10");

//do
//{
//    readResult = Console.ReadLine();
//    if (readResult != null)
//    {
//        valueEntered = readResult;
//    }

//    validNumber = int.TryParse(valueEntered, out numValue);

//    if (validNumber == true)
//    {
//        if (numValue <= 5 || numValue >= 10)
//        {
//            validNumber = false;
//            Console.WriteLine($"You entered {numValue}. Please enter a number between 5 and 10.");
//        }
//    }
//    else
//    {
//        Console.WriteLine("Sorry, you entered an invalid number, please try again");
//    }
//} while (validNumber == false);

//Console.WriteLine($"Your input value ({numValue}) has been accepted.");

//readResult = Console.ReadLine();
#endregion
#endregion


#region Projeto de código 2 - escrever o código que valida a entrada de cadeia de caracteres
/* Veja as seguintes condições que seu segundo projeto de codificação deve implementar:
    - A solução deve incluir uma iteração do-while ou while.
    - Antes do bloco de iteração: a solução deve usar uma instrução Console.WriteLine() 
      para solicitar ao usuário um dos três nomes de função: Administrador, Gerente ou Usuário.
    - Dentro do bloco de iteração:
        - A solução deve usar uma instrução Console.ReadLine() para obter uma entrada do usuário.
        - A solução deve garantir que o valor inserido corresponda a uma das três opções de função.
        - Sua solução deve usar o método Trim() no valor de entrada para ignorar caracteres 
          de espaço de entrelinhamento e à direita.
        - A solução deve usar o método ToLower() no valor de entrada para ignorar maiúsculas e minúsculas.
        - Se o valor inserido não corresponder a uma das opções de função, o código deverá 
          usar uma instrução Console.WriteLine() para solicitar ao usuário uma entrada válida.
    - Abaixo (depois) do bloco de código de iteração: a solução deve usar uma instrução Console.WriteLine() 
      para informar ao usuário que o valor de entrada foi aceito.

    A saída do console para este exemplo deve ser semelhante à seguinte:
        - Enter your role name (Administrator, Manager, or User)
        - Admin
        - The role name that you entered, "Admin" is not valid. Enter your role name (Administrator, Manager, or User)
        - Administrator
        - Your input value (Administrator) has been accepted.
 */

#region Minhar resposta para o desafio (Projeto de código 2)
//Console.WriteLine("Enter your role name (Administrator, Manager or User)");
//string? userInput;

//do
//{
//    userInput = Console.ReadLine();

//    if (userInput?.Trim().ToLower() is not ("administrator" or "manager" or "user"))
//    {
//        Console.WriteLine($"The role name that you entered \"{userInput}\". Enter your role name (Administrator, Manager, or User)");
//        continue;
//    }
//    break;
//} while (true);

//Console.WriteLine($"Your input value ({userInput}) has been accepted.");
#endregion

#region Resposta oficial
//string? readResult;
//string roleName = "";
//bool validEntry = false;

//do
//{
//    Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
//    readResult = Console.ReadLine();
//    if (readResult != null)
//    {
//        roleName = readResult.Trim();
//    }

//    if (roleName.ToLower() == "administrator" || roleName.ToLower() == "manager" || roleName.ToLower() == "user")
//    {
//        validEntry = true;
//    }
//    else
//    {
//        Console.Write($"The role name that you entered, \"{roleName}\" is not valid. ");
//    }

//} while (validEntry == false);

//Console.WriteLine($"Your input value ({roleName}) has been accepted.");
//readResult = Console.ReadLine();
#endregion
#endregion


#region Projeto de código 3 - escreva um código que processe o conteúdo de uma matriz de caracteres
/* Veja as seguintes condições que seu terceiro projeto de codificação deve implementar:
    - A solução deve usar a seguinte matriz de cadeia de caracteres para 
      representar a entrada para a lógica de codificação:
        string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
    - A solução deve declarar uma variável inteira chamada periodLocation que 
      pode ser usada para manter o local do caractere de ponto dentro de uma cadeia de caracteres.
    - A solução deve incluir um loop foreach ou for externo que possa ser usado 
      para processar cada elemento da cadeia de caracteres na matriz. A variável 
      da cadeia de caracteres que será processada dentro dos loops deve ser chamada de myString.
    - No loop externo, a solução deve usar o método IndexOf() da classe String 
      para obter a localização do primeiro caractere de ponto na variável myString. 
      A chamada de método deve ser semelhante a: myString.IndexOf("."). 
      Se não houver nenhum caractere de ponto na cadeia de caracteres, um valor de -1 será retornado.
    - A solução deve incluir um loop do-while ou while interno que possa ser 
      usado para processar a variável myString.
    - No loop interno, a solução deve extrair e exibir (gravar no console) cada frase 
      contida em cada uma das cadeias de caracteres processadas.
    - No loop interno, a solução não deve exibir o caractere de ponto.
    - No loop interno, a solução deve usar os métodos Remove(), Substring() e 
      TrimStart() para processar as informações da cadeia de caracteres.

    Se a lógica do código funcionar corretamente, a saída será semelhante à seguinte:
        - I like pizza
        - I like roast chicken
        - I like salad
        - I like all three of the menu choices
 */

#region Minhar resposta para o desafio (Projeto de código 3)
/* Métodos
 * IndexOf()    -> Obtem a posição da primeira ocorrência de determado elemento no array.
 *              -> Se não encontrar ocorrência, retorna -1.
 *              
 * Remove()     ->  (int startIndex) retorna uma cadeia de caracteres que remove cadeia de caracteres a partir do indice especificado
 *                  (int startIndex, int length) retorna uma cadeia de caracteres que  remove cadeira de caracteres a partir do indice especificado e tem o tamanho do range especificado

 * Substring()  ->  (int startIndex) retorna uma subcadeia de caracteres que é iniciada a partir do indice especificado
 *                  (int startIndex, int length) returma uma subcadeia que é iniciada a partir do indice especificado e tem o tamanho do range especificado
 * 
 * TrimStart()  ->  ()   retorna uma cadeia de caracteres removendo todas as ocorrências de espaço em branco a esquerda até a primeira ocorrencia de caractare não vazio.
 *                  (char trimChar) retorna uma cadeia de caracteres removendo todas as ocorrencias do caracteres informado no parametro a esquerda até a primeira ocorrencia de caractare não vazio.
 *                  (char[]) retorna uma cadeia de caracteres removendo todas as ocorrencias do conjunto de caracteres informado no parametro a esquerda até a primeira ocorrencia de caractare não vazio.
 */

/*
    Desafio abaixo não concluído, necessário refatorar.
    Porém através das tentetivas, o escopo do desafio e os conhecimentos necessários foram adquiridos.
 */
//string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
//int periodLocation = 0;

//foreach (string myString in myStrings)
//{
//    periodLocation = myString.IndexOf('.');

//    while (periodLocation < myString.Length)
//    {
//        string phrase;  //[DEBUG]

//        if (periodLocation != -1)
//        {
//            phrase = myString.Remove(periodLocation);


//            Console.WriteLine(phrase);

//            // pegar agora a proxima ocorrencia de ponto
//            periodLocation += myString.Substring(periodLocation++).IndexOf('.');
//        }
//    }
//}
#endregion

#region Resposta oficial
//string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
//int stringsCount = myStrings.Length;

//string myString = "";
//int periodLocation = 0;

//for (int i = 0; i < stringsCount; i++)
//{
//    myString = myStrings[i];
//    periodLocation = myString.IndexOf(".");

//    string mySentence;

//    // extract sentences from each string and display them one at a time
//    while (periodLocation != -1)
//    {

//        // first sentence is the string value to the left of the period location
//        mySentence = myString.Remove(periodLocation);

//        // the remainder of myString is the string value to the right of the location
//        myString = myString.Substring(periodLocation + 1);

//        // remove any leading white-space from myString
//        myString = myString.TrimStart();

//        // update the comma location and increment the counter
//        periodLocation = myString.IndexOf(".");

//        Console.WriteLine(mySentence);
//    }

//    mySentence = myString.Trim();
//    Console.WriteLine(mySentence);
//}
#endregion

#endregion
#endregion