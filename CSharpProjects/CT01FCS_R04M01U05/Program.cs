// Roteiro 04   - "Trabalhar com os dados variáveis em aplicativos de console C# (Introdução ao C#, Parte 4)"
// Modulo 01    - "Escolher o tipo de dados correto em seu código C#"
// Unidade 05   - "Exercício – Descobrir tipos de referência" (08min)
// https://learn.microsoft.com/pt-br/training/modules/csharp-choose-data-type/5-exercise-reference-types

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

#region CT01FCS_R04M01U05



#region Como os tipos de referência são diferentes dos tipos de valor
/*
Uma variável de tipo de valor armazena os próprios valores diretamente em uma área de armazenamento chamada pilha. 
A pilha é a memória alocada ao código que está em execução, no momento, 
na CPU (também conhecida como o registro de ativação ou quadro de ativação). 
Quando a execução do registro de ativação for concluída, os valores na pilha serão removidos.

Uma variável de tipo de referência armazena os próprios valores em uma região de memória separada chamada heap. 
O heap é uma área de memória compartilhada entre muitos aplicativos em execução no sistema operacional ao mesmo tempo. 
O Tempo de Execução do .NET comunica-se com o sistema operacional para determinar quais endereços de memória estão disponíveis 
e solicita um endereço em que ele possa armazenar o valor. O runtime do .NET armazena o valor e, em seguida, retorna o endereço de memória à variável. 
Quando o código usa a variável, o Tempo de Execução do .NET pesquisa sem interrupção o endereço armazenado na variável e recupera o valor que está armazenado lá.
*/
#endregion


#region Definir uma variável de tipo de referência
#region 2.
//int[] data;
#endregion

#region 3. Criar uma instância da matriz int usando a palavra-chave new
//int[] data;
//data = new int[3];
#endregion

#region 4. Modificar o exemplo de código para executar as duas operações em uma única linha de código
// int[] data = new int[3];
#endregion

#region O que há de diferente no tipo de dados de cadeia de caracteres em C#?
string shortenedString = "Hello World!";
Console.WriteLine(shortenedString);
#endregion
#endregion

#endregion