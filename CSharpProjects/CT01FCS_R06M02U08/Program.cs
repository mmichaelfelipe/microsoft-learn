﻿// Roteiro 06   - "Depurar aplicativos de console do C# (Introdução ao C#, Parte 6)"
// Modulo 02    - "Implementar as ferramentas de depuração do Visual Studio Code para C#"
// Unidade 08   - "Exercício – Monitorar as variáveis e o fluxo de execução" (13min)
// https://learn.microsoft.com/pt-br/training/modules/implement-visual-studio-code-debugging-tools/8-exercise-monitor-variables-execution-flow

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

#region CT01FCS_R06M02U08


#region Configurar o aplicativo e iniciar a configuração
#region 1., 9.
//string? readResult;
//int startIndex = 0;
//bool goodEntry = false;

//int[] numbers = { 1, 2, 3, 4, 5 };

//// Display the array to the console.
//Console.Clear();
//Console.Write("\n\rThe 'numbers' array contains: { ");
//foreach (int number in numbers)
//{
//    Console.Write($"{number} ");
//}

//// To calculate a sum of array elements, 
////  prompt the user for the starting element number.
//Console.WriteLine($"}}\n\r\n\rTo sum values 'n' through 5, enter a value for 'n':");
//while (goodEntry == false)
//{
//    readResult = Console.ReadLine();
//    goodEntry = int.TryParse(readResult, out startIndex);

//    if (startIndex > 5)
//    {
//        goodEntry = false;
//        Console.WriteLine("\n\rEnter an integer value between 1 and 5");
//    }
//}

//// Display the sum and then pause.
//Console.WriteLine($"\n\rThe sum of numbers {startIndex} through {numbers.Length} is: {SumValues(numbers, startIndex)}");

//Console.WriteLine("press Enter to exit");
//readResult = Console.ReadLine();

//// This method returns the sum of elements n through 5
//static int SumValues(int[] numbers, int n)
//{
//    int sum = 0;
//    for (int i = n; i < numbers.Length; i++)
//    {
//        sum += numbers[i];
//    }
//    return sum;
//}
#endregion
#endregion


#region Monitorar o estado da variável
#region 13.
//string? readResult;
//int startIndex = 0;
//bool goodEntry = false;

//int[] numbers = { 1, 2, 3, 4, 5 };

//// Display the array to the console.
//Console.Clear();
//Console.Write("\n\rThe 'numbers' array contains: { ");
//foreach (int number in numbers)
//{
//    Console.Write($"{number} ");
//}

//// To calculate a sum of array elements, 
////  prompt the user for the starting element number.
//Console.WriteLine($"}}\n\r\n\rTo sum values 'n' through 5, enter a value for 'n':");
//while (goodEntry == false)
//{
//    readResult = Console.ReadLine();
//    goodEntry = int.TryParse(readResult, out startIndex);

//    if (startIndex > 5)
//    {
//        goodEntry = false;
//        Console.WriteLine("\n\rEnter an integer value between 1 and 5");
//    }
//}

//// Display the sum and then pause.
//Console.WriteLine($"\n\rThe sum of numbers {startIndex} through {numbers.Length} is: {SumValues(numbers, startIndex - 1)}");

//Console.WriteLine("press Enter to exit");
//readResult = Console.ReadLine();

//// This method returns the sum of elements n through 5
//static int SumValues(int[] numbers, int n)
//{
//    int sum = 0;
//    for (int i = n; i < numbers.Length; i++)
//    {
//        sum += numbers[i];
//    }
//    return sum;
//}
#endregion
#endregion

#region Monitorar as expressões de inspeção
#region 1.
bool exit = false;
var rand = new Random();
int num1 = 5;
int num2 = 5;

do
{
    num1 = rand.Next(1, 11);
    num2 = num1 + rand.Next(1, 51);

} while (exit == false);
#endregion
#endregion

#endregion