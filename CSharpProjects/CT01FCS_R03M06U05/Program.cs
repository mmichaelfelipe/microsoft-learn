﻿// Roteiro 03   - "Adicionar lógica a aplicativos de console C# (Introdução ao C#, Parte 3)"
// Modulo 06    - "Projeto guiado – Desenvolver estruturas de ramificação condicional e loop em C#"
// Unidade 05   - "Exercício – Criar e testar um loop para inserir novos dados de animal de estimação" (20min)
// https://learn.microsoft.com/pt-br/training/modules/guided-project-develop-conditional-branching-looping/5-exercise-build-loop-new-array-data

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

#region CT01FCS_R03M06U05



#region Conte o número de animais de estimação na matriz ourAnimals
//// the ourAnimals array will store the following: 
//string animalSpecies = "";
//string animalID = "";
//string animalAge = "";
//string animalPhysicalDescription = "";
//string animalPersonalityDescription = "";
//string animalNickname = "";

//// variables that support data entry
//int maxPets = 8;
//string? readResult;
//string menuSelection = "";

//// array used to store runtime data, there is no persisted data
//string[,] ourAnimals = new string[maxPets, 6];

//// TODO: Convert the if-elseif-else construct to a switch statement

//// create some initial ourAnimals array entries
//for (int i = 0; i < maxPets; i++)
//{
//    switch (i)
//    {
//        case 0:
//            animalSpecies = "dog";
//            animalID = "d1";
//            animalAge = "2";
//            animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
//            animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
//            animalNickname = "lola";
//            break;
//        case 1:
//            animalSpecies = "dog";
//            animalID = "d2";
//            animalAge = "9";
//            animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
//            animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
//            animalNickname = "loki";
//            break;
//        case 2:
//            animalSpecies = "cat";
//            animalID = "c3";
//            animalAge = "1";
//            animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
//            animalPersonalityDescription = "friendly";
//            animalNickname = "Puss";
//            break;
//        case 3:
//            animalSpecies = "cat";
//            animalID = "c4";
//            animalAge = "?";
//            animalPhysicalDescription = "";
//            animalPersonalityDescription = "";
//            animalNickname = "";
//            break;
//        default:
//            animalSpecies = "";
//            animalID = "";
//            animalAge = "";
//            animalPhysicalDescription = "";
//            animalPersonalityDescription = "";
//            animalNickname = "";
//            break;
//    }

//    ourAnimals[i, 0] = "ID #: " + animalID;
//    ourAnimals[i, 1] = "Species: " + animalSpecies;
//    ourAnimals[i, 2] = "Age: " + animalAge;
//    ourAnimals[i, 3] = "Nickname: " + animalNickname;
//    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
//    ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
//}

//do
//{
//    // display the top-level menu options

//    Console.Clear();

//    Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
//    Console.WriteLine(" 1. List all of our current pet information");
//    Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
//    Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
//    Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
//    Console.WriteLine(" 5. Edit an animal’s age");
//    Console.WriteLine(" 6. Edit an animal’s personality description");
//    Console.WriteLine(" 7. Display all cats with a specified characteristic");
//    Console.WriteLine(" 8. Display all dogs with a specified characteristic");
//    Console.WriteLine();
//    Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

//    readResult = Console.ReadLine();

//    if (readResult != null)
//    {
//        menuSelection = readResult.ToLower();
//    }

//    //Console.WriteLine($"You selected menu option {menuSelection}.");
//    //Console.WriteLine("Press the Enter key to continue");

//    //// pause code execution
//    //readResult = Console.ReadLine();

