// Roteiro 03   - "Adicionar lógica a aplicativos de console C# (Introdução ao C#, Parte 3)"
// Modulo 03    - "Ramificar o fluxo de código usando o constructo de mudança de casos em C#"
// Unidade 03   - "Exercício – Concluir uma atividade de desafio usando instruções switch" (09min)
// https://learn.microsoft.com/pt-br/training/modules/csharp-switch-case/3-challenge


// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

namespace CT01FCS_R03M03U03;

#region Refatorando minha versão de resposta para o desafio
//public class Refactoring
//{
//    public static void Main(string[] args)
//    {
//        var productInfo = new ProductInfo("01-MN-L");
//        productInfo.PrintInfo();
//    }
//}

//public enum ProductType
//{
//    SweatShirt,
//    TShirt,
//    SweatPants,
//    Other
//}

//public enum Color
//{
//    Black,
//    Maroon,
//    White
//}

//public enum Size
//{
//    Small,
//    Medium,
//    Large,
//    OneSizeFitsAll
//}

//public class ProductInfo
//{
//    public string Sku { get; }
//    public ProductType Type { get; }
//    public Color Color { get; }
//    public Size Size { get; }

//    public ProductInfo(string sku)
//    {
//        Sku = sku;
//        var parts = sku.Split('-');
//        Type = parts[0] switch
//        {
//            "01" => ProductType.SweatShirt,
//            "02" => ProductType.TShirt,
//            "03" => ProductType.SweatPants,
//            _ => ProductType.Other
//        };
//        Color = parts[1] switch
//        {
//            "BL" => Color.Black,
//            "MN" => Color.Maroon,
//            _ => Color.White
//        };
//        Size = parts[2] switch
//        {
//            "S" => Size.Small,
//            "M" => Size.Medium,
//            "L" => Size.Large,
//            _ => Size.OneSizeFitsAll
//        };
//    }

//    public void PrintInfo()
//    {
//        Console.WriteLine($"Product: {Size} {Color} {Type}");
//    }
//}
#endregion