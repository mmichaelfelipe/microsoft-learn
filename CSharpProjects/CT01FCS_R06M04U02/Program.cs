// Roteiro 06   - "Depurar aplicativos de console do C# (Introdução ao C#, Parte 6)"
// Modulo 04    - "Criar e gerar exceções em aplicativos de console C#"
// Unidade 02   - "Analisar como criar e gerar exceções em C#" (16min)
// https://learn.microsoft.com/pt-br/training/modules/create-throw-exceptions-c-sharp/2-examine-create-exception-c-sharp

// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

#region CT01FCS_R06M04U02

#region Criar um objeto de exceção
//ArgumentException invalidArgumentException = new ArgumentException();
#endregion

#region Configurar e gerar exceções personalizadas
//ArgumentException invalidArgumentException = new ArgumentException("ArgumentException: The 'GraphData' method received data outside the expected range.");
//throw invalidArgumentException;

//throw new FormatException("FormatException: Calculations in process XYZ have been cancelled due to invalid data format.");
#endregion

#region Quando gerar uma exceção
//string[][] userEnteredValues = new string[][]
//{
//    new string[] { "1", "two", "3" },
//    new string[] { "0", "1", "2"}
//};

//foreach (string[] userEntries in userEnteredValues)
//{
//    try
//    {
//        BusinessProcess1(userEntries);
//    }
//    catch (Exception ex)
//    {
//        if (ex.StackTrace.Contains("BusinessProcess1") && (ex is FormatException))
//        {
//            Console.WriteLine(ex.Message);
//        }
//    }
//}

//static void BusinessProcess1(string[] userEntries)
//{
//    int valueEntered;

//    foreach (string userValue in userEntries)
//    {
//        try
//        {
//            valueEntered = int.Parse(userValue);

//            // completes required calculations based on userValue
//            // conclui os cálculos necessários com base em userValue
//            // ...
//        }
//        catch (FormatException)
//        {
//            FormatException invalidFormatException = new FormatException("FormatException: User input values in 'BusinessProcess1' must be valid integers");
//            throw invalidFormatException;
//        }
//    }
//}
#endregion

#region Como gerar exceções novamente
#region part 1 (trecho de codigo)
//catch (Exception ex)
//{
//    // handle or partially handle the exception
//    // manipular ou manipular parcialmente a exceção
//    // ...

//    // re-throw the original exception object for further handling down the call stack
//    // relançar o objeto de exceção original para manipulação adicional na pilha de chamadas
//    throw;
//}
#endregion

#region part 2 (trecho de codigo)
//// [PART 2]
//catch (Exception ex)
//{
//    // handle or partially handle the exception
//    // manipular ou manipular parcialmente a exceção
//    // ...

//    // create a new exception object that wraps the original exception
//    // criar um novo objeto de exceção que envolve a exceção original
//    throw new ApplicationException("An error occurred", ex);
//}
#endregion

#region Codigo completo
try
{
    OperatingProcedure1();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine("Exiting application");
}

static void OperatingProcedure1()
{
    string[][] userEnteredValues = new string[][]
    {
        new string[] { "1", "two", "3" },
        new string[] { "0", "1", "2"}
    };

    foreach (string[] userEntries in userEnteredValues)
    {
        try
        {
            BusinessProcess1(userEntries);
        }
        catch (Exception ex)
        {
            if (ex.StackTrace.Contains("BusinessProcess1"))
            {
                if (ex is FormatException)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Corrective action taken in OperatingProcedure1");
                }
                else if (ex is DivideByZeroException)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Partial correction in OperatingProcedure1 - further action required");

                    // re-throw the original exception
                    // relançar a exceção original
                    throw;
                }
                else
                {
                    // create a new exception object that wraps the original exception
                    // criar um novo objeto de exceção que envolve a exceção original
                    throw new ApplicationException("An error ocurred - ", ex);
                }
            }
        }
    }
}

static void BusinessProcess1(string[] userEntries)
{
    int valueEntered;

    foreach (string userValue in userEntries)
    {
        try
        {
            valueEntered = int.Parse(userValue);

            checked
            {
                int calculatedValue = 4 / valueEntered;
            }
        }
        catch (FormatException)
        {
            FormatException invalidFormatException = new FormatException("FormatException: User input values in 'BusinessProcess1' must be valid integers");
            throw invalidFormatException;
        }
        catch (DivideByZeroException)
        {
            DivideByZeroException unexpectedDivideByZeroException = new DivideByZeroException("DivideByZeroException: Calculation in 'BusinessProcess1' encountered an unexpected divide by zero");
            throw unexpectedDivideByZeroException;
        }
    }
}
#endregion
#endregion

#endregion