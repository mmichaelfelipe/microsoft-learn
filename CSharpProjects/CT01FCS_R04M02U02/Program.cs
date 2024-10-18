// Roteiro 04   - "Trabalhar com os dados variáveis em aplicativos de console C# (Introdução ao C#, Parte 4)"
// Modulo 02    - "Converter tipos de dados usando técnicas de conversão cast em C#"
// Unidade 02   - "Exercício – Explorar a coerção e a conversão de tipo de dados" (30min)
// https://learn.microsoft.com/pt-br/training/modules/csharp-convert-cast/2-exercise-data-type-conversion

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

#region CT01FCS_R04M02U02



#region Pergunta: Tentar alterar o tipo de dados do valor geraria uma exceção no tempo de execução?
#region Escreva um código que tente somar um int com uma string e salve o resultado em um int
#region 2.
//int first = 2;
//string second = "4";
//int result = first + second;
//Console.WriteLine(result);
#endregion

#region 7.
//int first = 2;
//string second = "4";
//string result = first + second;
//Console.WriteLine(result);
#endregion
#endregion
#endregion


#region Pergunta: Tentar alterar o tipo de dados do valor resultaria em uma perda de informações?
#region 1.
//int myInt = 3;
//Console.WriteLine($"int: {myInt}");

//decimal myDecimal = myInt;
//Console.WriteLine($"decimal: {myDecimal}");
#endregion

#region 2.
/*
O termo conversão de expansão significa que você está tentando converter um valor de um tipo de dados 
que poderia armazenar menos informações em um tipo de dados que pode armazenar mais informações. 
Neste caso, um valor armazenado em uma variável do tipo int convertida em uma variável do tipo decimal não perde informação.

Quando você sabe que está realizando uma conversão de expansão, é possível confiar na conversão implícita. 
O compilador lida com conversões implícitas.
*/
#endregion

#region Executar uma coerção
#region 1.
//decimal myDecimal = 3.14m;
//Console.WriteLine($"decimal: {myDecimal}");

//int myInt = (int)myDecimal;
//Console.WriteLine($"int: {myInt}");
#endregion
#endregion
#endregion


#region Determine se sua conversão é uma "conversão de expansão" ou uma "conversão de restrição"
#region 1.
//decimal myDecimal = 1.23456789m;
//float myFloat = (float)myDecimal;

//Console.WriteLine($"Decimal: {myDecimal}");
//Console.WriteLine($"Float: {myFloat}");
#endregion
#endregion


#region Executar conversões de dados
#region Use ToString() para converter um número em um string
#region 1.
//int first = 5;
//int second = 7;
//string message = first.ToString() + second.ToString();
//Console.WriteLine(message);
#endregion
#endregion
#endregion


#region Converter um string em um int usando o método auxiliar Parse()
//string first = "5";
//string second = "7";
//int sum = int.Parse(first) + int.Parse(second);
//Console.WriteLine(sum);
#endregion


#region Converter um string em um int usando a classe Convert
//string value1 = "5";
//string value2 = "7";
//int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
//Console.WriteLine(result);
#endregion


#region Comparar a coerção e a conversão de um decimal em um int
#region 1.
int value = (int)1.5m; // casting truncates
Console.WriteLine(value);

int value2 = Convert.ToInt32(1.5m); // converting rounds up
Console.WriteLine(value2);
#endregion
#endregion

#endregion