// Roteiro 04   - "Trabalhar com os dados variáveis em aplicativos de console C# (Introdução ao C#, Parte 4)"
// Modulo 06    - "Projeto guiado – Trabalhar com os dados variáveis em C#"
// Unidade 03   - "Exercício – Examinar o código inicial" (06min)
// https://learn.microsoft.com/pt-br/training/modules/guided-project-work-variable-data-c-sharp/3-exercise-review-starter-code

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

#region CT01FCS_R04M06U03


#region Examinar o conteúdo do arquivo Program.cs
#region 3. Leve alguns minutos para examinar as declarações de variáveis iniciais na parte superior do arquivo Program.cs.
// #1 the ourAnimals array will store the following: 
// #1 o array ourAnimals armazenará o seguinte:
string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";

// #2 variables that support data entry
// #2 variáveis ​​que suportam entrada de dados
int maxPets = 8;
string? readResult;
string menuSelection = "";

// #3 array used to store runtime data, there is no persisted data
// #3 array usado para armazenar dados de tempo de execução, não há dados persistentes
string[,] ourAnimals = new string[maxPets, 6];
#endregion

#region 4. Role para baixo o arquivo Program.cs a fim de examinar o loop for que contém um constructo de seleção switch dentro do bloco de código dele.
// #4 create sample data ourAnimals array entries
// #4 criar dados de amostra ourAnimals entradas de array
for (int i = 0; i < maxPets; i++)
{
    switch (i)
    {
        case 0:
            animalSpecies = "dog";
            animalID = "d1";
            animalAge = "2";
            animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 45 pounds. housebroken.";
            animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
            animalNickname = "lola";
            break;

        case 1:
            animalSpecies = "dog";
            animalID = "d2";
            animalAge = "9";
            animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
            animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
            animalNickname = "gus";
            break;

        // case 2: deleted for brevity
        // case 3: deleted for brevity

        default:
            animalSpecies = "";
            animalID = "";
            animalAge = "";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;
    }
    ourAnimals[i, 0] = "ID #: " + animalID;
    ourAnimals[i, 1] = "Species: " + animalSpecies;
    ourAnimals[i, 2] = "Age: " + animalAge;
    ourAnimals[i, 3] = "Nickname: " + animalNickname;
    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
    ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
}
#endregion

#region 7. Role até a parte inferior do arquivo de código no Visual Studio Code. Examine o código usado para exibir as opções de menu e capturar a entrada da seleção do usuário.
// #5 display the top-level menu options
// #5 exibe as opções do menu de nível superior
do
{
    // NOTE: the Console.Clear method is throwing an exception in debug sessions
    // NOTA: o método Console.Clear está lançando uma exceção nas sessões de depuração
    Console.Clear();

    Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
    Console.WriteLine(" 1. List all of our current pet information");
    Console.WriteLine(" 2. Display all dogs with a specified characteristic");
    Console.WriteLine();
    Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

    readResult = Console.ReadLine();
    if (readResult != null)
    {
        menuSelection = readResult.ToLower();
    }

    // use switch-case to process the selected menu option
    switch (menuSelection)
    {
        case "1":
            // list all pet info
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    Console.WriteLine();
                    for (int j = 0; j < 6; j++)
                    {
                        Console.WriteLine(ourAnimals[i, j]);
                    }
                }
            }
            Console.WriteLine("\n\rPress the Enter key to continue");
            readResult = Console.ReadLine();
            break;

        case "2":
            // Display all dogs with a specified characteristic");
            // Exibir todos os cães com uma característica especificada");
            Console.WriteLine("\nUNDER CONSTRUCTION - please check back next month to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        default:
            break;
    }

} while (menuSelection != "exit");
#endregion
#endregion

#endregion