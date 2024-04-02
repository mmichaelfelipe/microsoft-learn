// Roteiro 03   - "Adicionar lógica a aplicativos de console C# (Introdução ao C#, Parte 3)"
// Modulo 02    - "Controlar o escopo da variável e a lógica usando blocos de código em C#"
// Unidade 02   - "Exercício – Blocos de código e escopo de variável" (11min)
// https://learn.microsoft.com/pt-br/training/modules/csharp-code-blocks/2-exercise-variable-scope

// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

#region CT01FCS_R03M02U02



#region Blocos de código afetam o escopo de uma declaração de variáveis
#region Criar uma variável dentro de um bloco de código
//bool flag = true;
//if (flag)
//{
//    int value = 10;
//    Console.WriteLine($"Inside the code block: {value}");
//}
#endregion

#region Tentar acessar uma variável fora do bloco de código no qual ela é declarada
//bool flag = true;
//if (flag)
//{
//    int value = 10;
//    Console.WriteLine($"Inside the code block: {value}");
//}
//Console.WriteLine($"Outside the block: {value}");
#endregion

#region Mover a declaração de variável acima do bloco de código
//bool flag = true;
//int value;

//if (flag)
//{
//    Console.WriteLine($"Inside the code block: {value}");
//}

//value = 10;
//Console.WriteLine($"Outside the block: {value}");
#endregion

#region Inicializar uma variável como parte da declaração de variável
//bool flag = true;
//int value = 0;

//if (flag)
//{
//    Console.WriteLine($"Inside the code block: {value}");
//}

//value = 10;
//Console.WriteLine($"Outside the block: {value}");
#endregion

#region Examinar a interpretação do compilador do código
#region Code sample 1
//// Code sample 1
//bool flag = true;
//int value;

//if (flag)
//{
//    value = 10;
//    Console.WriteLine($"Inside the code block: {value}");
//}

//Console.WriteLine($"Outside the code block: {value}");
#endregion
#region Code sample 2
//// Code sample 2
//int value;

//if (true)
//{
//    value = 10;
//    Console.WriteLine($"Inside the code block: {value}");
//}

//Console.WriteLine($"Outside the code block: {value}");
#endregion 
#region Code sample Michael
//// Code sample Michael
//int goals = 5;
//int value;

//if (goals >= 5)
//{
//    value = 10;
//    Console.WriteLine($"Inside the code block: {value}");
//}
//else
//{
//    value = 10;
//}

//Console.WriteLine($"Outside the code block: {value}");
#endregion
#endregion
#endregion



#endregion


#region Verificação de conhecimentos
//1
int value1 = 5;
if (value1 > 0)
{
    int value2 = 6;
    value1 += value2;
}
Console.WriteLine($"Value1 = {value1}");
#endregion