// Roteiro 04   - "Trabalhar com os dados variáveis em aplicativos de console C# (Introdução ao C#, Parte 4)"
// Modulo 07    - "Projeto de desafio – Trabalhar com os dados variáveis em C#"
// Unidade 03   - "Dar suporte à pesquisa de diversos termos" (20min)
// https://learn.microsoft.com/pt-br/training/modules/challenge-project-work-variable-data-c-sharp/3-exercise-search-multiple-terms

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

#region CT01FCS_R04M07U03


#region Atualizando desafio
using System.Globalization;
CultureInfo.CurrentCulture = new CultureInfo("en-US");

// ourAnimals array will store the following: 
// o array ourAnimals armazenará o seguinte:
string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";
string suggestedDonation = "";

// variables that support data entry
// variáveis ​​que suportam entrada de dados
int maxPets = 8;
string? readResult;
string menuSelection = "";
decimal decimalDonation = 0.00m;

// array used to store runtime data
// array usado para armazenar dados de tempo de execução
string[,] ourAnimals = new string[maxPets, 7];

// sample data ourAnimals array entries
// dados de amostra ourAnimals entradas da matriz
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
            suggestedDonation = "85.00";
            break;

        case 1:
            animalSpecies = "dog";
            animalID = "d2";
            animalAge = "9";
            animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
            animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
            animalNickname = "gus";
            suggestedDonation = "49.99";
            break;

        case 2:
            animalSpecies = "cat";
            animalID = "c3";
            animalAge = "1";
            animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
            animalPersonalityDescription = "friendly";
            animalNickname = "snow";
            suggestedDonation = "40.00";
            break;

        case 3:
            animalSpecies = "cat";
            animalID = "c4";
            animalAge = "3";
            animalPhysicalDescription = "Medium sized, long hair, yellow, female, about 10 pounds. Uses litter box.";
            animalPersonalityDescription = "A people loving cat that likes to sit on your lap.";
            animalNickname = "Lion";
            suggestedDonation = "";
            break;

        default:
            animalSpecies = "";
            animalID = "";
            animalAge = "";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            suggestedDonation = "";
            break;
    }
    ourAnimals[i, 0] = "ID #: " + animalID;
    ourAnimals[i, 1] = "Species: " + animalSpecies;
    ourAnimals[i, 2] = "Age: " + animalAge;
    ourAnimals[i, 3] = "Nickname: " + animalNickname;
    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
    ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;

    if (!decimal.TryParse(suggestedDonation, out decimal decimalDonnation))
    {
        // if suggestedDonation NOT a number, default to 45.00
        // se a doação sugerida NÃO for um número, o padrão é 45,00
        decimalDonnation = 45.00m;
    }
    ourAnimals[i, 6] = $"Suggested donation: {decimalDonnation:C2}";
}

// top-level menu options
// opções de menu de nível superior
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

    // switch-case to process the selected menu option
    // alternar entre maiúsculas e minúsculas para processar a opção de menu selecionada
    switch (menuSelection)
    {
        case "1":
            // list all pet info
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    Console.WriteLine();
                    for (int j = 0; j < 7; j++)
                    {
                        Console.WriteLine(ourAnimals[i, j].ToString());
                    }
                }
            }
            Console.WriteLine("\n\rPress the Enter key to continue");
            readResult = Console.ReadLine();
            break;

        case "2":
            // #1 Display all dogs with a specified characteristic
            // #1 Exibir todos os cães com uma característica especificada
            string dogCharacteristics = "";

            while (dogCharacteristics == "")
            {
                // #2 have user enter multiple comma separated characteristics to search for
                // #2 faça com que o usuário insira várias características separadas por vírgulas para pesquisar
                Console.WriteLine($"\nEnter dog characteristics to search for separeted by commas");
                readResult = Console.ReadLine();

                if (readResult != null)
                {
                    dogCharacteristics = readResult.ToLower().Trim();
                }
            }

            string[] dogSearches = dogCharacteristics.Split(",");
            // trim leading and trailing spaces from each search term
            // aparar espaços iniciais e finais de cada termo de pesquisa
            for (int i = 0; i < dogSearches.Length; i++)
            {
                dogSearches[i] = dogSearches[i].Trim();
            }

            Array.Sort(dogSearches);
            // #4 update to "rotating" animation with countdown
            // #4 atualização para animação "rotativa" com contagem regressiva
            //string[] searchingIcons = { ".  ", ".. ", "..." };
            string[] searchingIcons = { " |", " /", "--", " \\", " *" };

            bool matchesAnyDog = false;
            string dogDescription = "";

            // loop ourAnimals array to search for matching animals
            // faça um loop no array ourAnimals para procurar animais correspondentes
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 1].Contains("dog"))
                {
                    // Search combined descriptions and report results
                    // Pesquise descrições combinadas e relate os resultados
                    dogDescription = ourAnimals[i, 4] + "\r\n" + ourAnimals[i, 5];
                    bool matchesCurrentDog = false;

                    foreach (string term in dogSearches)
                    {
                        // only search if there is a term to search for
                        // pesquise apenas se houver um termo a ser pesquisado
                        if (term != null && term.Trim() != "")
                        {
                            for (int j = 2; j > -1; j--)
                            {
                                // #5 update "searching" message to show countdown
                                // #5 atualizar mensagem "searching" para mostrar contagem regressiva
                                foreach (string icon in searchingIcons)
                                {
                                    Console.Write($"\rsearching our dog {ourAnimals[i, 3]} for {term.Trim()} {icon} {j.ToString()}");
                                    Thread.Sleep(250);
                                }
                            }

                            Console.Write($"\r{new String(' ', Console.BufferWidth)}");
                        }

                        // #3a iterate submitted characteristic terms and search description for each term
                        // #3a iterar os termos de características enviados e pesquisar a descrição de cada termo
                        if (dogDescription.Contains(" " + term.Trim() + " "))
                        {
                            // #3b update message to reflect current search term match 
                            // #3b atualizar mensagem para refletir a correspondência do termo de pesquisa atual
                            Console.WriteLine($"\rOur dog {ourAnimals[i, 3]} matches your search for {term.Trim()}");

                            matchesCurrentDog = true;
                            matchesAnyDog = true;
                        }
                    }

                    // #3d if "this dog" is match write match message + dog description
                    // #3d se "este cão" for correspondente, escreva a mensagem correspondente + dog description
                    if (matchesCurrentDog)
                    {
                        Console.WriteLine($"\r{ourAnimals[i, 3]} ({ourAnimals[i, 0]})\n{dogDescription}\n");
                    }
                }
            }

            if (!matchesAnyDog)
            {
                Console.WriteLine("None of our dogs are a match found for: " + dogCharacteristics);
            }

            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        default:
            break;
    }

} while (menuSelection != "exit");
#endregion

#endregion