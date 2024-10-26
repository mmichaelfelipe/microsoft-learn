// Roteiro 06   - "Depurar aplicativos de console do C# (Introdução ao C#, Parte 6)"
// Modulo 03    - "Implementar o tratamento de exceções em aplicativos de console C#"
// Unidade 02   - "Analisar as exceções e o processo de tratamento de exceções" (11min)
// https://learn.microsoft.com/pt-br/training/modules/implement-exception-handling-c-sharp/2-examine-exceptions-exception-handling-process

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

#region CT01FCS_R06M03U02


#region Palavras-chave, blocos de código e padrões do tratamento de exceções
//try
//{
//    // try code block - code that may generate an exception
//    // bloco de código try - código que pode gerar uma exceção
//}
//catch
//{
//    // catch code block - code to handle an exception
//    // bloco de código catch - código para lidar com uma exceção
//}
//finally
//{
//    // finally code block - code to clean up resources
//    // bloco de código finally - código para limpar recursos
//}
#endregion


#region Processo de tratamento de exceções
try
{
    // Step 1: code execution begins
    // Etapa 1: a execução do código começa
    try
    {
        // Step 2: an exception occurs here
        // Etapa 2: uma exceção ocorre aqui
    }
    finally
	{
        // Step 4: the system executes the finally code block associated with the try statement where the exception occurred
        // Etapa 4: o sistema executa o bloco de código finally associado à instrução try onde a exceção ocorreu
    }
}
// Step 3: the system finds a catch clause that can handle the exception
// Etapa 3: o sistema encontra uma cláusula catch que pode lidar com a exceção
catch
{
    // Step 5: the system transfers control to the first line of the catch code block
    // Etapa 5: o sistema transfere o controle para a primeira linha do bloco de código catch
}
#endregion

#endregion