//    switch (menuSelection)
//    {
//        case "1":
//            // List all of our current pet information
//            for (int i = 0; i < maxPets; i++)
//            {
//                if (ourAnimals[i, 0] != "ID #: ")
//                {
//                    Console.WriteLine();
//                    for (int j = 0; j < 6; j++)
//                    {
//                        Console.WriteLine(ourAnimals[i, j]);
//                    }
//                }
//            }
//            Console.WriteLine("Press the Enter key to continue.");
//            readResult = Console.ReadLine();
//            break;
//        case "2":
//            // Add a new animal friend to the ourAnimals array
//            string anotherPet = "y";
//            int petCount = 0;
//            for (int i = 0; i < maxPets; i++)
//            {
//                if (ourAnimals[i, 0] != "ID #: ")
//                {
//                    petCount += 1;
//                }
//            }
//            Console.WriteLine("Press the Enter key to continue.");
//            readResult = Console.ReadLine();
//            break;
//        case "3":
//            // Ensure animal ages and physical descriptions are complete
//            Console.WriteLine("Challenge Project - please check back to see progress.");
//            Console.WriteLine("Press the Enter key to continue.");
//            readResult = Console.ReadLine();
//            break;
//        case "4":
//            // Ensure animal nicknames and personality descriptions are complete
//            Console.WriteLine("Challenge Project - please check back to see progress.");
//            Console.WriteLine("Press the Enter key to continue.");
//            readResult = Console.ReadLine();
//            break;
//        case "5":
//            // Edit an animal’s age
//            Console.WriteLine("UNDER CONSTRUCTION - please check back to see progress.");
//            Console.WriteLine("Press the Enter key to continue.");
//            readResult = Console.ReadLine();
//            break;
//        case "6":
//            // Edit an animal’s personality description
//            Console.WriteLine("UNDER CONSTRUCTION - please check back to see progress.");
//            Console.WriteLine("Press the Enter key to continue.");
//            readResult = Console.ReadLine();
//            break;
//        case "7":
//            // Display all cats with a specified characteristic
//            Console.WriteLine("UNDER CONSTRUCTION - please check back to see progress.");
//            Console.WriteLine("Press the Enter key to continue.");
//            readResult = Console.ReadLine();
//            break;
//        case "8":
//            // Display all dogs with a specified characteristic
//            Console.WriteLine("UNDER CONSTRUCTION - please check back to see progress.");
//            Console.WriteLine("Press the Enter key to continue.");
//            readResult = Console.ReadLine();
//            break;
//        default:
//            readResult = Console.ReadLine();
//            break;
//    }

//} while (menuSelection != "exit");
#endregion


#region Exibir uma saída de mensagem quando petCount for menor que maxPets
//// the ourAnimals array will store the following: 
//string animalSpecies = "";
//string animalID = "";
//string animalAge = "";
//string animalPhysicalDescription = "";
//string animalPersonalityDescription = "";
//string animalNickname = "";

//// variables that support data entry
//int maxPets = 8;
//string? readResult;
//string menuSelection = "";

//// array used to store runtime data, there is no persisted data
//string[,] ourAnimals = new string[maxPets, 6];

//// TODO: Convert the if-elseif-else construct to a switch statement

//// create some initial ourAnimals array entries
//for (int i = 0; i < maxPets; i++)
//{
//    switch (i)
//    {
//        case 0:
//            animalSpecies = "dog";
//            animalID = "d1";
//            animalAge = "2";
//            animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
//            animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
//            animalNickname = "lola";
//            break;
//        case 1:
//            animalSpecies = "dog";
//            animalID = "d2";
//            animalAge = "9";
//            animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
//            animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
//            animalNickname = "loki";
//            break;
//        case 2:
//            animalSpecies = "cat";
//            animalID = "c3";
//            animalAge = "1";
//            animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
//            animalPersonalityDescription = "friendly";
//            animalNickname = "Puss";
//            break;
//        case 3:
//            animalSpecies = "cat";
//            animalID = "c4";
//            animalAge = "?";
//            animalPhysicalDescription = "";
//            animalPersonalityDescription = "";
//            animalNickname = "";
//            break;
//        default:
//            animalSpecies = "";
//            animalID = "";
//            animalAge = "";
//            animalPhysicalDescription = "";
//            animalPersonalityDescription = "";
//            animalNickname = "";
//            break;
//    }

//    ourAnimals[i, 0] = "ID #: " + animalID;
//    ourAnimals[i, 1] = "Species: " + animalSpecies;
//    ourAnimals[i, 2] = "Age: " + animalAge;
//    ourAnimals[i, 3] = "Nickname: " + animalNickname;
//    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
//    ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
//}

//do
//{
//    // display the top-level menu options

//    Console.Clear();

//    Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
//    Console.WriteLine(" 1. List all of our current pet information");
//    Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
//    Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
//    Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
//    Console.WriteLine(" 5. Edit an animal’s age");
//    Console.WriteLine(" 6. Edit an animal’s personality description");
//    Console.WriteLine(" 7. Display all cats with a specified characteristic");
//    Console.WriteLine(" 8. Display all dogs with a specified characteristic");
//    Console.WriteLine();
//    Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

