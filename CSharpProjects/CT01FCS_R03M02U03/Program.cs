// Roteiro 03   - "Adicionar lógica a aplicativos de console C# (Introdução ao C#, Parte 3)"
// Modulo 02    - "Controlar o escopo da variável e a lógica usando blocos de código em C#"
// Unidade 03   - "Exercício – Remover blocos de código de instruções if" (06min)
// https://learn.microsoft.com/pt-br/training/modules/csharp-code-blocks/3-exercise-remove-if-statements


// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

#region CT01FCS_R03M02U03



#region Criar um exemplo de instrução if que usa um bloco de código
//bool flag = true;
//if (flag)
//{
//    Console.WriteLine(flag);
//}
#endregion

#region Remover as chaves
//bool flag = true;
//if (flag)
//    Console.WriteLine(flag);
#endregion

#region Examinar a legibilidade de instruções if com apenas uma linha
#region 1.
//bool flag = true;
//if (flag) Console.WriteLine(flag);
#endregion
#region 5.
//string name = "steve";
//if (name == "bob") Console.WriteLine("Found Bob");
//else if (name == "steve") Console.WriteLine("Found Steve");
//else Console.WriteLine("Found Chucl");
#endregion
#region 7.
string name = "steve";

if (name == "bob")
    Console.WriteLine("Found Bob");
else if (name == "steve")
    Console.WriteLine("Found Steve");
else
    Console.WriteLine("Found Chuck");
#endregion
#endregion



#endregion