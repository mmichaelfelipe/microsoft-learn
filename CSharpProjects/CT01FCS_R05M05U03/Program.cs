// Roteiro 05   - "Criar métodos em aplicativos de console C# (Introdução ao C#, Parte 5)"
// Modulo 05    - "Desafio de Projeto – Criar um minijogo"
// Unidade 03   - "Exercício – Adicionar código para encerrar o jogo" (10min)
// https://learn.microsoft.com/pt-br/training/modules/challenge-project-create-mini-game/3-exercise-add-code-to-end-game

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

#region CT01FCS_R05M05U03

#region Before
//using System;

//Random random = new Random();
//Console.CursorVisible = false;
//int height = Console.WindowHeight - 1;
//int width = Console.WindowWidth - 5;
//bool shouldExit = false;

//// Console position of the player
//// Posição do console do jogador
//int playerX = 0;
//int playerY = 0;

//// Console position of the food
//// Posição do console da comida
//int foodX = 0;
//int foodY = 0;

//// Available player and food strings
//// Jogador disponível e cordas de comida
//string[] states = { "('-')", "(^-^)", "(X_X)" };
//string[] foods = { "@@@@@", "$$$$$", "#####" };

//// Current player string displayed in the Console
//// Sequência de caracteres do jogador atual exibida no console
//string player = states[0];

//// Index of the current food
//// Índice da alimentação atual
//int food = 0;

//InitializeGame();
//while (!shouldExit)
//{
//    Move();
//}

//// Returns true if the Terminal was resized 
//// Retorna verdadeiro se o Terminal foi redimensionado
//bool TerminalResized()
//{
//    return height != Console.WindowHeight - 1 || width != Console.WindowWidth - 5;
//}

//// Displays random food at a random location
//// Exibe comida aleatória em um local aleatório
//void ShowFood()
//{
//    // Update food to a random index
//    // Atualizar comida para um índice aleatório
//    food = random.Next(0, foods.Length);

//    // Update food position to a random location
//    // Atualiza a posição da comida para um local aleatório
//    foodX = random.Next(0, width - player.Length);
//    foodY = random.Next(0, height - 1);

//    // Display the food at the location
//    // Exibir a comida no local
//    Console.SetCursorPosition(foodX, foodY);
//    Console.Write(foods[food]);
//}

//// Changes the player to match the food consumed
//// Altera o player para corresponder à comida consumida
//void ChangePlayer()
//{
//    player = states[food];
//    Console.SetCursorPosition(playerX, playerY);
//    Console.Write(player);
//}

//// Temporarily stops the player from moving
//// Temporarily stops the player from moving
//void FreezePlayer()
//{
//    System.Threading.Thread.Sleep(1000);
//    player = states[0];
//}

//// Reads directional input from the Console and moves the player
//// Lê a entrada direcional do console e move o jogador
//void Move()
//{
//    int lastX = playerX;
//    int lastY = playerY;

//    switch (Console.ReadKey(true).Key)
//    {
//        case ConsoleKey.UpArrow:
//            playerY--;
//            break;
//        case ConsoleKey.DownArrow:
//            playerY++;
//            break;
//        case ConsoleKey.LeftArrow:
//            playerX--;
//            break;
//        case ConsoleKey.RightArrow:
//            playerX++;
//            break;
//        case ConsoleKey.Escape:
//            shouldExit = true;
//            break;
//    }

//    // Clear the characters at the previous position
//    // Limpa os caracteres na posição anterior
//    Console.SetCursorPosition(lastX, lastY);
//    for (int i = 0; i < player.Length; i++)
//    {
//        Console.Write(" ");
//    }

//    // Keep player position within the bounds of the Terminal window
//    // Mantenha a posição do jogador dentro dos limites da janela do Terminal
//    playerX = (playerX < 0) ? 0 : (playerX >= width ? width : playerX);
//    playerY = (playerY < 0) ? 0 : (playerY >= height ? height : playerY);

//    // Draw the player at the new location
//    // Desenhe o jogador no novo local
//    Console.SetCursorPosition(playerX, playerY);
//    Console.Write(player);
//}

//// Clears the console, displays the food and player
//// Limpa o console, exibe a comida e o jogador
//void InitializeGame()
//{
//    Console.Clear();
//    ShowFood();
//    Console.SetCursorPosition(0, 0);
//    Console.Write(player);
//}
#endregion

#region After (TODO)
Console.WriteLine("Hello, World!");
#endregion
#endregion