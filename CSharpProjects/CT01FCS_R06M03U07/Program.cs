// Roteiro 06   - "Depurar aplicativos de console do C# (Introdução ao C#, Parte 6)"
// Modulo 03    - "Implementar o tratamento de exceções em aplicativos de console C#"
// Unidade 07   - "Exercício – Capturar tipos de exceções específicos" (14min)
// https://learn.microsoft.com/pt-br/training/modules/implement-exception-handling-c-sharp/7-exercise-catch-explicit-exception-types

// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

#region CT01FCS_R06M03U07

#region Analisar as propriedades de exceção
/*
Analisar as propriedades de exceção
System.Exception é a classe base da qual todos os tipos de exceções derivadas herdam. 
Cada tipo de exceção herda da classe base por meio de uma hierarquia de classe específica. 
Por exemplo, a hierarquia de classe da InvalidCastException é a seguinte:
----------------------------------------------
System.Object
    System.Exception
        System.SystemException
            System.InvalidCastException
----------------------------------------------

A maioria das classes que herdam de Exception não implementa membros adicionais nem fornece funcionalidade adicional, apenas herdam de Exception. 
Portanto, analisar as propriedades da classe Exception permite que você entenda a maioria das exceções e como você pode usar uma exceção no código.

Estas são as propriedades da classe Exception:

- Data: 
    a propriedade Data contém dados arbitrários em pares chave-valor.
- HelpLink: 
    a propriedade HelpLink pode ser usada para conter uma URL (ou um URN) para um arquivo de ajuda 
    que fornece informações abrangentes sobre a causa de uma exceção.
- HResult: 
    a propriedade HResult pode ser usada para acessar um valor numérico codificado atribuído a uma exceção específica.
- InnerException: 
    a propriedade InnerException pode ser usada para criar e manter uma série de exceções durante o tratamento de exceções.
- Message: 
    a propriedade Message fornece detalhes sobre a causa de uma exceção.
- Source: 
    a propriedade Source pode ser usada para acessar o nome do aplicativo ou o objeto que causa o erro.
- StackTrace: 
    a propriedade StackTrace contém um rastreamento de pilha que pode ser usado para determinar o ponto em que ocorreu um erro.
- TargetSite: 
    a propriedade TargetSite pode ser usada para obter o método que gera a exceção atual.

Não se preocupe se estiver se sentindo um pouco sobrecarregado com esse exame de propriedades de exceção, classes base e herança. 
Não se preocupe: capturar exceções no código e acessar as propriedades de uma exceção é mais fácil do que explicar como as exceções 
e as propriedades de exceção funcionam.
*/
#endregion

#region Acessar as propriedades de um objeto de exceção
#region 1., 3.,
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
//    catch (Exception ex)
//    {
//        Console.WriteLine($"Exception caught in Process1: {ex.Message}");
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

#region Capturar um tipo de exceção específico
#region 1., 4.
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
//    catch (DivideByZeroException ex)
//    {
//        Console.WriteLine($"Exception caught in Process1: {ex.Message}");
//    }
//}

//static void WriteMessage()
//{
//    double float1 = 3000.0;
//    double float2 = 0.0;
//    int number1 = 3000;
//    int number2 = 0;
//    byte smallNumber;

//    Console.WriteLine(float1 / float2);
//    //Console.WriteLine(number1 / number2);

//    checked
//    {
//        smallNumber = (byte)number1;
//    }
//}
#endregion
#endregion

#region Capturar várias exceções em um bloco de código
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
//    try
//    {
//        WriteMessage();
//    }
//    catch (DivideByZeroException ex)
//    {
//        Console.WriteLine($"Exception caught in Process1: {ex.Message}");
//    }
//}

//static void WriteMessage()
//{
//    double float1 = 3000.0;
//    double float2 = 0.0;
//    int number1 = 3000;
//    int number2 = 0;
//    byte smallNumber;

//    Console.WriteLine(float1 / float2);
//    Console.WriteLine(number1 / number2);

//    checked
//    {
//        smallNumber = (byte)number1;
//    }
//}
#endregion

#region 5.
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
//    catch (DivideByZeroException ex)
//    {
//        Console.WriteLine($"Exception caught in Process1: {ex.Message}");
//    }
//}

//static void WriteMessage()
//{
//    double float1 = 3000.0;
//    double float2 = 0.0;
//    int number1 = 3000;
//    int number2 = 0;
//    byte smallNumber;

//    try
//    {
//        Console.WriteLine(float1 / float2);
//        Console.WriteLine(number1 / number2);
//    }
//    catch (DivideByZeroException ex)
//    {
//        Console.WriteLine($"Exception caught in WriteMessage: {ex.Message}");
//    }

//    checked
//    {
//        try
//        {
//            smallNumber = (byte)number1;
//        }
//        catch (OverflowException ex)
//        {
//            Console.WriteLine($"Exception caught in WriteMessage: {ex.Message}");
//        }
//    }
//}
#endregion
#endregion

#region Capturar tipos de exceções separados em um bloco de código
#region 1.
// inputValues is used to store numeric values entered by a user
// inputValues é usado para armazenar valores numéricos inseridos por um usuário
string[] inputValues = new string[] { "three", "9999999999", "0", "2" };

foreach (string inputValue in inputValues)
{
    int numValue = 0;
    try
    {
        numValue = int.Parse(inputValue);
    }
    catch (FormatException)
    {
        Console.WriteLine("Invalid readResult. Please enter a valid number.");
    }
    catch (OverflowException)
    {
        Console.WriteLine("The number you entered is too large or too small.");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}
#endregion
#endregion

#endregion