//    readResult = Console.ReadLine();

//    if (readResult != null)
//    {
//        menuSelection = readResult.ToLower();
//    }

//    //Console.WriteLine($"You selected menu option {menuSelection}.");
//    //Console.WriteLine("Press the Enter key to continue");

//    //// pause code execution
//    //readResult = Console.ReadLine();

//    switch (menuSelection)
//    {
//        case "1":
//            // List all of our current pet information
//            for (int i = 0; i < maxPets; i++)
//            {
//                if (ourAnimals[i, 0] != "ID #: ")
//                {
//                    Console.WriteLine();
//                    for (int j = 0; j < 6; j++)
//                    {
//                        Console.WriteLine(ourAnimals[i, j]);
//                    }
//                }
//            }
//            Console.WriteLine("Press the Enter key to continue.");
//            readResult = Console.ReadLine();
//            break;
//        case "2":
//            // Add a new animal friend to the ourAnimals array
//            string anotherPet = "y";
//            int petCount = 0;
//            for (int i = 0; i < maxPets; i++)
//            {
//                if (ourAnimals[i, 0] != "ID #: ")
//                {
//                    petCount += 1;
//                }
//            }

//            if (petCount < maxPets)
//            {
//                Console.WriteLine($"We currently have {petCount} pets that need homes. We can manage {(maxPets - petCount)} more.");
//            }

//            Console.WriteLine("Press the Enter key to continue.");
//            readResult = Console.ReadLine();
//            break;
//        case "3":
//            // Ensure animal ages and physical descriptions are complete
//            Console.WriteLine("Challenge Project - please check back to see progress.");
//            Console.WriteLine("Press the Enter key to continue.");
//            readResult = Console.ReadLine();
//            break;
//        case "4":
//            // Ensure animal nicknames and personality descriptions are complete
//            Console.WriteLine("Challenge Project - please check back to see progress.");
//            Console.WriteLine("Press the Enter key to continue.");
//            readResult = Console.ReadLine();
//            break;
//        case "5":
//            // Edit an animal’s age
//            Console.WriteLine("UNDER CONSTRUCTION - please check back to see progress.");
//            Console.WriteLine("Press the Enter key to continue.");
//            readResult = Console.ReadLine();
//            break;
//        case "6":
//            // Edit an animal’s personality description
//            Console.WriteLine("UNDER CONSTRUCTION - please check back to see progress.");
//            Console.WriteLine("Press the Enter key to continue.");
//            readResult = Console.ReadLine();
//            break;
//        case "7":
//            // Display all cats with a specified characteristic
//            Console.WriteLine("UNDER CONSTRUCTION - please check back to see progress.");
//            Console.WriteLine("Press the Enter key to continue.");
//            readResult = Console.ReadLine();
//            break;
//        case "8":
//            // Display all dogs with a specified characteristic
//            Console.WriteLine("UNDER CONSTRUCTION - please check back to see progress.");
//            Console.WriteLine("Press the Enter key to continue.");
//            readResult = Console.ReadLine();
//            break;
//        default:
//            readResult = Console.ReadLine();
//            break;
//    }

//} while (menuSelection != "exit");
#endregion


#region Crie uma estrutura de loop que será usada para inserir dados da matriz ourAnimals
//// the ourAnimals array will store the following: 
//string animalSpecies = "";
//string animalID = "";
//string animalAge = "";
//string animalPhysicalDescription = "";
//string animalPersonalityDescription = "";
//string animalNickname = "";

//// variables that support data entry
//int maxPets = 8;
//string? readResult;
//string menuSelection = "";

//// array used to store runtime data, there is no persisted data
//string[,] ourAnimals = new string[maxPets, 6];

//// TODO: Convert the if-elseif-else construct to a switch statement

