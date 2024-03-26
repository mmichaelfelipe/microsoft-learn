
// Roteiro 03   - "Adicionar lógica a aplicativos de console C# (Introdução ao C#, Parte 3)"
// Modulo 01    - "Avaliar expressões boolianas para tomar decisões em C#"
// Unidade 04   - "Exercício – Concluir uma atividade de desafio usando operadores condicionais" (06min)
// https://learn.microsoft.com/pt-br/training/modules/csharp-evaluate-boolean-expressions/4-challenge-1


// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

#region CT01FCS_R03M01U04



#region Desafio de código: escrever um código para exibir o resultado de um lançamento de moeda
/* Requisitos do desafio
 * 2. Use a classe Random para gerar um valor
 *  Considerar o intervalo de números necessários.
 * 3. Com base no valor gerado, usar o operador condicional para exibir heads ou tails.
 *  As chances de que o resultado seja cara ou coroa devem ser de 50% cada.
 * 4. Seu código deve ser fácil de ler, mas ter o menor número possível de linhas.
 *  Você deve ser capaz de obter o resultado desejado em três linhas de código.
 */

#region Minha versão do desafio
var random = new Random();
int value = random.Next(1, 3);
Console.WriteLine($"O resultado do jogo é {value}: {(value == 1 ? "heads" : "tails")}");
#endregion

#region Resposta oficial
/* Interpretação da resposta oficial:
 * Percebo que a resposta oficial trouxe nomes de variaveis mais significativos,
 * em relação ao contexto do desafio e os requisitos propostos.
 */
Random coin = new Random();
int flip = coin.Next(0, 2);
Console.WriteLine((flip == 0) ? "heads" : "tails");
#endregion
#endregion



#endregion