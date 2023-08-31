
//-welcome user
Console.ForegroundColor = ConsoleColor.Green;
Console.Write("\tQ");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("U");
Console.ForegroundColor = ConsoleColor.Red;
Console.Write("I");
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Z");
Console.ResetColor();
Console.WriteLine("\nWhich season are you?");

//-get username
string userName = "";
do
{
    Console.Write("\nWrite your username: ");
    string? readResult = Console.ReadLine();
    if (readResult != null)
        userName = readResult.Trim();
} while (userName == "");

Console.WriteLine($"\nWelcome {userName}!");
Console.WriteLine("\nPress enten to start.");

Console.ReadLine();

//-ask 5 questions(a, b, c, d)



//- display result