//// create some initial ourAnimals array entries
//for (int i = 0; i < maxPets; i++)
//{
//    switch (i)
//    {
//        case 0:
//            animalSpecies = "dog";
//            animalID = "d1";
//            animalAge = "2";
//            animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
//            animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
//            animalNickname = "lola";
//            break;
//        case 1:
//            animalSpecies = "dog";
//            animalID = "d2";
//            animalAge = "9";
//            animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
//            animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
//            animalNickname = "loki";
//            break;
//        case 2:
//            animalSpecies = "cat";
//            animalID = "c3";
//            animalAge = "1";
//            animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
//            animalPersonalityDescription = "friendly";
//            animalNickname = "Puss";
//            break;
//        case 3:
//            animalSpecies = "cat";
//            animalID = "c4";
//            animalAge = "?";
//            animalPhysicalDescription = "";
//            animalPersonalityDescription = "";
//            animalNickname = "";
//            break;
//        default:
//            animalSpecies = "";
//            animalID = "";
//            animalAge = "";
//            animalPhysicalDescription = "";
//            animalPersonalityDescription = "";
//            animalNickname = "";
//            break;
//    }

//    ourAnimals[i, 0] = "ID #: " + animalID;
//    ourAnimals[i, 1] = "Species: " + animalSpecies;
//    ourAnimals[i, 2] = "Age: " + animalAge;
//    ourAnimals[i, 3] = "Nickname: " + animalNickname;
//    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
//    ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
//}

//do
//{
//    // display the top-level menu options

//    Console.Clear();

//    Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
//    Console.WriteLine(" 1. List all of our current pet information");
//    Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
//    Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
//    Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
//    Console.WriteLine(" 5. Edit an animal’s age");
//    Console.WriteLine(" 6. Edit an animal’s personality description");
//    Console.WriteLine(" 7. Display all cats with a specified characteristic");
//    Console.WriteLine(" 8. Display all dogs with a specified characteristic");
//    Console.WriteLine();
//    Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

//    readResult = Console.ReadLine();

//    if (readResult != null)
//    {
//        menuSelection = readResult.ToLower();
//    }

//    //Console.WriteLine($"You selected menu option {menuSelection}.");
//    //Console.WriteLine("Press the Enter key to continue");

//    //// pause code execution
//    //readResult = Console.ReadLine();

//    switch (menuSelection)
//    {
//        case "1":
//            // List all of our current pet information
//            for (int i = 0; i < maxPets; i++)
//            {
//                if (ourAnimals[i, 0] != "ID #: ")
//                {
//                    Console.WriteLine();
//                    for (int j = 0; j < 6; j++)
//                    {
//                        Console.WriteLine(ourAnimals[i, j]);
//                    }
//                }
//            }
//            Console.WriteLine("Press the Enter key to continue.");
//            readResult = Console.ReadLine();
//            break;
//        case "2":
//            // Add a new animal friend to the ourAnimals array
//            string anotherPet = "y";
//            int petCount = 0;
//            for (int i = 0; i < maxPets; i++)
//            {
//                if (ourAnimals[i, 0] != "ID #: ")
//                {
//                    petCount += 1;
//                }
//            }

//            if (petCount < maxPets)
//            {
//                Console.WriteLine($"We currently have {petCount} pets that need homes. We can manage {(maxPets - petCount)} more.");
//            }

//            while (anotherPet == "y" && petCount < maxPets)
//            {

//            }

//            Console.WriteLine("Press the Enter key to continue.");
//            readResult = Console.ReadLine();
//            break;
//        case "3":
//            // Ensure animal ages and physical descriptions are complete
//            Console.WriteLine("Challenge Project - please check back to see progress.");
//            Console.WriteLine("Press the Enter key to continue.");
//            readResult = Console.ReadLine();
//            break;
//        case "4":
//            // Ensure animal nicknames and personality descriptions are complete
//            Console.WriteLine("Challenge Project - please check back to see progress.");
//            Console.WriteLine("Press the Enter key to continue.");
//            readResult = Console.ReadLine();
//            break;
//        case "5":
//            // Edit an animal’s age
//            Console.WriteLine("UNDER CONSTRUCTION - please check back to see progress.");
//            Console.WriteLine("Press the Enter key to continue.");
//            readResult = Console.ReadLine();
//            break;
//        case "6":
//            // Edit an animal’s personality description
//            Console.WriteLine("UNDER CONSTRUCTION - please check back to see progress.");
//            Console.WriteLine("Press the Enter key to continue.");
//            readResult = Console.ReadLine();
//            break;
//        case "7":
//            // Display all cats with a specified characteristic
//            Console.WriteLine("UNDER CONSTRUCTION - please check back to see progress.");
//            Console.WriteLine("Press the Enter key to continue.");
//            readResult = Console.ReadLine();
//            break;
//        case "8":
//            // Display all dogs with a specified characteristic
//            Console.WriteLine("UNDER CONSTRUCTION - please check back to see progress.");
//            Console.WriteLine("Press the Enter key to continue.");
//            readResult = Console.ReadLine();
//            break;
//        default:
//            readResult = Console.ReadLine();
//            break;
//    }

