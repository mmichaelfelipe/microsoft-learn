// Roteiro 05   - "Criar métodos em aplicativos de console C# (Introdução ao C#, Parte 5)"
// Modulo 03    - "Criar métodos C# que retornem valores"
// Unidade 06   - "Exercício – Retornar matrizes de métodos" (10min)
// https://learn.microsoft.com/pt-br/training/modules/create-c-sharp-methods-return-values/6-exercise-create-methods-return-arrays

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

#region CT01FCS_R05M03U06


#region Localizar moedas para fazer alterações
#region 2., 3., 4., 5.
//int[] TwoCoins(int[] coins, int target)
//{
//    for (int curr = 0; curr < coins.Length; curr++)
//    {
//        for (int next = curr + 1; next < coins.Length; next++)
//        {
//            if (coins[curr] + coins[next] == target)
//            {
//                return new int[] { curr, next };
//            }
//        }
//    }

//    //return Array.Empty<int>(); // Best pratice
//    return new int[0];
//}
#endregion
#endregion

#region Testar sua solução
#region 1., 2.
//int target = 60;
//int[] coins = new int[] { 5, 5, 50, 25, 25, 10, 5 };
//int[] result = TwoCoins(coins, target);

//if (result.Length == 0)
//{
//    Console.WriteLine("No two coins make change");
//}
//else
//{
//    Console.WriteLine($"Change found at positions {result[0]} and {result[1]}");
//}

//int[] TwoCoins(int[] coins, int target)
//{
//    for (int curr = 0; curr < coins.Length; curr++)
//    {
//        for (int next = curr + 1; next < coins.Length; next++)
//        {
//            if (coins[curr] + coins[next] == target)
//            {
//                return new int[] { curr, next };
//            }
//        }
//    }

//    //return Array.Empty<int>(); // Best pratice
//    return new int[0];
//}
#endregion
#endregion

#region Localizar vários pares de moedas que dão troco
#region 1., 2., 3., 4., 5., 6.
//int target = 60;
//int[] coins = new int[] { 5, 5, 50, 25, 25, 10, 5 };
//int[] result = TwoCoins(coins, target);

//if (result.Length == 0)
//{
//    Console.WriteLine("No two coins make change");
//}
//else
//{
//    Console.WriteLine($"Change found at positions {result[0]} and {result[1]}");
//}

//int[,] TwoCoins(int[] coins, int target)
//{
//    int[,] result = { { -1, -1 }, { -1, -1 }, { -1, -1 }, { -1, -1 }, { -1, -1 } };
//    int count = 0;

//    for (int curr = 0; curr < coins.Length; curr++)
//    {
//        for (int next = curr + 1; next < coins.Length; next++)
//        {
//            if (coins[curr] + coins[next] == target)
//            {
//                result[count, 0] = curr;
//                result[count, 1] = next;
//                count++;
//            }
//            if(count == result.GetLength(0))
//            {
//                return result;
//            }
//        }
//    }

//    return (count == 0) ? new int[0, 0] : result;
//}
#endregion
#endregion

#region Capturar a nova matriz de retorno
#region 1., 2.
int target = 30;
int[] coins = new int[] { 5, 5, 50, 25, 25, 10, 5 };
int[,] result = TwoCoins(coins, target);

if (result.Length == 0)
{
    Console.WriteLine("No two coins make change");
}
else
{
    Console.WriteLine($"Change found at positions:");
    for (int i = 0; i < result.GetLength(0); i++)
    {
        if (result[i, 0] == -1)
        {
            break;
        }
        Console.WriteLine($"{result[i, 0]},{result[i, 1]}");
    }
}

int[,] TwoCoins(int[] coins, int target)
{
    int[,] result = { { -1, -1 }, { -1, -1 }, { -1, -1 }, { -1, -1 }, { -1, -1 } };
    int count = 0;

    for (int curr = 0; curr < coins.Length; curr++)
    {
        for (int next = curr + 1; next < coins.Length; next++)
        {
            if (coins[curr] + coins[next] == target)
            {
                result[count, 0] = curr;
                result[count, 1] = next;
                count++;
            }
            if (count == result.GetLength(0))
            {
                return result;
            }
        }
    }

    return (count == 0) ? new int[0, 0] : result;
}
#endregion
#endregion

#endregion