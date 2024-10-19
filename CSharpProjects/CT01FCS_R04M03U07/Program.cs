// Roteiro 04   - "Trabalhar com os dados variáveis em aplicativos de console C# (Introdução ao C#, Parte 4)"
// Modulo 03    - "Executar operações em matrizes usando métodos auxiliares em C#"
// Unidade 07   - "Exercício – Concluir um desafio em que é preciso analisar uma cadeia de caracteres de pedidos, classificá-los e marcar possíveis erros" (05min)
// https://learn.microsoft.com/pt-br/training/modules/csharp-arrays-operations/7-challenge-2

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

#region CT01FCS_R04M03U07


#region 2.
//string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
#endregion

#region 4. Adicione o código abaixo do código anterior para analisar as "IDs de pedido" do de pedidos de entrada string e armazenar as "IDs do pedido" em uma matriz
//string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
//string[] ordersStreamArray = orderStream.Split(',');
#endregion

#region 5.Adicione o código para gerar cada "ID do pedido" na ordem classificada e marque os pedidos que não tiverem exatamente quatro caracteres como "- Erro"
string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] ordersStreamArray = orderStream.Split(',');
Array.Sort(ordersStreamArray);

foreach (var order in ordersStreamArray)
{
    if (order.Length == 4)
        Console.WriteLine(order);
    else
        Console.WriteLine($"{order} - Erro");
}
#endregion

#region resultado sugerido (Unidade 08)
//string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
//string[] items = orderStream.Split(',');
//Array.Sort(items);

//foreach (var item in items)
//{
//    if (item.Length == 4)
//    {
//        Console.WriteLine(item);
//    }
//    else
//    {
//        Console.WriteLine(item + "\t- Error");
//    }
//}
#endregion

#endregion