// Roteiro 06   - "Depurar aplicativos de console do C# (Introdução ao C#, Parte 6)"
// Modulo 03    - "Implementar o tratamento de exceções em aplicativos de console C#"
// Unidade 03   - "Analisar as exceções geradas pelo compilador" (10min)
// https://learn.microsoft.com/pt-br/training/modules/implement-exception-handling-c-sharp/3-examine-compiler-generated-exceptions

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

#region CT01FCS_R06M03U03

#region Exemplos de código para exceções geradas pelo compilador
#region ArrayTypeMismatchException
//string[] names = { "Dog", "Cat", "Fish" };
//Object[] objs = (Object[])names;

//Object obj = (Object)13;
//objs[2] = obj; // ArrayTypeMismatchException occurs
#endregion

#region DivideByZeroException
//int number1 = 3000;
//int number2 = 0;
//Console.WriteLine(number1 / number2); // DivideByZeroException occurs
#endregion

#region FormatException
//int valueEntered;
//string userValue = "two";
//valueEntered = int.Parse(userValue); // FormatException occurs
#endregion

#region IndexOutOfRangeException
//int[] values1 = { 3, 6, 9, 12, 15, 18, 21 };
//int[] values2 = new int[6];

//values2[values1.Length - 1] = values1[values1.Length - 1]; // IndexOutOfRangeException occurs
#endregion

#region InvalidCastException
//object obj = "This is a string";
//int num = (int)obj;
#endregion

#region NullReferenceException
//int[] values = null;
//for (int i = 0; i <= 9; i++)
//    values[i] = i * 2;

//string? lowCaseString = null;
//Console.WriteLine(lowCaseString.ToUpper());
#endregion

#region OverflowException
//decimal x = 400;
//byte i;

//i = (byte)x; // OverflowException occurs
//Console.WriteLine(i);
#endregion
#endregion

#endregion