//} while (menuSelection != "exit");
#endregion


#region Verifique a condição de saída para o novo loop de animais de estimação
// the ourAnimals array will store the following: 
string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";

// variables that support data entry
int maxPets = 8;
string? readResult;
string menuSelection = "";

// array used to store runtime data, there is no persisted data
string[,] ourAnimals = new string[maxPets, 6];

// TODO: Convert the if-elseif-else construct to a switch statement

// create some initial ourAnimals array entries
for (int i = 0; i < maxPets; i++)
{
    switch (i)
    {
        case 0:
            animalSpecies = "dog";
            animalID = "d1";
            animalAge = "2";
            animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
            animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
            animalNickname = "lola";
            break;
        case 1:
            animalSpecies = "dog";
            animalID = "d2";
            animalAge = "9";
            animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
            animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
            animalNickname = "loki";
            break;
        case 2:
            animalSpecies = "cat";
            animalID = "c3";
            animalAge = "1";
            animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
            animalPersonalityDescription = "friendly";
            animalNickname = "Puss";
            break;
        case 3:
            animalSpecies = "cat";
            animalID = "c4";
            animalAge = "?";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;
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

do
{
    // display the top-level menu options

    Console.Clear();

    Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
    Console.WriteLine(" 1. List all of our current pet information");
    Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
    Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
    Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
    Console.WriteLine(" 5. Edit an animal’s age");
    Console.WriteLine(" 6. Edit an animal’s personality description");
    Console.WriteLine(" 7. Display all cats with a specified characteristic");
    Console.WriteLine(" 8. Display all dogs with a specified characteristic");
    Console.WriteLine();
    Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

    readResult = Console.ReadLine();

    if (readResult != null)
    {
        menuSelection = readResult.ToLower();
    }

    //Console.WriteLine($"You selected menu option {menuSelection}.");
    //Console.WriteLine("Press the Enter key to continue");

    //// pause code execution
    //readResult = Console.ReadLine();

    switch (menuSelection)
    {
        case "1":
            // List all of our current pet information
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
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;
        case "2":
            // Add a new animal friend to the ourAnimals array
            string anotherPet = "y";
            int petCount = 0;
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    petCount += 1;
                }
            }

            if (petCount < maxPets)
            {
                Console.WriteLine($"We currently have {petCount} pets that need homes. We can manage {(maxPets - petCount)} more.");
            }

            while (anotherPet == "y" && petCount < maxPets)
            {
                // incremet petCount (the array is zero-based, so we increment the counter after adding to the array)
                petCount = petCount + 1;

                // check maxPet limit
                if (petCount < maxPets)
                {
                    // another pet?
                    Console.WriteLine("Do you want to enter info for another pet (y/n)");
                    do
                    {
                        readResult = Console.ReadLine();
                        if (readResult != null)
                        {
                            anotherPet = readResult.ToLower();
                        }
                    } while (anotherPet != "y" && anotherPet != "n");
                }
            }

            if (petCount >= maxPets)
            {
                Console.WriteLine("We have reached our limit on the number of pets that we can manage.");
                Console.WriteLine("Press the Enter key to continue.");
                readResult = Console.ReadLine();
            }

            break;
        case "3":
            // Ensure animal ages and physical descriptions are complete
            Console.WriteLine("Challenge Project - please check back to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;
        case "4":
            // Ensure animal nicknames and personality descriptions are complete
            Console.WriteLine("Challenge Project - please check back to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;
        case "5":
            // Edit an animal’s age
            Console.WriteLine("UNDER CONSTRUCTION - please check back to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;
        case "6":
            // Edit an animal’s personality description
            Console.WriteLine("UNDER CONSTRUCTION - please check back to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;
        case "7":
            // Display all cats with a specified characteristic
            Console.WriteLine("UNDER CONSTRUCTION - please check back to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;
        case "8":
            // Display all dogs with a specified characteristic
            Console.WriteLine("UNDER CONSTRUCTION - please check back to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;
        default:
            readResult = Console.ReadLine();
            break;
    }

} while (menuSelection != "exit");
#endregion



#endregion