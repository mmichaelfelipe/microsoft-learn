// Roteiro 05   - "Criar métodos em aplicativos de console C# (Introdução ao C#, Parte 5)"
// Modulo 04    - "Projeto guiado – Planejar uma visita ao zoológico"
// Unidade 04   - "Exercício – Criar um método para embaralhar uma matriz" (05min)
// https://learn.microsoft.com/pt-br/training/modules/guided-project-visit-petting-zoo/4-exercise-shuffle-array

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

#region CT01FCS_R05M04U04


#region Embaralhar uma matriz
#endregion 1., 2., 3., 4., 5.
using System;

string[] pettingZoo =
{
    "alpacas", "capybaras", "chickens", "ducks", "emus", "geese",
    "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws",
    "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
};

RandomizeAnimals();
// string[,] group = AssignGroup();
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
#region
#endregion

#endregion