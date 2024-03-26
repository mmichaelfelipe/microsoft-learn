// Roteiro 03   - "Adicionar lógica a aplicativos de console C# (Introdução ao C#, Parte 3)"
// Modulo 01    - "Avaliar expressões boolianas para tomar decisões em C#"
// Unidade 06   - "Exercício – Concluir uma atividade de desafio usando expressões boolianas" (10min)
// https://learn.microsoft.com/pt-br/training/modules/csharp-evaluate-boolean-expressions/6-challenge-2


// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

#region CT01FCS_R03M01U06



#region Desafio da lógica de decisão
#region Inicializar valores de permissão e nível
#region Minha versão do desafio
string permision = "Admin|Manager";
int level = 55;

// Se o usuário for um administrador com um nível maior que 55, exiba a mensagem:
string regraNegocioOutput1 = "Welcome, Super Admin user";
// Se o usuário for um administrador com um nível menor ou igual a 55, exiba a mensagem:
string regraNegocioOutput2 = "Welcome, Admin user.";
// Se o usuário for um gerente com um nível maior ou igual a 20, exiba a mensagem:
string regraNegocioOutput3 = "Contact an Admin for access.";
// Se o usuário for um gerente com um nível menor que 20, exiba a mensagem
string regraNegocioOutput4 = "You do not have sufficient privileges";
// Se o usuário não for um administrador nem um gerente, exiba a mensagem:
string regraNegocioOutput5 = "You do not have sufficient privileges";

if (permision.Contains("Admin") && level > 55)
    Console.WriteLine(regraNegocioOutput1);
else if (permision.Contains("Admin") && level <= 55)
    Console.WriteLine(regraNegocioOutput2);
else if (permision.Contains("Manager") && level >= 20)
    Console.WriteLine(regraNegocioOutput3);
else if (permision.Contains("Manager") && level <= 20)
    Console.WriteLine(regraNegocioOutput4);
else if (!permision.Contains("Admin") && !permision.Contains("Manager"))
    Console.WriteLine(regraNegocioOutput5);
#endregion

#region Resposta oficial
/* Interpretação da resposta oficial:
 * Percebo que nesse desafio proposto, o código desenvolvido por mim
 * ao mesmo tempo que ficou mais enxuto também manteve a legibilidade
 * tanto em relação aos outputs quanto as validações de regras de negócio
 */
//string permission = "Admin|Manager";
//int level = 53;

//if (permission.Contains("Admin"))
//{
//    if (level > 55)
//    {
//        Console.WriteLine("Welcome, Super Admin user.");
//    }
//    else
//    {
//        Console.WriteLine("Welcome, Admin user.");
//    }
//}
//else if (permission.Contains("Manager"))
//{
//    if (level >= 20)
//    {
//        Console.WriteLine("Contact an Admin for access.");
//    }
//    else
//    {
//        Console.WriteLine("You do not have sufficient privileges.");
//    }
//}
//else
//{
//    Console.WriteLine("You do not have sufficient privileges.");
//}
#endregion
#endregion
#endregion



#endregion