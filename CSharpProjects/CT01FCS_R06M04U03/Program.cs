// Roteiro 06   - "Depurar aplicativos de console do C# (Introdução ao C#, Parte 6)"
// Modulo 04    - "Criar e gerar exceções em aplicativos de console C#"
// Unidade 03   - "Exercício – Criar e gerar uma exceção" (14min)
// https://learn.microsoft.com/pt-br/training/modules/create-throw-exceptions-c-sharp/3-exercise-create-throw-exception-c-sharp

// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

#region CT01FCS_R06M04U03


#region Analisar um aplicativo de exemplo
#region 4.
//// Prompt the user for the lower and upper bounds
//// Solicite ao usuário o limite inferior e superior
//Console.Write("Enter the lower bound: ");
//int lowerBound = int.Parse(Console.ReadLine());

//Console.Write("Enter the upper bound: ");
//int upperBound = int.Parse(Console.ReadLine());

//decimal averageValue = 0;

//// Calculate the sum of the even numbers between the bounds
//// Calcule a soma dos números pares entre os limites
//averageValue = AverageOfEvenNumbers(lowerBound, upperBound);

//// Display the value returned by AverageOfEvenNumbers in the console
//// Exiba o valor retornado por AverageOfEvenNumbers no console
//Console.WriteLine($"The average of even numbers between {lowerBound} and {upperBound} is {averageValue}.");

//// Wait for user input
//// Aguarde a entrada do usuário
//Console.ReadLine();

//static decimal AverageOfEvenNumbers(int lowerBound, int upperBound)
//{
//    int sum = 0;
//    int count = 0;
//    decimal average = 0;

//    for (int i = lowerBound; i <= upperBound; i++)
//    {
//        if (i % 2 == 0)
//        {
//            sum += i;
//            count++;
//        }
//    }

//    average = (decimal)sum / count;

//    return average;
//}
#endregion
#endregion

#region Gerar uma exceção no método AverageOfEvenNumbers
#region 3., 4.
//// Prompt the user for the lower and upper bounds
//// Solicite ao usuário o limite inferior e superior
//Console.Write("Enter the lower bound: ");
//int lowerBound = int.Parse(Console.ReadLine());

//Console.Write("Enter the upper bound: ");
//int upperBound = int.Parse(Console.ReadLine());

//decimal averageValue = 0;

//// Calculate the sum of the even numbers between the bounds
//// Calcule a soma dos números pares entre os limites
//averageValue = AverageOfEvenNumbers(lowerBound, upperBound);

//// Display the value returned by AverageOfEvenNumbers in the console
//// Exiba o valor retornado por AverageOfEvenNumbers no console
//Console.WriteLine($"The average of even numbers between {lowerBound} and {upperBound} is {averageValue}.");

//// Wait for user input
//// Aguarde a entrada do usuário
//Console.ReadLine();

//static decimal AverageOfEvenNumbers(int lowerBound, int upperBound)
//{
//    if (lowerBound >= upperBound)
//    {
//        throw new ArgumentOutOfRangeException("upperBound", "ArgumentOutOfRangeException: upper bound must be greater than lower bound.");
//    }

//    int sum = 0;
//    int count = 0;
//    decimal average = 0;

//    for (int i = lowerBound; i <= upperBound; i++)
//    {
//        if (i % 2 == 0)
//        {
//            sum += i;
//            count++;
//        }
//    }

//    average = (decimal)sum / count;

//    return average;
//}
#endregion
#endregion

#region Capturar a exceção no código de chamada
#region 2., 3., 4., 5., 6., 7., 8., 9.
// Prompt the user for the lower and upper bounds
// Solicite ao usuário o limite inferior e superior
Console.Write("Enter the lower bound: ");
int lowerBound = int.Parse(Console.ReadLine());

Console.Write("Enter the upper bound: ");
int upperBound = int.Parse(Console.ReadLine());

decimal averageValue = 0;

bool exit = false;

do
{
    try
    {
        // Calculate the sum of the even numbers between the bounds
        // Calcule a soma dos números pares entre os limites
        averageValue = AverageOfEvenNumbers(lowerBound, upperBound);

        // Display the value returned by AverageOfEvenNumbers in the console
        // Exiba o valor retornado por AverageOfEvenNumbers no console
        Console.WriteLine($"The average of even numbers between {lowerBound} and {upperBound} is {averageValue}.");

        exit = true;
    }
    catch (ArgumentOutOfRangeException ex)
    {
        Console.WriteLine("An error has occurred.");
        Console.WriteLine(ex.Message);
        Console.WriteLine($"The upper bound must be greater than {lowerBound}");
        Console.Write($"Enter a new upper bound (or enter Exit to quit)");
        string? userResponse = Console.ReadLine();

        if (userResponse.ToLower().Contains("exit"))
        {
            exit = true;
        }
        else
        {
            exit = false;
            upperBound = int.Parse(userResponse);
        }
    }
} while (exit == false);

// Wait for user input
// Aguarde a entrada do usuário
Console.ReadLine();

static decimal AverageOfEvenNumbers(int lowerBound, int upperBound)
{
    if (lowerBound >= upperBound)
    {
        throw new ArgumentOutOfRangeException("upperBound", "ArgumentOutOfRangeException: upper bound must be greater than lower bound.");
    }

    int sum = 0;
    int count = 0;
    decimal average = 0;

    for (int i = lowerBound; i <= upperBound; i++)
    {
        if (i % 2 == 0)
        {
            sum += i;
            count++;
        }
    }

    average = (decimal)sum / count;

    return average;
}
#endregion
#endregion

#endregion