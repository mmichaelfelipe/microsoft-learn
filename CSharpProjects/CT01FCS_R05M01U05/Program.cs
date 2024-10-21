// Roteiro 05   - "Criar métodos em aplicativos de console C# (Introdução ao C#, Parte 5)"
// Modulo 01    - "Escrever seu primeiro método C#"
// Unidade 05   - "Exercício – Compilar código com métodos" (10min)
// https://learn.microsoft.com/pt-br/training/modules/write-first-c-sharp-method/5-exercise-build-code-with-methods

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

#region CT01FCS_R01M01U05

#region Dividir o problema
#region 2.
/*
if ipAddress consists of 4 numbers
and
if each ipAddress number has no leading zeroes
and
if each ipAddress number is in range 0 - 255

then ipAddress is valid

else ipAddress is invalid
*/

/*
if ipAddress consiste em 4 números
and
if cada número ipAddress não tem zeros à esquerda
and
if cada número ipAddress está no intervalo de 0 a 255

then ipAddress é válido

else ipAddress é inválido
*/
#endregion

#region 3., 4.
///*
//if ipAddress consists of 4 numbers
//and
//if each ipAddress number has no leading zeroes
//and
//if each ipAddress number is in range 0 - 255

//then ipAddress is valid

//else ipAddress is invalid
//*/

///*
//if ipAddress consiste em 4 números
//and
//if cada número ipAddress não tem zeros à esquerda
//and
//if cada número ipAddress está no intervalo de 0 a 255

//then ipAddress é válido

//else ipAddress é inválido
//*/

//if (ValidateLength() && ValidateZeroes() && ValidateRange())
//{
//    Console.WriteLine($"ip is a valid IPv4 address");
//}
//else
//{
//    Console.WriteLine($"ip is a invalid IPv4 address");
//}

//void ValidateLength() {}
//void ValidateZeroes() {}
//void ValidateRange() {}
#endregion
#endregion

#region Desenvolver sua solução
#region 1., 2., 3., 4., 5., 6., 7.
/*
if ipAddress consists of 4 numbers
and
if each ipAddress number has no leading zeroes
and
if each ipAddress number is in range 0 - 255

then ipAddress is valid

else ipAddress is invalid
*/

/*
if ipAddress consiste em 4 números
and
if cada número ipAddress não tem zeros à esquerda
and
if cada número ipAddress está no intervalo de 0 a 255

then ipAddress é válido

else ipAddress é inválido
*/

//string ipv4Input = "107.31.1.5";
//bool validLength = false;
//bool validZeroes = false;
//bool validRange = false;

//ValidateLength();
//ValidateZeroes();
//ValidateRange();

//if (validLength && validZeroes && validRange)
//{
//    Console.WriteLine($"{ip} is a valid IPv4 address");
//}
//else
//{
//    Console.WriteLine($"{ip} is an invalid IPv4 address");
//}

//void ValidateLength()
//{
//    string[] adress = ipv4Input.Split('.');
//    validLength = adress.Length == 4;
//}
//void ValidateZeroes() 
//{
//    string[] adress = ipv4Input.Split('.');

//    foreach (string number in adress)
//    {
//        if (number.Length > 1 && number.StartsWith("0"))
//        {
//            validZeroes = false;
//            return;
//        }
//    }

//    validZeroes = true;
//}

//void ValidateRange() 
//{
//    string[] adress = ipv4Input.Split(".", StringSplitOptions.RemoveEmptyEntries);

//    foreach (string number in adress)
//    {
//        int value = int.Parse(number);
//        if (value < 0 || value > 255)
//        {
//            validRange = false;
//            return;
//        }
//    }

//    validRange = true;
//}
#endregion
#endregion

#region Concluir sua solução
#region 1., 2., 3., 4., 5., 6.
string[] ipv4Input = {"107.31.1.5", "255.0.0.255", "555..0.555", "255...255"};
string[] adress;
bool validLength = false;
bool validZeroes = false;
bool validRange = false;

foreach (string ip in ipv4Input)
{
    adress = ip.Split(".", StringSplitOptions.RemoveEmptyEntries);

    ValidateLength();
    ValidateZeroes();
    ValidateRange();

    if (validLength && validZeroes && validRange)
    {
        Console.WriteLine($"{ip} is a valid IPv4 address");
    }
    else
    {
        Console.WriteLine($"{ip} is an invalid IPv4 address");
    }
}

void ValidateLength()
{
    validLength = adress.Length == 4;
}
void ValidateZeroes()
{
    foreach (string number in adress)
    {
        if (number.Length > 1 && number.StartsWith("0"))
        {
            validZeroes = false;
            return;
        }
    }

    validZeroes = true;
}

void ValidateRange()
{
    foreach (string number in adress)
    {
        int value = int.Parse(number);
        if (value < 0 || value > 255)
        {
            validRange = false;
            return;
        }
    }

    validRange = true;
}
#endregion
#endregion

#endregion