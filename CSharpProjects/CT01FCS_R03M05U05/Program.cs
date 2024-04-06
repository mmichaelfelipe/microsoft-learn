
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

//Console.WriteLine("Enter an integer value between 5 and 10");
//int userInputNumber;

//do
//{
//    string? userInput = Console.ReadLine();

//    if (!int.TryParse(userInput, out userInputNumber))
//    {
//        Console.WriteLine("Sorry, you entered a invalid number, please try again.");
//        continue;
//    }
//    if (userInputNumber is < 5 or > 10)
//    {
//        Console.WriteLine($"You entered {userInputNumber}. Please enter a number between 5 and 10.");
//        continue;
//    }

//    break;
//} while (true);

//Console.WriteLine($"Your input value ({userInputNumber})");
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

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int periodLocation;

foreach (string myString in myStrings)
{
    periodLocation = myString.IndexOf('.');
    while (periodLocation < myString.Length)
    {
        // .Remove()
        // .Substring()
        // .TrimStart()
        Console.WriteLine(myString.Remove(periodLocation));
    }
}

#endregion
#endregion