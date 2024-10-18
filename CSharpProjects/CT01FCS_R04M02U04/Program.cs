// Roteiro 04   - "Trabalhar com os dados variáveis em aplicativos de console C# (Introdução ao C#, Parte 4)"
// Modulo 02    - "Converter tipos de dados usando técnicas de conversão cast em C#"
// Unidade 04   - "Exercício – Concluir um desafio em que é preciso combinar valores de matriz de cadeia de caracteres como cadeias de caracteres e inteiros" (06min)
// https://learn.microsoft.com/pt-br/training/modules/csharp-convert-cast/4-challenge

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System.Globalization;
CultureInfo.CurrentCulture = new CultureInfo("en-US");

#region CT01FCS_R04M02U04


#region 2.
//string[] values = { "12.3", "45", "ABC", "11", "DEF" };
#endregion

#region 3. Crie uma estrutura de loop a ser usada na iteração por cada valor de cadeia de caracteres na matriz values.
//string[] values = { "12.3", "45", "ABC", "11", "DEF" };
//foreach (string value in values)
//{
    
//}
#endregion

#region 4. 
/*
Conclua o código necessário, colocando-o dentro do bloco de código da estrutura de loop da matriz. É necessário implementar as seguintes regras de negócio na lógica do código:

Regra 1: Se o valor for alfabético, concatene-o para formar uma mensagem.
Regra 2: se o valor for numérico, adicione-o ao total.
Regra 3: o resultado deve corresponder à seguinte saída:

Output:
Message: ABCDEF
Total: 68.3
*/
string[] values = { "12.3", "45", "ABC", "11", "DEF" };
string message = string.Empty;
decimal total = 0;

foreach (string value in values)
{
    if (value.All(char.IsLetter))
        message = message + value;

    if(decimal.TryParse(value, out decimal valueOut))
        total += valueOut;
}

Console.WriteLine($"Message: {message}");
Console.WriteLine($"Total: {total}");
#endregion
#endregion