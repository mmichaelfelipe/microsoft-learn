// Roteiro 02   - "Criar e executar aplicativos de console C# simples (Introdução ao C#, Parte 2)"
// Modulo 04    - "Armazenar e iterar em sequências de dados usando Matrizes e a instrução foreach em C#"
// Unidade 04   - "Exercício – Concluir uma atividade de desafio que usa instruções de seleção e iteração aninhada" (09min)
// https://learn.microsoft.com/pt-br/training/modules/csharp-arrays/4-challenge

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

#region CT01FCS_R02M04U04



    #region Desafio de codificação – Reportar as IDs de pedido que precisam de uma investigação mais aprofundada
string[] idPedidos = {"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};

foreach (string idPedido in idPedidos) {
    if(idPedido.StartsWith("B"))
        Console.WriteLine(idPedido);
}
    #endregion


    #region Solução do desafio
/*
string[] orderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

foreach (string orderID in orderIDs)
{
    if (orderID.StartsWith("B"))
    {
        Console.WriteLine(orderID);
    }
}
*/
    #endregion



#endregion