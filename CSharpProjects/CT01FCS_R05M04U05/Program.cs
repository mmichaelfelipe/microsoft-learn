// Roteiro 05   - "Criar métodos em aplicativos de console C# (Introdução ao C#, Parte 5)"
// Modulo 04    - "Projeto guiado – Planejar uma visita ao zoológico"
// Unidade 05   - "Exercício – Criar um método com um parâmetro opcional" (03min)
// https://learn.microsoft.com/pt-br/training/modules/guided-project-visit-petting-zoo/5-exercise-optional-parameters

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

#region CT01FCS_R05M04U05


#region Desenvolver seu método
#region 1., 2., 3., 4., 5., 6.
using System;

string[] pettingZoo =
{
    "alpacas", "capybaras", "chickens", "ducks", "emus", "geese",
    "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws",
    "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
};

RandomizeAnimals();
string[,] group = AssignGroup();
Console.WriteLine("School A");
// PrintGroup(group);

void RandomizeAnimals()
{
    Random random = new Random();

    for (int i = 0; i < pettingZoo.Length; i++)
    {
        int r = random.Next(i, pettingZoo.Length);

        string temp = pettingZoo[i];
        pettingZoo[i] = pettingZoo[r];
        pettingZoo[r] = temp;
    }
}

string[,] AssignGroup(int groups = 6)
{
    string[,] result = new string[groups, pettingZoo.Length / groups];
    int start = 0;

    for (int i = 0; i < groups; i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = pettingZoo[start++];
        }
    }

    return result;
}
#endregion
#endregion

#endregion