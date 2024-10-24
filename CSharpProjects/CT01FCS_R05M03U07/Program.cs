// Roteiro 05   - "Criar métodos em aplicativos de console C# (Introdução ao C#, Parte 5)"
// Modulo 03    - "Criar métodos C# que retornem valores"
// Unidade 07   - "Exercício – Concluir o desafio de adicionar métodos para tornar o jogo viável" (10min)
// https://learn.microsoft.com/pt-br/training/modules/create-c-sharp-methods-return-values/7-exercise-challenge-dice-game

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

#region CT01FCS_R05M03U07


#region Desafio de código: adicionar métodos para tornar o jogo viável
#region 2.
//Random random = new Random();

//Console.WriteLine("Would you like to play? (Y/N)");
//if (ShouldPlay())
//{
//    PlayGame();
//}

//void PlayGame()
//{
//    var play = true;

//    while (play)
//    {
//        var target;
//        var roll;

//        Console.WriteLine($"Roll a number greater than {target} to win!");
//        Console.WriteLine($"You rolled a {roll}");
//        Console.WriteLine(WinOrLose());
//        Console.WriteLine("\nPlay again? (Y/N)");

//        play = ShouldPlay();
//    }
//}
#endregion
#endregion

#region Resposta do desafio
Random random = new Random();

Console.WriteLine("Would you like to play? (Y/N)");
if (ShouldPlay())
{
    PlayGame();
}

bool ShouldPlay()
{
    string response = Console.ReadLine();
    return response.ToLower().Equals("y");
}

void PlayGame()
{
    var play = true;

    while (play)
    {
        var target = GetTarget();
        var roll = RollDice();

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(roll, target));
        Console.WriteLine("\nPlay again? (Y/N)");

        play = ShouldPlay();
    }
}

int GetTarget()
{
    return random.Next(1, 6);
}

int RollDice()
{
    return random.Next(1, 7);
}

string WinOrLose(int roll, int target)
{
    if (roll > target)
    {
        return "You win!";
    }
    return "You lose!";
}
#endregion

#endregion