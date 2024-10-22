// Roteiro 05   - "Criar métodos em aplicativos de console C# (Introdução ao C#, Parte 5)"
// Modulo 03    - "Criar métodos C# que retornem valores"
// Unidade 03   - "Exercício – Retornar números de métodos" (10min)
// https://learn.microsoft.com/pt-br/training/modules/create-c-sharp-methods-return-values/3-exercise-create-methods-return-numbers

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

#region CT01FCS_R01M03U03


#region Criar um método que retorna um inteiro
#region 2., 3.
//double usd = 23.73;
//int vnd = UsdToVnd(usd);

//Console.WriteLine($"${usd} USD = ${vnd} VND");

//int UsdToVnd(double usd)
//{
//    int rate = 23500;
//    return (int) (rate * usd);
//}
#endregion
#endregion

#region Criar um método que retorna um duplo (double)
#region 2., 3., 4.
double usd = 23.73;
int vnd = UsdToVnd(usd);

Console.WriteLine($"${usd} USD = ${vnd} VND");
Console.WriteLine($"${vnd} VND = ${VndToUsd(vnd)} USD");

int UsdToVnd(double usd)
{
    int rate = 23500;
    return (int)(rate * usd);
}

double VndToUsd(int vnd)
{
    double rate = 23500;
    return vnd / rate;
}
#endregion
#endregion

#endregion