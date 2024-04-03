// Roteiro 03   - "Adicionar lógica a aplicativos de console C# (Introdução ao C#, Parte 3)"
// Modulo 03    - "Ramificar o fluxo de código usando o constructo de mudança de casos em C#"
// Unidade 02   - "Exercício – Implementar uma instrução switch" (11min)
// https://learn.microsoft.com/pt-br/training/modules/csharp-switch-case/2-exercise-switch-case


// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

#region CT01FCS_R03M03U02



#region Criar e testar uma instrução switch
//int employeeLevel = 200;
//string employeeName = "John Smith";

//string title = "";

//switch (employeeLevel)
//{
//    case 100:
//        title = "Junior Associate";
//        break;
//    case 200:
//        title = "Senior Associate";
//        break;
//    case 300:
//        title = "Manager";
//        break;
//    case 400:
//        title = "Senior Manager";
//        break;
//    default:
//        title = "Associate";
//        break;

//}

//Console.WriteLine($"{employeeName}, {title}");
#endregion


#region Altere o valor da variável de nível para ver como a instrução switch a avalia
//int employeeLevel = 201;
//string employeeName = "John Smith";

//string title = "";

//switch (employeeLevel)
//{
//    case 100:
//        title = "Junior Associate";
//        break;
//    case 200:
//        title = "Senior Associate";
//        break;
//    case 300:
//        title = "Manager";
//        break;
//    case 400:
//        title = "Senior Manager";
//        break;
//    default:
//        title = "Associate";
//        break;

//}

//Console.WriteLine($"{employeeName}, {title}");
#endregion


#region Modificar uma seção switch para incluir vários rótulos
//int employeeLevel = 101;
//string employeeName = "John Smith";

//string title = "";

//switch (employeeLevel)
//{
//    /* Outro abordagem aplicando a regra na mesma linha com uma condicional composta:
//     * case 100 or 200:
//     *      title = "Senior Associate";
//     *      break;
//     */
//    case 100:
//    case 200:
//        title = "Senior Associate";
//        break;
//    case 300:
//        title = "Manager";
//        break;
//    case 400:
//        title = "Senior Manager";
//        break;
//    default:
//        title = "Associate";
//        break;

//}

//Console.WriteLine($"{employeeName}, {title}");
#endregion


#region Minha versão refatorando o código
/* Transformaria ainda o title em um enum JobTitle para tornar o código autodocumentável.
    public enum JobTitle {
        Junior Associate,
        Senior Associate,
        Manager,
        Senior Manager
        Associate
    }
 */

int employeeLevel = 200;
string employeeName = "Jeff Bezos";
string title = string.Empty;

    title = employeeLevel switch
{
    100 or 200 => "Senior Associate",
    300 => "Manager",
    400 => "Senior Manager",
    _ => "Associate"
};

Console.WriteLine($"{employeeName}, {employeeLevel}, {title}");
#endregion



#endregion