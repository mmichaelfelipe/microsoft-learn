// Roteiro 05   - "Criar métodos em aplicativos de console C# (Introdução ao C#, Parte 5)"
// Modulo 02    - "Criar métodos C# com parâmetros"
// Unidade 06   - "Exercício – Concluir o desafio de exibir endereços de email" (10min)
// https://learn.microsoft.com/pt-br/training/modules/create-c-sharp-methods-parameters/6-exercise-challenge-email-addresses

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

#region CT01FCS_R05M02U06


#region Desafio de código: adicionar um método para exibir endereços de email
#region 2.
//string[,] corporate =
//{
//    {"Robert", "Bavin"},
//    {"Simon", "Bright"},
//    {"Kim", "Sinclair"},
//    {"Aashrita", "Kamath"},
//    {"Sarah", "Delucchi"},
//    {"Sinan", "Ali"}
//};

//string[,] external =
//{
//    {"Vinnie", "Ashton"},
//    {"Cody", "Dysart"},
//    {"Shay", "Lawrence"},
//    {"Daren", "Valdes"}
//};

//string externalDomain = "hayworth.com";

//for (int i = 0; i < corporate.GetLength(0); i++)
//{
//    // display internal email addresses
//}

//for (int i = 0; i < external.GetLength(0); i++)
//{
//    // display external email addresses
//}
#endregion
#endregion

#region Minha solução para o desafio
string[,] corporate =
{
    {"Robert", "Bavin"},
    {"Simon", "Bright"},
    {"Kim", "Sinclair"},
    {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"},
    {"Sinan", "Ali"}
};

string[,] external =
{
    {"Vinnie", "Ashton"},
    {"Cody", "Dysart"},
    {"Shay", "Lawrence"},
    {"Daren", "Valdes"}
};

const string internalDomain = "contoso.com";
const string externalDomain = "hayworth.com";

for (int i = 0; i < corporate.GetLength(0); i++)
{
    // display internal email addresses
    //DisplayEmail(corporate[i, 0], corporate[i, 1]);
    DisplayEmail(firstName: corporate[i, 0], lastName: corporate[i, 1]);
}

for (int i = 0; i < external.GetLength(0); i++)
{
    // display external email addresses
    //DisplayEmail(external[i, 0], external[ilastName 1], externalDomain);
    DisplayEmail(firstName: external[i, 0], lastName: external[i, 1], domain: externalDomain);
}

void DisplayEmail(string firstName, string lastName, string domain = internalDomain)
{
    string email =  $"{firstName.Substring(0, 2).ToLower()}" +
                    $"{lastName.ToLower()}" +
                    $"@" + $"{domain}";
    Console.WriteLine(email);
}
#endregion

#endregion