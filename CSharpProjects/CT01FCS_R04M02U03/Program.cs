// Roteiro 04   - "Trabalhar com os dados variáveis em aplicativos de console C# (Introdução ao C#, Parte 4)"
// Modulo 02    - "Converter tipos de dados usando técnicas de conversão cast em C#"
// Unidade 03   - "Exercício – Examinar o método TryParse()" (12min)
// https://learn.microsoft.com/pt-br/training/modules/csharp-convert-cast/3-exercise-tryparse

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

#region CT01FCS_R04M02U03



#region example
//string name = "Bob";
//Console.WriteLine(int.Parse(name));
//// System.FormatException: 'Input string was not in a correct format.'
#endregion


#region Usar TryParse()
#region Utilizar o método TryParse() para analisar uma cadeia de caracteres como um int
#region 2.
//string value = "102";
//int result = 0;
//if (int.TryParse(value, out result))
//{
//    Console.WriteLine($"Measurement: {result}");
//}
//else
//{
//    Console.WriteLine("Unable to report the measurement.");
//}
#endregion
#endregion

#region O int analisado será usado posteriormente no código
//string value = "102";
//int result = 0;
//if (int.TryParse(value, out result))
//{
//    Console.WriteLine($"Measurement: {result}");
//}
//else
//{
//    Console.WriteLine("Unable to report the measurement.");
//}
//Console.WriteLine($"Measurement (w/ offset): {50 + result}");
#endregion

#region Modificar a variável de cadeia de caracteres para um valor que não possa ser analisado
#region 1.
//string value = "bad";
//int result = 0;
//if (int.TryParse(value, out result))
//{
//    Console.WriteLine($"Measurement: {result}");
//}
//else
//{
//    Console.WriteLine("Unable to report the measurement.");
//}
//Console.WriteLine($"Measurement (w/ offset): {50 + result}");
#endregion

#region 2.
string value = "bad";
int result = 0;
if (int.TryParse(value, out result))
{
    Console.WriteLine($"Measurement: {result}");
}
else
{
    Console.WriteLine("Unable to report the measurement.");
}

if (result > 0)
    Console.WriteLine($"Measurement (w/ offset): {50 + result}");
#endregion
#endregion
#endregion

#endregion