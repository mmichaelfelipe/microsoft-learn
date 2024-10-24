// Roteiro 05   - "Criar métodos em aplicativos de console C# (Introdução ao C#, Parte 5)"
// Modulo 01    - "Escrever seu primeiro método C#"
// Unidade 06   - "Exercício – Concluir o desafio de criar um método reutilizável" (10min)
// https://learn.microsoft.com/pt-br/training/modules/write-first-c-sharp-method/6-exercise-challenge-restructure-code-to-use-methods

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

#region CT01FCS_R05M01U06


#region Desafio de código: criar um método reutilizável
#region 2.
//Random random = new Random();
//int luck = random.Next(100);

//string[] text = { "You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to" };
//string[] good = { "look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!" };
//string[] bad = { "fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life." };
//string[] neutral = { "appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature." };

//Console.WriteLine("A fortune teller whispers the following words:");
//string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));
//for (int i = 0; i < 4; i++)
//{
//    Console.Write($"{text[i]} {fortune[i]} ");
//}
#endregion

#region resolução do desafio
Random random = new Random();
int luck = random.Next(100);

string[] text = { "You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to" };
string[] good = { "look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!" };
string[] bad = { "fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life." };
string[] neutral = { "appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature." };

TellFortune();

void TellFortune()
{
    Console.WriteLine("A fortune teller whispers the following words:");
    string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));
    for (int i = 0; i < 4; i++)
    {
        Console.Write($"{text[i]} {fortune[i]} ");
    }
}
#endregion

#region Solucao sugerida
//Random random = new Random();
//int luck = random.Next(100);

//string[] text = { "You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to" };
//string[] good = { "look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!" };
//string[] bad = { "fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life." };
//string[] neutral = { "appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature." };

//TellFortune();

//void TellFortune()
//{
//    Console.WriteLine("A fortune teller whispers the following words:");
//    string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));
//    for (int i = 0; i < 4; i++)
//    {
//        Console.Write($"{text[i]} {fortune[i]} ");
//    }
//}
#endregion
#endregion

#endregion