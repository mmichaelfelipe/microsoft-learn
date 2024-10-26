// Roteiro 06   - "Depurar aplicativos de console do C# (Introdução ao C#, Parte 6)"
// Modulo 03    - "Implementar o tratamento de exceções em aplicativos de console C#"
// Unidade 05   - "Exercício – Concluir uma atividade de desafio para try-catch" (07min)
// https://learn.microsoft.com/pt-br/training/modules/implement-exception-handling-c-sharp/5-exercise-challenge-try-catch

// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

#region CT01FCS_R06M03U05


#region Desafio try-catch
#region 1.
//try
//{
//    Process1();
//}
//catch
//{
//    Console.WriteLine("An exception has occurred");
//}

//Console.WriteLine("Exit program");

//static void Process1()
//{
//    WriteMessage();
//}

//static void WriteMessage()
//{
//    double float1 = 3000.0;
//    double float2 = 0.0;
//    int number1 = 3000;
//    int number2 = 0;

//    Console.WriteLine(float1 / float2);
//    Console.WriteLine(number1 / number2);
//}
#endregion

#region 2., 3. (Minha resposta para o desafio)
try
{
    Process1();
}
catch
{
    Console.WriteLine("An exception has occurred");
}

Console.WriteLine("Exit program");

static void Process1()
{
    try
    {
        WriteMessage();
    }
    catch
    {
        Console.WriteLine("Exception caught in Process1");
    }
}

static void WriteMessage()
{
    double float1 = 3000.0;
    double float2 = 0.0;
    int number1 = 3000;
    int number2 = 0;

    Console.WriteLine(float1 / float2);
    Console.WriteLine(number1 / number2);
}
#endregion

#region Resposta oficial para o desafio
//try
//{
//    Process1();
//}
//catch
//{
//    Console.WriteLine("An exception has occurred");
//}

//Console.WriteLine("Exit program");

//static void Process1()
//{
//    try
//    {
//        WriteMessage();
//    }
//    catch
//    {
//        Console.WriteLine("Exception caught in Process1");
//    }

//}

//static void WriteMessage()
//{
//    double float1 = 3000.0;
//    double float2 = 0.0;
//    int number1 = 3000;
//    int number2 = 0;

//    Console.WriteLine(float1 / float2);
//    Console.WriteLine(number1 / number2);
//}
#endregion
#endregion

#endregion