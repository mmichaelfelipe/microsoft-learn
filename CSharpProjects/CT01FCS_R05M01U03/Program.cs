// Roteiro 05   - "Criar métodos em aplicativos de console C# (Introdução ao C#, Parte 5)"
// Modulo 01    - "Escrever seu primeiro método C#"
// Unidade 03   - "Exercício – Criar seu primeiro método" (10min)
// https://learn.microsoft.com/pt-br/training/modules/write-first-c-sharp-method/3-exercise-create-your-first-method

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

#region CT01FCS_R05M01U03

#region Criar um método para exibir números aleatórios
#region 1.
//void DisplayRandomNumbers();
#endregion

#region 2.
//void DisplayRandomNumbers()
//{
//    Random random = new Random();
//}
#endregion

#region 3.
//void DisplayRandomNumbers()
//{
//    Random random = new Random();

//    for (int i = 0; i < 5; i++)
//    {
//        Console.Write($"{random.Next(1, 100)} ");
//    }
//}
#endregion

#region 4.
//void DisplayRandomNumbers()
//{
//    Random random = new Random();

//    for (int i = 0; i < 5; i++)
//    {
//        Console.Write($"{random.Next(1, 100)} ");
//    }

//    Console.WriteLine();
//}
#endregion
#endregion

#region Chamar seu método
#region 2.
Console.WriteLine("Generating random numbers:");
DisplayRandomNumbers();

void DisplayRandomNumbers()
{
    Random random = new Random();

    for (int i = 0; i < 5; i++)
    {
        Console.Write($"{random.Next(1, 100)} ");
    }

    Console.WriteLine();
}
#endregion
#endregion

#endregion