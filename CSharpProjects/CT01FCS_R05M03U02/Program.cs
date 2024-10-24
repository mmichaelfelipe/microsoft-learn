// Roteiro 05   - "Criar métodos em aplicativos de console C# (Introdução ao C#, Parte 5)"
// Modulo 03    - "Criar métodos C# que retornem valores"
// Unidade 02   - "Exercício – Entender a sintaxe do tipo de retorno" (03min)
// https://learn.microsoft.com/pt-br/training/modules/create-c-sharp-methods-return-values/2-exercise-understand-return-type-syntax

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

#region CT01FCS_R05M03U02


#region Usar métodos para calcular o preço total de compra
#region 1.
//double total = 0;
//double minimumSpend = 30.00;

//double[] items = { 15.97, 3.50, 12.25, 22.99, 10.98 };
//double[] discounts = { 0.30, 0.00, 0.10, 0.20, 0.50 };

//Console.WriteLine($"Total: ${total}");

//void GetDiscountedPrice(int itemIndex)
//{
//    // Calculate the discounted price of the item
//}

//void TotalMeetsMinimum()
//{
//    // Check if the total meets the minimum
//}

//void FormatDecimal(double input)
//{
//    // Format the double so only 2 decimal places are displayed
//}
#endregion

#region 2., 3., 4., 5., 6.
//double total = 0;
//double minimumSpend = 30.00;

//double[] items = { 15.97, 3.50, 12.25, 22.99, 10.98 };
//double[] discounts = { 0.30, 0.00, 0.10, 0.20, 0.50 };

//Console.WriteLine($"Total: ${total}");

//double GetDiscountedPrice(int itemIndex)
//{
//    // Calculate the discounted price of the item
//    // Calcular o preço com desconto do item
//    return items[itemIndex] * (1 - discounts[itemIndex]);
//}

//bool TotalMeetsMinimum()
//{
//    // Check if the total meets the minimum
//    // Verifique se o total atende ao mínimo
//    return total >= minimumSpend;
//}

//string FormatDecimal(double input)
//{
//    // Format the double so only 2 decimal places are displayed
//    // Formate o double para que apenas 2 casas decimais sejam exibidas
//    return input.ToString().Substring(0, 5);
//}
#endregion
#endregion

#region Capturar valores retornados
#region 1., 2., 3., 4.
double total = 0;
double minimumSpend = 30.00;

double[] items = { 15.97, 3.50, 12.25, 22.99, 10.98 };
double[] discounts = { 0.30, 0.00, 0.10, 0.20, 0.50 };

for (int i = 0; i < items.Length; i++)
{
    total += GetDiscountedPrice(i);
}

if(TotalMeetsMinimum())
{
    total -= 5.00;
}

//Console.WriteLine($"Total: ${total}");
Console.WriteLine($"Total: ${FormatDecimal(total)}");

double GetDiscountedPrice(int itemIndex)
{
    // Calculate the discounted price of the item
    // Calcular o preço com desconto do item
    return items[itemIndex] * (1 - discounts[itemIndex]);
}

bool TotalMeetsMinimum()
{
    // Check if the total meets the minimum
    // Verifique se o total atende ao mínimo
    return total >= minimumSpend;
}

string FormatDecimal(double input)
{
    // Format the double so only 2 decimal places are displayed
    // Formate o double para que apenas 2 casas decimais sejam exibidas
    return input.ToString().Substring(0, 5);
}
#endregion
#endregion

#endregion