// Roteiro 05   - "Criar métodos em aplicativos de console C# (Introdução ao C#, Parte 5)"
// Modulo 01    - "Escrever seu primeiro método C#"
// Unidade 02   - "Entender a sintaxe dos métodos" (05min)
// https://learn.microsoft.com/pt-br/training/modules/write-first-c-sharp-method/2-understand-syntax-of-methods

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

#region CT01FCS_R05M01U02


#region Como os métodos funcionam
//void SayHello();

//void SayHello()
//{
//    Console.WriteLine("Hello World!");
//}
#endregion

#region Chamando um método
//Console.Write("Input!");

//SayHello();

//void SayHello()
//{
//    Console.WriteLine("Hello World!");
//}

//int[] a = { 1, 2, 3, 4, 5 };

//Console.WriteLine("Contents of Array:");
//PrintArray();

//void PrintArray()
//{
//    foreach (int x in a)
//    {
//        Console.Write($"{x} ");
//    }
//    Console.WriteLine();
//}
#endregion

#region Execução do método
Console.WriteLine("Before calling a method");
SayHello();
Console.WriteLine("After calling a method");

void SayHello()
{
    Console.WriteLine("Hello World!");
}
#endregion

#endregion