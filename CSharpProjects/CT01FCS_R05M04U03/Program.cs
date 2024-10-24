// Roteiro 05   - "Criar métodos em aplicativos de console C# (Introdução ao C#, Parte 5)"
// Modulo 04    - "Projeto guiado – Planejar uma visita ao zoológico"
// Unidade 03   - "Exercício – Planejar seu código usando métodos" (03min)
// https://learn.microsoft.com/pt-br/training/modules/guided-project-visit-petting-zoo/3-exercise-plan-use-methods

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

#region CT01FCS_R01M04U03


#region Converter tarefas em pseudocódigo
#region 1. Reserve um momento para considerar a especificação de design:
/*
- There will be three visiting schools
    - School A has six visiting groups (the default number)
    - School B has three visiting groups
    - School C has two visiting groups

- For each visiting school, perform the following tasks
    - Randomize the animals
    - Assign the animals to the correct number of groups
    - Print the school name
    - Print the animal groups
*/

/*
- Haverá três escolas visitantes
    - A escola A tem seis grupos visitantes (o número padrão)
    - A escola B tem três grupos visitantes
    - A escola C tem dois grupos visitantes

- Para cada escola visitante, execute as seguintes tarefas
    - Randomize os animais
    - Atribua os animais ao número correto de grupos
    - Imprima o nome da escola
    - Imprima os grupos de animais
*/
#endregion

#region 2., 3., 4., 5., 6., 7., 8., 9.
using System;

string[] pettingZoo =
{
    "alpacas", "capybaras", "chickens", "ducks", "emus", "geese",
    "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws",
    "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
};

// RandomizeAnimals();
// string[,] group = AssignGroup();
Console.WriteLine("School A");
// PrintGroup(group);
#endregion
#endregion

#endregion