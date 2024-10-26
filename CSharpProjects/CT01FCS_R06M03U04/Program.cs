// Roteiro 06   - "Depurar aplicativos de console do C# (Introdução ao C#, Parte 6)"
// Modulo 03    - "Implementar o tratamento de exceções em aplicativos de console C#"
// Unidade 04   - "Exercício – Implementar o tratamento de exceção try-catch" (09min)
// https://learn.microsoft.com/pt-br/training/modules/implement-exception-handling-c-sharp/4-exercise-try-catch

// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

#region CT01FCS_R06M03U04

#region Implementar um try-catch simples
#region 4.
//double float1 = 3000.0;
//double float2 = 0.0;
//int number1 = 3000;
//int number2 = 0;

//Console.WriteLine(float1 / float2);
//Console.WriteLine(number1 / number2);
//Console.WriteLine("Exit program");
#endregion

#region 9., 10., 11.
//double float1 = 3000.0;
//double float2 = 0.0;
//int number1 = 3000;
//int number2 = 0;

//try
//{
//    Console.WriteLine(float1 / float2);
//    Console.WriteLine(number1 / number2);
//}
//catch
//{
//    Console.WriteLine("An exception has been caught");
//}

//Console.WriteLine("Exit program");
#endregion
#endregion

#region Capturar exceções geradas nos métodos chamados
#region 1.
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
    WriteMessage();
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
#endregion

#endregion