// Roteiro 03   - "Adicionar lógica a aplicativos de console C# (Introdução ao C#, Parte 3)"
// Modulo 03    - "Ramificar o fluxo de código usando o constructo de mudança de casos em C#"
// Unidade 03   - "Exercício – Concluir uma atividade de desafio usando instruções switch" (09min)
// https://learn.microsoft.com/pt-br/training/modules/csharp-switch-case/3-challenge


// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

#region CT01FCS_R03M03U03



#region Desafio de código: reescrever if-elseif-else usando uma instrução switch
#region 2. Versão Original do código
//// SKU = Stock Keeping Unit. 
//// SKU value format: <product #>-<2-letter color code>-<size code>
//string sku = "01-MN-L";

//string[] product = sku.Split('-');

//string type = "";
//string color = "";
//string size = "";

//if (product[0] == "01")
//{
//    type = "Sweat shirt";
//}
//else if (product[0] == "02")
//{
//    type = "T-Shirt";
//}
//else if (product[0] == "03")
//{
//    type = "Sweat pants";
//}
//else
//{
//    type = "Other";
//}

//if (product[1] == "BL")
//{
//    color = "Black";
//}
//else if (product[1] == "MN")
//{
//    color = "Maroon";
//}
//else
//{
//    color = "White";
//}

//if (product[2] == "S")
//{
//    size = "Small";
//}
//else if (product[2] == "M")
//{
//    size = "Medium";
//}
//else if (product[2] == "L")
//{
//    size = "Large";
//}
//else
//{
//    size = "One Size Fits All";
//}

//Console.WriteLine($"Product: {size} {color} {type}");
#endregion

#region 3. Minha versão de resposta para o desafio
/* Para esse desafio a solução foi desenvolvida utilizando Switch Expressions, introduzido na linguagem na versão 8.0 do C#
    * Transformaria ainda os elementod do SKU nos enums Type, Color e Size  para tornar o código autodocumentável.
    */
// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = string.Empty;
string color = string.Empty;
string size = string.Empty;

type = product[0] switch
{
    "01" => "Sweat shirt",
    "02" => "T-Shirt",
    "03" => "Sweat pants",
    _ => "Other"
};

color = product[1] switch
{
    "BL" => "Black",
    "MN" => "Maroon",
    _ => "White"
};

size = product[2] switch
{
    "S" => "Small",
    "M" => "Medium",
    "L" => "Large",
    _ => "One Size Fits All"
};

Console.WriteLine($"Product: {size} {color} {type}");
#endregion

#region Refatorando minha versão de resposta para o desafio
/* Código contido na classe Refactoring.cs dessa solução.
    * A ideia é a utilização de Enum para facilitar a legibilidade do mapeamento dos padrões do SKU.
    */
#endregion
#endregion

#region Resposta oficial
//// SKU = Stock Keeping Unit
//string sku = "01-MN-L";

//string[] product = sku.Split('-');

//string type = "";
//string color = "";
//string size = "";

//switch (product[0])
//{
//    case "01":
//        type = "Sweat shirt";
//        break;
//    case "02":
//        type = "T-Shirt";
//        break;
//    case "03":
//        type = "Sweat pants";
//        break;
//    default:
//        type = "Other";
//        break;
//}

//switch (product[1])
//{
//    case "BL":
//        color = "Black";
//        break;
//    case "MN":
//        color = "Maroon";
//        break;
//    default:
//        color = "White";
//        break;
//}

//switch (product[2])
//{
//    case "S":
//        size = "Small";
//        break;
//    case "M":
//        size = "Medium";
//        break;
//    case "L":
//        size = "Large";
//        break;
//    default:
//        size = "One Size Fits All";
//        break;
//}

//Console.WriteLine($"Product: {size} {color} {type}");
#endregion
#endregion