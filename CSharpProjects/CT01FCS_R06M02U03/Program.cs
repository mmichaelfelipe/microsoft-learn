// Roteiro 06   - "Depurar aplicativos de console do C# (Introdução ao C#, Parte 6)"
// Modulo 02    - "Implementar as ferramentas de depuração do Visual Studio Code para C#"
// Unidade 03   - "Exercício – Executar o código no ambiente de depuração" (08min)
// https://learn.microsoft.com/pt-br/training/modules/implement-visual-studio-code-debugging-tools/3-exercise-run-code-debug-environment

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

#region CT01FCS_R06M02U03
/* 
This code uses a names array and corresponding methods to display
greeting messages
*/

string[] names = new string[] { "Sophia", "Andrew", "AllGreetings" };

string messageText = "";

foreach (string name in names)
{
    if (name == "Sophia")
        messageText = SophiaMessage();
    else if (name == "Andrew")
        messageText = AndrewMessage();
    else if (name == "AllGreetings")
        messageText = SophiaMessage();
        messageText = messageText + "\n\r" + AndrewMessage();

    Console.WriteLine(messageText + "\n\r");
}

bool pauseCode = true;
while (pauseCode == true);

static string SophiaMessage()
{
    return "Hello, my name is Sophia.";
}

static string AndrewMessage()
{
    return "Hi, my name is Andrew. Good to meet you.";
}
#endregion