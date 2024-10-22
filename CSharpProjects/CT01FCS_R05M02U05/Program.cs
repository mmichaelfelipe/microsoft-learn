// Roteiro 05   - "Criar métodos em aplicativos de console C# (Introdução ao C#, Parte 5)"
// Modulo 01    - "Criar métodos C# com parâmetros"
// Unidade 05   - "Exercício – Métodos com parâmetros opcionais" (10min)
// https://learn.microsoft.com/pt-br/training/modules/create-c-sharp-methods-parameters/5-exercise-use-named-optional-parameters

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

#region CT01FCS_R01M02U05


#region Criar um aplicativo RSVP
#region 2.
//string[] guestList = { "Rebecca", "Nadia", "Noor", "Jonte" };
//string[] rsvps = new string[10];
//int count = 0;

//void RSVP(string name, int partySize, string allergies, bool inviteOnly)
//{
//    if (inviteOnly)
//    { 
//        // search guestList before adding rsvp
//    }

//    rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
//    count++;
//}

//void ShowRSVPs()
//{
//    Console.WriteLine("\nTotal RSVPs:");
//    for (int i = 0; i < count; i++)
//    {
//        Console.WriteLine(rsvps[i]);
//    }
//}
#endregion

#region 3.
//string[] guestList = { "Rebecca", "Nadia", "Noor", "Jonte" };
//string[] rsvps = new string[10];
//int count = 0;

//void RSVP(string name, int partySize, string allergies, bool inviteOnly)
//{
//    if (inviteOnly)
//    {
//        bool found = false;
//        foreach (string guest in guestList)
//        {
//            if (guest.Equals(name))
//            {
//                found = true;
//                break;
//            }
//        }

//        if (!found)
//        {
//            Console.WriteLine($"Sorry, {name} is not on the guest list");
//            return;
//        }
//    }

//    rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
//    count++;
//}

//void ShowRSVPs()
//{
//    Console.WriteLine("\nTotal RSVPs:");
//    for (int i = 0; i < count; i++)
//    {
//        Console.WriteLine(rsvps[i]);
//    }
//}
#endregion

#region 4.
//string[] guestList = { "Rebecca", "Nadia", "Noor", "Jonte" };
//string[] rsvps = new string[10];
//int count = 0;

//RSVP("Rebecca", 1, "none", true);
//RSVP("Nadia", 2, "Nuts", true);
//RSVP("Linh", 2, "none", false);
//RSVP("Tony", 1, "Jackfruit", true);
//RSVP("Noor", 4, "none", false);
//RSVP("Jonte", 2, "Stone fruit", false);
//ShowRSVPs();

//void RSVP(string name, int partySize, string allergies, bool inviteOnly)
//{
//    if (inviteOnly)
//    {
//        bool found = false;
//        foreach (string guest in guestList)
//        {
//            if (guest.Equals(name))
//            {
//                found = true;
//                break;
//            }
//        }

//        if (!found)
//        {
//            Console.WriteLine($"Sorry, {name} is not on the guest list");
//            return;
//        }
//    }

//    rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
//    count++;
//}

//void ShowRSVPs()
//{
//    Console.WriteLine("\nTotal RSVPs:");
//    for (int i = 0; i < count; i++)
//    {
//        Console.WriteLine(rsvps[i]);
//    }
//}
#endregion
#endregion

#region Usar argumentos nomeados
#region 1., 2.
//string[] guestList = { "Rebecca", "Nadia", "Noor", "Jonte" };
//string[] rsvps = new string[10];
//int count = 0;

//RSVP("Rebecca", 1, "none", true);
//RSVP("Nadia", 2, "Nuts", true);
////RSVP("Linh", 2, "none", false);
////RSVP("Linh", 2, allergies: "none", inviteOnly: false); 
////RSVP("Linh", partySize: 2, "none", false);
//RSVP(name: "Linh", partySize: 2, allergies: "none", inviteOnly: false);
//RSVP("Tony", 1, "Jackfruit", true);
//RSVP("Noor", 4, "none", false);
//RSVP("Jonte", 2, "Stone fruit", false);
//ShowRSVPs();

//void RSVP(string name, int partySize, string allergies, bool inviteOnly)
//{
//    if (inviteOnly)
//    {
//        bool found = false;
//        foreach (string guest in guestList)
//        {
//            if (guest.Equals(name))
//            {
//                found = true;
//                break;
//            }
//        }

//        if (!found)
//        {
//            Console.WriteLine($"Sorry, {name} is not on the guest list");
//            return;
//        }
//    }

//    rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
//    count++;
//}

//void ShowRSVPs()
//{
//    Console.WriteLine("\nTotal RSVPs:");
//    for (int i = 0; i < count; i++)
//    {
//        Console.WriteLine(rsvps[i]);
//    }
//}
#endregion

#region 3., 4.
//string[] guestList = { "Rebecca", "Nadia", "Noor", "Jonte" };
//string[] rsvps = new string[10];
//int count = 0;

//RSVP("Rebecca", 1, "none", true);
//RSVP("Nadia", 2, "Nuts", true);
//RSVP(name: "Linh", partySize: 2, allergies: "none", inviteOnly: false);
////RSVP("Tony", 1, "Jackfruit", true);
//RSVP("Tony", inviteOnly: true, allergies: "Jackfruit", partySize: 1);
//RSVP("Noor", 4, "none", false);
//RSVP("Jonte", 2, "Stone fruit", false);
//ShowRSVPs();

//void RSVP(string name, int partySize, string allergies, bool inviteOnly)
//{
//    if (inviteOnly)
//    {
//        bool found = false;
//        foreach (string guest in guestList)
//        {
//            if (guest.Equals(name))
//            {
//                found = true;
//                break;
//            }
//        }

//        if (!found)
//        {
//            Console.WriteLine($"Sorry, {name} is not on the guest list");
//            return;
//        }
//    }

//    rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
//    count++;
//}

//void ShowRSVPs()
//{
//    Console.WriteLine("\nTotal RSVPs:");
//    for (int i = 0; i < count; i++)
//    {
//        Console.WriteLine(rsvps[i]);
//    }
//}
#endregion
#endregion

#region Declarar parâmetros opcionais
#region 1., 2.
string[] guestList = { "Rebecca", "Nadia", "Noor", "Jonte" };
string[] rsvps = new string[10];
int count = 0;

RSVP("Rebecca");
RSVP("Nadia", 2, "Nuts");
RSVP(name: "Linh", partySize: 2, inviteOnly: false);
RSVP("Tony", allergies: "Jackfruit", inviteOnly: true);
RSVP("Noor", 4, inviteOnly: false);
RSVP("Jonte", 2, "Stone fruit", false);
ShowRSVPs();

//void RSVP(string name, int partySize, string allergies, bool inviteOnly)
void RSVP(string name, int partySize = 1, string allergies = "none", bool inviteOnly = true)
{
    if (inviteOnly)
    {
        bool found = false;
        foreach (string guest in guestList)
        {
            if (guest.Equals(name))
            {
                found = true;
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine($"Sorry, {name} is not on the guest list");
            return;
        }
    }

    rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
    count++;
}

void ShowRSVPs()
{
    Console.WriteLine("\nTotal RSVPs:");
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine(rsvps[i]);
    }
}
#endregion
#endregion

#endregion