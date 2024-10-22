// Roteiro 05   - "Criar métodos em aplicativos de console C# (Introdução ao C#, Parte 5)"
// Modulo 02    - "Criar métodos C# com parâmetros"
// Unidade 02   - "Exercício – Usar parâmetros em métodos" (10min)
// https://learn.microsoft.com/pt-br/training/modules/create-c-sharp-methods-parameters/2-exercise-add-parameters-to-methods

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

#region CT01FCS_R01M02U02


#region Adicionar parâmetros a métodos
//CountTo(5);

//void CountTo(int max)
//{
//    for (int i = 0; i < max; i++)
//    {
//        Console.Write($"{i}, ");
//    }
//}
#endregion

#region Criar um método com parâmetros
#region 1., 2., 3., 4., 5., 6.
int[] schedule = {800, 1200, 1600, 2000};
DisplayAdjustedTimes(schedule, 6, -6);

void DisplayAdjustedTimes(int[] times, int currentGMT, int newGMT)
{
    int diff = 0;
    if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
    {
        Console.WriteLine("Invalid GMT");
    }
    else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
    {
        diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
    }
    else
    {
        diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
    }

    for (int i = 0; i < times.Length; i++)
    {
        int newTime = ((times[i] + diff)) % 2400;
        Console.WriteLine($"{times[i]} -> {newTime}");
    }
}
#endregion
#endregion

#endregion