// Roteiro 03   - "Adicionar lógica a aplicativos de console C# (Introdução ao C#, Parte 3)"
// Modulo 05    - "Adicione lógica de loop a seu código usando as instruções "do-while" e "while" em C#"
// Unidade 03   - "Exercício – Concluir uma atividade de desafio usando instruções de iteração do e while" (09min)
// https://learn.microsoft.com/pt-br/training/modules/csharp-do-while/3-challenge

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

#region CT01FCS_R03M05U03


#region Desafio da batalha em RPG
/* Em algumas das funções que desempenham jogos, o personagem do jogador 
 * batalha contra personagens não controlados por outros jogadores, que 
 * geralmente são monstros ou vilões. Às vezes, uma batalha consiste em cada 
 * personagem gerar um valor aleatório jogando dados, e esse valor é subtraído dos 
 * pontos de vida do adversário. Quando a vida de um personagem chega a zero, ele perde o jogo.

 * Neste desafio, vamos reduzir essa interação à sua essência. Um herói e um monstro 
 * começam com a mesma pontuação de integridade. Durante a rodada do 
 * herói, ele gerará um valor aleatório que será subtraído da integridade do monstro. 
 * Se a integridade do monstro for maior que zero, ela terá sua rodada e atacará o 
 * herói. Desde que tanto o herói quanto o monstro tenham integridade maior que zero, 
 * a batalha continuará.
 */
#endregion

#region Desafio de código - Escrever um código para implementar as regras do jogo
/* Veja as regras para o jogo de batalha que você precisa implementar em seu projeto de código:
 * - Você deve usar a instrução do-while ou a instrução while como um loop de jogo externo
 * - O herói e o monstro começarão com dez pontos de integridade.
 * - Todos os ataques serão um valor entre 1 e 10.
 * - O herói atacará primeiro.
 * - Imprima a quantidade de integridade que o monstro perdeu e a integridade que resta a ele.
 * - Se a integridade do monstro for maior que zero, ele poderá atacar o herói.
 * - Imprima a quantidade de integridade que o herói perdeu e a integridade que resta a ele.
 * - Continue esta sequência de ataque até que a integridade do monstro ou do herói seja zero ou menos.
 * - Imprima quem foi o vencedor.
 * 
 * Não importa como você fará isso; o código deverá produzir uma saída semelhante:
 * Monster was damaged and lost 1 health and now has 9 health
 * Hero was damaged and lost 1 health and now has 9 health
 * Monster was damaged and lost 7 health and now has 2 health
 * Hero was damaged and lost 6 health and now has 3 health
 * Monster was damaged and lost 9 health and now has -7 health
 * Hero wins!
 */

#region Minha versão do desafio
//int heroLife = 10;
//int monsterLife = 10;
//bool heroWinner = false; 
//bool monsterWinner = false;

//int damage = 0;
//var randomDamage = new Random();

//do
//{
//    Console.WriteLine("[INICIANDO NOVA RODADA]");

//    // turno do heroi
//    damage = randomDamage.Next(1, 11);
//    monsterLife -= damage;
//    Console.WriteLine($"Monster was damaged and lost {damage} and now has {monsterLife} health.");
//    if (monsterLife <= 0)
//    {
//        heroWinner = true;
//        continue;
//    }

//    // turno do monstro
//    damage = randomDamage.Next(1, 11);
//    heroLife -= damage;
//    Console.WriteLine($"Hero was damaged and lost {damage} and now has {heroLife} health.");
//    if (heroLife <= 0)
//    {
//        monsterWinner = true;
//        continue;
//    }
//} while (!heroWinner && !monsterWinner);

//if (heroWinner) Console.WriteLine("Hero wins!");
//else Console.WriteLine("Monster wins!");
#endregion

#region Resposta oficial
//int hero = 10;
//int monster = 10;

//Random dice = new Random();
//do
//{
//    int roll = dice.Next(1, 11);
//    monster -= roll;
//    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

//    if (monster <= 0) continue;

//    roll = dice.Next(1, 11);
//    hero -= roll;
//    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

//} while (hero > 0 && monster > 0);

//Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");
#endregion

#region Refatorando minha versão do desafio
int heroHealth = 10;
int monsterHealth = 10;
string playerWinner;

int damage = 0;
var randomDamage = new Random();

do
{
    Console.WriteLine("[INICIANDO NOVA RODADA]");

    // turno do heroi
    damage = randomDamage.Next(1, 11);
    monsterHealth -= damage;
    Console.WriteLine($"Monster was damaged and lost {damage} and now has {monsterHealth} health.");
    if (monsterHealth <= 0)
    {
        playerWinner = "Hero";
        continue;
    }

    // turno do monstro
    damage = randomDamage.Next(1, 11);
    heroHealth -= damage;
    Console.WriteLine($"Hero was damaged and lost {damage} and now has {heroHealth} health.");
    if (heroHealth <= 0)
    {
        playerWinner = "Monster";
        continue;
    }
} while (true);

Console.WriteLine($"{playerWinner} wins!");
#endregion
#endregion


#endregion