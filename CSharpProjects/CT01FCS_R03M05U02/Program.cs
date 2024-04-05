// Roteiro 03   - "Adicionar lógica a aplicativos de console C# (Introdução ao C#, Parte 3)"
// Modulo 05    - "Adicione lógica de loop a seu código usando as instruções "do-while" e "while" em C#"
// Unidade 02   - "Exercício – Criar loops de iteração do e while" (10min)
// https://learn.microsoft.com/pt-br/training/modules/csharp-do-while/2-exercise-do-while-continue

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

#region CT01FCS_R03M05U02


#region O que é a instrução do-while?
#region Escrever uma instrução do-while que seja interrompida quando determinado número aleatório for gerado
//// [Versão oficial]
//Random random = new Random();
//int current = 0;

//do
//{
//    current = random.Next(1, 11);
//    Console.WriteLine(current);
//} while (current != 7);

////[Minha versão]
//var randomNumber = new Random();
//int i = 0;
//do
//{
//    i = randomNumber.Next(1, 11);
//    Console.WriteLine(i);
//} while (i != 7);
#endregion

#region Escrever uma instrução while que itere somente enquanto um número aleatório for maior que determinado valor
//// [Versão oficial]
//Random random = new Random();
//int current = random.Next(1, 11);

//while (current >= 3)
//{
//    Console.WriteLine(current);
//    current = random.Next(1, 11);
//}
//Console.WriteLine($"Last number: {current}");

//// [Minha versão]
//var randomNumber = new Random();
//int i = 0;
//int conditionClosureWhile = randomNumber.Next(1, 21);
//Console.WriteLine($"Condição para finalizar while é ser maior que: {conditionClosureWhile}");

//do
//{
//    i = randomNumber.Next(1, 21);
//    Console.WriteLine(i);
//} while (i < conditionClosureWhile);

#endregion

#region Usar a instrução continue para passar diretamente para a expressão booliana
Random random = new Random();
int current = random.Next(1, 11);

do
{
    current = random.Next(1, 11);

    //if (current >= 8) continue;
    if (current >= 8) break;

    Console.WriteLine(current);
} while (current != 7);

Console.WriteLine(current);
#endregion
#endregion



#endregion