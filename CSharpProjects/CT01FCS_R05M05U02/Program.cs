// Roteiro 05   - "Criar métodos em aplicativos de console C# (Introdução ao C#, Parte 5)"
// Modulo 05    - "Desafio de Projeto – Criar um minijogo"
// Unidade 02   - "Preparar-se para o desafio" (05min)
// https://learn.microsoft.com/pt-br/training/modules/challenge-project-create-mini-game/2-prepare

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

#region CT01FCS_R05M05U02

#region Especificacao do projeto (en-US)
/*
-The code declares the following variables:
    -Variables to determine the size of the Terminal window.
    - Variables to track the locations of the player and food.
    - Arrays `states` and `foods` to provide available player and food appearances
    - Variables to track the current player and food appearance

- The code provides the following methods:
    -A method to determine if the Terminal window was resized.
    - A method to display a random food appearance at a random location.
    - A method that changes the player appearance to match the food consumed.
    - A method that temporarily freezes the player movement.
    - A method that moves the player according to directional input.
    - A method that sets up the initial game state.

- The code doesn't call the methods correctly to make the game playable. The following features are missing:
    - Code to determine if the player has consumed the food displayed.
    - Code to determine if the food consumed should freeze player movement.
    - Code to determine if the food consumed should increase player movement.
    - Code to increase movement speed.
    - Code to redisplay the food after it's consumed by the player.
    - Code to terminate execution if an unsupported key is entered.
    - Code to terminate execution if the terminal was resized.
*/
#endregion

#region Especificacao do projeto (pt-BR)
/*
-O código declara as seguintes variáveis:
    - Variáveis ​​para determinar o tamanho da janela do Terminal.
    - Variáveis ​​para rastrear os locais do jogador e da comida.
    - Arrays `states` e `foods` para fornecer as aparências disponíveis do jogador e da comida
    - Variáveis ​​para rastrear a aparência atual do jogador e da comida

- O código fornece os seguintes métodos:
    - Um método para determinar se a janela do Terminal foi redimensionada.
    - Um método para exibir uma aparência aleatória da comida em um local aleatório.
    - Um método que altera a aparência do jogador para corresponder à comida consumida.
    - Um método que congela temporariamente o movimento do jogador.
    - Um método que move o jogador de acordo com a entrada direcional.
    - Um método que configura o estado inicial do jogo.

- O código não chama os métodos corretamente para tornar o jogo jogável. Os seguintes recursos estão faltando:
    - Código para determinar se o jogador consumiu a comida exibida.
    - Código para determinar se a comida consumida deve congelar o movimento do jogador.
    - Código para determinar se a comida consumida deve aumentar o movimento do jogador.
    - Código para aumentar a velocidade do movimento.
    - Código para reexibir a comida após ela ser consumida pelo jogador.
    - Código para encerrar a execução se uma chave não suportada for inserida.
    - Código para encerrar a execução se o terminal for redimensionado.
*/

Console.WriteLine("Hello, World!");
#endregion

#endregion