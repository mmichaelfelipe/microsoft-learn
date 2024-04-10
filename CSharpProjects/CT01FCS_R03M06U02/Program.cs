// Roteiro 03   - "Adicionar lógica a aplicativos de console C# (Introdução ao C#, Parte 3)"
// Modulo 06    - "Projeto guiado – Desenvolver estruturas de ramificação condicional e loop em C#"
// Unidade 02   - "Preparar" (09min)
// https://learn.microsoft.com/pt-br/training/modules/guided-project-develop-conditional-branching-looping/2-prepare

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

#region CT01FCS_R03M06U02
/*  Visão geral do projeto
    Você está trabalhando no aplicativo Contoso Pets, um aplicativo que ajuda a colocar animais de estimação em novas casas. 
    As especificações do aplicativo são as seguintes:

    - Crie um aplicativo de console C#.

    - Armazene dados do aplicativo em uma matriz de cadeia de caracteres multidimensional chamada ourAnimals.

    - A matriz ourAnimals inclui as seguintes "características de animais de estimação" para cada animal:
        - Nº da ID do animal de estimação.
        - Espécie do animal de estimação (gato ou cachorro).
        - Idade do animal de estimação (em anos).
        - Descrição das condições/características físicas do animal de estimação.
        - Descrição da personalidade do animal de estimação.
        - Apelido do animal de estimação.
        - Implemente um conjunto de dados de exemplo que represente os cães e gatos atualmente sob seus cuidados.

    - Exiba opções de menu para acessar os principais recursos do aplicativo.

    - Os principais recursos habilitam as seguintes tarefas:
        - Listar as informações de animais de estimação para todos os animais da matriz ourAnimals.
        - Adicionar novos animais à matriz ourAnimals. As seguintes condições se aplicam:
            - A espécie do animal de estimação (cão ou gato) deve ser informada quando um novo animal é adicionado à matriz ourAnimals.
            - Uma ID de animal de estimação deve ser gerada programaticamente quando um novo animal é adicionado à matriz ourAnimals.
            - Algumas características físicas do animal de estimação podem ser desconhecidas até o exame de um veterinário. 
              Por exemplo: idade, raça e status de castração.
            - O apelido e a personalidade do animal de estimação podem ser desconhecidos logo que ele chega.
            - Verificar se os dados de idade e descrição física dos animais estão completos. Isso pode exigir o exame de um veterinário.
        - Verificar se os dados de apelido e descrição da personalidade dos animais estão completos 
          (isso pode exigir que a equipe conheça melhor o animal de estimação).
        - Alterar a idade do animal (se a data de nascimento dele for conhecida e ele fizer aniversário enquanto estiver sob nossos cuidados).
        - Alterar a descrição de personalidade do animal (ele pode mudar de comportamento após algum tempo sob nossos cuidados).
        - Exibir todos os gatos que atendem às características físicas especificadas pelo usuário.
        - Exibir todos os cães que atendem às características físicas especificadas pelo usuário.

    Uma versão inicial do aplicativo já foi concluída. O projeto de código inicial deste módulo de projeto guiado inclui um arquivo Program.cs, 
    que fornece os seguintes recursos de código:
    - O código declara variáveis usadas para coletar e processar dados de animais de estimação e seleções de itens de menu.
    - O código declara a matriz ourAnimals.
    - O código usa um loop for em torno de um constructo if-elseif-else para preencher a matriz ourAnimals com um conjunto de dados de exemplo.
    - O código exibe as seguintes opções principais de menu para seleção pelo usuário:
        1. Listar todas as nossas informações atuais sobre os animais de estimação.
        2. Atribuir valores aos campos da matriz ourAnimals.
        3. Verificar se os dados de idade e descrição física dos animais estão completos.
        4. Verificar se os dados de apelido e descrição de personalidade dos animais estão completos.
        5. Editar a idade do animal.
        6. Editar a descrição de personalidade do animal.
        7. Exibir todos os gatos com uma característica especificada.
        8. Exibir todos os cães com uma característica especificada.
        Insira o item de menu desejado ou digite "Exit" para sair do programa
    - O código lê o item de menu selecionado pelo usuário e exibe uma mensagem ecoando a seleção.
*/


#region Código oficial inicial do projeto
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
    if (i == 0)
    {
        animalSpecies = "dog";
        animalID = "d1";
        animalAge = "2";
        animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
        animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
        animalNickname = "lola";
    }
    else if (i == 1)
    {
        animalSpecies = "dog";
        animalID = "d2";
        animalAge = "9";
        animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
        animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
        animalNickname = "loki";
    }
    else if (i == 2)
    {
        animalSpecies = "cat";
        animalID = "c3";
        animalAge = "1";
        animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
        animalPersonalityDescription = "friendly";
        animalNickname = "Puss";
    }
    else if (i == 3)
    {
        animalSpecies = "cat";
        animalID = "c4";
        animalAge = "?";
        animalPhysicalDescription = "";
        animalPersonalityDescription = "";
        animalNickname = "";
    }
    else
    {
        animalSpecies = "";
        animalID = "";
        animalAge = "";
        animalPhysicalDescription = "";
        animalPersonalityDescription = "";
        animalNickname = "";
    }

    ourAnimals[i, 0] = "ID #: " + animalID;
    ourAnimals[i, 1] = "Species: " + animalSpecies;
    ourAnimals[i, 2] = "Age: " + animalAge;
    ourAnimals[i, 3] = "Nickname: " + animalNickname;
    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
    ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
}

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

Console.WriteLine($"You selected menu option {menuSelection}.");
Console.WriteLine("Press the Enter key to continue");

// pause code execution
readResult = Console.ReadLine();
#endregion



#endregion