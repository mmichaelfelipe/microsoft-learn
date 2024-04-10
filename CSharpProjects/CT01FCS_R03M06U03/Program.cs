﻿// Roteiro 03   - "Adicionar lógica a aplicativos de console C# (Introdução ao C#, Parte 3)"
// Modulo 06    - "Projeto guiado – Desenvolver estruturas de ramificação condicional e loop em C#"
// Unidade 03   - "Exercício – Criar dados de exemplo e loops de seleção de menu" (25min)
// https://learn.microsoft.com/pt-br/training/modules/guided-project-develop-conditional-branching-looping/3-exercise-build-data-menu-loops

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

#region CT01FCS_R03M06U03


#region Converter instrução if em instrução switch
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

//// display the top-level menu options

//Console.Clear();

//Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
//Console.WriteLine(" 1. List all of our current pet information");
//Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
//Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
//Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
//Console.WriteLine(" 5. Edit an animal’s age");
//Console.WriteLine(" 6. Edit an animal’s personality description");
//Console.WriteLine(" 7. Display all cats with a specified characteristic");
//Console.WriteLine(" 8. Display all dogs with a specified characteristic");
//Console.WriteLine();
//Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

//readResult = Console.ReadLine();
//if (readResult != null)
//{
//    menuSelection = readResult.ToLower();
//}

//Console.WriteLine($"You selected menu option {menuSelection}.");
//Console.WriteLine("Press the Enter key to continue");

//// pause code execution
//readResult = Console.ReadLine();
#endregion


#region Criar um loop do menu do programa
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

//    Console.WriteLine($"You selected menu option {menuSelection}.");
//    Console.WriteLine("Press the Enter key to continue");

//    // pause code execution
//    readResult = Console.ReadLine();
//} while (menuSelection is not "exit");
#endregion


#region Escrever a instrução switch para seleções de menu
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
//            break;
//        case "2":
//            break;
//        case "3":
//            break;
//        case "4":
//            break;
//        case "5":
//            break;
//        case "6":
//            break;
//        case "7":
//            break;
//        case "8":
//            break;
//        default:
//            break;
//    }

//} while (menuSelection is not "exit");
#endregion


#region Escreva o código de espaço reservado para cada caso da instrução switch
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
            Console.WriteLine("this app feature is coming soon - please check back to se progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;
        case "2":
            // Add a new animal friend to the ourAnimals array
            Console.WriteLine("this app feature is coming soon - please check back to se progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
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