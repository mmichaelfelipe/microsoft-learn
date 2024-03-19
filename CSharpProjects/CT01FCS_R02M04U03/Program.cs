// Roteiro 02   - "Criar e executar aplicativos de console C# simples (Introdução ao C#, Parte 2)"
// Modulo 04    - "Armazenar e iterar em sequências de dados usando Matrizes e a instrução foreach em C#"
// Unidade 03   - "Exercício – Implementar a instrução foreach" (12min)
// https://learn.microsoft.com/pt-br/training/modules/csharp-arrays/3-exercise-foreach

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

#region CT01FCS_R02M04U03



    #region Executar um loop em uma matriz usando o foreach
// string[] names = { "Rowena", "Robin", "Bao"};
// foreach (string nameTest in names) {
//     Console.WriteLine(nameTest);
// }
    #endregion


    #region Criar e inicializr uma matriz int
// int[] inventory = { 200, 450, 700, 175, 250};
    #endregion


    #region Adicionar uma instrução foreach para a iteração na matriz
// int[] inventory = { 200, 450, 700, 175, 250};

// foreach(int items in inventory) {

// }
    #endregion


    #region Adicionar uma variável para somar o valor de cada elemento da matriz
// int[] inventory = { 200, 450, 700, 175, 250};
// int sum = 0;
// foreach(int items in inventory) {
//     sum += items;
// }
    #endregion


    #region Exiba o valor final da soma
// int[] inventory = { 200, 450, 700, 175, 250};
// int sum = 0;
// foreach(int items in inventory) {
//     sum += items;
// }

// Console.WriteLine($"We have {sum} items in inventory.");
    #endregion


    #region Criar uma variável para manter o número do compartimento atual e exibir o total acumulado
int[] inventory = { 200, 450, 700, 175, 250};
int sum = 0;
int bin = 0;
foreach(int items in inventory) {
    sum += items;
    bin++;
    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
}

Console.WriteLine($"We have {sum} items in inventory.");
    #endregion



#endregion