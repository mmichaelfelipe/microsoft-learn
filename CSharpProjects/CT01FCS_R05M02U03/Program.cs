// Roteiro 05   - "Criar métodos em aplicativos de console C# (Introdução ao C#, Parte 5)"
// Modulo 02    - "Criar métodos C# com parâmetros"
// Unidade 03   - "Exercício – Entender o escopo do método" (05min)
// https://learn.microsoft.com/pt-br/training/modules/create-c-sharp-methods-parameters/3-exercise-understand-method-scope

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

#region CT01FCS_R05M02U03

#region Testar o escopo de variáveis
#region 2.
//string[] students = { "Jenna", "Ayesha", "Carlos", "Viktor" };

//DisplayStudents(students);
//DisplayStudents(new string[] {"Robert", "Vanya"});

//void DisplayStudents(string[] students)
//{
//    foreach (var student in students)
//    {
//        Console.Write($"{student}, ");
//    }
//    Console.WriteLine();
//}
#endregion

#region 5., 6., 7., 8., 9.
double pi = 3.14159;

PrintCircleInfo(12);
PrintCircleInfo(24);

void PrintCircleArea(int radius)
{
    double area = pi * (radius * radius);
    Console.WriteLine($"Area = {area}");
}

void PrintCircumference(int radius)
{
    double circumference = 2 * pi * radius;
    Console.WriteLine($"Circumference = {circumference}");
}

void PrintCircleInfo(int radius)
{
    Console.WriteLine($"Circle with radius {radius}");
    PrintCircleArea(radius);
    PrintCircumference(radius);
}
#endregion
#endregion

#endregion