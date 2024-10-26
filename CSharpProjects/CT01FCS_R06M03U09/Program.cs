// Roteiro 06   - "Depurar aplicativos de console do C# (Introdução ao C#, Parte 6)"
// Modulo 03    - "Implementar o tratamento de exceções em aplicativos de console C#"
// Unidade 08   - "Exercício – Concluir uma atividade de desafio para capturar exceções específicas" (09min)
// https://learn.microsoft.com/pt-br/training/modules/implement-exception-handling-c-sharp/8-exercise-challenge-try-catch-explicit-exceptions

// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

#region CT01FCS_R06M03U09


#region Desafio de captura de exceções específicas
#region 1.
//try
//{
//    int num1 = int.MaxValue;
//    int num2 = int.MaxValue;
//    int result = num1 + num2;
//    Console.WriteLine("Result: " + result);

//    string str = null;
//    int length = str.Length;
//    Console.WriteLine("String Length: " + length);

//    int[] numbers = new int[5];
//    numbers[5] = 10;
//    Console.WriteLine("Number at index 5: " + numbers[5]);

//    int num3 = 10;
//    int num4 = 0;
//    int result2 = num3 / num4;
//    Console.WriteLine("Result: " + result2);
//}
//catch (OverflowException ex)
//{
//    Console.WriteLine("Error: The number is too large to be represented as an integer." + ex.Message);
//}
//catch (NullReferenceException ex)
//{
//    Console.WriteLine("Error: The reference is null." + ex.Message);
//}
//catch (IndexOutOfRangeException ex)
//{
//    Console.WriteLine("Error: Index out of range." + ex.Message);
//}
//catch (DivideByZeroException ex)
//{
//    Console.WriteLine("Error: Cannot divide by zero." + ex.Message);
//}

//Console.WriteLine("Exiting program.");
#endregion

#region 2. (Minha solução para o desafio)
//try
//{
//    int num1 = int.MaxValue;
//    int num2 = int.MaxValue;
//    int result = num1 + num2;
//    Console.WriteLine("Result: " + result);

//    try
//    {
//        string str = null;
//        int length = str.Length;
//        Console.WriteLine("String Length: " + length);
//    }
//    catch (NullReferenceException ex)
//    {
//        Console.WriteLine("Error: The reference is null." + ex.Message);
//    }

//    try
//    {
//        int[] numbers = new int[5];
//        numbers[5] = 10;
//        Console.WriteLine("Number at index 5: " + numbers[5]);
//    }
//    catch (IndexOutOfRangeException ex)
//    {
//        Console.WriteLine("Error: Index out of range." + ex.Message);
//    }

//    try
//    {
//        int num3 = 10;
//        int num4 = 0;
//        int result2 = num3 / num4;
//        Console.WriteLine("Result: " + result2);
//    }
//    catch (DivideByZeroException ex)
//    {
//        Console.WriteLine("Error: Cannot divide by zero." + ex.Message);
//    }
//}
//catch (OverflowException ex)
//{
//    Console.WriteLine("Error: The number is too large to be represented as an integer." + ex.Message);
//}

//Console.WriteLine("Exiting program.");
#endregion
#endregion

#region Solução oficial do desafio
checked
{
    try
    {
        int num1 = int.MaxValue;
        int num2 = int.MaxValue;
        int result = num1 + num2;
        Console.WriteLine("Result: " + result);
    }
    catch (OverflowException ex)
    {
        Console.WriteLine("Error: The number is too large to be represented as an integer. " + ex.Message);
    }
}

try
{
    string? str = null;
    int length = str.Length;
    Console.WriteLine("String Length: " + length);
}
catch (NullReferenceException ex)
{
    Console.WriteLine("Error: The reference is null. " + ex.Message);
}

try
{
    int[] numbers = new int[5];
    numbers[5] = 10;
    Console.WriteLine("Number at index 5: " + numbers[5]);
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine("Error: Index out of range. " + ex.Message);
}

try
{
    int num3 = 10;
    int num4 = 0;
    int result2 = num3 / num4;
    Console.WriteLine("Result: " + result2);
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Error: Cannot divide by zero. " + ex.Message);
}

Console.WriteLine("Exiting program.");
#endregion

#endregion