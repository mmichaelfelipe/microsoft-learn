// Roteiro 02   - "Criar e executar aplicativos de console C# simples (Introdução ao C#, Parte 2)"
// Modulo 06    - "Projeto guiado – Desenvolver estruturas foreach e if-elseif-else para processar dados de matriz em C#"
// Unidade 03   - "Exercício – Criar matrizes e loops foreach" (25min)
// https://learn.microsoft.com/pt-br/training/modules/guided-project-arrays-iteration-selection/3-exercise-create-arrays-foreach-loops

using System;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

#region CT01FCS_R02M06U03



    #region Criar as matrizes de notas de tarefa
/*
// initialize variables - graded assignments 
int currentAssignments = 5;

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100 };
int[] andrewScores = new int[] { 92, 89, 87, 96, 90 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96 };
*/
    #endregion


    #region Criar uma iteração foreach para calcular a nota de Sophia
// initialize variables - graded assignments 
int currentAssignments = 5;

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96 };

int sophiaSum = 0;

decimal sophiaScore;

foreach (int score in sophiaScores) {
    // add the exam score to the sum
    sophiaSum += score;
}

sophiaScore = (decimal)sophiaSum / currentAssignments;

Console.WriteLine("Student\t\tGrade\n");
Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
    #endregion



#endregion





#region Recommended Starter Code
/*
//using System;

// initialize variables - graded assignments 
int currentAssignments = 5;

int sophia1 = 90;
int sophia2 = 86;
int sophia3 = 87;
int sophia4 = 98;
int sophia5 = 100;

int andrew1 = 92;
int andrew2 = 89;
int andrew3 = 81;
int andrew4 = 96;
int andrew5 = 90;

int emma1 = 90;
int emma2 = 85;
int emma3 = 87;
int emma4 = 98;
int emma5 = 68;

int logan1 = 90;
int logan2 = 95;
int logan3 = 87;
int logan4 = 88;
int logan5 = 96;

int sophiaSum = 0;
int andrewSum = 0;
int emmaSum = 0;
int loganSum = 0;

decimal sophiaScore;
decimal andrewScore;
decimal emmaScore;
decimal loganScore;

sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
andrewSum = andrew1 + andrew2 + andrew3 + andrew4 + andrew5;
emmaSum = emma1 + emma2 + emma3 + emma4 + emma5;
loganSum = logan1 + logan2 + logan3 + logan4 + logan5;

sophiaScore = (decimal)sophiaSum / currentAssignments;
andrewScore = (decimal)andrewSum / currentAssignments;
emmaScore = (decimal)emmaSum / currentAssignments;
loganScore = (decimal)loganSum / currentAssignments;

Console.WriteLine("Student\t\tGrade\n");
Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");
Console.WriteLine("Andrew:\t\t" + andrewScore + "\tB+");
Console.WriteLine("Emma:\t\t" + emmaScore + "\tB");
Console.WriteLine("Logan:\t\t" + loganScore + "\tA-");

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
*/
#endregion