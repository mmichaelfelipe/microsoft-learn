// Roteiro 05   - "Criar métodos em aplicativos de console C# (Introdução ao C#, Parte 5)"
// Modulo 01    - "Escrever seu primeiro método C#"
// Unidade 04   - "Exercício – Criar métodos reutilizáveis" (10min)
// https://learn.microsoft.com/pt-br/training/modules/write-first-c-sharp-method/4-exercise-create-reusable-methods

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

#region CT01FCS_R01M01U04


#region Identificar código duplicado
#region 2.
//using System;

//int[] times = { 800, 1200, 1600, 2000 };
//int diff = 0;

//Console.WriteLine("Enter current GMT");
//int currentGMT = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Current Medicine Schedule:");

///* Format and display medicine times */
//// Formatar e exibir horários de medicamentos
//foreach (int val in times)
//{
//    string time = val.ToString();
//    int len = time.Length;

//    if (len >= 3)
//    {
//        time = time.Insert(len - 2, ":");
//    }
//    else if (len == 2)
//    {
//        time = time.Insert(0, "0:");
//    }
//    else
//    {
//        time = time.Insert(0, "0:0");
//    }

//    Console.Write($"{time} ");
//}

//Console.WriteLine();

//Console.WriteLine("Enter new GMT");
//int newGMT = Convert.ToInt32(Console.ReadLine());

//if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
//{
//    Console.WriteLine("Invalid GMT");
//}
//else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
//{
//    diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));

//    /* Adjust the times by adding the difference, keeping the value within 24 hours */
//    // Ajuste os horários adicionando a diferença, mantendo o valor dentro de 24 horas
//    for (int i = 0; i < times.Length; i++)
//    {
//        times[i] = ((times[i] + diff)) % 2400;
//    }
//}
//else
//{
//    diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));

//    /* Adjust the times by adding the difference, keeping the value within 24 hours */
//    // Ajuste os horários adicionando a diferença, mantendo o valor dentro de 24 horas
//    for (int i = 0; i < times.Length; i++)
//    {
//        times[i] = ((times[i] + diff)) % 2400;
//    }
//}

//Console.WriteLine("New Medicine Schedule:");

///* Format and display medicine times */
//// Formatar e exibir horários de medicamentos
//foreach (int val in times)
//{
//    string time = val.ToString();
//    int len = time.Length;

//    if (len >= 3)
//    {
//        time = time.Insert(len - 2, ":");
//    }
//    else if (len == 2)
//    {
//        time = time.Insert(0, "0:");
//    }
//    else
//    {
//        time = time.Insert(0, "0:0");
//    }

//    Console.Write($"{time} ");
//}

//Console.WriteLine();
#endregion
#endregion

#region Criar métodos para executar tarefas repetidas
#region 2., 3., 4., 5., 6.
//using System;

//int[] times = { 800, 1200, 1600, 2000 };
//int diff = 0;

//Console.WriteLine("Enter current GMT");
//int currentGMT = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Current Medicine Schedule:");

///* Format and display medicine times */
//// Formatar e exibir horários de medicamentos
//foreach (int val in times)
//{
//    string time = val.ToString();
//    int len = time.Length;

//    if (len >= 3)
//    {
//        time = time.Insert(len - 2, ":");
//    }
//    else if (len == 2)
//    {
//        time = time.Insert(0, "0:");
//    }
//    else
//    {
//        time = time.Insert(0, "0:0");
//    }

//    Console.Write($"{time} ");
//}

//Console.WriteLine();

//Console.WriteLine("Enter new GMT");
//int newGMT = Convert.ToInt32(Console.ReadLine());

//if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
//{
//    Console.WriteLine("Invalid GMT");
//}
//else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
//{
//    diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));

//    /* Adjust the times by adding the difference, keeping the value within 24 hours */
//    // Ajuste os horários adicionando a diferença, mantendo o valor dentro de 24 horas
//    for (int i = 0; i < times.Length; i++)
//    {
//        times[i] = ((times[i] + diff)) % 2400;
//    }
//}
//else
//{
//    diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));

//    /* Adjust the times by adding the difference, keeping the value within 24 hours */
//    // Ajuste os horários adicionando a diferença, mantendo o valor dentro de 24 horas
//    for (int i = 0; i < times.Length; i++)
//    {
//        times[i] = ((times[i] + diff)) % 2400;
//    }
//}

//Console.WriteLine("New Medicine Schedule:");

///* Format and display medicine times */
//// Formatar e exibir horários de medicamentos
//foreach (int val in times)
//{
//    string time = val.ToString();
//    int len = time.Length;

//    if (len >= 3)
//    {
//        time = time.Insert(len - 2, ":");
//    }
//    else if (len == 2)
//    {
//        time = time.Insert(0, "0:");
//    }
//    else
//    {
//        time = time.Insert(0, "0:0");
//    }

//    Console.Write($"{time} ");
//}

//Console.WriteLine();

//void DisplayTimes()
//{
//    /* Format and display medicine times */
//    // Formatar e exibir horários de medicamentos
//    foreach (int val in times)
//    {
//        string time = val.ToString();
//        int len = time.Length;

//        if (len >= 3)
//        {
//            time = time.Insert(len - 2, ":");
//        }
//        else if (len == 2)
//        {
//            time = time.Insert(0, "0:");
//        }
//        else
//        {
//            time = time.Insert(0, "0:0");
//        }

//        Console.Write($"{time} ");
//    }
//}

//void AdjustTimes()
//{
//    /* Adjust the times by adding the difference, keeping the value within 24 hours */
//    // Ajuste os horários adicionando a diferença, mantendo o valor dentro de 24 horas
//    for (int i = 0; i < times.Length; i++)
//    {
//        times[i] = ((times[i] + diff)) % 2400;
//    }
//}
#endregion
#endregion

#region Etapa 3: Chamar os métodos
#region 1., 2., 3., 4., 5., 6.
using System;

int[] times = { 800, 1200, 1600, 2000 };
int diff = 0;

Console.WriteLine("Enter current GMT");
int currentGMT = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Current Medicine Schedule:");
DisplayTimes();

Console.WriteLine("Enter new GMT");
int newGMT = Convert.ToInt32(Console.ReadLine());

if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
{
    Console.WriteLine("Invalid GMT");
}
else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
{
    diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
    AdjustTimes();
}
else
{
    diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
    AdjustTimes();
}

Console.WriteLine("New Medicine Schedule:");
DisplayTimes();

void DisplayTimes()
{
    /* Format and display medicine times */
    // Formatar e exibir horários de medicamentos
    foreach (int val in times)
    {
        string time = val.ToString();
        int len = time.Length;

        if (len >= 3)
        {
            time = time.Insert(len - 2, ":");
        }
        else if (len == 2)
        {
            time = time.Insert(0, "0:");
        }
        else
        {
            time = time.Insert(0, "0:0");
        }

        Console.Write($"{time} ");
    }
}

void AdjustTimes()
{
    /* Adjust the times by adding the difference, keeping the value within 24 hours */
    // Ajuste os horários adicionando a diferença, mantendo o valor dentro de 24 horas
    for (int i = 0; i < times.Length; i++)
    {
        times[i] = ((times[i] + diff)) % 2400;
    }
}
#endregion
#endregion

#endregion