// Roteiro 02   - "Criar e executar aplicativos de console C# simples (Introdução ao C#, Parte 2)"
// Modulo 05    - "Criar código legível com convenções, espaço em branco e comentários em C#"
// Unidade 04   - "Exercício – Usar espaços em branco para facilitar a leitura do código" (10min)
// https://learn.microsoft.com/pt-br/training/modules/csharp-readable-code/4-exercise-use-whitespace

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

#region CT01FCS_R02M05U4



    #region Adicionar código para ilustrar como o espaço em branco é ignorado pelo compilador do C#


        #region 2.
/*
// Example 1:
Console
.
WriteLine
(
"Hello Example 1!"
)
;

// Example 2:
string firstWord="Hello";string lastWord="Example 2";Console.WriteLine(firstWord+" "+lastWord+"!");
*/
        #endregion


        #region 7.
/*
Random dice = new Random();
int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);
int total = roll1 + roll2 + roll3;
Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");
if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)) {
    if ((roll1 == roll2) && (roll2 == roll3)) {
        Console.WriteLine("You rolled triples! +6 bonus to total!");
        total += 6;
    } else {
        Console.WriteLine("You rolled doubles! +2 bonus to total!");
        total += 2;
    }
}
*/
        #endregion


        #region 9.
/*
Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;
Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)) {
    if ((roll1 == roll2) && (roll2 == roll3)) {
        Console.WriteLine("You rolled triples! +6 bonus to total!");
        total += 6;
    } else {
        Console.WriteLine("You rolled doubles! +2 bonus to total!");
        total += 2;
    }
}
*/
        #endregion


        #region  10.
/*
Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;
Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)) 
{
    if ((roll1 == roll2) && (roll2 == roll3)) 
    {
        Console.WriteLine("You rolled triples! +6 bonus to total!");
        total += 6;
    } 
    else 
    {
        Console.WriteLine("You rolled doubles! +2 bonus to total!");
        total += 2;
    }
}
*/
        #endregion


    #endregion



#region CT01FCS_R02M05U3



#region Desafio: Recriando simulação dos dados

Random dice = new Random();
const int diceInitialValue = 1;
const int diceFinalValue = 6 + 1;

int[] rolls = new int[] {
        dice.Next(diceInitialValue, diceFinalValue), 
        dice.Next(diceInitialValue, diceFinalValue), 
        dice.Next(diceInitialValue, diceFinalValue)
    };

int position = 0;
foreach (int roll in rolls) 
{
    position++;
    Console.WriteLine($"Roll ({position}): {roll}.");
}

int total = rolls[0] + rolls[1] + rolls[2];
Console.WriteLine($"Dice roll: {rolls[0]} + {rolls[1]} + {rolls[2]} = {total}");

if ((rolls[0] == rolls[1]) || (rolls[1] == rolls[2]) || (rolls[0] == rolls[2])) 
{
    if ((rolls[0] == rolls[1]) && (rolls[1] == rolls[2])) 
    {
        Console.WriteLine("You rolled triples! +6 bonus to total!");
        total += 6;
    } 
    else 
    {
        Console.WriteLine("You rolled doubles! +2 bonus to total!");
        total += 2;
    }
}

#endregion