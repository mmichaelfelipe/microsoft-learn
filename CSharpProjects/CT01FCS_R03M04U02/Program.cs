// Roteiro 03   - "Adicionar lógica a aplicativos de console C# (Introdução ao C#, Parte 3)"
// Modulo 04    - "Iterar por meio de um bloco de código usando a instrução for em C#"
// Unidade 02   - "Exercício – Criar e configurar loops de iteração" (14min)
// https://learn.microsoft.com/pt-br/training/modules/csharp-for/2-exercise-for

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

#region CT01FCS_R03M04U02



#region Qual é a instrução for?
#region Escrever uma instrução for básica
//// int i = 0;       Inicializador (do iterador)
//// i < 10;          Condição (de conclusão)
//// i++              Iterador (ação após cada iteração)
//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine(i);
//}
#endregion

#region Alterar as condições da iteração
//for (int i = 10; i >= 0; i--)
//{
//    Console.WriteLine(i);
//}
#endregion

#region Faça experimentos com o padrão do iterador
//for (int i = 0; i < 10; i += 3)
//{
//    Console.WriteLine(i);
//}
#endregion

#region Usar a palavra-chave break para interromper a instrução de iteração
//// o break pode ser usado para quando você encontra o que você precisa em um conjunto de dados e não precisa mais iterar novamente
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
    if (i == 7) break;
}
#endregion

#region Percorrer cada elemento de uma matriz
//// o for convencional proporciona um controle mais personalizado sobre a forma e as regras de iteração em relação ao foreach
//string[] names = ["Alex", "Eddie", "David", "Michael"];

////for (int i = 0; i < names.Length; i++)    // de inicio para o fim
//for (int i = names.Length - 1; i >= 0; i--) // do fim para o inicio
//{
//    Console.WriteLine(names[i]);
//}

//// Teste do mesmo funcionamento com foreach
//List<string> namesList = ["Alex", "Eddie", "David", "Michael"];
//foreach (string name in namesList.ToArray().Reverse())
//{
//    Console.WriteLine(name);
//}
#endregion

#region Examinar as limitações da instrução foreach
//string[] names = ["Alex", "Eddie", "David", "Michael"];

//foreach (var name in names)
//{
//    // Can't do this:
//    if (name == "David") name = "Sammy";
//}
#endregion

#region Como superar a limitação da instrução foreach usando a instrução for
//string[] names = ["Alex", "Eddie", "David", "Michael"];
//for (int i = 0; i < names.Length; i++)
//    if (names[i] == "David") names[i] = "Sammy";

//foreach (var name in names) Console.WriteLine(name);

//// Refatorando codigo com visualização melhor
//string[] names = ["Alex", "Eddie", "David", "Michael"];

//for (int i = 0; i < names.Length; i++)
//    if (names[i] == "David")
//        names[i] = "Sammy";

//foreach (var name in names) 
//    Console.WriteLine(name);
#endregion
#endregion



#endregion