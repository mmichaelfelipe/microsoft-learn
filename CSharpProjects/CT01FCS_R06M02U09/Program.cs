// Roteiro 06   - "Depurar aplicativos de console do C# (Introdução ao C#, Parte 6)"
// Modulo 02    - "Implementar as ferramentas de depuração do Visual Studio Code para C#"
// Unidade 09   - "Exercício – Concluir uma atividade de desafio usando o depurador" (07min)
// https://learn.microsoft.com/pt-br/training/modules/implement-visual-studio-code-debugging-tools/9-exercise-challenge-debug-code

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

#region CT01FCS_R06M02U09

#region Desafio de estado de variável
#region 1.
///*  
//This code instantiates a value and then calls the ChangeValue method
//to update the value. The code then prints the updated value to the console.
//*/
///*
//Este código instancia um valor e então chama o método ChangeValue
//para atualizar o valor. O código então imprime o valor atualizado no console.
//*/
//int x = 5;

//ChangeValue(x);

//Console.WriteLine(x);

//void ChangeValue(int value)
//{
//    value = 10;
//}
#endregion
#endregion

#region Minha solução do desafio
int x = 5;
x = ChangeValue(x);
Console.WriteLine(x);

int ChangeValue(int value)
{
    value = 10;
    return value;
}
#endregion

#endregion